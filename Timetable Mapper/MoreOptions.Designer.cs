namespace Timetable_Mapper
{
    partial class MoreOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreOptions));
            this.lstFonts = new System.Windows.Forms.ListBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.lblColourPresets = new System.Windows.Forms.Label();
            this.chkBlackAndWhite = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPresetFive = new System.Windows.Forms.Button();
            this.btnPresetFour = new System.Windows.Forms.Button();
            this.btnPresetThree = new System.Windows.Forms.Button();
            this.btnPresetTwo = new System.Windows.Forms.Button();
            this.btnPresetOne = new System.Windows.Forms.Button();
            this.picForm = new System.Windows.Forms.PictureBox();
            this.lblFontExample = new System.Windows.Forms.Label();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFonts
            // 
            this.lstFonts.FormattingEnabled = true;
            this.lstFonts.Items.AddRange(new object[] {
            "Arial",
            "Comic Sans",
            "Gothic",
            "Himalaya",
            "Sego Script",
            "Times New Roman"});
            this.lstFonts.Location = new System.Drawing.Point(12, 68);
            this.lstFonts.Name = "lstFonts";
            this.lstFonts.Size = new System.Drawing.Size(119, 95);
            this.lstFonts.TabIndex = 0;
            this.lstFonts.SelectedIndexChanged += new System.EventHandler(this.lstFonts_SelectedIndexChanged);
            // 
            // lblFont
            // 
            this.lblFont.BackColor = System.Drawing.Color.Transparent;
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(12, 47);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(120, 17);
            this.lblFont.TabIndex = 9;
            this.lblFont.Text = "Font";
            this.lblFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFont.UseCompatibleTextRendering = true;
            // 
            // lblColourPresets
            // 
            this.lblColourPresets.BackColor = System.Drawing.Color.Transparent;
            this.lblColourPresets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourPresets.Location = new System.Drawing.Point(188, 47);
            this.lblColourPresets.Name = "lblColourPresets";
            this.lblColourPresets.Size = new System.Drawing.Size(101, 17);
            this.lblColourPresets.TabIndex = 10;
            this.lblColourPresets.Text = "Colour Presets";
            this.lblColourPresets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblColourPresets.UseCompatibleTextRendering = true;
            // 
            // chkBlackAndWhite
            // 
            this.chkBlackAndWhite.AutoSize = true;
            this.chkBlackAndWhite.BackColor = System.Drawing.Color.Transparent;
            this.chkBlackAndWhite.Location = new System.Drawing.Point(12, 276);
            this.chkBlackAndWhite.Name = "chkBlackAndWhite";
            this.chkBlackAndWhite.Size = new System.Drawing.Size(90, 18);
            this.chkBlackAndWhite.TabIndex = 6;
            this.chkBlackAndWhite.Text = "Black + white";
            this.chkBlackAndWhite.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkBlackAndWhite.UseCompatibleTextRendering = true;
            this.chkBlackAndWhite.UseVisualStyleBackColor = false;
            this.chkBlackAndWhite.CheckedChanged += new System.EventHandler(this.chkBlackAndWhite_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(188, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseCompatibleTextRendering = true;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPresetFive
            // 
            this.btnPresetFive.BackgroundImage = global::Timetable_Mapper.Properties.Resources.Palette5;
            this.btnPresetFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPresetFive.Location = new System.Drawing.Point(188, 184);
            this.btnPresetFive.Name = "btnPresetFive";
            this.btnPresetFive.Size = new System.Drawing.Size(101, 23);
            this.btnPresetFive.TabIndex = 5;
            this.btnPresetFive.UseVisualStyleBackColor = true;
            this.btnPresetFive.Click += new System.EventHandler(this.btnPresetFive_Click);
            // 
            // btnPresetFour
            // 
            this.btnPresetFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPresetFour.BackgroundImage")));
            this.btnPresetFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPresetFour.Location = new System.Drawing.Point(188, 155);
            this.btnPresetFour.Name = "btnPresetFour";
            this.btnPresetFour.Size = new System.Drawing.Size(101, 23);
            this.btnPresetFour.TabIndex = 4;
            this.btnPresetFour.UseVisualStyleBackColor = true;
            this.btnPresetFour.Click += new System.EventHandler(this.btnPresetFour_Click);
            // 
            // btnPresetThree
            // 
            this.btnPresetThree.BackgroundImage = global::Timetable_Mapper.Properties.Resources.Palette3;
            this.btnPresetThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPresetThree.Location = new System.Drawing.Point(188, 126);
            this.btnPresetThree.Name = "btnPresetThree";
            this.btnPresetThree.Size = new System.Drawing.Size(101, 23);
            this.btnPresetThree.TabIndex = 3;
            this.btnPresetThree.UseVisualStyleBackColor = true;
            this.btnPresetThree.Click += new System.EventHandler(this.btnPresetThree_Click);
            // 
            // btnPresetTwo
            // 
            this.btnPresetTwo.BackgroundImage = global::Timetable_Mapper.Properties.Resources.Palette2;
            this.btnPresetTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPresetTwo.Location = new System.Drawing.Point(188, 97);
            this.btnPresetTwo.Name = "btnPresetTwo";
            this.btnPresetTwo.Size = new System.Drawing.Size(101, 23);
            this.btnPresetTwo.TabIndex = 2;
            this.btnPresetTwo.UseVisualStyleBackColor = true;
            this.btnPresetTwo.Click += new System.EventHandler(this.btnPresetTwo_Click);
            // 
            // btnPresetOne
            // 
            this.btnPresetOne.BackgroundImage = global::Timetable_Mapper.Properties.Resources.Palette1;
            this.btnPresetOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPresetOne.Location = new System.Drawing.Point(188, 68);
            this.btnPresetOne.Name = "btnPresetOne";
            this.btnPresetOne.Size = new System.Drawing.Size(101, 23);
            this.btnPresetOne.TabIndex = 1;
            this.btnPresetOne.UseVisualStyleBackColor = true;
            this.btnPresetOne.Click += new System.EventHandler(this.btnPresetOne_Click);
            // 
            // picForm
            // 
            this.picForm.Image = global::Timetable_Mapper.Properties.Resources.TimeTableMapper_MoreOptions;
            this.picForm.Location = new System.Drawing.Point(0, 0);
            this.picForm.Name = "picForm";
            this.picForm.Size = new System.Drawing.Size(300, 300);
            this.picForm.TabIndex = 0;
            this.picForm.TabStop = false;
            // 
            // lblFontExample
            // 
            this.lblFontExample.BackColor = System.Drawing.Color.Transparent;
            this.lblFontExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontExample.Location = new System.Drawing.Point(12, 166);
            this.lblFontExample.Name = "lblFontExample";
            this.lblFontExample.Size = new System.Drawing.Size(120, 17);
            this.lblFontExample.TabIndex = 8;
            this.lblFontExample.Text = "Example";
            this.lblFontExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFontExample.UseCompatibleTextRendering = true;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.BackColor = System.Drawing.Color.Transparent;
            this.chkItalic.Location = new System.Drawing.Point(12, 210);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(47, 18);
            this.chkItalic.TabIndex = 11;
            this.chkItalic.Text = "Italic";
            this.chkItalic.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkItalic.UseCompatibleTextRendering = true;
            this.chkItalic.UseVisualStyleBackColor = false;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.BackColor = System.Drawing.Color.Transparent;
            this.chkBold.Location = new System.Drawing.Point(12, 187);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(46, 18);
            this.chkBold.TabIndex = 12;
            this.chkBold.Text = "Bold";
            this.chkBold.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkBold.UseCompatibleTextRendering = true;
            this.chkBold.UseVisualStyleBackColor = false;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // MoreOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.lblFontExample);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkBlackAndWhite);
            this.Controls.Add(this.btnPresetFive);
            this.Controls.Add(this.btnPresetFour);
            this.Controls.Add(this.btnPresetThree);
            this.Controls.Add(this.btnPresetTwo);
            this.Controls.Add(this.lblColourPresets);
            this.Controls.Add(this.btnPresetOne);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.lstFonts);
            this.Controls.Add(this.picForm);
            this.Name = "MoreOptions";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picForm;
        private System.Windows.Forms.ListBox lstFonts;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Button btnPresetOne;
        private System.Windows.Forms.Button btnPresetTwo;
        private System.Windows.Forms.Button btnPresetThree;
        private System.Windows.Forms.Button btnPresetFour;
        private System.Windows.Forms.Button btnPresetFive;
        private System.Windows.Forms.Label lblColourPresets;
        private System.Windows.Forms.CheckBox chkBlackAndWhite;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFontExample;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
    }
}