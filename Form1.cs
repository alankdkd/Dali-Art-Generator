using System;
using Microsoft.Win32;

namespace ArteDeLaGuitarra
{
    public partial class Form1 : Form
    {
        private bool m_bUpdate = true;          // Update parameter on text changed.
        private Dictionary<string, string> dictVals = new Dictionary<string, string>();
        string[] ParNames = { "BitmapWidth", "BitmapHeight", "BitmapBorder", "NumRows",
                              "NumCols", "SourceFolder", "StemName", "PictGap", "Dpi", "PictSize", "TopSpace" };
        enum ParOrder  { BitmapWidth, BitmapHeight, BitmapBorder, NumRows,
                         NumCols, SourceFolder, StemName, PictGap, DPI, PictSize, TopSpace };

        public Form1()
        {
            InitializeComponent();
            InitializeControlsFromRegistry();
        }

        private void InitializeControlsFromRegistry()
        {
            InitRegistry();
            FillDictFromRegistry();
            SetControlsFromDict();
        }

        private void InitRegistry()
        {
            // Create a new key under HKEY_LOCAL_MACHINE\Software as Dali:
            RegistryKey swKey = Registry.CurrentUser.OpenSubKey("Software", true);

            if (swKey != null)
            {
                RegistryKey daliKey = swKey.OpenSubKey("Dali", true);

                if (daliKey == null)
                {
                    daliKey = swKey.CreateSubKey("Dali");

                    // Set value of sub key
                    daliKey.SetValue("BitmapWidth", "0");
                    daliKey.SetValue("BitmapHeight", "0");
                    daliKey.SetValue("BitmapBorder", "0");
                    daliKey.SetValue("NumRows", "8");
                    daliKey.SetValue("NumCols", "12");
                    daliKey.SetValue("SourceFolder", @"C:\Users\alank\Pictures");
                    daliKey.SetValue("StemName", "DaliGuitar");
                    daliKey.SetValue("PictGap", ".2");
                    daliKey.SetValue("DPI", "300");
                    daliKey.SetValue("PictSize", "256");
                    daliKey.SetValue("TopSpace", "0");
                }
            }
        }

        private void FillDictFromRegistry()
        {
            RegistryKey swKey = Registry.CurrentUser.OpenSubKey("Software", true);
            RegistryKey daliKey = swKey.OpenSubKey("Dali", true);

            foreach (string key in ParNames)
                dictVals[key] = daliKey.GetValue(key).ToString();
        }

        private void SetControlsFromDict()
        {
            BitmapWidth.Text = dictVals["BitmapWidth"];
            BitmapHeight.Text = dictVals["BitmapHeight"];
            BitmapBorder.Text = dictVals["BitmapBorder"];
            NumRows.Text = dictVals["NumRows"];
            NumCols.Text = dictVals["NumCols"];
            PictGap.Text = dictVals["PictGap"];
            Dpi.Text = dictVals["Dpi"];
            PictureSize.Text = dictVals["PictSize"];
            SpaceFromTop.Text = dictVals["TopSpace"];
            SourceFolder.Text = dictVals["SourceFolder"];
            StemName.Text = dictVals["StemName"];
        }

        private void MakeArtButton_Click(object sender, EventArgs e)
        {
            Formatter formatter = new Formatter(dictVals);
            ShowBitmap(formatter);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BitmapWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void BitmapHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void BitmapBorder_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumRows_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumCols_TextChanged(object sender, EventArgs e)
        {

        }

        private void SourceFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void StemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictGap_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dpi_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void SpaceFromTop_TextChanged(object sender, EventArgs e)
        {

        }
        private void ShowBitmap(Formatter formatter)
        {
            throw new NotImplementedException();
        }
    }
}