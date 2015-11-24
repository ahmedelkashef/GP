namespace Brightness_Contrast
{
    partial class BrightnessAndContrast
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
            this.groupBox_original = new System.Windows.Forms.GroupBox();
            this.pic_original = new System.Windows.Forms.PictureBox();
            this.groupBox_Modified = new System.Windows.Forms.GroupBox();
            this.pic_modified = new System.Windows.Forms.PictureBox();
            this.groupBox_bright = new System.Windows.Forms.GroupBox();
            this.trackBar_bright = new System.Windows.Forms.TrackBar();
            this.numericUpDown_bright = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Contrast = new System.Windows.Forms.GroupBox();
            this.numericUpDown_contrast = new System.Windows.Forms.NumericUpDown();
            this.trackBar_contrast = new System.Windows.Forms.TrackBar();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox_original.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_original)).BeginInit();
            this.groupBox_Modified.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_modified)).BeginInit();
            this.groupBox_bright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_bright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bright)).BeginInit();
            this.groupBox_Contrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_contrast)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_original
            // 
            this.groupBox_original.Controls.Add(this.pic_original);
            this.groupBox_original.Location = new System.Drawing.Point(12, 12);
            this.groupBox_original.Name = "groupBox_original";
            this.groupBox_original.Size = new System.Drawing.Size(282, 222);
            this.groupBox_original.TabIndex = 0;
            this.groupBox_original.TabStop = false;
            this.groupBox_original.Text = "Original";
            // 
            // pic_original
            // 
            this.pic_original.Location = new System.Drawing.Point(6, 19);
            this.pic_original.Name = "pic_original";
            this.pic_original.Size = new System.Drawing.Size(270, 197);
            this.pic_original.TabIndex = 0;
            this.pic_original.TabStop = false;
            // 
            // groupBox_Modified
            // 
            this.groupBox_Modified.Controls.Add(this.pic_modified);
            this.groupBox_Modified.Location = new System.Drawing.Point(304, 12);
            this.groupBox_Modified.Name = "groupBox_Modified";
            this.groupBox_Modified.Size = new System.Drawing.Size(282, 222);
            this.groupBox_Modified.TabIndex = 1;
            this.groupBox_Modified.TabStop = false;
            this.groupBox_Modified.Text = "Modified";
            // 
            // pic_modified
            // 
            this.pic_modified.Location = new System.Drawing.Point(6, 19);
            this.pic_modified.Name = "pic_modified";
            this.pic_modified.Size = new System.Drawing.Size(270, 197);
            this.pic_modified.TabIndex = 0;
            this.pic_modified.TabStop = false;
            // 
            // groupBox_bright
            // 
            this.groupBox_bright.Controls.Add(this.numericUpDown_bright);
            this.groupBox_bright.Controls.Add(this.trackBar_bright);
            this.groupBox_bright.Location = new System.Drawing.Point(18, 242);
            this.groupBox_bright.Name = "groupBox_bright";
            this.groupBox_bright.Size = new System.Drawing.Size(330, 57);
            this.groupBox_bright.TabIndex = 2;
            this.groupBox_bright.TabStop = false;
            this.groupBox_bright.Text = "Brightness";
            // 
            // trackBar_bright
            // 
            this.trackBar_bright.Location = new System.Drawing.Point(6, 19);
            this.trackBar_bright.Name = "trackBar_bright";
            this.trackBar_bright.Size = new System.Drawing.Size(236, 45);
            this.trackBar_bright.TabIndex = 0;
            // 
            // numericUpDown_bright
            // 
            this.numericUpDown_bright.Location = new System.Drawing.Point(278, 19);
            this.numericUpDown_bright.Name = "numericUpDown_bright";
            this.numericUpDown_bright.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown_bright.TabIndex = 1;
            // 
            // groupBox_Contrast
            // 
            this.groupBox_Contrast.Controls.Add(this.numericUpDown_contrast);
            this.groupBox_Contrast.Controls.Add(this.trackBar_contrast);
            this.groupBox_Contrast.Location = new System.Drawing.Point(18, 305);
            this.groupBox_Contrast.Name = "groupBox_Contrast";
            this.groupBox_Contrast.Size = new System.Drawing.Size(330, 57);
            this.groupBox_Contrast.TabIndex = 3;
            this.groupBox_Contrast.TabStop = false;
            this.groupBox_Contrast.Text = "Contrast";
            // 
            // numericUpDown_contrast
            // 
            this.numericUpDown_contrast.Location = new System.Drawing.Point(278, 19);
            this.numericUpDown_contrast.Name = "numericUpDown_contrast";
            this.numericUpDown_contrast.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown_contrast.TabIndex = 1;
            // 
            // trackBar_contrast
            // 
            this.trackBar_contrast.Location = new System.Drawing.Point(6, 19);
            this.trackBar_contrast.Name = "trackBar_contrast";
            this.trackBar_contrast.Size = new System.Drawing.Size(236, 45);
            this.trackBar_contrast.TabIndex = 0;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(521, 242);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(59, 23);
            this.btn_apply.TabIndex = 4;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(521, 276);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(59, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // BrightnessAndContrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 375);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox_Contrast);
            this.Controls.Add(this.groupBox_bright);
            this.Controls.Add(this.groupBox_Modified);
            this.Controls.Add(this.groupBox_original);
            this.Name = "BrightnessAndContrast";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_original.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_original)).EndInit();
            this.groupBox_Modified.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_modified)).EndInit();
            this.groupBox_bright.ResumeLayout(false);
            this.groupBox_bright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_bright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bright)).EndInit();
            this.groupBox_Contrast.ResumeLayout(false);
            this.groupBox_Contrast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_contrast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_original;
        private System.Windows.Forms.PictureBox pic_original;
        private System.Windows.Forms.GroupBox groupBox_Modified;
        private System.Windows.Forms.PictureBox pic_modified;
        private System.Windows.Forms.GroupBox groupBox_bright;
        private System.Windows.Forms.NumericUpDown numericUpDown_bright;
        private System.Windows.Forms.TrackBar trackBar_bright;
        private System.Windows.Forms.GroupBox groupBox_Contrast;
        private System.Windows.Forms.NumericUpDown numericUpDown_contrast;
        private System.Windows.Forms.TrackBar trackBar_contrast;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_cancel;

    }
}

