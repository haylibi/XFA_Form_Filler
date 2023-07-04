
namespace XFA_Filler_App
{
    partial class PDF_Form_Filler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Excel_Button = new System.Windows.Forms.Button();
            this.excel_input_file = new System.Windows.Forms.OpenFileDialog();
            this.Excel_Input = new System.Windows.Forms.TextBox();
            this.PDF_Input = new System.Windows.Forms.TextBox();
            this.PDF_Button = new System.Windows.Forms.Button();
            this.Execute_Button = new System.Windows.Forms.Button();
            this.pdf_input_file = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Excel_Button
            // 
            this.Excel_Button.Location = new System.Drawing.Point(364, 18);
            this.Excel_Button.Name = "Excel_Button";
            this.Excel_Button.Size = new System.Drawing.Size(134, 23);
            this.Excel_Button.TabIndex = 0;
            this.Excel_Button.Text = "Browse Excel File";
            this.Excel_Button.UseVisualStyleBackColor = true;
            this.Excel_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // excel_input_file
            // 
            this.excel_input_file.FileName = "Excel.xlsx";
            this.excel_input_file.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            // 
            // Excel_Input
            // 
            this.Excel_Input.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Excel_Input.Location = new System.Drawing.Point(13, 18);
            this.Excel_Input.Name = "Excel_Input";
            this.Excel_Input.ReadOnly = true;
            this.Excel_Input.Size = new System.Drawing.Size(345, 23);
            this.Excel_Input.TabIndex = 1;
            this.Excel_Input.TextChanged += new System.EventHandler(this.Excel_Input_TextChanged);
            this.Excel_Input.MouseEnter += new System.EventHandler(this.Excel_Input_MouseEnter);
            this.Excel_Input.MouseHover += new System.EventHandler(this.Excel_Input_MouseHover);
            // 
            // PDF_Input
            // 
            this.PDF_Input.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PDF_Input.Location = new System.Drawing.Point(13, 47);
            this.PDF_Input.Name = "PDF_Input";
            this.PDF_Input.ReadOnly = true;
            this.PDF_Input.Size = new System.Drawing.Size(345, 23);
            this.PDF_Input.TabIndex = 2;
            // 
            // PDF_Button
            // 
            this.PDF_Button.Location = new System.Drawing.Point(365, 47);
            this.PDF_Button.Name = "PDF_Button";
            this.PDF_Button.Size = new System.Drawing.Size(134, 23);
            this.PDF_Button.TabIndex = 3;
            this.PDF_Button.Text = "Browse PDF File";
            this.PDF_Button.UseVisualStyleBackColor = true;
            this.PDF_Button.Click += new System.EventHandler(this.PDF_Button_Click);
            // 
            // Execute_Button
            // 
            this.Execute_Button.Location = new System.Drawing.Point(13, 76);
            this.Execute_Button.Name = "Execute_Button";
            this.Execute_Button.Size = new System.Drawing.Size(486, 39);
            this.Execute_Button.TabIndex = 4;
            this.Execute_Button.Text = "Execute";
            this.Execute_Button.UseVisualStyleBackColor = true;
            this.Execute_Button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pdf_input_file
            // 
            this.pdf_input_file.FileName = "pdf.pdf";
            this.pdf_input_file.Filter = "Pdf Files|*.pdf";
            // 
            // progressBar
            // 
            this.progressBar.AccessibleDescription = "";
            this.progressBar.AccessibleName = "";
            this.progressBar.Location = new System.Drawing.Point(13, 76);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(486, 39);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(459, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PDF_Form_Filler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PDF_Button);
            this.Controls.Add(this.PDF_Input);
            this.Controls.Add(this.Excel_Input);
            this.Controls.Add(this.Excel_Button);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Execute_Button);
            this.Name = "PDF_Form_Filler";
            this.Text = "PDF Form Filler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Excel_Button;
        private System.Windows.Forms.OpenFileDialog excel_input_file;
        private System.Windows.Forms.TextBox Excel_Input;
        private System.Windows.Forms.TextBox PDF_Input;
        private System.Windows.Forms.Button PDF_Button;
        private System.Windows.Forms.Button Execute_Button;
        private System.Windows.Forms.OpenFileDialog pdf_input_file;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
    }
}

