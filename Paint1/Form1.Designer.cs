namespace Paint1
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
            this.plButtons = new System.Windows.Forms.Panel();
            this.btnColors = new System.Windows.Forms.Button();
            this.numDoDay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdBtnBrush = new System.Windows.Forms.RadioButton();
            this.rdBtnPen = new System.Windows.Forms.RadioButton();
            this.cbbDashStyle = new System.Windows.Forms.ComboBox();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.txtSweepAngle = new System.Windows.Forms.TextBox();
            this.txtStartAngle = new System.Windows.Forms.TextBox();
            this.lbSweepAngle = new System.Windows.Forms.Label();
            this.lbStartAngle = new System.Windows.Forms.Label();
            this.btnDone2 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnUnGroup = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnArc = new System.Windows.Forms.Button();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnEclipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnPolyGon = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.plMain = new System.Windows.Forms.PictureBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.plButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDoDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            this.SuspendLayout();
            // 
            // plButtons
            // 
            this.plButtons.BackColor = System.Drawing.Color.DimGray;
            this.plButtons.Controls.Add(this.btnSave);
            this.plButtons.Controls.Add(this.btnColors);
            this.plButtons.Controls.Add(this.numDoDay);
            this.plButtons.Controls.Add(this.label1);
            this.plButtons.Controls.Add(this.pictureBox2);
            this.plButtons.Controls.Add(this.pictureBox1);
            this.plButtons.Controls.Add(this.rdBtnBrush);
            this.plButtons.Controls.Add(this.rdBtnPen);
            this.plButtons.Controls.Add(this.cbbDashStyle);
            this.plButtons.Controls.Add(this.btnZoomOut);
            this.plButtons.Controls.Add(this.btnZoomIn);
            this.plButtons.Controls.Add(this.txtSweepAngle);
            this.plButtons.Controls.Add(this.txtStartAngle);
            this.plButtons.Controls.Add(this.lbSweepAngle);
            this.plButtons.Controls.Add(this.lbStartAngle);
            this.plButtons.Controls.Add(this.btnDone2);
            this.plButtons.Controls.Add(this.btnXoa);
            this.plButtons.Controls.Add(this.btnUnGroup);
            this.plButtons.Controls.Add(this.btnSelect);
            this.plButtons.Controls.Add(this.btnGroup);
            this.plButtons.Controls.Add(this.btnArc);
            this.plButtons.Controls.Add(this.btnCurve);
            this.plButtons.Controls.Add(this.btnEclipse);
            this.plButtons.Controls.Add(this.btnCircle);
            this.plButtons.Controls.Add(this.btnRectangle);
            this.plButtons.Controls.Add(this.btnPolyGon);
            this.plButtons.Controls.Add(this.btnLine);
            this.plButtons.Location = new System.Drawing.Point(2, 1);
            this.plButtons.Name = "plButtons";
            this.plButtons.Size = new System.Drawing.Size(166, 762);
            this.plButtons.TabIndex = 0;
            // 
            // btnColors
            // 
            this.btnColors.Image = global::Paint1.Properties.Resources.Color_80;
            this.btnColors.Location = new System.Drawing.Point(51, 715);
            this.btnColors.Name = "btnColors";
            this.btnColors.Size = new System.Drawing.Size(55, 44);
            this.btnColors.TabIndex = 13;
            this.btnColors.UseVisualStyleBackColor = true;
            this.btnColors.Click += new System.EventHandler(this.btnColors_Click);
            // 
            // numDoDay
            // 
            this.numDoDay.Location = new System.Drawing.Point(91, 680);
            this.numDoDay.Name = "numDoDay";
            this.numDoDay.Size = new System.Drawing.Size(66, 27);
            this.numDoDay.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 682);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Độ dày";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(112, 615);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 49);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(28, 615);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rdBtnBrush
            // 
            this.rdBtnBrush.AutoSize = true;
            this.rdBtnBrush.Location = new System.Drawing.Point(89, 632);
            this.rdBtnBrush.Name = "rdBtnBrush";
            this.rdBtnBrush.Size = new System.Drawing.Size(17, 16);
            this.rdBtnBrush.TabIndex = 10;
            this.rdBtnBrush.TabStop = true;
            this.rdBtnBrush.UseVisualStyleBackColor = true;
            // 
            // rdBtnPen
            // 
            this.rdBtnPen.AutoSize = true;
            this.rdBtnPen.Location = new System.Drawing.Point(5, 632);
            this.rdBtnPen.Name = "rdBtnPen";
            this.rdBtnPen.Size = new System.Drawing.Size(17, 16);
            this.rdBtnPen.TabIndex = 9;
            this.rdBtnPen.TabStop = true;
            this.rdBtnPen.UseVisualStyleBackColor = true;
            // 
            // cbbDashStyle
            // 
            this.cbbDashStyle.FormattingEnabled = true;
            this.cbbDashStyle.Location = new System.Drawing.Point(17, 576);
            this.cbbDashStyle.Name = "cbbDashStyle";
            this.cbbDashStyle.Size = new System.Drawing.Size(127, 28);
            this.cbbDashStyle.TabIndex = 8;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Image = global::Paint1.Properties.Resources.ZoomOut_801;
            this.btnZoomOut.Location = new System.Drawing.Point(99, 520);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(48, 50);
            this.btnZoomOut.TabIndex = 5;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Image = global::Paint1.Properties.Resources.ZoomIn1ZoomIn_80;
            this.btnZoomIn.Location = new System.Drawing.Point(17, 520);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(48, 50);
            this.btnZoomIn.TabIndex = 4;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // txtSweepAngle
            // 
            this.txtSweepAngle.Location = new System.Drawing.Point(91, 487);
            this.txtSweepAngle.Name = "txtSweepAngle";
            this.txtSweepAngle.Size = new System.Drawing.Size(61, 27);
            this.txtSweepAngle.TabIndex = 7;
            // 
            // txtStartAngle
            // 
            this.txtStartAngle.Location = new System.Drawing.Point(91, 456);
            this.txtStartAngle.Name = "txtStartAngle";
            this.txtStartAngle.Size = new System.Drawing.Size(61, 27);
            this.txtStartAngle.TabIndex = 6;
            // 
            // lbSweepAngle
            // 
            this.lbSweepAngle.AutoSize = true;
            this.lbSweepAngle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSweepAngle.Location = new System.Drawing.Point(12, 494);
            this.lbSweepAngle.Name = "lbSweepAngle";
            this.lbSweepAngle.Size = new System.Drawing.Size(67, 19);
            this.lbSweepAngle.TabIndex = 5;
            this.lbSweepAngle.Text = "Góc cong";
            // 
            // lbStartAngle
            // 
            this.lbStartAngle.AutoSize = true;
            this.lbStartAngle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStartAngle.Location = new System.Drawing.Point(5, 464);
            this.lbStartAngle.Name = "lbStartAngle";
            this.lbStartAngle.Size = new System.Drawing.Size(84, 19);
            this.lbStartAngle.TabIndex = 4;
            this.lbStartAngle.Text = "Góc bắt đầu";
            // 
            // btnDone2
            // 
            this.btnDone2.Location = new System.Drawing.Point(94, 399);
            this.btnDone2.Name = "btnDone2";
            this.btnDone2.Size = new System.Drawing.Size(58, 45);
            this.btnDone2.TabIndex = 3;
            this.btnDone2.Text = "Done";
            this.btnDone2.UseVisualStyleBackColor = true;
            this.btnDone2.Click += new System.EventHandler(this.btnDone2_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::Paint1.Properties.Resources.Thungrac_80;
            this.btnXoa.Location = new System.Drawing.Point(12, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(58, 45);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnUnGroup
            // 
            this.btnUnGroup.Location = new System.Drawing.Point(94, 348);
            this.btnUnGroup.Name = "btnUnGroup";
            this.btnUnGroup.Size = new System.Drawing.Size(58, 45);
            this.btnUnGroup.TabIndex = 2;
            this.btnUnGroup.Text = "UnGroup";
            this.btnUnGroup.UseVisualStyleBackColor = true;
            this.btnUnGroup.Click += new System.EventHandler(this.btnUnGroup_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::Paint1.Properties.Resources.Select_80;
            this.btnSelect.Location = new System.Drawing.Point(94, 297);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(58, 45);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(12, 348);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(58, 45);
            this.btnGroup.TabIndex = 3;
            this.btnGroup.Text = "Group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnArc
            // 
            this.btnArc.Image = global::Paint1.Properties.Resources.Arc_80;
            this.btnArc.Location = new System.Drawing.Point(94, 246);
            this.btnArc.Name = "btnArc";
            this.btnArc.Size = new System.Drawing.Size(58, 45);
            this.btnArc.TabIndex = 2;
            this.btnArc.UseVisualStyleBackColor = true;
            this.btnArc.Click += new System.EventHandler(this.btnArc_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.Image = global::Paint1.Properties.Resources.Curve_80;
            this.btnCurve.Location = new System.Drawing.Point(12, 297);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(58, 45);
            this.btnCurve.TabIndex = 3;
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.btnCurve_Click);
            // 
            // btnEclipse
            // 
            this.btnEclipse.Image = global::Paint1.Properties.Resources.Ecllipse_80;
            this.btnEclipse.Location = new System.Drawing.Point(94, 195);
            this.btnEclipse.Name = "btnEclipse";
            this.btnEclipse.Size = new System.Drawing.Size(58, 45);
            this.btnEclipse.TabIndex = 1;
            this.btnEclipse.UseVisualStyleBackColor = true;
            this.btnEclipse.Click += new System.EventHandler(this.btnEclipse_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Image = global::Paint1.Properties.Resources.circle_80;
            this.btnCircle.Location = new System.Drawing.Point(12, 246);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(58, 45);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Image = global::Paint1.Properties.Resources.Rectangle__80;
            this.btnRectangle.Location = new System.Drawing.Point(12, 195);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(58, 45);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnPolyGon
            // 
            this.btnPolyGon.Image = global::Paint1.Properties.Resources.Polygon_80;
            this.btnPolyGon.Location = new System.Drawing.Point(94, 144);
            this.btnPolyGon.Name = "btnPolyGon";
            this.btnPolyGon.Size = new System.Drawing.Size(58, 45);
            this.btnPolyGon.TabIndex = 1;
            this.btnPolyGon.UseVisualStyleBackColor = true;
            this.btnPolyGon.Click += new System.EventHandler(this.btnPolyGon_Click);
            // 
            // btnLine
            // 
            this.btnLine.Image = global::Paint1.Properties.Resources.Line_80;
            this.btnLine.Location = new System.Drawing.Point(12, 144);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(58, 45);
            this.btnLine.TabIndex = 0;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // plMain
            // 
            this.plMain.InitialImage = null;
            this.plMain.Location = new System.Drawing.Point(174, 1);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1022, 762);
            this.plMain.TabIndex = 1;
            this.plMain.TabStop = false;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
            this.plMain.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.plMain_PreviewKeyDown);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDone.Location = new System.Drawing.Point(192, 18);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(56, 24);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 48);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 764);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.plButtons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plButtons.ResumeLayout(false);
            this.plButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDoDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel plButtons;
        private Button btnColors;
        private NumericUpDown numDoDay;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RadioButton rdBtnBrush;
        private RadioButton rdBtnPen;
        private ComboBox cbbDashStyle;
        private Button btnZoomOut;
        private Button btnZoomIn;
        private TextBox txtSweepAngle;
        private TextBox txtStartAngle;
        private Label lbSweepAngle;
        private Label lbStartAngle;
        private Button btnDone2;
        private Button btnXoa;
        private Button btnUnGroup;
        private Button btnSelect;
        private Button btnGroup;
        private Button btnArc;
        private Button btnCurve;
        private Button btnEclipse;
        private Button btnCircle;
        private Button btnRectangle;
        private Button btnPolyGon;
        private Button btnLine;
        private PictureBox plMain;
        private Button btnDone;
        private Button btnSave;
    }
}