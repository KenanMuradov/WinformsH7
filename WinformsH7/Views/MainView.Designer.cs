namespace WinformsH7.Views
{
    partial class MainView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.cBoxFontSize = new System.Windows.Forms.ComboBox();
            this.lblFontAlignment = new System.Windows.Forms.Label();
            this.cBoxFontStyle = new System.Windows.Forms.ComboBox();
            this.lblFontStyle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOpenColorMenu = new System.Windows.Forms.Button();
            this.lblFontColor = new System.Windows.Forms.Label();
            this.cBoxColor = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnSaveMenu = new System.Windows.Forms.Button();
            this.btnLoadMenu = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtFileSave = new System.Windows.Forms.TextBox();
            this.txtFileLoad = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.96058F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.85663F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25448F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1404, 112);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFontDialog);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnCenter);
            this.panel1.Controls.Add(this.btnItalic);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnUnderline);
            this.panel1.Controls.Add(this.btnBold);
            this.panel1.Controls.Add(this.cBoxFontSize);
            this.panel1.Controls.Add(this.lblFontAlignment);
            this.panel1.Controls.Add(this.cBoxFontStyle);
            this.panel1.Controls.Add(this.lblFontStyle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFontSize);
            this.panel1.Controls.Add(this.lblFont);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 112);
            this.panel1.TabIndex = 0;
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.AutoSize = true;
            this.btnFontDialog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFontDialog.Location = new System.Drawing.Point(552, 59);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(107, 25);
            this.btnFontDialog.TabIndex = 4;
            this.btnFontDialog.Text = "Open Font Menu";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // btnRight
            // 
            this.btnRight.AutoSize = true;
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnRight.Location = new System.Drawing.Point(497, 58);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(32, 27);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "R";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnAlignment_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.AutoSize = true;
            this.btnCenter.Location = new System.Drawing.Point(459, 58);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(32, 27);
            this.btnCenter.TabIndex = 3;
            this.btnCenter.Text = "C";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnAlignment_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.AutoSize = true;
            this.btnItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnItalic.Location = new System.Drawing.Point(376, 58);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(32, 27);
            this.btnItalic.TabIndex = 3;
            this.btnItalic.Text = "I";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.AutoSize = true;
            this.btnLeft.Location = new System.Drawing.Point(421, 59);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(32, 27);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "L";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnAlignment_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.AutoSize = true;
            this.btnUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnUnderline.Location = new System.Drawing.Point(338, 58);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(32, 27);
            this.btnUnderline.TabIndex = 3;
            this.btnUnderline.Text = "U";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnBold
            // 
            this.btnBold.AutoSize = true;
            this.btnBold.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBold.Location = new System.Drawing.Point(300, 58);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(32, 27);
            this.btnBold.TabIndex = 3;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // cBoxFontSize
            // 
            this.cBoxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxFontSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxFontSize.FormattingEnabled = true;
            this.cBoxFontSize.Location = new System.Drawing.Point(163, 58);
            this.cBoxFontSize.Name = "cBoxFontSize";
            this.cBoxFontSize.Size = new System.Drawing.Size(121, 29);
            this.cBoxFontSize.TabIndex = 2;
            this.cBoxFontSize.SelectedIndexChanged += new System.EventHandler(this.cBoxFont_SelectedIndexChanged);
            // 
            // lblFontAlignment
            // 
            this.lblFontAlignment.AutoSize = true;
            this.lblFontAlignment.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFontAlignment.Location = new System.Drawing.Point(426, 19);
            this.lblFontAlignment.Name = "lblFontAlignment";
            this.lblFontAlignment.Size = new System.Drawing.Size(80, 20);
            this.lblFontAlignment.TabIndex = 1;
            this.lblFontAlignment.Text = "Alingment";
            // 
            // cBoxFontStyle
            // 
            this.cBoxFontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFontStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxFontStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxFontStyle.FormattingEnabled = true;
            this.cBoxFontStyle.Location = new System.Drawing.Point(15, 58);
            this.cBoxFontStyle.Name = "cBoxFontStyle";
            this.cBoxFontStyle.Size = new System.Drawing.Size(121, 29);
            this.cBoxFontStyle.TabIndex = 2;
            this.cBoxFontStyle.SelectedIndexChanged += new System.EventHandler(this.cBoxFont_SelectedIndexChanged);
            // 
            // lblFontStyle
            // 
            this.lblFontStyle.AutoSize = true;
            this.lblFontStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFontStyle.Location = new System.Drawing.Point(303, 19);
            this.lblFontStyle.Name = "lblFontStyle";
            this.lblFontStyle.Size = new System.Drawing.Size(77, 20);
            this.lblFontStyle.TabIndex = 1;
            this.lblFontStyle.Text = "Font Style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFontSize.Location = new System.Drawing.Point(163, 19);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(36, 20);
            this.lblFontSize.TabIndex = 1;
            this.lblFontSize.Text = "Size";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFont.Location = new System.Drawing.Point(15, 19);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(40, 20);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "Font";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOpenColorMenu);
            this.panel2.Controls.Add(this.lblFontColor);
            this.panel2.Controls.Add(this.cBoxColor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(686, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 112);
            this.panel2.TabIndex = 1;
            // 
            // btnOpenColorMenu
            // 
            this.btnOpenColorMenu.AutoSize = true;
            this.btnOpenColorMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenColorMenu.Location = new System.Drawing.Point(163, 62);
            this.btnOpenColorMenu.Name = "btnOpenColorMenu";
            this.btnOpenColorMenu.Size = new System.Drawing.Size(112, 25);
            this.btnOpenColorMenu.TabIndex = 4;
            this.btnOpenColorMenu.Text = "Open Color Menu";
            this.btnOpenColorMenu.UseVisualStyleBackColor = true;
            this.btnOpenColorMenu.Click += new System.EventHandler(this.btnOpenColorMenu_Click);
            // 
            // lblFontColor
            // 
            this.lblFontColor.AutoSize = true;
            this.lblFontColor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFontColor.Location = new System.Drawing.Point(15, 19);
            this.lblFontColor.Name = "lblFontColor";
            this.lblFontColor.Size = new System.Drawing.Size(46, 20);
            this.lblFontColor.TabIndex = 1;
            this.lblFontColor.Text = "Color";
            // 
            // cBoxColor
            // 
            this.cBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxColor.FormattingEnabled = true;
            this.cBoxColor.Location = new System.Drawing.Point(15, 58);
            this.cBoxColor.Name = "cBoxColor";
            this.cBoxColor.Size = new System.Drawing.Size(121, 29);
            this.cBoxColor.TabIndex = 2;
            this.cBoxColor.SelectedIndexChanged += new System.EventHandler(this.cBoxColor_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveFile);
            this.panel3.Controls.Add(this.btnSaveMenu);
            this.panel3.Controls.Add(this.btnLoadMenu);
            this.panel3.Controls.Add(this.btnLoadFile);
            this.panel3.Controls.Add(this.txtFileSave);
            this.panel3.Controls.Add(this.txtFileLoad);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(964, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 112);
            this.panel3.TabIndex = 2;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.AutoSize = true;
            this.btnSaveFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveFile.Location = new System.Drawing.Point(209, 60);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(107, 25);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Save";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnSaveMenu
            // 
            this.btnSaveMenu.AutoSize = true;
            this.btnSaveMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveMenu.Location = new System.Drawing.Point(322, 61);
            this.btnSaveMenu.Name = "btnSaveMenu";
            this.btnSaveMenu.Size = new System.Drawing.Size(107, 25);
            this.btnSaveMenu.TabIndex = 4;
            this.btnSaveMenu.Text = "Save Menu";
            this.btnSaveMenu.UseVisualStyleBackColor = true;
            this.btnSaveMenu.Click += new System.EventHandler(this.btnSaveMenu_Click);
            // 
            // btnLoadMenu
            // 
            this.btnLoadMenu.AutoSize = true;
            this.btnLoadMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadMenu.Location = new System.Drawing.Point(322, 18);
            this.btnLoadMenu.Name = "btnLoadMenu";
            this.btnLoadMenu.Size = new System.Drawing.Size(107, 25);
            this.btnLoadMenu.TabIndex = 4;
            this.btnLoadMenu.Text = "Load menu";
            this.btnLoadMenu.UseVisualStyleBackColor = true;
            this.btnLoadMenu.Click += new System.EventHandler(this.btnLoadMenu_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.AutoSize = true;
            this.btnLoadFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadFile.Location = new System.Drawing.Point(209, 18);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(107, 25);
            this.btnLoadFile.TabIndex = 4;
            this.btnLoadFile.Text = "Load";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // txtFileSave
            // 
            this.txtFileSave.Location = new System.Drawing.Point(20, 63);
            this.txtFileSave.Name = "txtFileSave";
            this.txtFileSave.PlaceholderText = "Save File Name";
            this.txtFileSave.Size = new System.Drawing.Size(168, 23);
            this.txtFileSave.TabIndex = 0;
            // 
            // txtFileLoad
            // 
            this.txtFileLoad.Location = new System.Drawing.Point(20, 20);
            this.txtFileLoad.Name = "txtFileLoad";
            this.txtFileLoad.PlaceholderText = "Load File Path";
            this.txtFileLoad.Size = new System.Drawing.Size(168, 23);
            this.txtFileLoad.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(0, 112);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1404, 466);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lblFont;
        private FontDialog fontDialog1;
        private Button btnFontDialog;
        private Button btnRight;
        private Button btnCenter;
        private Button btnItalic;
        private Button btnLeft;
        private Button btnUnderline;
        private Button btnBold;
        private ComboBox cBoxFontSize;
        private Label lblFontAlignment;
        private ComboBox cBoxFontStyle;
        private Label lblFontStyle;
        private Label lblFontSize;
        private RichTextBox richTextBox1;
        private Label label1;
        private Panel panel2;
        private Label lblFontColor;
        private ComboBox cBoxColor;
        private Button btnOpenColorMenu;
        private ColorDialog colorDialog1;
        private Panel panel3;
        private Button btnSaveFile;
        private Button btnLoadFile;
        private TextBox txtFileSave;
        private TextBox txtFileLoad;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnSaveMenu;
        private Button btnLoadMenu;
    }
}