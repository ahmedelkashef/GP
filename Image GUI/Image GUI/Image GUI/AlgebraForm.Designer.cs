namespace PhotoEditor
{
    partial class AlgebraForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.groupBox_Operations = new System.Windows.Forms.GroupBox();
            this.groupBox_img2 = new System.Windows.Forms.GroupBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txt_path2 = new System.Windows.Forms.TextBox();
            this.groupBox_img1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_path1 = new System.Windows.Forms.TextBox();
            this.groupBox_output = new System.Windows.Forms.GroupBox();
            this.txt_fraction = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_output = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_operations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox_Operations.SuspendLayout();
            this.groupBox_img2.SuspendLayout();
            this.groupBox_img1.SuspendLayout();
            this.groupBox_output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fraction";
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(609, 421);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(75, 23);
            this.btn_Apply.TabIndex = 13;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            // 
            // groupBox_Operations
            // 
            this.groupBox_Operations.Controls.Add(this.label1);
            this.groupBox_Operations.Controls.Add(this.comboBox_operations);
            this.groupBox_Operations.Controls.Add(this.txt_fraction);
            this.groupBox_Operations.Controls.Add(this.label2);
            this.groupBox_Operations.Location = new System.Drawing.Point(295, 354);
            this.groupBox_Operations.Name = "groupBox_Operations";
            this.groupBox_Operations.Size = new System.Drawing.Size(389, 44);
            this.groupBox_Operations.TabIndex = 13;
            this.groupBox_Operations.TabStop = false;
            this.groupBox_Operations.Text = "Operations";
            // 
            // groupBox_img2
            // 
            this.groupBox_img2.Controls.Add(this.pictureBox2);
            this.groupBox_img2.Controls.Add(this.btn_browse);
            this.groupBox_img2.Controls.Add(this.txt_path2);
            this.groupBox_img2.Location = new System.Drawing.Point(24, 228);
            this.groupBox_img2.Name = "groupBox_img2";
            this.groupBox_img2.Size = new System.Drawing.Size(238, 216);
            this.groupBox_img2.TabIndex = 10;
            this.groupBox_img2.TabStop = false;
            this.groupBox_img2.Text = "Image 2";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(17, 19);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 3;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            // 
            // txt_path2
            // 
            this.txt_path2.Location = new System.Drawing.Point(98, 19);
            this.txt_path2.Name = "txt_path2";
            this.txt_path2.Size = new System.Drawing.Size(127, 20);
            this.txt_path2.TabIndex = 4;
            // 
            // groupBox_img1
            // 
            this.groupBox_img1.Controls.Add(this.button1);
            this.groupBox_img1.Controls.Add(this.pictureBox1);
            this.groupBox_img1.Controls.Add(this.txt_path1);
            this.groupBox_img1.Location = new System.Drawing.Point(24, 10);
            this.groupBox_img1.Name = "groupBox_img1";
            this.groupBox_img1.Size = new System.Drawing.Size(238, 216);
            this.groupBox_img1.TabIndex = 12;
            this.groupBox_img1.TabStop = false;
            this.groupBox_img1.Text = "Image 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_path1
            // 
            this.txt_path1.Location = new System.Drawing.Point(87, 22);
            this.txt_path1.Name = "txt_path1";
            this.txt_path1.Size = new System.Drawing.Size(126, 20);
            this.txt_path1.TabIndex = 6;
            // 
            // groupBox_output
            // 
            this.groupBox_output.Controls.Add(this.pictureBox_output);
            this.groupBox_output.Location = new System.Drawing.Point(295, 10);
            this.groupBox_output.Name = "groupBox_output";
            this.groupBox_output.Size = new System.Drawing.Size(389, 338);
            this.groupBox_output.TabIndex = 15;
            this.groupBox_output.TabStop = false;
            this.groupBox_output.Text = "Output";
            // 
            // txt_fraction
            // 
            this.txt_fraction.DecimalPlaces = 2;
            this.txt_fraction.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txt_fraction.Location = new System.Drawing.Point(287, 14);
            this.txt_fraction.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_fraction.Name = "txt_fraction";
            this.txt_fraction.Size = new System.Drawing.Size(43, 20);
            this.txt_fraction.TabIndex = 14;
            // 
            // pictureBox_output
            // 
            this.pictureBox_output.Location = new System.Drawing.Point(14, 15);
            this.pictureBox_output.Name = "pictureBox_output";
            this.pictureBox_output.Size = new System.Drawing.Size(362, 310);
            this.pictureBox_output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_output.TabIndex = 11;
            this.pictureBox_output.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_operations
            // 
            this.comboBox_operations.FormattingEnabled = true;
            this.comboBox_operations.Items.AddRange(new object[] {
            "Sum",
            "Subtract"});
            this.comboBox_operations.Location = new System.Drawing.Point(132, 13);
            this.comboBox_operations.Name = "comboBox_operations";
            this.comboBox_operations.Size = new System.Drawing.Size(75, 21);
            this.comboBox_operations.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Operation";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(528, 421);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // AlgebraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 458);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox_output);
            this.Controls.Add(this.groupBox_Operations);
            this.Controls.Add(this.groupBox_img2);
            this.Controls.Add(this.groupBox_img1);
            this.Controls.Add(this.btn_Apply);
            this.Name = "AlgebraForm";
            this.Text = "AlgebraForm";
            this.groupBox_Operations.ResumeLayout(false);
            this.groupBox_Operations.PerformLayout();
            this.groupBox_img2.ResumeLayout(false);
            this.groupBox_img2.PerformLayout();
            this.groupBox_img1.ResumeLayout(false);
            this.groupBox_img1.PerformLayout();
            this.groupBox_output.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_fraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.PictureBox pictureBox_output;
        private System.Windows.Forms.GroupBox groupBox_Operations;
        private System.Windows.Forms.NumericUpDown txt_fraction;
        private System.Windows.Forms.GroupBox groupBox_img2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txt_path2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_img1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_path1;
        private System.Windows.Forms.GroupBox groupBox_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_operations;
        private System.Windows.Forms.Button btn_cancel;
    }
}