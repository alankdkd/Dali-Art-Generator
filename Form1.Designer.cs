namespace ArteDeLaGuitarra
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BitmapWidth = new System.Windows.Forms.TextBox();
            this.BitmapHeight = new System.Windows.Forms.TextBox();
            this.Lip = new System.Windows.Forms.TextBox();
            this.NumRows = new System.Windows.Forms.TextBox();
            this.NumCols = new System.Windows.Forms.TextBox();
            this.PixelSpacing = new System.Windows.Forms.TextBox();
            this.Dpi = new System.Windows.Forms.TextBox();
            this.PictureSize = new System.Windows.Forms.TextBox();
            this.SpaceFromTop = new System.Windows.Forms.TextBox();
            this.SourceFolder = new System.Windows.Forms.TextBox();
            this.StemName = new System.Windows.Forms.TextBox();
            this.MakeArtButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TheBitmap = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TheBitmap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitmap Width (inches):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitmap Height (inches):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lip (bitmap border, inches):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "# Rows:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "# Columns:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Source Folder:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Stem Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Picture Spacing (pixels):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "DPI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Picture Size (inches):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Space From Top (inches):";
            // 
            // BitmapWidth
            // 
            this.BitmapWidth.Location = new System.Drawing.Point(204, 44);
            this.BitmapWidth.Name = "BitmapWidth";
            this.BitmapWidth.Size = new System.Drawing.Size(45, 23);
            this.BitmapWidth.TabIndex = 11;
            this.BitmapWidth.TextChanged += new System.EventHandler(this.BitmapWidth_TextChanged);
            // 
            // BitmapHeight
            // 
            this.BitmapHeight.Location = new System.Drawing.Point(204, 77);
            this.BitmapHeight.Name = "BitmapHeight";
            this.BitmapHeight.Size = new System.Drawing.Size(45, 23);
            this.BitmapHeight.TabIndex = 12;
            this.BitmapHeight.TextChanged += new System.EventHandler(this.BitmapHeight_TextChanged);
            // 
            // Lip
            // 
            this.Lip.Location = new System.Drawing.Point(204, 110);
            this.Lip.Name = "Lip";
            this.Lip.Size = new System.Drawing.Size(45, 23);
            this.Lip.TabIndex = 13;
            this.Lip.TextChanged += new System.EventHandler(this.Lip_TextChanged);
            // 
            // NumRows
            // 
            this.NumRows.Location = new System.Drawing.Point(204, 143);
            this.NumRows.Name = "NumRows";
            this.NumRows.Size = new System.Drawing.Size(45, 23);
            this.NumRows.TabIndex = 14;
            this.NumRows.TextChanged += new System.EventHandler(this.NumRows_TextChanged);
            // 
            // NumCols
            // 
            this.NumCols.Location = new System.Drawing.Point(204, 176);
            this.NumCols.Name = "NumCols";
            this.NumCols.Size = new System.Drawing.Size(45, 23);
            this.NumCols.TabIndex = 15;
            this.NumCols.TextChanged += new System.EventHandler(this.NumCols_TextChanged);
            // 
            // PixelSpacing
            // 
            this.PixelSpacing.Location = new System.Drawing.Point(204, 275);
            this.PixelSpacing.Name = "PixelSpacing";
            this.PixelSpacing.Size = new System.Drawing.Size(45, 23);
            this.PixelSpacing.TabIndex = 16;
            this.PixelSpacing.TextChanged += new System.EventHandler(this.PixelSpacing_TextChanged);
            // 
            // Dpi
            // 
            this.Dpi.Location = new System.Drawing.Point(204, 308);
            this.Dpi.Name = "Dpi";
            this.Dpi.Size = new System.Drawing.Size(45, 23);
            this.Dpi.TabIndex = 17;
            this.Dpi.TextChanged += new System.EventHandler(this.Dpi_TextChanged);
            // 
            // PictureSize
            // 
            this.PictureSize.Location = new System.Drawing.Point(204, 341);
            this.PictureSize.Name = "PictureSize";
            this.PictureSize.Size = new System.Drawing.Size(45, 23);
            this.PictureSize.TabIndex = 18;
            this.PictureSize.TextChanged += new System.EventHandler(this.PictureSize_TextChanged);
            // 
            // SpaceFromTop
            // 
            this.SpaceFromTop.Location = new System.Drawing.Point(204, 374);
            this.SpaceFromTop.Name = "SpaceFromTop";
            this.SpaceFromTop.Size = new System.Drawing.Size(45, 23);
            this.SpaceFromTop.TabIndex = 19;
            this.SpaceFromTop.TextChanged += new System.EventHandler(this.SpaceFromTop_TextChanged);
            // 
            // SourceFolder
            // 
            this.SourceFolder.Location = new System.Drawing.Point(204, 209);
            this.SourceFolder.Name = "SourceFolder";
            this.SourceFolder.Size = new System.Drawing.Size(213, 23);
            this.SourceFolder.TabIndex = 20;
            this.SourceFolder.TextChanged += new System.EventHandler(this.SourceFolder_TextChanged);
            // 
            // StemName
            // 
            this.StemName.Location = new System.Drawing.Point(205, 242);
            this.StemName.Name = "StemName";
            this.StemName.Size = new System.Drawing.Size(103, 23);
            this.StemName.TabIndex = 21;
            this.StemName.TextChanged += new System.EventHandler(this.StemName_TextChanged);
            // 
            // MakeArtButton
            // 
            this.MakeArtButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.MakeArtButton.Location = new System.Drawing.Point(754, 36);
            this.MakeArtButton.Name = "MakeArtButton";
            this.MakeArtButton.Size = new System.Drawing.Size(90, 56);
            this.MakeArtButton.TabIndex = 22;
            this.MakeArtButton.Text = "&Make Art";
            this.MakeArtButton.UseVisualStyleBackColor = true;
            this.MakeArtButton.Click += new System.EventHandler(this.MakeArtButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(754, 120);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(90, 56);
            this.CloseButton.TabIndex = 23;
            this.CloseButton.Text = "&Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TheBitmap
            // 
            this.TheBitmap.Location = new System.Drawing.Point(532, 209);
            this.TheBitmap.Name = "TheBitmap";
            this.TheBitmap.Size = new System.Drawing.Size(312, 208);
            this.TheBitmap.TabIndex = 24;
            this.TheBitmap.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(481, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Bitmap:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TheBitmap);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MakeArtButton);
            this.Controls.Add(this.StemName);
            this.Controls.Add(this.SourceFolder);
            this.Controls.Add(this.SpaceFromTop);
            this.Controls.Add(this.PictureSize);
            this.Controls.Add(this.Dpi);
            this.Controls.Add(this.PixelSpacing);
            this.Controls.Add(this.NumCols);
            this.Controls.Add(this.NumRows);
            this.Controls.Add(this.Lip);
            this.Controls.Add(this.BitmapHeight);
            this.Controls.Add(this.BitmapWidth);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Arte de la guitarra";
            ((System.ComponentModel.ISupportInitialize)(this.TheBitmap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox BitmapWidth;
        private TextBox BitmapHeight;
        private TextBox Lip;
        private TextBox NumRows;
        private TextBox NumCols;
        private TextBox PixelSpacing;
        private TextBox Dpi;
        private TextBox PictureSize;
        private TextBox SpaceFromTop;
        private TextBox SourceFolder;
        private TextBox StemName;
        private Button MakeArtButton;
        private Button CloseButton;
        private PictureBox TheBitmap;
        private Label label12;
    }
}