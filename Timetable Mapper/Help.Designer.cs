namespace Timetable_Mapper
{
    partial class Help
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
            this.btnChangeLog = new System.Windows.Forms.Button();
            this.picChangeLog = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChangeLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeLog
            // 
            this.btnChangeLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangeLog.Location = new System.Drawing.Point(116, 456);
            this.btnChangeLog.Name = "btnChangeLog";
            this.btnChangeLog.Size = new System.Drawing.Size(170, 24);
            this.btnChangeLog.TabIndex = 1;
            this.btnChangeLog.Text = "Change Log";
            this.btnChangeLog.UseVisualStyleBackColor = true;
            this.btnChangeLog.Click += new System.EventHandler(this.btnChangeLog_Click);
            // 
            // picChangeLog
            // 
            this.picChangeLog.Image = global::Timetable_Mapper.Properties.Resources.ChangeLog;
            this.picChangeLog.Location = new System.Drawing.Point(0, 0);
            this.picChangeLog.Name = "picChangeLog";
            this.picChangeLog.Size = new System.Drawing.Size(800, 500);
            this.picChangeLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChangeLog.TabIndex = 2;
            this.picChangeLog.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Timetable_Mapper.Properties.Resources.HelpForm2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.picChangeLog);
            this.Controls.Add(this.btnChangeLog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Help";
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.picChangeLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChangeLog;
        private System.Windows.Forms.PictureBox picChangeLog;
    }
}