﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using BarcodeLib;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace BarcodeTestApp
{
    public partial class FormBarcodeDisplay : Form
    {
        public FormBarcodeDisplay()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (chkBxAutoEncode.Checked == true)
                Encode();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            Encode();
        }

        protected void Encode()
        {
            BarcodeLib.Barcode b = new BarcodeLib.Barcode
            {
                Alignment = AlignmentPositions.CENTER,
                BackColor = Color.White,
                ForeColor = Color.Black,
                Height = 150,
                EncodedType = TYPE.CODE128,
                ImageFormat = ImageFormat.Png,
                IncludeLabel = true,
                LabelFont = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 10F),
                LabelPosition = LabelPositions.TOPCENTER,
                Width = 500
            };

            b.RawData = textBox1.Text;
            b.Encode(TYPE.CODE128, textBox1.Text);

            pictureBox1.Image = b.EncodedImage;
            btnPrint.Enabled = true;
            btnPrintPreview.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print().Print();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Image img = pictureBox1.Image;
            Point loc = new Point(100, 100);
            e.Graphics.DrawImage(img, loc);     
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = Print();
            printPreviewDialog.ShowDialog();
        }

        private PrintDocument Print()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;

            return pd;
        }
    }
}
