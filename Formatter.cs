using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteDeLaGuitarra
{
    public class Formatter
    {
        private int BitmapWidth, BitmapHeight, NumRows, NumCols,
                    Dpi, PictSize, TargetPictSize, TopSpace;
        private float PictGap, BitmapBorder;
        private int leftBound, topBound;
        private int rowHeightPixels, colWidthPixels;
        private int xPixels, yPixels, PictGapPixels;
        private int fileNumEnd;
        private string SourceFolder, StemName;
        Dictionary<string, string> dict;
        Bitmap? bitmap = null;

        public Formatter(Dictionary<string, string> theDict)
        {
            dict = theDict;
            fileNumEnd = -1;
            GetVariablesFromDict();
            CalculateParameters();
            WriteBitmap();
            bitmap.Save("Dali.jpg");
        }

        public static string[] ParNames = { "BitmapWidth", "BitmapHeight", "BitmapBorder", "NumRows",
                              "NumCols", "SourceFolder", "StemName", "PictGap", "Dpi", "PictSize",
                               "TargetPictSize", "TopSpace" };

        private void GetVariablesFromDict()
        {
            BitmapWidth = Int32.Parse(dict["BitmapWidth"]);
            BitmapHeight = Int32.Parse(dict["BitmapHeight"]);
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
        }

        private void CalculateParameters()
        {
            xPixels = BitmapWidth * Dpi;        // Convert inches to pixels:
            yPixels = BitmapHeight * Dpi;
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

            if (fileNumEnd > -1)
                if (i >= fileNumEnd)
                    i = i - fileNumEnd + 1;

            string fileName = SourceFolder + '\\' + StemName + i.ToString() + ".png"; ;

            if (!File.Exists(fileName))
            {
                if (fileNumEnd == -1)
                    fileNumEnd = i;

                i = 1;
                fileName = SourceFolder + '\\' + StemName + i.ToString() + ".png";
            }

            Bitmap picBitmap = new Bitmap(fileName);
            return picBitmap;
        }

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
