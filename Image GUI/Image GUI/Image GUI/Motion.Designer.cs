namespace PhotoEditor
{
    partial class Motion
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.radioButton_Option_2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Option_1 = new System.Windows.Forms.RadioButton();
            this.groupBox_options = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Orign_x = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.txt_mask_size_y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mask_size_x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_mask = new System.Windows.Forms.GroupBox();
            this.groupBox_Modified = new System.Windows.Forms.GroupBox();
            this.groupBox_original = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pic_modified = new System.Windows.Forms.PictureBox();
            this.pic_original = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_options.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_mask.SuspendLayout();
            this.groupBox_Modified.SuspendLayout();
            this.groupBox_original.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_modified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Location = new System.Drawing.Point(520, 256);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(59, 23);
            this.btn_ok.TabIndex = 28;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // radioButton_Option_2
            // 
            this.radioButton_Option_2.AutoSize = true;
            this.radioButton_Option_2.Location = new System.Drawing.Point(17, 42);
            this.radioButton_Option_2.Name = "radioButton_Option_2";
            this.radioButton_Option_2.Size = new System.Drawing.Size(85, 17);
            this.radioButton_Option_2.TabIndex = 1;
            this.radioButton_Option_2.TabStop = true;
            this.radioButton_Option_2.Text = "Right to Left";
            this.radioButton_Option_2.UseVisualStyleBackColor = true;
            // 
            // radioButton_Option_1
            // 
            this.radioButton_Option_1.AutoSize = true;
            this.radioButton_Option_1.Location = new System.Drawing.Point(17, 19);
            this.radioButton_Option_1.Name = "radioButton_Option_1";
            this.radioButton_Option_1.Size = new System.Drawing.Size(85, 17);
            this.radioButton_Option_1.TabIndex = 0;
            this.radioButton_Option_1.TabStop = true;
            this.radioButton_Option_1.Text = "Left to Right";
            this.radioButton_Option_1.UseVisualStyleBackColor = true;
            // 
            // groupBox_options
            // 
            this.groupBox_options.Controls.Add(this.radioButton1);
            this.groupBox_options.Controls.Add(this.radioButton_Option_2);
            this.groupBox_options.Controls.Add(this.radioButton_Option_1);
            this.groupBox_options.Location = new System.Drawing.Point(303, 252);
            this.groupBox_options.Name = "groupBox_options";
            this.groupBox_options.Size = new System.Drawing.Size(211, 85);
            this.groupBox_options.TabIndex = 26;
            this.groupBox_options.TabStop = false;
            this.groupBox_options.Text = "Options";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Orign y";
            // 
            // txt_Orign_x
            // 
            this.txt_Orign_x.Location = new System.Drawing.Point(55, 28);
            this.txt_Orign_x.Name = "txt_Orign_x";
            this.txt_Orign_x.Size = new System.Drawing.Size(52, 20);
            this.txt_Orign_x.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Orign x";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Orign_x);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(171, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 85);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Orign";
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(520, 314);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(59, 23);
            this.btn_cancel.TabIndex = 25;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_apply
            // 
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.Location = new System.Drawing.Point(520, 285);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(59, 23);
            this.btn_apply.TabIndex = 24;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            // 
            // txt_mask_size_y
            // 
            this.txt_mask_size_y.Location = new System.Drawing.Point(47, 54);
            this.txt_mask_size_y.Name = "txt_mask_size_y";
            this.txt_mask_size_y.Size = new System.Drawing.Size(52, 20);
            this.txt_mask_size_y.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hight";
            // 
            // txt_mask_size_x
            // 
            this.txt_mask_size_x.Location = new System.Drawing.Point(47, 28);
            this.txt_mask_size_x.Name = "txt_mask_size_x";
            this.txt_mask_size_x.Size = new System.Drawing.Size(52, 20);
            this.txt_mask_size_x.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox_mask
            // 
            this.groupBox_mask.Controls.Add(this.txt_mask_size_y);
            this.groupBox_mask.Controls.Add(this.label2);
            this.groupBox_mask.Controls.Add(this.txt_mask_size_x);
            this.groupBox_mask.Controls.Add(this.label1);
            this.groupBox_mask.Location = new System.Drawing.Point(17, 252);
            this.groupBox_mask.Name = "groupBox_mask";
            this.groupBox_mask.Size = new System.Drawing.Size(116, 85);
            this.groupBox_mask.TabIndex = 22;
            this.groupBox_mask.TabStop = false;
            this.groupBox_mask.Text = "Mask Size";
            // 
            // groupBox_Modified
            // 
            this.groupBox_Modified.Controls.Add(this.pic_modified);
            this.groupBox_Modified.Location = new System.Drawing.Point(303, 15);
            this.groupBox_Modified.Name = "groupBox_Modified";
            this.groupBox_Modified.Size = new System.Drawing.Size(282, 222);
            this.groupBox_Modified.TabIndex = 21;
            this.groupBox_Modified.TabStop = false;
            this.groupBox_Modified.Text = "Modified";
            // 
            // groupBox_original
            // 
            this.groupBox_original.Controls.Add(this.pic_original);
            this.groupBox_original.Location = new System.Drawing.Point(11, 15);
            this.groupBox_original.Name = "groupBox_original";
            this.groupBox_original.Size = new System.Drawing.Size(282, 222);
            this.groupBox_original.TabIndex = 20;
            this.groupBox_original.TabStop = false;
            this.groupBox_original.Text = "Original";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Both";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pic_modified
            // 
            this.pic_modified.Location = new System.Drawing.Point(6, 19);
            this.pic_modified.Name = "pic_modified";
            this.pic_modified.Size = new System.Drawing.Size(270, 197);
            this.pic_modified.TabIndex = 0;
            this.pic_modified.TabStop = false;
            // 
            // pic_original
            // 
            this.pic_original.Location = new System.Drawing.Point(6, 19);
            this.pic_original.Name = "pic_original";
            this.pic_original.Size = new System.Drawing.Size(270, 197);
            this.pic_original.TabIndex = 0;
            this.pic_original.TabStop = false;
            // 
            // Motion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 353);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox_options);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox_mask);
            this.Controls.Add(this.groupBox_Modified);
            this.Controls.Add(this.groupBox_original);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Motion";
            this.Text = "Motion";
            this.groupBox_options.ResumeLayout(false);
            this.groupBox_options.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_mask.ResumeLayout(false);
            this.groupBox_mask.PerformLayout();
            this.groupBox_Modified.ResumeLayout(false);
            this.groupBox_original.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_modified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.RadioButton radioButton_Option_2;
        private System.Windows.Forms.RadioButton radioButton_Option_1;
        private System.Windows.Forms.GroupBox groupBox_options;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Orign_x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.TextBox txt_mask_size_y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mask_size_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_mask;
        private System.Windows.Forms.PictureBox pic_modified;
        private System.Windows.Forms.GroupBox groupBox_Modified;
        private System.Windows.Forms.PictureBox pic_original;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox_original;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}