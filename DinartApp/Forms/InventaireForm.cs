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
        public InventaireForm()
        {
            InitializeComponent();
            readExcel();
        }

        private void readExcel()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string localPath = new Uri(outPutDirectory).LocalPath;
            string[] strSplitPath = localPath.Split(new String[] { "bin" }, StringSplitOptions.None);
            string strFilePath = strSplitPath[0] + "Ressources\\Inventaire.xlsx";

            /*
            var filePath = Path.Combine(outPutDirectory, "Ressources\\Inventaire.xslx");
            string strFilePath = new Uri(filePath).LocalPath;
            */
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open(strFilePath); // chemin vers fichier
            xlWorksheet = xlWorkbook.Worksheets[1];
            xlRange = xlWorksheet.UsedRange;

            for (xlRow = 4; xlRow <= xlRange.Rows.Count; xlRow++)
            {
                if (xlRange.Cells[xlRow, 1].Text != "")
                {
                    dgvInventaire.Rows.Add(
                        xlRange.Cells[xlRow, 1].Text,
                        xlRange.Cells[xlRow, 2].Text
                    ); // 1 = A, 2 = B, ...
                }
            }
            xlWorkbook.Close();
            xlApp.Quit();
        }
    }
}
