namespace OOPDraw2021
{
    partial class OOPDraw
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
            this.pbx_Canvas = new System.Windows.Forms.PictureBox();
            this.cbx_LineWidth = new System.Windows.Forms.ComboBox();
            this.lbl_LineWidth = new System.Windows.Forms.Label();
            this.lbl_Colour = new System.Windows.Forms.Label();
            this.cbx_Colour = new System.Windows.Forms.ComboBox();
            this.cbx_Shape = new System.Windows.Forms.ComboBox();
            this.lbl_Shape = new System.Windows.Forms.Label();
            this.lbl_Action = new System.Windows.Forms.Label();
            this.cbx_Action = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Canvas
            // 
            this.pbx_Canvas.BackColor = System.Drawing.SystemColors.Window;
            this.pbx_Canvas.Location = new System.Drawing.Point(461, 15);
            this.pbx_Canvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbx_Canvas.Name = "pbx_Canvas";
            this.pbx_Canvas.Size = new System.Drawing.Size(1105, 855);
            this.pbx_Canvas.TabIndex = 0;
            this.pbx_Canvas.TabStop = false;
            this.pbx_Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx_Canvas_Paint);
            this.pbx_Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbx_Canvas_MouseDown);
            this.pbx_Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbx_Canvas_MouseMove);
            this.pbx_Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbx_Canvas_MouseUp);
            // 
            // cbx_LineWidth
            // 
            this.cbx_LineWidth.FormattingEnabled = true;
            this.cbx_LineWidth.Items.AddRange(new object[] {
            "Thin",
            "Medium",
            "Thick"});
            this.cbx_LineWidth.Location = new System.Drawing.Point(16, 48);
            this.cbx_LineWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_LineWidth.Name = "cbx_LineWidth";
            this.cbx_LineWidth.Size = new System.Drawing.Size(289, 33);
            this.cbx_LineWidth.TabIndex = 1;
            this.cbx_LineWidth.SelectedIndexChanged += new System.EventHandler(this.cbx_LineWidth_SelectedIndexChanged);
            // 
            // lbl_LineWidth
            // 
            this.lbl_LineWidth.AutoSize = true;
            this.lbl_LineWidth.Location = new System.Drawing.Point(17, 16);
            this.lbl_LineWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LineWidth.Name = "lbl_LineWidth";
            this.lbl_LineWidth.Size = new System.Drawing.Size(114, 25);
            this.lbl_LineWidth.TabIndex = 2;
            this.lbl_LineWidth.Text = "Line Width";
            // 
            // lbl_Colour
            // 
            this.lbl_Colour.AutoSize = true;
            this.lbl_Colour.Location = new System.Drawing.Point(16, 106);
            this.lbl_Colour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Colour.Name = "lbl_Colour";
            this.lbl_Colour.Size = new System.Drawing.Size(75, 25);
            this.lbl_Colour.TabIndex = 3;
            this.lbl_Colour.Text = "Colour";
            // 
            // cbx_Colour
            // 
            this.cbx_Colour.FormattingEnabled = true;
            this.cbx_Colour.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.cbx_Colour.Location = new System.Drawing.Point(16, 136);
            this.cbx_Colour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_Colour.Name = "cbx_Colour";
            this.cbx_Colour.Size = new System.Drawing.Size(289, 33);
            this.cbx_Colour.TabIndex = 4;
            this.cbx_Colour.SelectedIndexChanged += new System.EventHandler(this.cbx_Colour_SelectedIndexChanged);
            // 
            // cbx_Shape
            // 
            this.cbx_Shape.FormattingEnabled = true;
            this.cbx_Shape.Items.AddRange(new object[] {
            "Cirlce",
            "Ellipse",
            "Line",
            "Rectangle"});
            this.cbx_Shape.Location = new System.Drawing.Point(17, 230);
            this.cbx_Shape.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_Shape.Name = "cbx_Shape";
            this.cbx_Shape.Size = new System.Drawing.Size(288, 33);
            this.cbx_Shape.TabIndex = 5;
            // 
            // lbl_Shape
            // 
            this.lbl_Shape.AutoSize = true;
            this.lbl_Shape.Location = new System.Drawing.Point(16, 198);
            this.lbl_Shape.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Shape.Name = "lbl_Shape";
            this.lbl_Shape.Size = new System.Drawing.Size(74, 25);
            this.lbl_Shape.TabIndex = 6;
            this.lbl_Shape.Text = "Shape";
            // 
            // lbl_Action
            // 
            this.lbl_Action.AutoSize = true;
            this.lbl_Action.Location = new System.Drawing.Point(17, 301);
            this.lbl_Action.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Action.Name = "lbl_Action";
            this.lbl_Action.Size = new System.Drawing.Size(72, 25);
            this.lbl_Action.TabIndex = 7;
            this.lbl_Action.Text = "Action";
            // 
            // cbx_Action
            // 
            this.cbx_Action.FormattingEnabled = true;
            this.cbx_Action.Items.AddRange(new object[] {
            "Draw",
            "Move",
            "Select",
            "Group",
            "Delete",
            "Duplicate"});
            this.cbx_Action.Location = new System.Drawing.Point(16, 331);
            this.cbx_Action.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_Action.Name = "cbx_Action";
            this.cbx_Action.Size = new System.Drawing.Size(289, 33);
            this.cbx_Action.TabIndex = 8;
            this.cbx_Action.SelectedIndexChanged += new System.EventHandler(this.cbx_Action_SelectedIndexChanged);
            // 
            // OOPDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 885);
            this.Controls.Add(this.cbx_Action);
            this.Controls.Add(this.lbl_Action);
            this.Controls.Add(this.lbl_Shape);
            this.Controls.Add(this.cbx_Shape);
            this.Controls.Add(this.cbx_Colour);
            this.Controls.Add(this.lbl_Colour);
            this.Controls.Add(this.lbl_LineWidth);
            this.Controls.Add(this.cbx_LineWidth);
            this.Controls.Add(this.pbx_Canvas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OOPDraw";
            this.Text = "OOPDraw";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Canvas;
        private System.Windows.Forms.ComboBox cbx_LineWidth;
        private System.Windows.Forms.Label lbl_LineWidth;
        private System.Windows.Forms.Label lbl_Colour;
        private System.Windows.Forms.ComboBox cbx_Colour;
        private System.Windows.Forms.ComboBox cbx_Shape;
        private System.Windows.Forms.Label lbl_Shape;
        private System.Windows.Forms.Label lbl_Action;
        private System.Windows.Forms.ComboBox cbx_Action;
    }
}

