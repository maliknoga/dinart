using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Utils;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace DinartApp.Forms
{
    public partial class InventaireForm : Form
    {
        // Créer les objets Excel
        private Excel.Application xlApp;
        private Excel.Workbook xlWorkbook;
        private Excel.Worksheet xlWorksheet;
        private Excel.Range xlRange;

        private Excel.Range last;

        private int xlRow;
        //private int xlCol;
        private string strFilePath;

        public InventaireForm()
        {
            InitializeComponent();
            OpenExcelFile();
            ReadExcel();
            CloseExcelFile();
        }
        public void OpenExcelFile()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string localPath = new Uri(outPutDirectory).LocalPath;
            string[] strSplitPath = localPath.Split(new String[] { "bin" }, StringSplitOptions.None);
            this.strFilePath = strSplitPath[0] + "Ressources\\Inventaire_20_12_2021.xlsx";

            //string date = DateTime.Now.ToString("dd_MM_yyyy");

            this.xlApp = new Excel.Application();
            this.xlWorkbook = xlApp.Workbooks.Open(this.strFilePath); // chemin vers classeur
            this.xlWorksheet = xlWorkbook.Worksheets[1]; // premiere feuille
            //this.xlRange = xlWorksheet.UsedRange;
            this.last = xlWorksheet.UsedRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            this.xlRange = xlWorksheet.get_Range("A2:B2", last);
        }
        public void ReadExcel()
        {
            for (this.xlRow = 1; this.xlRow <= this.xlRange.Rows.Count; this.xlRow++)
            {
                if (this.xlRange.Cells[xlRow, 1].Text != "")
                {
                    dgvInventaire.Rows.Add(
                        this.xlRange.Cells[xlRow, 1].Text,
                        this.xlRange.Cells[xlRow, 2].Text
                    ); // 1 = A, 2 = B, ...
                    // somme = somme + this.xlRange.Cells[xlRow, 2].Value;
                }
            }
        }
        private void dgvInventaire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ourGrid = (DataGridView)sender;
            if (ourGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                OpenExcelFile(); // peut être retirer plus tard si déplacement CloseExcelFile()
                try
                {
                    this.xlRange.Cells[e.RowIndex + 1, 1].Value
                        = dgvInventaire.Rows[e.RowIndex].Cells[0].Value;
                    this.xlRange.Cells[e.RowIndex + 1, 2].Value
                        = dgvInventaire.Rows[e.RowIndex].Cells[1].Value;

                    dgvInventaire.Sort(dgvInventaire.Columns[0], ListSortDirection.Ascending);
                    this.xlRange.Sort(xlRange.Columns[1], Excel.XlSortOrder.xlAscending);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                this.xlWorkbook.Save();
                CloseExcelFile(); // peut être retirer plus tard si déplacement CloseExcelFile()
            }
        }
        private void dgvInventaire_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            var ourGrid = (DataGridView)sender;
            
            OpenExcelFile(); // peut être retirer plus tard si déplacement CloseExcelFile()
            try
            {
                this.xlRange.Rows[e.RowIndex + 1].Delete(); // supprimme ligne excel
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            this.xlWorkbook.Save();
            CloseExcelFile(); // peut être retirer plus tard si déplacement CloseExcelFile()
            
        }
        public void CloseExcelFile()
        {
            this.xlWorkbook.Close();
            this.xlApp.Quit();

            // CLEAN UP
            System.Runtime.InteropServices.Marshal.ReleaseComObject(this.xlApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(this.xlWorkbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(this.xlWorksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(this.xlRange);
        }
        protected override bool ProcessCmdKey
            (ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}"); // Deplacement sur la cellule suivante quand on appuie sur "Entrer"
                return true; 
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        /*
        public void ClearGrid()
        {
            dgvInventaire.Rows.Clear();
            dgvInventaire.Columns.Clear();
        }
        */

        /*
        public void WriteExcel(string newValue)
        {
            OpenExcelFile(); // peut être retirer plus tard si déplacement CloseExcelFile()

            for (this.xlRow = 4; this.xlRow <= this.xlRange.Rows.Count; this.xlRow++)
            {
                if (this.xlRange.Cells[xlRow, 1].Text != "" 
                    && this.xlRange.Cells[xlRow+1, 1].Text != "")
                {
                    break;
                }
                this.xlRange.Cells[xlRow, 1].Value = dgvInventaire.CurrentCell.Value;
                this.xlRange.Cells[xlRow, 2].Value = dgvInventaire.CurrentCell.Value;
            }

            CloseExcelFile(); // peut être retirer plus tard si déplacement CloseExcelFile()
        }
        */
    }
}
