namespace HumphreyErik21Shapes
{
    partial class frmShapeDemo
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
            this.components = new System.ComponentModel.Container();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.radEllipse = new System.Windows.Forms.RadioButton();
            this.radRectangle = new System.Windows.Forms.RadioButton();
            this.radLine = new System.Windows.Forms.RadioButton();
            this.tmrShape = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.Black;
            this.pnlDraw.Location = new System.Drawing.Point(185, 12);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(608, 448);
            this.pnlDraw.TabIndex = 6;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(45, 193);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // radEllipse
            // 
            this.radEllipse.AutoSize = true;
            this.radEllipse.ForeColor = System.Drawing.SystemColors.Control;
            this.radEllipse.Location = new System.Drawing.Point(45, 117);
            this.radEllipse.Name = "radEllipse";
            this.radEllipse.Size = new System.Drawing.Size(55, 17);
            this.radEllipse.TabIndex = 0;
            this.radEllipse.TabStop = true;
            this.radEllipse.Text = "Ellipse";
            this.radEllipse.UseVisualStyleBackColor = true;
            this.radEllipse.CheckedChanged += new System.EventHandler(this.radEllipse_CheckedChanged);
            // 
            // radRectangle
            // 
            this.radRectangle.AutoSize = true;
            this.radRectangle.BackColor = System.Drawing.Color.Black;
            this.radRectangle.ForeColor = System.Drawing.SystemColors.Control;
            this.radRectangle.Location = new System.Drawing.Point(45, 141);
            this.radRectangle.Name = "radRectangle";
            this.radRectangle.Size = new System.Drawing.Size(74, 17);
            this.radRectangle.TabIndex = 3;
            this.radRectangle.TabStop = true;
            this.radRectangle.Text = "Rectangle";
            this.radRectangle.UseVisualStyleBackColor = false;
            this.radRectangle.CheckedChanged += new System.EventHandler(this.radRectangle_CheckedChanged);
            // 
            // radLine
            // 
            this.radLine.AutoSize = true;
            this.radLine.BackColor = System.Drawing.Color.Black;
            this.radLine.ForeColor = System.Drawing.SystemColors.Control;
            this.radLine.Location = new System.Drawing.Point(45, 165);
            this.radLine.Name = "radLine";
            this.radLine.Size = new System.Drawing.Size(45, 17);
            this.radLine.TabIndex = 4;
            this.radLine.TabStop = true;
            this.radLine.Text = "Line";
            this.radLine.UseVisualStyleBackColor = false;
            this.radLine.CheckedChanged += new System.EventHandler(this.radLine_CheckedChanged);
            // 
            // tmrShape
            // 
            this.tmrShape.Tick += new System.EventHandler(this.tmrShape_Tick);
            // 
            // frmShapeDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(805, 476);
            this.Controls.Add(this.radLine);
            this.Controls.Add(this.radRectangle);
            this.Controls.Add(this.radEllipse);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pnlDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmShapeDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erik Humphrey\'s Shape Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShapeDemo_FormClosing);
            this.Load += new System.EventHandler(this.frmShapeDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.RadioButton radEllipse;
        private System.Windows.Forms.RadioButton radRectangle;
        private System.Windows.Forms.RadioButton radLine;
        private System.Windows.Forms.Timer tmrShape;
    }
}

