using Bunifu.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinartApp.Forms
{
    public partial class InventaireForm : Form
    {
        private Microsoft.Office.Interop.Excel.Application xlApp;
        private Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
        private Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
        private Microsoft.Office.Interop.Excel.Range xlRange;

        private int xlRow;

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
            string strFilePath = strSplitPath[0] + "Ressources\\Inventaire.xlsx";

            this.xlApp = new Microsoft.Office.Interop.Excel.Application();
            this.xlWorkbook = xlApp.Workbooks.Open(strFilePath); // chemin vers fichier
            this.xlWorksheet = xlWorkbook.Worksheets[1];
            this.xlRange = xlWorksheet.UsedRange;
        }

        public void ReadExcel()
        {
            for (this.xlRow = 4; this.xlRow <= this.xlRange.Rows.Count; this.xlRow++)
            {
                if (this.xlRange.Cells[xlRow, 1].Text != "")
                {
                    dgvInventaire.Rows.Add(
                        this.xlRange.Cells[xlRow, 1].Text,
                        this.xlRange.Cells[xlRow, 2].Text
                    ); // 1 = A, 2 = B, ...
                }
            }
        }

        public void WriteExcel(string newValue)
        {
            OpenExcelFile();

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

            CloseExcelFile();
        }

        public void CloseExcelFile()
        {
            this.xlWorkbook.Close();
            this.xlApp.Quit();
        }
    }
}
