using System;
using Microsoft.Win32;

namespace ArteDeLaGuitarra
{
    public partial class Form1 : Form
    {
        public static string[] ParNames = { "BitmapWidth", "BitmapHeight", "BitmapBorder", "NumRows",
                              "NumCols", "SourceFolder", "StemName", "PictGap", "Dpi", "PictSize",
                              "TargetPictSize", "TopSpace", "Message" };
        private bool UpdateVars = true;          // Update parameter on text changed.
        private Dictionary<string, string> dictVals = new Dictionary<string, string>();
        private enum ParOrder  { BitmapWidth, BitmapHeight, BitmapBorder, NumRows,
                                 NumCols, SourceFolder, StemName, PictGap, DPI, PictSize,
                                 TargetPictSize, TopSpace, Message,
        };
        private RegistryKey daliKey;

        public Form1()
        {
            //CenterToScreen();
            StartPosition = FormStartPosition.CenterScreen;
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
                daliKey = swKey.OpenSubKey("Dali", true);

                if (daliKey == null)
                {
                    daliKey = swKey.CreateSubKey("Dali");

                    // Set value of sub key
                    daliKey.SetValue("BitmapWidth", "36");
                    daliKey.SetValue("BitmapHeight", "24");
                    daliKey.SetValue("BitmapBorder", ".5");
                    daliKey.SetValue("NumRows", "8");
                    daliKey.SetValue("NumCols", "12");
                    daliKey.SetValue("SourceFolder", @"C:\Users\alank\Pictures");
                    daliKey.SetValue("StemName", "DaliGuitar");
                    daliKey.SetValue("PictGap", ".2");
                    daliKey.SetValue("DPI", "300");
                    daliKey.SetValue("PictSize", "256");
                    daliKey.SetValue("TargetPictSize", "738");
                    daliKey.SetValue("TopSpace", "0");
                    daliKey.SetValue("Message", "Copyright � 2022 Alan Balkany.");
                }
            }
            else
                throw new Exception("No software key for current user");
        }

        private void FillDictFromRegistry()
        {
            RegistryKey swKey = Registry.CurrentUser.OpenSubKey("Software", true);
            RegistryKey daliKey = swKey.OpenSubKey("Dali", true);

            foreach (string key in ParNames)
            {
                object val = daliKey.GetValue(key);

                    if (val != null)
                        dictVals[key] = val.ToString();
            }
        }

        private void SetControlsFromDict()
        {
            UpdateVars = false;
            try
            {
                BitmapWidth.Text = dictVals["BitmapWidth"];
                BitmapHeight.Text = dictVals["BitmapHeight"];
                BitmapBorder.Text = dictVals["BitmapBorder"];
                NumRows.Text = dictVals["NumRows"];
                NumCols.Text = dictVals["NumCols"];
                PictGap.Text = dictVals["PictGap"];
                Dpi.Text = dictVals["Dpi"];
                PictureSize.Text = dictVals["PictSize"];
                TargetPictureSize.Text = dictVals["TargetPictSize"];
                SpaceFromTop.Text = dictVals["TopSpace"];
                SourceFolder.Text = dictVals["SourceFolder"];
                StemName.Text = dictVals["StemName"];
                CopyrightMessage.Text = dictVals["Message"];
            }

            catch (Exception)
            {
                MessageBox.Show("Problem in SetControlsFromDict().");
            }

            UpdateVars = true;
        }

        private void MakeArtButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Formatter formatter = new Formatter(dictVals);
            //ShowBitmap(formatter);
            Cursor.Current = Cursors.Default;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoUpdate(string key, string value)
        {
            if (UpdateVars)
            {
                if (key != "Message")
                    daliKey.SetValue(key, value);
                
                dictVals[key] = value;
            }
        }

        private void BitmapWidth_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("BitmapWidth", BitmapWidth.Text);
        }

        private void BitmapHeight_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("BitmapHeight", BitmapHeight.Text);
        }

        private void BitmapBorder_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("BitmapBorder", BitmapBorder.Text);
        }

        private void NumRows_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("NumRows", NumRows.Text);
        }

        private void NumCols_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("NumCols", NumCols.Text);
        }

        private void SourceFolder_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("SourceFolder", SourceFolder.Text);
        }

        private void StemName_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("StemName", StemName.Text);
        }

        private void PictGap_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("PictGap", PictGap.Text);
        }

        private void Dpi_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("Dpi", Dpi.Text);
        }

        private void PictureSize_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("PictSize", PictureSize.Text);
        }

        private void TargetPictureSize_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("TargetPictSize", TargetPictureSize.Text);
        }

        private void SpaceFromTop_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("TopSpace", SpaceFromTop.Text);
        }
 
        private void CopyrightMessage_TextChanged(object sender, EventArgs e)
        {
            DoUpdate("Message", CopyrightMessage.Text);
        }

       private void ShowBitmap(Formatter formatter)
        {
            throw new NotImplementedException();
        }
    }
}