namespace PhotoEditor
{
    partial class Filters
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
            this.groupBox_original = new System.Windows.Forms.GroupBox();
            this.pic_original = new System.Windows.Forms.PictureBox();
            this.groupBox_Modified = new System.Windows.Forms.GroupBox();
            this.pic_modified = new System.Windows.Forms.PictureBox();
            this.groupBox_mask = new System.Windows.Forms.GroupBox();
            this.MaskHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaskWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sigma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OriginY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrignX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_options = new System.Windows.Forms.GroupBox();
            this.comboBox_D_type = new System.Windows.Forms.ComboBox();
            this.radioButton_Option_2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Option_1 = new System.Windows.Forms.RadioButton();
            this.groupBox_sigma = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox_original.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_original)).BeginInit();
            this.groupBox_Modified.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_modified)).BeginInit();
            this.groupBox_mask.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_options.SuspendLayout();
            this.groupBox_sigma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_original
            // 
            this.groupBox_original.Controls.Add(this.pic_original);
            this.groupBox_original.Location = new System.Drawing.Point(18, 18);
            this.groupBox_original.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_original.Name = "groupBox_original";
            this.groupBox_original.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_original.Size = new System.Drawing.Size(423, 342);
            this.groupBox_original.TabIndex = 9;
            this.groupBox_original.TabStop = false;
            this.groupBox_original.Text = "Original";
            // 
            // pic_original
            // 
            this.pic_original.Location = new System.Drawing.Point(9, 29);
            this.pic_original.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_original.Name = "pic_original";
            this.pic_original.Size = new System.Drawing.Size(405, 303);
            this.pic_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_original.TabIndex = 0;
            this.pic_original.TabStop = false;
            // 
            // groupBox_Modified
            // 
            this.groupBox_Modified.Controls.Add(this.pic_modified);
            this.groupBox_Modified.Location = new System.Drawing.Point(456, 18);
            this.groupBox_Modified.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Modified.Name = "groupBox_Modified";
            this.groupBox_Modified.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Modified.Size = new System.Drawing.Size(423, 342);
            this.groupBox_Modified.TabIndex = 10;
            this.groupBox_Modified.TabStop = false;
            this.groupBox_Modified.Text = "Modified";
            // 
            // pic_modified
            // 
            this.pic_modified.Location = new System.Drawing.Point(9, 29);
            this.pic_modified.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_modified.Name = "pic_modified";
            this.pic_modified.Size = new System.Drawing.Size(405, 303);
            this.pic_modified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_modified.TabIndex = 0;
            this.pic_modified.TabStop = false;
            // 
            // groupBox_mask
            // 
            this.groupBox_mask.Controls.Add(this.MaskHeight);
            this.groupBox_mask.Controls.Add(this.label2);
            this.groupBox_mask.Controls.Add(this.MaskWidth);
            this.groupBox_mask.Controls.Add(this.label1);
            this.groupBox_mask.Location = new System.Drawing.Point(27, 383);
            this.groupBox_mask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_mask.Name = "groupBox_mask";
            this.groupBox_mask.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_mask.Size = new System.Drawing.Size(174, 131);
            this.groupBox_mask.TabIndex = 11;
            this.groupBox_mask.TabStop = false;
            this.groupBox_mask.Text = "Mask Size";
            // 
            // MaskHeight
            // 
            this.MaskHeight.Location = new System.Drawing.Point(70, 83);
            this.MaskHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaskHeight.Name = "MaskHeight";
            this.MaskHeight.Size = new System.Drawing.Size(76, 26);
            this.MaskHeight.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height";
            // 
            // MaskWidth
            // 
            this.MaskWidth.Location = new System.Drawing.Point(70, 43);
            this.MaskWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaskWidth.Name = "MaskWidth";
            this.MaskWidth.Size = new System.Drawing.Size(76, 26);
            this.MaskWidth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Sigma
            // 
            this.Sigma.Location = new System.Drawing.Point(9, 83);
            this.Sigma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sigma.Name = "Sigma";
            this.Sigma.Size = new System.Drawing.Size(97, 26);
            this.Sigma.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sigma value";
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(782, 481);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 35);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.Location = new System.Drawing.Point(782, 441);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(88, 35);
            this.btn_apply.TabIndex = 15;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OriginY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.OrignX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(258, 383);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(174, 131);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Orign";
            // 
            // OriginY
            // 
            this.OriginY.Location = new System.Drawing.Point(82, 83);
            this.OriginY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OriginY.Name = "OriginY";
            this.OriginY.Size = new System.Drawing.Size(76, 26);
            this.OriginY.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Orign Y";
            // 
            // OrignX
            // 
            this.OrignX.Location = new System.Drawing.Point(82, 43);
            this.OrignX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrignX.Name = "OrignX";
            this.OrignX.Size = new System.Drawing.Size(76, 26);
            this.OrignX.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Orign X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox_options
            // 
            this.groupBox_options.Controls.Add(this.comboBox_D_type);
            this.groupBox_options.Controls.Add(this.radioButton_Option_2);
            this.groupBox_options.Controls.Add(this.radioButton_Option_1);
            this.groupBox_options.Location = new System.Drawing.Point(456, 385);
            this.groupBox_options.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_options.Name = "groupBox_options";
            this.groupBox_options.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_options.Size = new System.Drawing.Size(152, 129);
            this.groupBox_options.TabIndex = 17;
            this.groupBox_options.TabStop = false;
            this.groupBox_options.Text = "Options";
            // 
            // comboBox_D_type
            // 
            this.comboBox_D_type.FormattingEnabled = true;
            this.comboBox_D_type.Items.AddRange(new object[] {
            "1D",
            "2D"});
            this.comboBox_D_type.Location = new System.Drawing.Point(26, 22);
            this.comboBox_D_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_D_type.Name = "comboBox_D_type";
            this.comboBox_D_type.Size = new System.Drawing.Size(97, 28);
            this.comboBox_D_type.TabIndex = 1;
            // 
            // radioButton_Option_2
            // 
            this.radioButton_Option_2.AutoSize = true;
            this.radioButton_Option_2.Location = new System.Drawing.Point(26, 94);
            this.radioButton_Option_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_Option_2.Name = "radioButton_Option_2";
            this.radioButton_Option_2.Size = new System.Drawing.Size(94, 24);
            this.radioButton_Option_2.TabIndex = 1;
            this.radioButton_Option_2.TabStop = true;
            this.radioButton_Option_2.Text = "Option 2";
            this.radioButton_Option_2.UseVisualStyleBackColor = true;
            this.radioButton_Option_2.CheckedChanged += new System.EventHandler(this.radioButton_Option_2_CheckedChanged);
            // 
            // radioButton_Option_1
            // 
            this.radioButton_Option_1.AutoSize = true;
            this.radioButton_Option_1.Location = new System.Drawing.Point(26, 58);
            this.radioButton_Option_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_Option_1.Name = "radioButton_Option_1";
            this.radioButton_Option_1.Size = new System.Drawing.Size(94, 24);
            this.radioButton_Option_1.TabIndex = 0;
            this.radioButton_Option_1.TabStop = true;
            this.radioButton_Option_1.Text = "Option 1";
            this.radioButton_Option_1.UseVisualStyleBackColor = true;
            this.radioButton_Option_1.CheckedChanged += new System.EventHandler(this.radioButton_Option_1_CheckedChanged);
            // 
            // groupBox_sigma
            // 
            this.groupBox_sigma.Controls.Add(this.label5);
            this.groupBox_sigma.Controls.Add(this.Sigma);
            this.groupBox_sigma.Location = new System.Drawing.Point(616, 383);
            this.groupBox_sigma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_sigma.Name = "groupBox_sigma";
            this.groupBox_sigma.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_sigma.Size = new System.Drawing.Size(140, 131);
            this.groupBox_sigma.TabIndex = 18;
            this.groupBox_sigma.TabStop = false;
            this.groupBox_sigma.Text = "Sigma";
            // 
            // btn_ok
            // 
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Location = new System.Drawing.Point(782, 400);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(88, 35);
            this.btn_ok.TabIndex = 19;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Filters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 543);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox_sigma);
            this.Controls.Add(this.groupBox_options);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox_mask);
            this.Controls.Add(this.groupBox_original);
            this.Controls.Add(this.groupBox_Modified);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Filters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filters";
            this.Load += new System.EventHandler(this.Filters_Load);
            this.groupBox_original.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_original)).EndInit();
            this.groupBox_Modified.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_modified)).EndInit();
            this.groupBox_mask.ResumeLayout(false);
            this.groupBox_mask.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_options.ResumeLayout(false);
            this.groupBox_options.PerformLayout();
            this.groupBox_sigma.ResumeLayout(false);
            this.groupBox_sigma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_original;
        private System.Windows.Forms.PictureBox pic_original;
        private System.Windows.Forms.GroupBox groupBox_Modified;
        private System.Windows.Forms.PictureBox pic_modified;
        private System.Windows.Forms.GroupBox groupBox_mask;
        private System.Windows.Forms.TextBox MaskHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaskWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Sigma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OriginY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrignX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_options;
        private System.Windows.Forms.RadioButton radioButton_Option_2;
        private System.Windows.Forms.RadioButton radioButton_Option_1;
        private System.Windows.Forms.GroupBox groupBox_sigma;
        private System.Windows.Forms.ComboBox comboBox_D_type;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_ok;
    }
}