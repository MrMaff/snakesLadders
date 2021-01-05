namespace ImageViewer
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_LoadImage = new System.Windows.Forms.Button();
            this.pbc_viewer = new System.Windows.Forms.PictureBox();
            this.lbl_WidthLBL = new System.Windows.Forms.Label();
            this.lbl_HeightLBL = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.tbx_Output = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbc_viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btn_LoadImage
            // 
            this.btn_LoadImage.Location = new System.Drawing.Point(601, 37);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(183, 49);
            this.btn_LoadImage.TabIndex = 0;
            this.btn_LoadImage.Text = "Load Image";
            this.btn_LoadImage.UseVisualStyleBackColor = true;
            this.btn_LoadImage.Click += new System.EventHandler(this.btn_LoadImage_Click);
            // 
            // pbc_viewer
            // 
            this.pbc_viewer.Location = new System.Drawing.Point(600, 215);
            this.pbc_viewer.Name = "pbc_viewer";
            this.pbc_viewer.Size = new System.Drawing.Size(183, 161);
            this.pbc_viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbc_viewer.TabIndex = 1;
            this.pbc_viewer.TabStop = false;
            // 
            // lbl_WidthLBL
            // 
            this.lbl_WidthLBL.AutoSize = true;
            this.lbl_WidthLBL.Location = new System.Drawing.Point(650, 390);
            this.lbl_WidthLBL.Name = "lbl_WidthLBL";
            this.lbl_WidthLBL.Size = new System.Drawing.Size(54, 20);
            this.lbl_WidthLBL.TabIndex = 2;
            this.lbl_WidthLBL.Text = "Width:";
            this.lbl_WidthLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_HeightLBL
            // 
            this.lbl_HeightLBL.AutoSize = true;
            this.lbl_HeightLBL.Location = new System.Drawing.Point(644, 414);
            this.lbl_HeightLBL.Name = "lbl_HeightLBL";
            this.lbl_HeightLBL.Size = new System.Drawing.Size(60, 20);
            this.lbl_HeightLBL.TabIndex = 3;
            this.lbl_HeightLBL.Text = "Height:";
            this.lbl_HeightLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(715, 390);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(18, 20);
            this.lbl_Width.TabIndex = 4;
            this.lbl_Width.Text = "0";
            this.lbl_Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(715, 414);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(18, 20);
            this.lbl_Height.TabIndex = 5;
            this.lbl_Height.Text = "0";
            this.lbl_Height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_Output
            // 
            this.tbx_Output.Location = new System.Drawing.Point(38, 12);
            this.tbx_Output.Multiline = true;
            this.tbx_Output.Name = "tbx_Output";
            this.tbx_Output.Size = new System.Drawing.Size(464, 422);
            this.tbx_Output.TabIndex = 6;
            this.tbx_Output.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_Output);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.lbl_HeightLBL);
            this.Controls.Add(this.lbl_WidthLBL);
            this.Controls.Add(this.pbc_viewer);
            this.Controls.Add(this.btn_LoadImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbc_viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.PictureBox pbc_viewer;
        private System.Windows.Forms.Label lbl_WidthLBL;
        private System.Windows.Forms.Label lbl_HeightLBL;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.TextBox tbx_Output;
    }
}

