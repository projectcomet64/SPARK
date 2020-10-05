namespace CMTSpark
{
    partial class AppearanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppearanceForm));
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLightCol = new System.Windows.Forms.Button();
            this.btnDarkCol = new System.Windows.Forms.Button();
            this.lbColors = new System.Windows.Forms.ListBox();
            this.btnLoadFromGame = new System.Windows.Forms.Button();
            this.btnResetColors = new System.Windows.Forms.Button();
            this.btnExportCode = new System.Windows.Forms.Button();
            this.btnImportCode = new System.Windows.Forms.Button();
            this.grpShading = new System.Windows.Forms.GroupBox();
            this.btnRandomizeShading = new System.Windows.Forms.Button();
            this.btnResetShading = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBackFront = new System.Windows.Forms.TrackBar();
            this.tbBottomTop = new System.Windows.Forms.TrackBar();
            this.tbLeftRight = new System.Windows.Forms.TrackBar();
            this.gbTransforms = new System.Windows.Forms.GroupBox();
            this.btnTFShirtPants = new System.Windows.Forms.Button();
            this.btnTFCustomRestore = new System.Windows.Forms.Button();
            this.btnTFShorties = new System.Windows.Forms.Button();
            this.btnTFSCCSleeves = new System.Windows.Forms.Button();
            this.btnTFCC2SCC = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutSPARKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marioSprite = new System.Windows.Forms.PictureBox();
            this.epilepsyWarningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpColor.SuspendLayout();
            this.grpShading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBackFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBottomTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftRight)).BeginInit();
            this.gbTransforms.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marioSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            this.colorDialog.SolidColorOnly = true;
            // 
            // label9
            // 
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(12, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(450, 30);
            this.label9.TabIndex = 21;
            this.label9.Text = "IMPORTANT: Make sure to DISABLE all color codes in Project64!\nOtherwise, Mario\'s " +
    "colors won\'t match the ones you pick here.";
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.label2);
            this.grpColor.Controls.Add(this.label1);
            this.grpColor.Controls.Add(this.label7);
            this.grpColor.Controls.Add(this.label8);
            this.grpColor.Controls.Add(this.btnLightCol);
            this.grpColor.Controls.Add(this.btnDarkCol);
            this.grpColor.Controls.Add(this.lbColors);
            this.grpColor.Controls.Add(this.btnLoadFromGame);
            this.grpColor.Controls.Add(this.btnResetColors);
            this.grpColor.Controls.Add(this.btnExportCode);
            this.grpColor.Controls.Add(this.marioSprite);
            this.grpColor.Controls.Add(this.btnImportCode);
            this.grpColor.Location = new System.Drawing.Point(12, 62);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(294, 270);
            this.grpColor.TabIndex = 22;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color Settings";
            // 
            // label2
            // 
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "SPARK CC Parts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(184, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Selected Part";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(173, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Light";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(234, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Base";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLightCol
            // 
            this.btnLightCol.BackColor = System.Drawing.Color.Red;
            this.btnLightCol.ForeColor = System.Drawing.Color.Black;
            this.btnLightCol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLightCol.Location = new System.Drawing.Point(172, 45);
            this.btnLightCol.Name = "btnLightCol";
            this.btnLightCol.Size = new System.Drawing.Size(48, 24);
            this.btnLightCol.TabIndex = 25;
            this.btnLightCol.UseVisualStyleBackColor = false;
            this.btnLightCol.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // btnDarkCol
            // 
            this.btnDarkCol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDarkCol.ForeColor = System.Drawing.Color.Black;
            this.btnDarkCol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDarkCol.Location = new System.Drawing.Point(233, 45);
            this.btnDarkCol.Name = "btnDarkCol";
            this.btnDarkCol.Size = new System.Drawing.Size(48, 24);
            this.btnDarkCol.TabIndex = 26;
            this.btnDarkCol.UseVisualStyleBackColor = false;
            this.btnDarkCol.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // lbColors
            // 
            this.lbColors.FormattingEnabled = true;
            this.lbColors.Location = new System.Drawing.Point(9, 45);
            this.lbColors.Name = "lbColors";
            this.lbColors.Size = new System.Drawing.Size(147, 212);
            this.lbColors.TabIndex = 24;
            this.lbColors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbColors_DrawItem);
            this.lbColors.SelectedValueChanged += new System.EventHandler(this.lbColors_SelectedValueChanged);
            // 
            // btnLoadFromGame
            // 
            this.btnLoadFromGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoadFromGame.Location = new System.Drawing.Point(170, 234);
            this.btnLoadFromGame.Name = "btnLoadFromGame";
            this.btnLoadFromGame.Size = new System.Drawing.Size(111, 23);
            this.btnLoadFromGame.TabIndex = 24;
            this.btnLoadFromGame.Text = "Load From Game";
            this.btnLoadFromGame.UseVisualStyleBackColor = true;
            this.btnLoadFromGame.Click += new System.EventHandler(this.LoadFromGame);
            // 
            // btnResetColors
            // 
            this.btnResetColors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnResetColors.Location = new System.Drawing.Point(170, 176);
            this.btnResetColors.Name = "btnResetColors";
            this.btnResetColors.Size = new System.Drawing.Size(111, 23);
            this.btnResetColors.TabIndex = 23;
            this.btnResetColors.Text = "Reset Colors";
            this.btnResetColors.UseVisualStyleBackColor = true;
            this.btnResetColors.Click += new System.EventHandler(this.ResetColors);
            // 
            // btnExportCode
            // 
            this.btnExportCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExportCode.Location = new System.Drawing.Point(170, 205);
            this.btnExportCode.Name = "btnExportCode";
            this.btnExportCode.Size = new System.Drawing.Size(111, 23);
            this.btnExportCode.TabIndex = 22;
            this.btnExportCode.Text = "Export Color Code";
            this.btnExportCode.UseVisualStyleBackColor = true;
            this.btnExportCode.Click += new System.EventHandler(this.OpenCopyPasteForm);
            // 
            // btnImportCode
            // 
            this.btnImportCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImportCode.Location = new System.Drawing.Point(170, 147);
            this.btnImportCode.Name = "btnImportCode";
            this.btnImportCode.Size = new System.Drawing.Size(111, 23);
            this.btnImportCode.TabIndex = 21;
            this.btnImportCode.Text = "Import Color Code";
            this.btnImportCode.UseVisualStyleBackColor = true;
            this.btnImportCode.Click += new System.EventHandler(this.OpenCopyPasteForm);
            // 
            // grpShading
            // 
            this.grpShading.Controls.Add(this.btnRandomizeShading);
            this.grpShading.Controls.Add(this.btnResetShading);
            this.grpShading.Controls.Add(this.label13);
            this.grpShading.Controls.Add(this.label14);
            this.grpShading.Controls.Add(this.label15);
            this.grpShading.Controls.Add(this.label12);
            this.grpShading.Controls.Add(this.label11);
            this.grpShading.Controls.Add(this.label10);
            this.grpShading.Controls.Add(this.tbBackFront);
            this.grpShading.Controls.Add(this.tbBottomTop);
            this.grpShading.Controls.Add(this.tbLeftRight);
            this.grpShading.Location = new System.Drawing.Point(12, 338);
            this.grpShading.Name = "grpShading";
            this.grpShading.Size = new System.Drawing.Size(452, 107);
            this.grpShading.TabIndex = 23;
            this.grpShading.TabStop = false;
            this.grpShading.Text = "Shading Settings:";
            // 
            // btnRandomizeShading
            // 
            this.btnRandomizeShading.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRandomizeShading.Location = new System.Drawing.Point(326, 43);
            this.btnRandomizeShading.Name = "btnRandomizeShading";
            this.btnRandomizeShading.Size = new System.Drawing.Size(116, 23);
            this.btnRandomizeShading.TabIndex = 23;
            this.btnRandomizeShading.Text = "Randomize Shading";
            this.btnRandomizeShading.UseVisualStyleBackColor = true;
            this.btnRandomizeShading.Click += new System.EventHandler(this.RandomizeShadows);
            // 
            // btnResetShading
            // 
            this.btnResetShading.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnResetShading.Location = new System.Drawing.Point(326, 14);
            this.btnResetShading.Name = "btnResetShading";
            this.btnResetShading.Size = new System.Drawing.Size(116, 23);
            this.btnResetShading.TabIndex = 22;
            this.btnResetShading.Text = "Reset Shading";
            this.btnResetShading.UseVisualStyleBackColor = true;
            this.btnResetShading.Click += new System.EventHandler(this.ResetShadows);
            // 
            // label13
            // 
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(292, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Front";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(292, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Top";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(292, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Right";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(6, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Back";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Bottom";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Left";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBackFront
            // 
            this.tbBackFront.AutoSize = false;
            this.tbBackFront.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbBackFront.Location = new System.Drawing.Point(59, 77);
            this.tbBackFront.Maximum = 127;
            this.tbBackFront.Minimum = -127;
            this.tbBackFront.Name = "tbBackFront";
            this.tbBackFront.Size = new System.Drawing.Size(235, 23);
            this.tbBackFront.TabIndex = 2;
            this.tbBackFront.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBackFront.Value = 40;
            this.tbBackFront.ValueChanged += new System.EventHandler(this.UpdateTrackbar);
            // 
            // tbBottomTop
            // 
            this.tbBottomTop.AutoSize = false;
            this.tbBottomTop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbBottomTop.Location = new System.Drawing.Point(59, 48);
            this.tbBottomTop.Maximum = 127;
            this.tbBottomTop.Minimum = -127;
            this.tbBottomTop.Name = "tbBottomTop";
            this.tbBottomTop.Size = new System.Drawing.Size(235, 23);
            this.tbBottomTop.TabIndex = 1;
            this.tbBottomTop.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBottomTop.Value = 40;
            this.tbBottomTop.ValueChanged += new System.EventHandler(this.UpdateTrackbar);
            // 
            // tbLeftRight
            // 
            this.tbLeftRight.AutoSize = false;
            this.tbLeftRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbLeftRight.Location = new System.Drawing.Point(59, 19);
            this.tbLeftRight.Maximum = 127;
            this.tbLeftRight.Minimum = -127;
            this.tbLeftRight.Name = "tbLeftRight";
            this.tbLeftRight.Size = new System.Drawing.Size(235, 23);
            this.tbLeftRight.TabIndex = 0;
            this.tbLeftRight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbLeftRight.Value = 40;
            this.tbLeftRight.ValueChanged += new System.EventHandler(this.UpdateTrackbar);
            // 
            // gbTransforms
            // 
            this.gbTransforms.Controls.Add(this.btnTFShirtPants);
            this.gbTransforms.Controls.Add(this.btnTFCustomRestore);
            this.gbTransforms.Controls.Add(this.btnTFShorties);
            this.gbTransforms.Controls.Add(this.btnTFSCCSleeves);
            this.gbTransforms.Controls.Add(this.btnTFCC2SCC);
            this.gbTransforms.Location = new System.Drawing.Point(312, 62);
            this.gbTransforms.Name = "gbTransforms";
            this.gbTransforms.Size = new System.Drawing.Size(150, 270);
            this.gbTransforms.TabIndex = 24;
            this.gbTransforms.TabStop = false;
            this.gbTransforms.Text = "Color Code Transforms";
            // 
            // btnTFShirtPants
            // 
            this.btnTFShirtPants.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTFShirtPants.Location = new System.Drawing.Point(6, 48);
            this.btnTFShirtPants.Name = "btnTFShirtPants";
            this.btnTFShirtPants.Size = new System.Drawing.Size(136, 23);
            this.btnTFShirtPants.TabIndex = 4;
            this.btnTFShirtPants.Text = "SCC Shirt and Pants";
            this.btnTFShirtPants.UseVisualStyleBackColor = true;
            this.btnTFShirtPants.Click += new System.EventHandler(this.btnTFShirtPants_Click);
            // 
            // btnTFCustomRestore
            // 
            this.btnTFCustomRestore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTFCustomRestore.Location = new System.Drawing.Point(6, 135);
            this.btnTFCustomRestore.Name = "btnTFCustomRestore";
            this.btnTFCustomRestore.Size = new System.Drawing.Size(136, 23);
            this.btnTFCustomRestore.TabIndex = 3;
            this.btnTFCustomRestore.Text = "SCC Restore Customs";
            this.btnTFCustomRestore.UseVisualStyleBackColor = true;
            this.btnTFCustomRestore.Click += new System.EventHandler(this.btnTFCustomRestore_Click);
            // 
            // btnTFShorties
            // 
            this.btnTFShorties.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTFShorties.Location = new System.Drawing.Point(6, 77);
            this.btnTFShorties.Name = "btnTFShorties";
            this.btnTFShorties.Size = new System.Drawing.Size(136, 23);
            this.btnTFShorties.TabIndex = 2;
            this.btnTFShorties.Text = "SCC Short Pants";
            this.btnTFShorties.UseVisualStyleBackColor = true;
            this.btnTFShorties.Click += new System.EventHandler(this.btnTFShorties_Click);
            // 
            // btnTFSCCSleeves
            // 
            this.btnTFSCCSleeves.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTFSCCSleeves.Location = new System.Drawing.Point(6, 106);
            this.btnTFSCCSleeves.Name = "btnTFSCCSleeves";
            this.btnTFSCCSleeves.Size = new System.Drawing.Size(136, 23);
            this.btnTFSCCSleeves.TabIndex = 1;
            this.btnTFSCCSleeves.Text = "SCC Short Sleeves";
            this.btnTFSCCSleeves.UseVisualStyleBackColor = true;
            this.btnTFSCCSleeves.Click += new System.EventHandler(this.btnTFSCCSleeves_Click);
            // 
            // btnTFCC2SCC
            // 
            this.btnTFCC2SCC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTFCC2SCC.Location = new System.Drawing.Point(6, 19);
            this.btnTFCC2SCC.Name = "btnTFCC2SCC";
            this.btnTFCC2SCC.Size = new System.Drawing.Size(136, 23);
            this.btnTFCC2SCC.TabIndex = 0;
            this.btnTFCC2SCC.Text = "Classic CC to SCC";
            this.btnTFCC2SCC.UseVisualStyleBackColor = true;
            this.btnTFCC2SCC.Click += new System.EventHandler(this.btnTFCC2SCC_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSPARKToolStripMenuItem,
            this.epilepsyWarningToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutSPARKToolStripMenuItem
            // 
            this.aboutSPARKToolStripMenuItem.Name = "aboutSPARKToolStripMenuItem";
            this.aboutSPARKToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.aboutSPARKToolStripMenuItem.Text = "About SPARK";
            this.aboutSPARKToolStripMenuItem.Click += new System.EventHandler(this.aboutSPARKToolStripMenuItem_Click);
            // 
            // marioSprite
            // 
            this.marioSprite.BackColor = System.Drawing.Color.Transparent;
            this.marioSprite.Image = global::CMTSpark.Properties.Resources.spark_;
            this.marioSprite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.marioSprite.Location = new System.Drawing.Point(194, 75);
            this.marioSprite.Name = "marioSprite";
            this.marioSprite.Size = new System.Drawing.Size(64, 64);
            this.marioSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.marioSprite.TabIndex = 0;
            this.marioSprite.TabStop = false;
            this.marioSprite.DoubleClick += new System.EventHandler(this.marioSprite_DoubleClick);
            // 
            // epilepsyWarningToolStripMenuItem
            // 
            this.epilepsyWarningToolStripMenuItem.Name = "epilepsyWarningToolStripMenuItem";
            this.epilepsyWarningToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.epilepsyWarningToolStripMenuItem.Text = "Epilepsy warning";
            this.epilepsyWarningToolStripMenuItem.Click += new System.EventHandler(this.epilepsyWarningToolStripMenuItem_Click);
            // 
            // AppearanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 457);
            this.Controls.Add(this.gbTransforms);
            this.Controls.Add(this.grpShading);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AppearanceForm";
            this.Text = "SPARK Editor";
            this.grpColor.ResumeLayout(false);
            this.grpShading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbBackFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBottomTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftRight)).EndInit();
            this.gbTransforms.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marioSprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox marioSprite;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.GroupBox grpShading;
        private System.Windows.Forms.Button btnExportCode;
        private System.Windows.Forms.Button btnImportCode;
        private System.Windows.Forms.Button btnLoadFromGame;
        private System.Windows.Forms.Button btnResetColors;
        private System.Windows.Forms.TrackBar tbLeftRight;
        private System.Windows.Forms.TrackBar tbBackFront;
        private System.Windows.Forms.TrackBar tbBottomTop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnResetShading;
        private System.Windows.Forms.Button btnRandomizeShading;
        private System.Windows.Forms.ListBox lbColors;
        private System.Windows.Forms.Button btnLightCol;
        private System.Windows.Forms.Button btnDarkCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbTransforms;
        private System.Windows.Forms.Button btnTFShirtPants;
        private System.Windows.Forms.Button btnTFCustomRestore;
        private System.Windows.Forms.Button btnTFShorties;
        private System.Windows.Forms.Button btnTFSCCSleeves;
        private System.Windows.Forms.Button btnTFCC2SCC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutSPARKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem epilepsyWarningToolStripMenuItem;
    }
}