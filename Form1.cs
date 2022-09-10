namespace ArteDeLaGuitarra
{
    public partial class Form1 : Form
    {
        private bool m_bUpdate = true;          // Update parameter on text changed.
        private Dictionary<string, string> m_dVals = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            //InitializeControlsFromRegistry();
        }

        private void MakeArtButton_Click(object sender, EventArgs e)
        {
            Formatter formatter = new Formatter(m_dVals);
            ShowBitmap(formatter);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeControlsFromRegistry()
        {
            FillDictFromRegistry();
            SetControlsFromDict();
        }

        private void SetControlsFromDict()
        {
            throw new NotImplementedException();
        }

        private void FillDictFromRegistry()
        {
            throw new NotImplementedException();
        }

        private void BitmapWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void BitmapHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lip_TextChanged(object sender, EventArgs e)
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

        private void PixelSpacing_TextChanged(object sender, EventArgs e)
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