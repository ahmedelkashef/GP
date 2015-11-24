namespace PhotoEditor
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
            this.components = new System.ComponentModel.Container();
            this.panel_histogram = new System.Windows.Forms.Panel();
            this.tab_Histogram = new System.Windows.Forms.TabControl();
            this.Histogram = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.panel_history = new System.Windows.Forms.Panel();
            this.tabHistory = new System.Windows.Forms.TabControl();
            this.tab_history = new System.Windows.Forms.TabPage();
            this.panel_work = new System.Windows.Forms.Panel();
            this.ControlTab = new System.Windows.Forms.TabControl();
            this.SharpenGB = new System.Windows.Forms.GroupBox();
            this.Origin_y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Origin_X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_gamma = new System.Windows.Forms.GroupBox();
            this.numericUpDown_gamma = new System.Windows.Forms.NumericUpDown();
            this.trackBar_gamma = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_apply_gamma = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjactementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitplaneSlicingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add2ImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mATLABToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsharpHighboostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removalOfCoarseReflectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combinationOfEnhancementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalEdgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalFiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magnitudeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_histogram.SuspendLayout();
            this.tab_Histogram.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.panel_work.SuspendLayout();
            this.SharpenGB.SuspendLayout();
            this.groupBox_gamma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gamma)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_histogram
            // 
            this.panel_histogram.BackColor = System.Drawing.Color.Transparent;
            this.panel_histogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_histogram.Controls.Add(this.tab_Histogram);
            this.panel_histogram.Location = new System.Drawing.Point(1476, 35);
            this.panel_histogram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_histogram.Name = "panel_histogram";
            this.panel_histogram.Size = new System.Drawing.Size(432, 273);
            this.panel_histogram.TabIndex = 2;
            // 
            // tab_Histogram
            // 
            this.tab_Histogram.Controls.Add(this.Histogram);
            this.tab_Histogram.Location = new System.Drawing.Point(4, 9);
            this.tab_Histogram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_Histogram.Name = "tab_Histogram";
            this.tab_Histogram.SelectedIndex = 0;
            this.tab_Histogram.Size = new System.Drawing.Size(418, 246);
            this.tab_Histogram.TabIndex = 3;
            // 
            // Histogram
            // 
            this.Histogram.Location = new System.Drawing.Point(4, 29);
            this.Histogram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Histogram.Name = "Histogram";
            this.Histogram.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Histogram.Size = new System.Drawing.Size(410, 213);
            this.Histogram.TabIndex = 0;
            this.Histogram.Text = "Histogram";
            this.Histogram.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_value);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_apply);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(1476, 309);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(434, 280);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(22, 60);
            this.txt_value.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(148, 26);
            this.txt_value.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(306, 235);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(112, 35);
            this.btn_apply.TabIndex = 0;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            // 
            // panel_history
            // 
            this.panel_history.BackColor = System.Drawing.Color.Transparent;
            this.panel_history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_history.Location = new System.Drawing.Point(1476, 598);
            this.panel_history.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_history.Name = "panel_history";
            this.panel_history.Size = new System.Drawing.Size(432, 479);
            this.panel_history.TabIndex = 4;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.tab_history);
            this.tabHistory.Location = new System.Drawing.Point(1476, 604);
            this.tabHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.SelectedIndex = 0;
            this.tabHistory.Size = new System.Drawing.Size(434, 446);
            this.tabHistory.TabIndex = 5;
            // 
            // tab_history
            // 
            this.tab_history.Location = new System.Drawing.Point(4, 29);
            this.tab_history.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_history.Name = "tab_history";
            this.tab_history.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_history.Size = new System.Drawing.Size(426, 413);
            this.tab_history.TabIndex = 0;
            this.tab_history.Text = "History";
            this.tab_history.UseVisualStyleBackColor = true;
            // 
            // panel_work
            // 
            this.panel_work.AutoScroll = true;
            this.panel_work.BackColor = System.Drawing.Color.Transparent;
            this.panel_work.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_work.Controls.Add(this.ControlTab);
            this.panel_work.Location = new System.Drawing.Point(0, 45);
            this.panel_work.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_work.Name = "panel_work";
            this.panel_work.Size = new System.Drawing.Size(1468, 1041);
            this.panel_work.TabIndex = 6;
            // 
            // ControlTab
            // 
            this.ControlTab.AllowDrop = true;
            this.ControlTab.Location = new System.Drawing.Point(9, 14);
            this.ControlTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ControlTab.Name = "ControlTab";
            this.ControlTab.SelectedIndex = 0;
            this.ControlTab.Size = new System.Drawing.Size(1462, 1011);
            this.ControlTab.TabIndex = 0;
            this.ControlTab.Visible = false;
            this.ControlTab.SelectedIndexChanged += new System.EventHandler(this.Control_Tab_SelectedIndexChanged);
            // 
            // SharpenGB
            // 
            this.SharpenGB.BackColor = System.Drawing.Color.Transparent;
            this.SharpenGB.Controls.Add(this.Origin_y);
            this.SharpenGB.Controls.Add(this.label3);
            this.SharpenGB.Controls.Add(this.Origin_X);
            this.SharpenGB.Controls.Add(this.label2);
            this.SharpenGB.Controls.Add(this.button1);
            this.SharpenGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SharpenGB.Location = new System.Drawing.Point(1478, 301);
            this.SharpenGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SharpenGB.Name = "SharpenGB";
            this.SharpenGB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SharpenGB.Size = new System.Drawing.Size(434, 293);
            this.SharpenGB.TabIndex = 4;
            this.SharpenGB.TabStop = false;
            this.SharpenGB.Text = "SharpenGB";
            this.SharpenGB.Visible = false;
            this.SharpenGB.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Origin_y
            // 
            this.Origin_y.Location = new System.Drawing.Point(22, 120);
            this.Origin_y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Origin_y.Name = "Origin_y";
            this.Origin_y.Size = new System.Drawing.Size(148, 26);
            this.Origin_y.TabIndex = 1;
            this.Origin_y.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // Origin_X
            // 
            this.Origin_X.Location = new System.Drawing.Point(22, 60);
            this.Origin_X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Origin_X.Name = "Origin_X";
            this.Origin_X.Size = new System.Drawing.Size(148, 26);
            this.Origin_X.TabIndex = 0;
            this.Origin_X.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            // 
            // groupBox_gamma
            // 
            this.groupBox_gamma.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_gamma.Controls.Add(this.numericUpDown_gamma);
            this.groupBox_gamma.Controls.Add(this.trackBar_gamma);
            this.groupBox_gamma.Controls.Add(this.label5);
            this.groupBox_gamma.Controls.Add(this.btn_apply_gamma);
            this.groupBox_gamma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_gamma.Location = new System.Drawing.Point(1478, 297);
            this.groupBox_gamma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_gamma.Name = "groupBox_gamma";
            this.groupBox_gamma.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_gamma.Size = new System.Drawing.Size(434, 297);
            this.groupBox_gamma.TabIndex = 5;
            this.groupBox_gamma.TabStop = false;
            this.groupBox_gamma.Text = "$$";
            this.groupBox_gamma.Visible = false;
            // 
            // numericUpDown_gamma
            // 
            this.numericUpDown_gamma.Location = new System.Drawing.Point(356, 49);
            this.numericUpDown_gamma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_gamma.Name = "numericUpDown_gamma";
            this.numericUpDown_gamma.Size = new System.Drawing.Size(69, 26);
            this.numericUpDown_gamma.TabIndex = 3;
            // 
            // trackBar_gamma
            // 
            this.trackBar_gamma.Location = new System.Drawing.Point(22, 49);
            this.trackBar_gamma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_gamma.Name = "trackBar_gamma";
            this.trackBar_gamma.Size = new System.Drawing.Size(324, 69);
            this.trackBar_gamma.TabIndex = 2;
            this.trackBar_gamma.Scroll += new System.EventHandler(this.trackBar_gamma_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gamma value";
            // 
            // btn_apply_gamma
            // 
            this.btn_apply_gamma.Location = new System.Drawing.Point(306, 235);
            this.btn_apply_gamma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_apply_gamma.Name = "btn_apply_gamma";
            this.btn_apply_gamma.Size = new System.Drawing.Size(112, 35);
            this.btn_apply_gamma.TabIndex = 0;
            this.btn_apply_gamma.Text = "Apply";
            this.btn_apply_gamma.UseVisualStyleBackColor = true;
            this.btn_apply_gamma.Click += new System.EventHandler(this.btn_apply_gamma_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 34);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(127, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.BackgroundImage = global::PhotoEditor.Properties.Resources.Untitled_1___Copy;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.mATLABToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1912, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.fileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::PhotoEditor.Properties.Resources.Open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::PhotoEditor.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::PhotoEditor.Properties.Resources.Close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::PhotoEditor.Properties.Resources.Undo;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::PhotoEditor.Properties.Resources.Redo;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adjactementsToolStripMenuItem,
            this.bitplaneSlicingToolStripMenuItem,
            this.quantizationToolStripMenuItem,
            this.add2ImagesToolStripMenuItem,
            this.resizeToolStripMenuItem});
            this.imageToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // adjactementsToolStripMenuItem
            // 
            this.adjactementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightnessContrastToolStripMenuItem,
            this.gammaToolStripMenuItem,
            this.greyToolStripMenuItem,
            this.notToolStripMenuItem});
            this.adjactementsToolStripMenuItem.Name = "adjactementsToolStripMenuItem";
            this.adjactementsToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.adjactementsToolStripMenuItem.Text = "Adjactements";
            this.adjactementsToolStripMenuItem.Click += new System.EventHandler(this.adjactementsToolStripMenuItem_Click);
            // 
            // brightnessContrastToolStripMenuItem
            // 
            this.brightnessContrastToolStripMenuItem.Image = global::PhotoEditor.Properties.Resources.Image1;
            this.brightnessContrastToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brightnessContrastToolStripMenuItem.Name = "brightnessContrastToolStripMenuItem";
            this.brightnessContrastToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.brightnessContrastToolStripMenuItem.Text = "Brightness/Contrast";
            this.brightnessContrastToolStripMenuItem.Click += new System.EventHandler(this.brightnessContrastToolStripMenuItem_Click);
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.Image = global::PhotoEditor.Properties.Resources.gamma;
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.gammaToolStripMenuItem.Text = "Gamma";
            this.gammaToolStripMenuItem.Click += new System.EventHandler(this.gammaToolStripMenuItem_Click);
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.Image = global::PhotoEditor.Properties.Resources.grey;
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.greyToolStripMenuItem.Text = "Grey";
            // 
            // notToolStripMenuItem
            // 
            this.notToolStripMenuItem.Image = global::PhotoEditor.Properties.Resources.not;
            this.notToolStripMenuItem.Name = "notToolStripMenuItem";
            this.notToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.notToolStripMenuItem.Text = "Not";
            // 
            // bitplaneSlicingToolStripMenuItem
            // 
            this.bitplaneSlicingToolStripMenuItem.Name = "bitplaneSlicingToolStripMenuItem";
            this.bitplaneSlicingToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.bitplaneSlicingToolStripMenuItem.Text = "Bit-plane slicing";
            // 
            // quantizationToolStripMenuItem
            // 
            this.quantizationToolStripMenuItem.Name = "quantizationToolStripMenuItem";
            this.quantizationToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.quantizationToolStripMenuItem.Text = "Quantization";
            this.quantizationToolStripMenuItem.Click += new System.EventHandler(this.quantizationToolStripMenuItem_Click);
            // 
            // add2ImagesToolStripMenuItem
            // 
            this.add2ImagesToolStripMenuItem.Name = "add2ImagesToolStripMenuItem";
            this.add2ImagesToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.add2ImagesToolStripMenuItem.Text = "Algebric Operations";
            this.add2ImagesToolStripMenuItem.Click += new System.EventHandler(this.add2ImagesToolStripMenuItem_Click);
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rToolStripMenuItem,
            this.scaleToolStripMenuItem,
            this.shearToolStripMenuItem});
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.resizeToolStripMenuItem.Text = "Transformation";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.rToolStripMenuItem.Text = "Rotate";
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rToolStripMenuItem_Click);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.scaleToolStripMenuItem.Text = "Scale";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
            // 
            // shearToolStripMenuItem
            // 
            this.shearToolStripMenuItem.Name = "shearToolStripMenuItem";
            this.shearToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.shearToolStripMenuItem.Text = "Shear";
            this.shearToolStripMenuItem.Click += new System.EventHandler(this.shearToolStripMenuItem_Click);
            // 
            // mATLABToolStripMenuItem
            // 
            this.mATLABToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unsharpHighboostToolStripMenuItem,
            this.removalOfCoarseReflectionToolStripMenuItem,
            this.combinationOfEnhancementsToolStripMenuItem});
            this.mATLABToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.mATLABToolStripMenuItem.Name = "mATLABToolStripMenuItem";
            this.mATLABToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.mATLABToolStripMenuItem.Text = "MATLAB";
            // 
            // unsharpHighboostToolStripMenuItem
            // 
            this.unsharpHighboostToolStripMenuItem.Name = "unsharpHighboostToolStripMenuItem";
            this.unsharpHighboostToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.unsharpHighboostToolStripMenuItem.Text = "Unsharp & Highboost  ";
            // 
            // removalOfCoarseReflectionToolStripMenuItem
            // 
            this.removalOfCoarseReflectionToolStripMenuItem.Name = "removalOfCoarseReflectionToolStripMenuItem";
            this.removalOfCoarseReflectionToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.removalOfCoarseReflectionToolStripMenuItem.Text = "Removal of Coarse Reflection";
            // 
            // combinationOfEnhancementsToolStripMenuItem
            // 
            this.combinationOfEnhancementsToolStripMenuItem.Name = "combinationOfEnhancementsToolStripMenuItem";
            this.combinationOfEnhancementsToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.combinationOfEnhancementsToolStripMenuItem.Text = "Combination of Enhancements ";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.sharpeningToolStripMenuItem,
            this.edgeToolStripMenuItem,
            this.motionToolStripMenuItem});
            this.filterToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meanToolStripMenuItem,
            this.gaussianToolStripMenuItem});
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.blurToolStripMenuItem.Text = "Blur";
            // 
            // meanToolStripMenuItem
            // 
            this.meanToolStripMenuItem.Name = "meanToolStripMenuItem";
            this.meanToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.meanToolStripMenuItem.Text = "Mean ";
            this.meanToolStripMenuItem.Click += new System.EventHandler(this.meanToolStripMenuItem_Click);
            // 
            // gaussianToolStripMenuItem
            // 
            this.gaussianToolStripMenuItem.Name = "gaussianToolStripMenuItem";
            this.gaussianToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.gaussianToolStripMenuItem.Text = "Gaussian ";
            this.gaussianToolStripMenuItem.Click += new System.EventHandler(this.gaussianToolStripMenuItem_Click);
            // 
            // sharpeningToolStripMenuItem
            // 
            this.sharpeningToolStripMenuItem.Name = "sharpeningToolStripMenuItem";
            this.sharpeningToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.sharpeningToolStripMenuItem.Text = "Laplacian Sharpen";
            this.sharpeningToolStripMenuItem.Click += new System.EventHandler(this.sharpeningToolStripMenuItem_Click);
            // 
            // edgeToolStripMenuItem
            // 
            this.edgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalEdgeToolStripMenuItem,
            this.verticalFiterToolStripMenuItem,
            this.magnitudeFilterToolStripMenuItem});
            this.edgeToolStripMenuItem.Name = "edgeToolStripMenuItem";
            this.edgeToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.edgeToolStripMenuItem.Text = "Edge Detection";
            // 
            // horizontalEdgeToolStripMenuItem
            // 
            this.horizontalEdgeToolStripMenuItem.Name = "horizontalEdgeToolStripMenuItem";
            this.horizontalEdgeToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.horizontalEdgeToolStripMenuItem.Text = "Horizontal Filter ";
            this.horizontalEdgeToolStripMenuItem.Click += new System.EventHandler(this.horizontalEdgeToolStripMenuItem_Click);
            // 
            // verticalFiterToolStripMenuItem
            // 
            this.verticalFiterToolStripMenuItem.Name = "verticalFiterToolStripMenuItem";
            this.verticalFiterToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.verticalFiterToolStripMenuItem.Text = "Vertical Fiter";
            this.verticalFiterToolStripMenuItem.Click += new System.EventHandler(this.verticalFiterToolStripMenuItem_Click);
            // 
            // magnitudeFilterToolStripMenuItem
            // 
            this.magnitudeFilterToolStripMenuItem.Name = "magnitudeFilterToolStripMenuItem";
            this.magnitudeFilterToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.magnitudeFilterToolStripMenuItem.Text = " Magnitude Filter";
            this.magnitudeFilterToolStripMenuItem.Click += new System.EventHandler(this.magnitudeFilterToolStripMenuItem_Click);
            // 
            // motionToolStripMenuItem
            // 
            this.motionToolStripMenuItem.Name = "motionToolStripMenuItem";
            this.motionToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.motionToolStripMenuItem.Text = "Motion";
            this.motionToolStripMenuItem.Click += new System.EventHandler(this.motionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1912, 1025);
            this.Controls.Add(this.groupBox_gamma);
            this.Controls.Add(this.SharpenGB);
            this.Controls.Add(this.panel_work);
            this.Controls.Add(this.tabHistory);
            this.Controls.Add(this.panel_history);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_histogram);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_histogram.ResumeLayout(false);
            this.tab_Histogram.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabHistory.ResumeLayout(false);
            this.panel_work.ResumeLayout(false);
            this.SharpenGB.ResumeLayout(false);
            this.SharpenGB.PerformLayout();
            this.groupBox_gamma.ResumeLayout(false);
            this.groupBox_gamma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_gamma)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjactementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitplaneSlicingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add2ImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mATLABToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsharpHighboostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removalOfCoarseReflectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combinationOfEnhancementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalEdgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalFiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magnitudeFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel_histogram;
        private System.Windows.Forms.TabControl tab_Histogram;
        private System.Windows.Forms.TabPage Histogram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_history;
        private System.Windows.Forms.TabControl tabHistory;
        private System.Windows.Forms.TabPage tab_history;
        private System.Windows.Forms.Panel panel_work;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.TabControl ControlTab;
        private System.Windows.Forms.GroupBox SharpenGB;
        private System.Windows.Forms.TextBox Origin_y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Origin_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox_gamma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_apply_gamma;
        private System.Windows.Forms.NumericUpDown numericUpDown_gamma;
        private System.Windows.Forms.TrackBar trackBar_gamma;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionToolStripMenuItem;



    }
}

