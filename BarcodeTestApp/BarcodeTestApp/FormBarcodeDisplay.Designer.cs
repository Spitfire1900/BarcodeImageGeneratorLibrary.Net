namespace BarcodeTestApp
{
    partial class FormBarcodeDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarcodeDisplay));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.chkBxAutoEncode = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDiagBarcode = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.printDiagBarcode = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(120, 13);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // chkBxAutoEncode
            // 
            this.chkBxAutoEncode.AutoSize = true;
            this.chkBxAutoEncode.Checked = true;
            this.chkBxAutoEncode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxAutoEncode.Location = new System.Drawing.Point(202, 15);
            this.chkBxAutoEncode.Name = "chkBxAutoEncode";
            this.chkBxAutoEncode.Size = new System.Drawing.Size(88, 17);
            this.chkBxAutoEncode.TabIndex = 3;
            this.chkBxAutoEncode.Text = "Auto Encode";
            this.chkBxAutoEncode.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(560, 9);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDiagBarcode
            // 
            this.printPreviewDiagBarcode.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDiagBarcode.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDiagBarcode.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDiagBarcode.Enabled = true;
            this.printPreviewDiagBarcode.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDiagBarcode.Icon")));
            this.printPreviewDiagBarcode.Name = "printPreviewDialog";
            this.printPreviewDiagBarcode.Visible = false;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Enabled = false;
            this.btnPrintPreview.Location = new System.Drawing.Point(457, 9);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(97, 23);
            this.btnPrintPreview.TabIndex = 5;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // printDiagBarcode
            // 
            this.printDiagBarcode.UseEXDialog = true;
            // 
            // FormBarcodeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 278);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.chkBxAutoEncode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBarcodeDisplay";
            this.Text = "Barcode Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.CheckBox chkBxAutoEncode;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDiagBarcode;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.PrintDialog printDiagBarcode;

    }
}

