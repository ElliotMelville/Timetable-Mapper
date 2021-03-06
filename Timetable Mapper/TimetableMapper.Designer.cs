﻿namespace Timetable_Mapper
{
    partial class TimetableMapper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimetableMapper));
            this.clrdLineOne = new System.Windows.Forms.ColorDialog();
            this.clrdLineTwo = new System.Windows.Forms.ColorDialog();
            this.clrdLineThree = new System.Windows.Forms.ColorDialog();
            this.clrdLineFour = new System.Windows.Forms.ColorDialog();
            this.clrdLineFive = new System.Windows.Forms.ColorDialog();
            this.clrdLineSix = new System.Windows.Forms.ColorDialog();
            this.btnMap = new System.Windows.Forms.Button();
            this.tmrTitle = new System.Windows.Forms.Timer(this.components);
            this.btnLineOne = new System.Windows.Forms.Button();
            this.btnLineTwo = new System.Windows.Forms.Button();
            this.btnLineThree = new System.Windows.Forms.Button();
            this.btnLineFour = new System.Windows.Forms.Button();
            this.btnLineFive = new System.Windows.Forms.Button();
            this.btnLineSix = new System.Windows.Forms.Button();
            this.lblLineOne = new System.Windows.Forms.Label();
            this.lblLineTwo = new System.Windows.Forms.Label();
            this.lblLineThree = new System.Windows.Forms.Label();
            this.lblLineFive = new System.Windows.Forms.Label();
            this.lblLineSix = new System.Windows.Forms.Label();
            this.lblLineFour = new System.Windows.Forms.Label();
            this.btnRandomiseColours = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnMoreOptions = new System.Windows.Forms.Button();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.picForm = new System.Windows.Forms.PictureBox();
            this.txtLineSixNote = new Timetable_Mapper.GhostTextBox();
            this.txtLineSix = new Timetable_Mapper.GhostTextBox();
            this.txtLineFiveNote = new Timetable_Mapper.GhostTextBox();
            this.txtLineFive = new Timetable_Mapper.GhostTextBox();
            this.txtLineFourNote = new Timetable_Mapper.GhostTextBox();
            this.txtLineFour = new Timetable_Mapper.GhostTextBox();
            this.txtLineThreeNote = new Timetable_Mapper.GhostTextBox();
            this.txtLineThree = new Timetable_Mapper.GhostTextBox();
            this.txtLineTwoNote = new Timetable_Mapper.GhostTextBox();
            this.txtLineTwo = new Timetable_Mapper.GhostTextBox();
            this.txtLineOneNote = new Timetable_Mapper.GhostTextBox();
            this.txtLineOne = new Timetable_Mapper.GhostTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMap
            // 
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(283, 618);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(234, 66);
            this.btnMap.TabIndex = 19;
            this.btnMap.Text = "MAP TIMETABLE";
            this.btnMap.UseCompatibleTextRendering = true;
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // tmrTitle
            // 
            this.tmrTitle.Enabled = true;
            this.tmrTitle.Interval = 16;
            this.tmrTitle.Tick += new System.EventHandler(this.tmrAnimation_Tick_1);
            // 
            // btnLineOne
            // 
            this.btnLineOne.BackColor = System.Drawing.SystemColors.Window;
            this.btnLineOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineOne.Location = new System.Drawing.Point(86, 403);
            this.btnLineOne.Name = "btnLineOne";
            this.btnLineOne.Size = new System.Drawing.Size(92, 23);
            this.btnLineOne.TabIndex = 12;
            this.btnLineOne.Text = "Colour";
            this.btnLineOne.UseCompatibleTextRendering = true;
            this.btnLineOne.UseVisualStyleBackColor = false;
            this.btnLineOne.Click += new System.EventHandler(this.btnLineOne_Click);
            // 
            // btnLineTwo
            // 
            this.btnLineTwo.BackColor = System.Drawing.SystemColors.Window;
            this.btnLineTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineTwo.Location = new System.Drawing.Point(359, 403);
            this.btnLineTwo.Name = "btnLineTwo";
            this.btnLineTwo.Size = new System.Drawing.Size(92, 23);
            this.btnLineTwo.TabIndex = 13;
            this.btnLineTwo.Text = "Colour";
            this.btnLineTwo.UseCompatibleTextRendering = true;
            this.btnLineTwo.UseVisualStyleBackColor = false;
            this.btnLineTwo.Click += new System.EventHandler(this.btnLineTwo_Click);
            // 
            // btnLineThree
            // 
            this.btnLineThree.BackColor = System.Drawing.SystemColors.Window;
            this.btnLineThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineThree.Location = new System.Drawing.Point(632, 403);
            this.btnLineThree.Name = "btnLineThree";
            this.btnLineThree.Size = new System.Drawing.Size(92, 23);
            this.btnLineThree.TabIndex = 14;
            this.btnLineThree.Text = "Colour";
            this.btnLineThree.UseCompatibleTextRendering = true;
            this.btnLineThree.UseVisualStyleBackColor = false;
            this.btnLineThree.Click += new System.EventHandler(this.btnLineThree_Click);
            // 
            // btnLineFour
            // 
            this.btnLineFour.BackColor = System.Drawing.SystemColors.Window;
            this.btnLineFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineFour.Location = new System.Drawing.Point(87, 554);
            this.btnLineFour.Name = "btnLineFour";
            this.btnLineFour.Size = new System.Drawing.Size(91, 23);
            this.btnLineFour.TabIndex = 15;
            this.btnLineFour.Text = "Colour";
            this.btnLineFour.UseCompatibleTextRendering = true;
            this.btnLineFour.UseVisualStyleBackColor = false;
            this.btnLineFour.Click += new System.EventHandler(this.btnLineFour_Click);
            // 
            // btnLineFive
            // 
            this.btnLineFive.BackColor = System.Drawing.SystemColors.Window;
            this.btnLineFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineFive.Location = new System.Drawing.Point(359, 554);
            this.btnLineFive.Name = "btnLineFive";
            this.btnLineFive.Size = new System.Drawing.Size(92, 23);
            this.btnLineFive.TabIndex = 16;
            this.btnLineFive.Text = "Colour";
            this.btnLineFive.UseCompatibleTextRendering = true;
            this.btnLineFive.UseVisualStyleBackColor = false;
            this.btnLineFive.Click += new System.EventHandler(this.btnLineFive_Click);
            // 
            // btnLineSix
            // 
            this.btnLineSix.BackColor = System.Drawing.SystemColors.Window;
            this.btnLineSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineSix.Location = new System.Drawing.Point(632, 554);
            this.btnLineSix.Name = "btnLineSix";
            this.btnLineSix.Size = new System.Drawing.Size(92, 23);
            this.btnLineSix.TabIndex = 17;
            this.btnLineSix.Text = "Colour";
            this.btnLineSix.UseCompatibleTextRendering = true;
            this.btnLineSix.UseVisualStyleBackColor = false;
            this.btnLineSix.Click += new System.EventHandler(this.btnLineSix_Click);
            // 
            // lblLineOne
            // 
            this.lblLineOne.BackColor = System.Drawing.Color.Transparent;
            this.lblLineOne.Location = new System.Drawing.Point(1, 306);
            this.lblLineOne.Name = "lblLineOne";
            this.lblLineOne.Size = new System.Drawing.Size(264, 33);
            this.lblLineOne.TabIndex = 35;
            this.lblLineOne.Text = "LINE ONE";
            this.lblLineOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLineOne.UseCompatibleTextRendering = true;
            // 
            // lblLineTwo
            // 
            this.lblLineTwo.BackColor = System.Drawing.Color.Transparent;
            this.lblLineTwo.Location = new System.Drawing.Point(268, 306);
            this.lblLineTwo.Name = "lblLineTwo";
            this.lblLineTwo.Size = new System.Drawing.Size(264, 33);
            this.lblLineTwo.TabIndex = 36;
            this.lblLineTwo.Text = "LINE TWO";
            this.lblLineTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLineTwo.UseCompatibleTextRendering = true;
            // 
            // lblLineThree
            // 
            this.lblLineThree.BackColor = System.Drawing.Color.Transparent;
            this.lblLineThree.Location = new System.Drawing.Point(534, 306);
            this.lblLineThree.Name = "lblLineThree";
            this.lblLineThree.Size = new System.Drawing.Size(275, 33);
            this.lblLineThree.TabIndex = 37;
            this.lblLineThree.Text = "LINE THREE";
            this.lblLineThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLineThree.UseCompatibleTextRendering = true;
            // 
            // lblLineFive
            // 
            this.lblLineFive.BackColor = System.Drawing.Color.Transparent;
            this.lblLineFive.Location = new System.Drawing.Point(268, 456);
            this.lblLineFive.Name = "lblLineFive";
            this.lblLineFive.Size = new System.Drawing.Size(264, 33);
            this.lblLineFive.TabIndex = 38;
            this.lblLineFive.Text = "LINE FIVE";
            this.lblLineFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLineFive.UseCompatibleTextRendering = true;
            // 
            // lblLineSix
            // 
            this.lblLineSix.BackColor = System.Drawing.Color.Transparent;
            this.lblLineSix.Location = new System.Drawing.Point(536, 456);
            this.lblLineSix.Name = "lblLineSix";
            this.lblLineSix.Size = new System.Drawing.Size(273, 33);
            this.lblLineSix.TabIndex = 39;
            this.lblLineSix.Text = "LINE SIX";
            this.lblLineSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLineSix.UseCompatibleTextRendering = true;
            // 
            // lblLineFour
            // 
            this.lblLineFour.BackColor = System.Drawing.Color.Transparent;
            this.lblLineFour.Location = new System.Drawing.Point(1, 456);
            this.lblLineFour.Name = "lblLineFour";
            this.lblLineFour.Size = new System.Drawing.Size(264, 33);
            this.lblLineFour.TabIndex = 40;
            this.lblLineFour.Text = "LINE FOUR";
            this.lblLineFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLineFour.UseCompatibleTextRendering = true;
            // 
            // btnRandomiseColours
            // 
            this.btnRandomiseColours.BackColor = System.Drawing.SystemColors.Window;
            this.btnRandomiseColours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomiseColours.Location = new System.Drawing.Point(59, 627);
            this.btnRandomiseColours.Name = "btnRandomiseColours";
            this.btnRandomiseColours.Size = new System.Drawing.Size(146, 47);
            this.btnRandomiseColours.TabIndex = 20;
            this.btnRandomiseColours.Text = "Randomise Colours";
            this.btnRandomiseColours.UseCompatibleTextRendering = true;
            this.btnRandomiseColours.UseVisualStyleBackColor = false;
            this.btnRandomiseColours.Click += new System.EventHandler(this.btnRandomiseColours_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.AccessibleDescription = "Help";
            this.btnHelp.AccessibleName = "Help";
            this.btnHelp.BackColor = System.Drawing.Color.Gold;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(377, 271);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(56, 19);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseCompatibleTextRendering = true;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnMoreOptions
            // 
            this.btnMoreOptions.BackColor = System.Drawing.Color.White;
            this.btnMoreOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreOptions.Location = new System.Drawing.Point(604, 627);
            this.btnMoreOptions.Name = "btnMoreOptions";
            this.btnMoreOptions.Size = new System.Drawing.Size(146, 47);
            this.btnMoreOptions.TabIndex = 18;
            this.btnMoreOptions.Text = "More options";
            this.btnMoreOptions.UseCompatibleTextRendering = true;
            this.btnMoreOptions.UseVisualStyleBackColor = false;
            this.btnMoreOptions.Click += new System.EventHandler(this.btnMoreOptions_Click_1);
            // 
            // picTitle
            // 
            this.picTitle.Image = global::Timetable_Mapper.Properties.Resources.TIMETABLEMAPPER_Title8;
            this.picTitle.Location = new System.Drawing.Point(-1, 0);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(810, 260);
            this.picTitle.TabIndex = 22;
            this.picTitle.TabStop = false;
            // 
            // picForm
            // 
            this.picForm.BackColor = System.Drawing.Color.Transparent;
            this.picForm.Image = global::Timetable_Mapper.Properties.Resources.TimetableMapper_form9;
            this.picForm.Location = new System.Drawing.Point(0, 0);
            this.picForm.Name = "picForm";
            this.picForm.Size = new System.Drawing.Size(809, 700);
            this.picForm.TabIndex = 0;
            this.picForm.TabStop = false;
            // 
            // txtLineSixNote
            // 
            this.txtLineSixNote.ForeColor = System.Drawing.Color.Gray;
            this.txtLineSixNote.GhostText = "Notes";
            this.txtLineSixNote.Location = new System.Drawing.Point(604, 526);
            this.txtLineSixNote.Name = "txtLineSixNote";
            this.txtLineSixNote.Size = new System.Drawing.Size(146, 20);
            this.txtLineSixNote.TabIndex = 62;
            this.txtLineSixNote.Text = "Notes";
            // 
            // txtLineSix
            // 
            this.txtLineSix.ForeColor = System.Drawing.Color.Gray;
            this.txtLineSix.GhostText = "Subject";
            this.txtLineSix.Location = new System.Drawing.Point(632, 497);
            this.txtLineSix.Name = "txtLineSix";
            this.txtLineSix.Size = new System.Drawing.Size(92, 20);
            this.txtLineSix.TabIndex = 61;
            this.txtLineSix.Text = "Subject";
            // 
            // txtLineFiveNote
            // 
            this.txtLineFiveNote.ForeColor = System.Drawing.Color.Gray;
            this.txtLineFiveNote.GhostText = "Notes";
            this.txtLineFiveNote.Location = new System.Drawing.Point(331, 526);
            this.txtLineFiveNote.Name = "txtLineFiveNote";
            this.txtLineFiveNote.Size = new System.Drawing.Size(146, 20);
            this.txtLineFiveNote.TabIndex = 60;
            this.txtLineFiveNote.Text = "Notes";
            // 
            // txtLineFive
            // 
            this.txtLineFive.ForeColor = System.Drawing.Color.Gray;
            this.txtLineFive.GhostText = "Subject";
            this.txtLineFive.Location = new System.Drawing.Point(359, 497);
            this.txtLineFive.Name = "txtLineFive";
            this.txtLineFive.Size = new System.Drawing.Size(92, 20);
            this.txtLineFive.TabIndex = 59;
            this.txtLineFive.Text = "Subject";
            // 
            // txtLineFourNote
            // 
            this.txtLineFourNote.ForeColor = System.Drawing.Color.Gray;
            this.txtLineFourNote.GhostText = "Notes";
            this.txtLineFourNote.Location = new System.Drawing.Point(59, 526);
            this.txtLineFourNote.Name = "txtLineFourNote";
            this.txtLineFourNote.Size = new System.Drawing.Size(146, 20);
            this.txtLineFourNote.TabIndex = 58;
            this.txtLineFourNote.Text = "Notes";
            // 
            // txtLineFour
            // 
            this.txtLineFour.ForeColor = System.Drawing.Color.Gray;
            this.txtLineFour.GhostText = "Subject";
            this.txtLineFour.Location = new System.Drawing.Point(86, 497);
            this.txtLineFour.Name = "txtLineFour";
            this.txtLineFour.Size = new System.Drawing.Size(92, 20);
            this.txtLineFour.TabIndex = 57;
            this.txtLineFour.Text = "Subject";
            // 
            // txtLineThreeNote
            // 
            this.txtLineThreeNote.ForeColor = System.Drawing.Color.Gray;
            this.txtLineThreeNote.GhostText = "Notes";
            this.txtLineThreeNote.Location = new System.Drawing.Point(604, 376);
            this.txtLineThreeNote.Name = "txtLineThreeNote";
            this.txtLineThreeNote.Size = new System.Drawing.Size(146, 20);
            this.txtLineThreeNote.TabIndex = 56;
            this.txtLineThreeNote.Text = "Notes";
            // 
            // txtLineThree
            // 
            this.txtLineThree.ForeColor = System.Drawing.Color.Gray;
            this.txtLineThree.GhostText = "Subject";
            this.txtLineThree.Location = new System.Drawing.Point(632, 347);
            this.txtLineThree.Name = "txtLineThree";
            this.txtLineThree.Size = new System.Drawing.Size(92, 20);
            this.txtLineThree.TabIndex = 55;
            this.txtLineThree.Text = "Subject";
            // 
            // txtLineTwoNote
            // 
            this.txtLineTwoNote.ForeColor = System.Drawing.Color.Gray;
            this.txtLineTwoNote.GhostText = "Notes";
            this.txtLineTwoNote.Location = new System.Drawing.Point(331, 376);
            this.txtLineTwoNote.Name = "txtLineTwoNote";
            this.txtLineTwoNote.Size = new System.Drawing.Size(146, 20);
            this.txtLineTwoNote.TabIndex = 54;
            this.txtLineTwoNote.Text = "Notes";
            // 
            // txtLineTwo
            // 
            this.txtLineTwo.ForeColor = System.Drawing.Color.Gray;
            this.txtLineTwo.GhostText = "Subject";
            this.txtLineTwo.Location = new System.Drawing.Point(359, 347);
            this.txtLineTwo.Name = "txtLineTwo";
            this.txtLineTwo.Size = new System.Drawing.Size(92, 20);
            this.txtLineTwo.TabIndex = 53;
            this.txtLineTwo.Text = "Subject";
            // 
            // txtLineOneNote
            // 
            this.txtLineOneNote.ForeColor = System.Drawing.Color.Gray;
            this.txtLineOneNote.GhostText = "Notes";
            this.txtLineOneNote.Location = new System.Drawing.Point(59, 376);
            this.txtLineOneNote.Name = "txtLineOneNote";
            this.txtLineOneNote.Size = new System.Drawing.Size(146, 20);
            this.txtLineOneNote.TabIndex = 52;
            this.txtLineOneNote.Text = "Notes";
            // 
            // txtLineOne
            // 
            this.txtLineOne.ForeColor = System.Drawing.Color.Gray;
            this.txtLineOne.GhostText = "Subject";
            this.txtLineOne.Location = new System.Drawing.Point(86, 347);
            this.txtLineOne.Name = "txtLineOne";
            this.txtLineOne.Size = new System.Drawing.Size(92, 20);
            this.txtLineOne.TabIndex = 51;
            this.txtLineOne.Text = "Subject";
            // 
            // TimetableMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 700);
            this.Controls.Add(this.txtLineSixNote);
            this.Controls.Add(this.txtLineSix);
            this.Controls.Add(this.txtLineFiveNote);
            this.Controls.Add(this.txtLineFive);
            this.Controls.Add(this.txtLineFourNote);
            this.Controls.Add(this.txtLineFour);
            this.Controls.Add(this.txtLineThreeNote);
            this.Controls.Add(this.txtLineThree);
            this.Controls.Add(this.txtLineTwoNote);
            this.Controls.Add(this.txtLineTwo);
            this.Controls.Add(this.txtLineOneNote);
            this.Controls.Add(this.txtLineOne);
            this.Controls.Add(this.btnMoreOptions);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnRandomiseColours);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.lblLineFour);
            this.Controls.Add(this.lblLineSix);
            this.Controls.Add(this.lblLineFive);
            this.Controls.Add(this.lblLineThree);
            this.Controls.Add(this.lblLineTwo);
            this.Controls.Add(this.lblLineOne);
            this.Controls.Add(this.btnLineSix);
            this.Controls.Add(this.btnLineFive);
            this.Controls.Add(this.btnLineFour);
            this.Controls.Add(this.btnLineThree);
            this.Controls.Add(this.btnLineTwo);
            this.Controls.Add(this.btnLineOne);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.picForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimetableMapper";
            this.Text = "Timetable Mapper";
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picForm;
        private System.Windows.Forms.ColorDialog clrdLineOne;
        private System.Windows.Forms.ColorDialog clrdLineTwo;
        private System.Windows.Forms.ColorDialog clrdLineThree;
        private System.Windows.Forms.ColorDialog clrdLineFour;
        private System.Windows.Forms.ColorDialog clrdLineFive;
        private System.Windows.Forms.ColorDialog clrdLineSix;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Timer tmrTitle;
        private System.Windows.Forms.Button btnLineOne;
        private System.Windows.Forms.Button btnLineTwo;
        private System.Windows.Forms.Button btnLineThree;
        private System.Windows.Forms.Button btnLineFour;
        private System.Windows.Forms.Button btnLineFive;
        private System.Windows.Forms.Button btnLineSix;
        private System.Windows.Forms.Label lblLineOne;
        private System.Windows.Forms.Label lblLineTwo;
        private System.Windows.Forms.Label lblLineThree;
        private System.Windows.Forms.Label lblLineFive;
        private System.Windows.Forms.Label lblLineSix;
        private System.Windows.Forms.Label lblLineFour;
        private System.Windows.Forms.Button btnRandomiseColours;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnMoreOptions;
        private GhostTextBox txtLineOne;
        private GhostTextBox txtLineOneNote;
        private GhostTextBox txtLineTwo;
        private GhostTextBox txtLineTwoNote;
        private GhostTextBox txtLineThree;
        private GhostTextBox txtLineThreeNote;
        private GhostTextBox txtLineFour;
        private GhostTextBox txtLineFourNote;
        private GhostTextBox txtLineFive;
        private GhostTextBox txtLineFiveNote;
        private GhostTextBox txtLineSix;
        private GhostTextBox txtLineSixNote;
    }
}

