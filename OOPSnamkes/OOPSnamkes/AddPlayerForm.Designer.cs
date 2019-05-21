namespace OOPSnamkes
{
    partial class AddPlayerForm
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
            this.lbl_Player = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_colour = new System.Windows.Forms.Label();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.cbx_Colour = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Player
            // 
            this.lbl_Player.AutoSize = true;
            this.lbl_Player.Location = new System.Drawing.Point(30, 22);
            this.lbl_Player.Name = "lbl_Player";
            this.lbl_Player.Size = new System.Drawing.Size(36, 13);
            this.lbl_Player.TabIndex = 0;
            this.lbl_Player.Text = "Player";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(30, 81);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_colour
            // 
            this.lbl_colour.AutoSize = true;
            this.lbl_colour.Location = new System.Drawing.Point(30, 140);
            this.lbl_colour.Name = "lbl_colour";
            this.lbl_colour.Size = new System.Drawing.Size(37, 13);
            this.lbl_colour.TabIndex = 2;
            this.lbl_colour.Text = "Colour";
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(84, 81);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(170, 20);
            this.tbx_Name.TabIndex = 3;
            // 
            // cbx_Colour
            // 
            this.cbx_Colour.FormattingEnabled = true;
            this.cbx_Colour.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Yellow",
            "Blue"});
            this.cbx_Colour.Location = new System.Drawing.Point(84, 131);
            this.cbx_Colour.Name = "cbx_Colour";
            this.cbx_Colour.Size = new System.Drawing.Size(170, 21);
            this.cbx_Colour.TabIndex = 4;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(33, 193);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(138, 193);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add Player";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(241, 193);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 237);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.cbx_Colour);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.lbl_colour);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Player);
            this.Name = "AddPlayerForm";
            this.Text = "AddPlayerForm";
            this.Load += new System.EventHandler(this.AddPlayerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Player;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_colour;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.ComboBox cbx_Colour;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_OK;
    }
}