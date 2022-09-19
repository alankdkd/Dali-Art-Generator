using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace ArteDeLaGuitarra
{
    public class Formatter
    {
        private int NumRows, NumCols,
                    Dpi, PictSize, TargetPictSize, TopSpace;
        private float BitmapWidth, BitmapHeight, PictGap, BitmapBorder;
        private int leftBound, topBound;
        private int rowHeightPixels, colWidthPixels;
        private int xPixels, yPixels, PictGapPixels;
        private int fileNumEnd;
        private string SourceFolder, StemName, Message;
        Dictionary<string, string> dict;
        Bitmap? bitmap = null;

        public Formatter(Dictionary<string, string> theDict)
        {
            dict = theDict;
            GetVariablesFromDict();
            CalculateParameters();
            WriteBitmap();
            bitmap.Save("Dali.jpg");
        }

        public static string[] ParNames = { "BitmapWidth", "BitmapHeight", "BitmapBorder", "NumRows",
                              "NumCols", "SourceFolder", "StemName", "PictGap", "Dpi", "PictSize",
                               "TargetPictSize", "TopSpace", "Message" };

        private void GetVariablesFromDict()
        {
            BitmapWidth = float.Parse(dict["BitmapWidth"]);
            BitmapHeight = float.Parse(dict["BitmapHeight"]);
            BitmapBorder = float.Parse(dict["BitmapBorder"]);
            NumRows = Int32.Parse(dict["NumRows"]);
            NumCols = Int32.Parse(dict["NumCols"]);
            SourceFolder = dict["SourceFolder"];
            StemName = dict["StemName"];
            PictGap = float.Parse(dict["PictGap"]);
            Dpi = Int32.Parse(dict["Dpi"]);
            PictSize = Int32.Parse(dict["PictSize"]);
            TargetPictSize = Int32.Parse(dict["TargetPictSize"]);
            TopSpace = Int32.Parse(dict["TopSpace"]);
            Message = dict["Message"];
        }

        private void CalculateParameters()
        {
            xPixels = (int) Math.Floor(BitmapWidth * Dpi);         // Convert inches to pixels:
            yPixels = (int) Math.Floor(BitmapHeight * Dpi);
            PictGapPixels = (int) Math.Round(PictGap * Dpi);

            int borderPixels = (int) Math.Floor(2.0 * BitmapBorder * Dpi);
            int availableSpaceRow = xPixels - borderPixels;
            int availableSpaceCol = yPixels - borderPixels;

            int neededSpaceRow, neededSpaceCol;
            NumCols = availableSpaceRow / TargetPictSize + 1;
            NumRows = availableSpaceCol / TargetPictSize + 1;

            do
            {
                --NumCols;
                neededSpaceRow = TargetPictSize * NumCols + PictGapPixels * (NumCols - 1);
            }
            while (neededSpaceRow > availableSpaceRow);

            do
            {
                --NumRows;
                neededSpaceCol = TargetPictSize * NumRows + PictGapPixels * (NumRows - 1);
            }
            while (neededSpaceCol > availableSpaceCol);

            leftBound = borderPixels / 2 + (availableSpaceRow - neededSpaceRow) / 2;
            topBound = borderPixels / 2 + (availableSpaceCol - neededSpaceCol) / 2;
            rowHeightPixels = TargetPictSize + PictGapPixels;
            colWidthPixels = TargetPictSize + PictGapPixels;
        }

        private void WriteBitmap()
        {
            if (bitmap != null)
                bitmap.Dispose();

            bitmap = new Bitmap(xPixels, yPixels);
            PaintBitmapBlack(bitmap);

            for (int i = 0;   i < NumRows * NumCols;   ++i)
            {
                int rowNum = i / NumCols;
                int colNum = i % NumCols;
                int xCoord = leftBound + colNum * colWidthPixels;
                int yCoord = topBound + rowNum * rowHeightPixels;

                RectangleF dstRect = new RectangleF(leftBound, topBound, TargetPictSize, TargetPictSize);

                using (Bitmap picBitmap = GetPicBitmap(i))
                using (Graphics g = Graphics.FromImage(bitmap))
                    g.DrawImage(picBitmap, xCoord, yCoord, TargetPictSize, TargetPictSize);
            }

        }

        private Bitmap GetPicBitmap(int i)
        {
            ++i;

            string fileName = SourceFolder + '\\' + StemName + i.ToString() + ".png"; ;

            if (!File.Exists(fileName))
                throw new Exception("Couldn't find file " + fileName);
            
            fileName = SourceFolder + '\\' + StemName + i.ToString() + ".png";

            Bitmap picBitmap = new Bitmap(fileName);

            if (i == NumRows * NumCols)
                OverlayCopyrightNotice(picBitmap);

            return picBitmap;
        }

        private Bitmap OverlayCopyrightNotice(Bitmap picBitmap)
        {
            int top = 185;
            int left = 31;

            using (Font font = new Font("Times", 18, (FontStyle)1))
            using (Font typeFont = new Font("Courrier New", 8))
            using (LinearGradientBrush linGrBrush = new LinearGradientBrush(
                   new Point(0, 10),
                   new Point(200, 10),
                   Color.FromArgb(255, 255, 0, 255),   // Magenta.
                   Color.FromArgb(255, 255, 0, 255)))
            using (Graphics g = Graphics.FromImage(picBitmap))
            {
                LinearGradientBrush turquoise = new LinearGradientBrush(
                   new Point(0, 200),
                   new Point(200, 0),
                   Color.Turquoise,         // Turquoise smear to clash with the magenta.
                   Color.FromArgb(100, 255, 255, 255));
                Brush blackBrush = new SolidBrush(Color.Black);
                Pen p = new Pen(turquoise, 40);
                g.DrawEllipse(p, left + 12, top, 167, 38);
                g.DrawString("Dali Guitar Art #1", font, linGrBrush, left - 1, top);
                g.DrawString(Message,
                    typeFont, blackBrush, left + 17, top + 26);
                g.DrawString("All rights reserved.", typeFont, blackBrush, left + 51, top + 39);

                return picBitmap;
            }
        }

        // REPEATS FROM BEGINNING IF WE RUN OUT OF PICTURES:
        //
        //private Bitmap GetPicBitmap(int i)
        //{
        //    ++i;

        //    if (fileNumEnd > -1)
        //        if (i >= fileNumEnd)
        //            i = i - fileNumEnd + 1;

        //    string fileName = SourceFolder + '\\' + StemName + i.ToString() + ".png"; ;

        //    if (!File.Exists(fileName))
        //    {
        //        if (fileNumEnd == -1)
        //            fileNumEnd = i;

        //        i = 1;
        //        fileName = SourceFolder + '\\' + StemName + i.ToString() + ".png";
        //    }

        //    Bitmap picBitmap = new Bitmap(fileName);
        //    return picBitmap;
        //}

        private void PaintBitmapBlack(Bitmap bitmap)
        {
            int redvalue = 0, greenvalue = 0, bluevalue = 0;

            using (Graphics g = Graphics.FromImage(bitmap))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(redvalue, greenvalue, bluevalue)))
            {
                g.FillRectangle(brush, 0, 0, xPixels, yPixels);
            }
        }
    }
}
