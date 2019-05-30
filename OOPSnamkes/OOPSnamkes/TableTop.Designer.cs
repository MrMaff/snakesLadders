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
            this.btn_NextPlayer = new System.Windows.Forms.Button();
            this.lbl_PlayerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Shaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Board)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Shaker
            // 
            this.pbx_Shaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_Shaker.Location = new System.Drawing.Point(729, 180);
            this.pbx_Shaker.Name = "pbx_Shaker";
            this.pbx_Shaker.Size = new System.Drawing.Size(400, 300);
            this.pbx_Shaker.TabIndex = 0;
            this.pbx_Shaker.TabStop = false;
            // 
            // btn_roll
            // 
            this.btn_roll.Location = new System.Drawing.Point(748, 487);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(369, 75);
            this.btn_roll.TabIndex = 1;
            this.btn_roll.Text = "Roll Dice";
            this.btn_roll.UseVisualStyleBackColor = true;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // pbx_Board
            // 
            this.pbx_Board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbx_Board.Location = new System.Drawing.Point(54, 58);
            this.pbx_Board.Name = "pbx_Board";
            this.pbx_Board.Size = new System.Drawing.Size(600, 600);
            this.pbx_Board.TabIndex = 2;
            this.pbx_Board.TabStop = false;
            // 
            // btn_NextPlayer
            // 
            this.btn_NextPlayer.Location = new System.Drawing.Point(747, 583);
            this.btn_NextPlayer.Name = "btn_NextPlayer";
            this.btn_NextPlayer.Size = new System.Drawing.Size(369, 75);
            this.btn_NextPlayer.TabIndex = 3;
            this.btn_NextPlayer.Text = "Next Player";
            this.btn_NextPlayer.UseVisualStyleBackColor = true;
            this.btn_NextPlayer.Click += new System.EventHandler(this.btn_NextPlayer_Click);
            // 
            // lbl_PlayerName
            // 
            this.lbl_PlayerName.AutoSize = true;
            this.lbl_PlayerName.Location = new System.Drawing.Point(729, 58);
            this.lbl_PlayerName.Name = "lbl_PlayerName";
            this.lbl_PlayerName.Size = new System.Drawing.Size(98, 20);
            this.lbl_PlayerName.TabIndex = 4;
            this.lbl_PlayerName.Text = "Player Name";
            // 
            // TableTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 722);
            this.Controls.Add(this.lbl_PlayerName);
            this.Controls.Add(this.btn_NextPlayer);
            this.Controls.Add(this.pbx_Board);
            this.Controls.Add(this.btn_roll);
            this.Controls.Add(this.pbx_Shaker);
            this.Name = "TableTop";
            this.Text = "TableTop";
            this.Load += new System.EventHandler(this.TableTop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Shaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Shaker;
        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.PictureBox pbx_Board;
        private System.Windows.Forms.Button btn_NextPlayer;
        private System.Windows.Forms.Label lbl_PlayerName;
    }
}