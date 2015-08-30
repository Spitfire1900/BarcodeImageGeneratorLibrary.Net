// Copyright © 2014 Kyle Gottfried. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeLib;
using System.Drawing;
using System.Drawing.Imaging;

namespace BarcodeTestApp
{
    class Barcode : BarcodeLib.Barcode
    {
        /// <summary>
        /// Default Barcode Instance
        /// </summary>
        public Barcode()
        {
            Alignment = AlignmentPositions.CENTER;
                BackColor = Color.White;
                ForeColor = Color.Black;
                Height = 150;
                EncodedType = TYPE.CODE128;
                ImageFormat = ImageFormat.Png;
                IncludeLabel = true;
                LabelFont = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 10F);
                LabelPosition = LabelPositions.TOPCENTER;
                Width = 500;
        }
    }
}
