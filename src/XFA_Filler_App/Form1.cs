using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace XFA_Filler_App
{
    public partial class PDF_Form_Filler : Form
    {
        public PDF_Form_Filler()
        {
            InitializeComponent();
            progressBar.Visible = false;
            label1.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (excel_input_file.ShowDialog() == DialogResult.OK)
            {
                Excel_Input.Text = excel_input_file.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PDF_Button_Click(object sender, EventArgs e)
        {

            if (pdf_input_file.ShowDialog() == DialogResult.OK)
            {
                PDF_Input.Text = pdf_input_file.FileName;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            label1.Visible = true;

            var pbar = new ProgressBar();

            // This code example demonstrates how to read a filled XFA form.
            // Load XFA form
            Aspose.Pdf.Document doc = new(PDF_Input.Text);



            Console.WriteLine(doc.Form.XFA["form1[0].tip1[0].sub1[3200].sub2[0].cuiP[0]"]);

            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();

            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(Excel_Input.Text);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            int col;
            string colname;
            int max_row = 1;

            while (xlRange.Cells[max_row, 1].Value2 != null)
            {
                max_row += 1;
            }
            
            for (int row=2; row<max_row; row++)
            {
                col = 1;
                while (xlRange.Cells[1, col].Value2 != null)
                {
                    colname = xlRange.Cells[1, col].Value2.ToString();
                    //xlRange.Cells[row, col].Value2 = doc.Form.XFA["form1[0].tip1[0].sub1[" + (row - 2) + "].sub2[0]." + colname + "[0]"];
                    doc.Form.XFA["form1[0].tip1[0].sub1[" + (row - 1) + "].sub2[0]." + colname + "[0]"] = xlRange.Cells[row, col].Value2.ToString();
                    col += 1;
                }
                progressBar.Value = 100 * row / max_row;
                label1.Text = (100 * row / max_row).ToString() + "%";
            }
            xlWorkbook.Close();

            string[] dir_ = PDF_Input.Text.Split(@"\");
            dir_ = dir_.SkipLast(1).ToArray();

            doc.Save(string.Join(@"\", dir_) + @"\pdf_output.pdf");

            progressBar.Visible = false;
            label1.Visible = false;
            label1.Text = "";
        }

        private void Excel_Input_MouseEnter(object sender, EventArgs e)
        {
        }

        private void Excel_Input_MouseHover(object sender, EventArgs e)
        {
        }


        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Excel_Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
