namespace OOPSnamkes
{
    partial class TableTop
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
            this.pbx_Shaker = new System.Windows.Forms.PictureBox();
            this.btn_roll = new System.Windows.Forms.Button();
            this.pbx_Board = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Shaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Board)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Shaker
            // 
            this.pbx_Shaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_Shaker.Location = new System.Drawing.Point(485, 38);
            this.pbx_Shaker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbx_Shaker.Name = "pbx_Shaker";
            this.pbx_Shaker.Size = new System.Drawing.Size(267, 195);
            this.pbx_Shaker.TabIndex = 0;
            this.pbx_Shaker.TabStop = false;
            // 
            // btn_roll
            // 
            this.btn_roll.Location = new System.Drawing.Point(498, 237);
            this.btn_roll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(246, 49);
            this.btn_roll.TabIndex = 1;
            this.btn_roll.Text = "Roll Dice";
            this.btn_roll.UseVisualStyleBackColor = true;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // pbx_Board
            // 
            this.pbx_Board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbx_Board.Location = new System.Drawing.Point(36, 38);
            this.pbx_Board.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbx_Board.Name = "pbx_Board";
            this.pbx_Board.Size = new System.Drawing.Size(400, 390);
            this.pbx_Board.TabIndex = 2;
            this.pbx_Board.TabStop = false;
            // 
            // TableTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 469);
            this.Controls.Add(this.pbx_Board);
            this.Controls.Add(this.btn_roll);
            this.Controls.Add(this.pbx_Shaker);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TableTop";
            this.Text = "TableTop";
            this.Load += new System.EventHandler(this.TableTop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Shaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Board)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Shaker;
        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.PictureBox pbx_Board;
    }
}