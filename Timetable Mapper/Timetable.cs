using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Timetable_Mapper
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
            CreateTimetable();
        }

        private void SetCell(Label label, String text, Color colour)
        {
            label.Text = text;
            label.BackColor = colour;
        }

        private void CreateTimetable()
        {
            //line one
            SetCell(lblLineOne1, TimetableMapper.SetValueForLineOneText, TimetableMapper.SetValueForLineOneColor);
            SetCell(lblLineOne2, TimetableMapper.SetValueForLineOneText, TimetableMapper.SetValueForLineOneColor);
            SetCell(lblLineOne3, TimetableMapper.SetValueForLineOneText, TimetableMapper.SetValueForLineOneColor);
            SetCell(lblLineOne4, TimetableMapper.SetValueForLineOneText, TimetableMapper.SetValueForLineOneColor);

            //line two
            SetCell(lblLineTwo1, TimetableMapper.SetValueForLineTwoText, TimetableMapper.SetValueForLineTwoColor);
            SetCell(lblLineTwo2, TimetableMapper.SetValueForLineTwoText, TimetableMapper.SetValueForLineTwoColor);
            SetCell(lblLineTwo3, TimetableMapper.SetValueForLineTwoText, TimetableMapper.SetValueForLineTwoColor);
            SetCell(lblLineTwo4, TimetableMapper.SetValueForLineTwoText, TimetableMapper.SetValueForLineTwoColor);

            //line 3
            SetCell(lblLineThree1, TimetableMapper.SetValueForLineThreeText, TimetableMapper.SetValueForLineThreeColor);
            SetCell(lblLineThree2, TimetableMapper.SetValueForLineThreeText, TimetableMapper.SetValueForLineThreeColor);
            SetCell(lblLineThree3, TimetableMapper.SetValueForLineThreeText, TimetableMapper.SetValueForLineThreeColor);
            SetCell(lblLineThree4, TimetableMapper.SetValueForLineThreeText, TimetableMapper.SetValueForLineThreeColor);

            //line four
            SetCell(lblLineFour1, TimetableMapper.SetValueForLineFourText, TimetableMapper.SetValueForLineFourColor);
            SetCell(lblLineFour2, TimetableMapper.SetValueForLineFourText, TimetableMapper.SetValueForLineFourColor);
            SetCell(lblLineFour3, TimetableMapper.SetValueForLineFourText, TimetableMapper.SetValueForLineFourColor);
            SetCell(lblLineFour4, TimetableMapper.SetValueForLineFourText, TimetableMapper.SetValueForLineFourColor);

            //line five
            SetCell(lblLineFive1, TimetableMapper.SetValueForLineFiveText, TimetableMapper.SetValueForLineFiveColor);
            SetCell(lblLineFive2, TimetableMapper.SetValueForLineFiveText, TimetableMapper.SetValueForLineFiveColor);
            SetCell(lblLineFive3, TimetableMapper.SetValueForLineFiveText, TimetableMapper.SetValueForLineFiveColor);
            SetCell(lblLineFive4, TimetableMapper.SetValueForLineFiveText, TimetableMapper.SetValueForLineFiveColor);

            //line six
            SetCell(lblLineSix1, TimetableMapper.SetValueForLineSixText, TimetableMapper.SetValueForLineSixColor);
            SetCell(lblLineSix2, TimetableMapper.SetValueForLineSixText, TimetableMapper.SetValueForLineSixColor);
            SetCell(lblLineSix3, TimetableMapper.SetValueForLineSixText, TimetableMapper.SetValueForLineSixColor);
            SetCell(lblLineSix4, TimetableMapper.SetValueForLineSixText, TimetableMapper.SetValueForLineSixColor);

            //if the background is dark, foreground is white
            System.Drawing.Color col1 = System.Drawing.ColorTranslator.FromHtml(System.Drawing.ColorTranslator.ToHtml(lblLineOne1.BackColor));
            if (col1.R * 0.2126 + col1.G * 0.7152 + col1.B * 0.0722 > 255 / 7)
            {
                //dark colour
                lblLineOne1.ForeColor = System.Drawing.Color.Black;
                lblLineOne2.ForeColor = System.Drawing.Color.Black;
                lblLineOne3.ForeColor = System.Drawing.Color.Black;
                lblLineOne4.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                //light colour
                lblLineOne1.ForeColor = System.Drawing.Color.White;
                lblLineOne2.ForeColor = System.Drawing.Color.White;
                lblLineOne3.ForeColor = System.Drawing.Color.White;
                lblLineOne4.ForeColor = System.Drawing.Color.White;
            }

            System.Drawing.Color col2 = System.Drawing.ColorTranslator.FromHtml(System.Drawing.ColorTranslator.ToHtml(lblLineTwo1.BackColor));
            if (col2.R * 0.2126 + col2.G * 0.7152 + col2.B * 0.0722 > 255 / 7)
            {
                //dark colour
                lblLineTwo1.ForeColor = System.Drawing.Color.Black;
                lblLineTwo2.ForeColor = System.Drawing.Color.Black;
                lblLineTwo3.ForeColor = System.Drawing.Color.Black;
                lblLineTwo4.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                //light colour
                lblLineTwo1.ForeColor = System.Drawing.Color.White;
                lblLineTwo2.ForeColor = System.Drawing.Color.White;
                lblLineTwo3.ForeColor = System.Drawing.Color.White;
                lblLineTwo4.ForeColor = System.Drawing.Color.White;
            }

            System.Drawing.Color col3 = System.Drawing.ColorTranslator.FromHtml(System.Drawing.ColorTranslator.ToHtml(lblLineThree1.BackColor));
            if (col3.R * 0.2126 + col3.G * 0.7152 + col3.B * 0.0722 > 255 / 7)
            {
                //dark colour
                lblLineThree1.ForeColor = System.Drawing.Color.Black;
                lblLineThree2.ForeColor = System.Drawing.Color.Black;
                lblLineThree3.ForeColor = System.Drawing.Color.Black;
                lblLineThree4.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                //light colour
                lblLineThree1.ForeColor = System.Drawing.Color.White;
                lblLineThree2.ForeColor = System.Drawing.Color.White;
                lblLineThree3.ForeColor = System.Drawing.Color.White;
                lblLineThree4.ForeColor = System.Drawing.Color.White;
            }

            System.Drawing.Color col4 = System.Drawing.ColorTranslator.FromHtml(System.Drawing.ColorTranslator.ToHtml(lblLineFour1.BackColor));
            if (col4.R * 0.2126 + col4.G * 0.7152 + col4.B * 0.0722 > 255 / 7)
            {
                //dark colour
                lblLineFour1.ForeColor = System.Drawing.Color.Black;
                lblLineFour2.ForeColor = System.Drawing.Color.Black;
                lblLineFour3.ForeColor = System.Drawing.Color.Black;
                lblLineFour4.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                //light colour
                lblLineFour1.ForeColor = System.Drawing.Color.White;
                lblLineFour2.ForeColor = System.Drawing.Color.White;
                lblLineFour3.ForeColor = System.Drawing.Color.White;
                lblLineFour4.ForeColor = System.Drawing.Color.White;
            }

            System.Drawing.Color col5 = System.Drawing.ColorTranslator.FromHtml(System.Drawing.ColorTranslator.ToHtml(lblLineFive1.BackColor));
            if (col5.R * 0.2126 + col5.G * 0.7152 + col5.B * 0.0722 > 255 / 7)
            {
                //dark colour
                lblLineFive1.ForeColor = System.Drawing.Color.Black;
                lblLineFive2.ForeColor = System.Drawing.Color.Black;
                lblLineFive3.ForeColor = System.Drawing.Color.Black;
                lblLineFive4.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                //light colour
                lblLineFive1.ForeColor = System.Drawing.Color.White;
                lblLineFive2.ForeColor = System.Drawing.Color.White;
                lblLineFive3.ForeColor = System.Drawing.Color.White;
                lblLineFive4.ForeColor = System.Drawing.Color.White;
            }

            System.Drawing.Color col6 = System.Drawing.ColorTranslator.FromHtml(System.Drawing.ColorTranslator.ToHtml(lblLineSix1.BackColor));
            if (col6.R * 0.2126 + col6.G * 0.7152 + col6.B * 0.0722 > 255 / 7)
            {
                //dark colour
                lblLineSix1.ForeColor = System.Drawing.Color.Black;
                lblLineSix2.ForeColor = System.Drawing.Color.Black;
                lblLineSix3.ForeColor = System.Drawing.Color.Black;
                lblLineSix4.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                //light colour
                lblLineSix1.ForeColor = System.Drawing.Color.White;
                lblLineSix2.ForeColor = System.Drawing.Color.White;
                lblLineSix3.ForeColor = System.Drawing.Color.White;
                lblLineSix4.ForeColor = System.Drawing.Color.White;
            }

            //if there is no note, center the text
            if (TimetableMapper.SetValueForLineOneNote == "")
            {
                lblLineOne1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineOne2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineOne3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineOne4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            else
            {
                SetNote(lblLineOne1, lblLineOne2, lblLineOne3, lblLineOne4, TimetableMapper.SetValueForLineOneNote, "One");
            }
            if (TimetableMapper.SetValueForLineTwoNote == "")
            {
                lblLineTwo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineTwo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineTwo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineTwo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            else
            {
                SetNote(lblLineTwo1, lblLineTwo2, lblLineTwo3, lblLineTwo4, TimetableMapper.SetValueForLineTwoNote, "Two");
            }
            if (TimetableMapper.SetValueForLineThreeNote == "")
            {
                lblLineThree1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineThree2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineThree3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineThree4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            else
            {
                SetNote(lblLineThree1, lblLineThree2, lblLineThree3, lblLineThree4, TimetableMapper.SetValueForLineThreeNote, "Three");
            }
            if (TimetableMapper.SetValueForLineFourNote == "")
            {
                lblLineFour1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineFour2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineFour3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineFour4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            else
            {
                SetNote(lblLineFour1, lblLineFour2, lblLineFour3, lblLineFour4, TimetableMapper.SetValueForLineFourNote, "Four");
            }
            if (TimetableMapper.SetValueForLineFiveNote == "")
            {
                lblLineFive1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineFive2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineFive3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineFive4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            else
            {
                SetNote(lblLineFive1, lblLineFive2, lblLineFive3, lblLineFive4, TimetableMapper.SetValueForLineFiveNote, "Five");
            }
            if (TimetableMapper.SetValueForLineSixNote == "")
            {
                lblLineSix1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineSix2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineSix3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblLineSix4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            else
            {
                SetNote(lblLineSix1, lblLineSix2, lblLineSix3, lblLineSix4, TimetableMapper.SetValueForLineSixNote, "Six");
            }
        }

        private void SetNote(Label parentLabel1, Label parentLabel2, Label parentLabel3, Label parentLabel4, string text, string line)
        {
            //counts from zero
            int i = 0;
            
            var parentLabels = new List<Label>();
            parentLabels.Add(parentLabel1);
            parentLabels.Add(parentLabel2);
            parentLabels.Add(parentLabel3);
            parentLabels.Add(parentLabel4);

            while (i < 4)
            {
                var note = new Label
                {
                    Name = "note" + line + i,
                    AutoSize = false,
                    //Size = parentLabels[i].Size,
                    Width = parentLabels[i].Width,
                    Height = 19,
                    Location = new Point(parentLabels[i].Location.X, parentLabels[i].Location.Y + (parentLabels[i].Height - 17) - 2),
                    TextAlign = System.Drawing.ContentAlignment.MiddleRight,
                    Text = text,
                    ForeColor = System.Drawing.Color.Black,
                    BackColor = parentLabels[i].BackColor,
                    Parent = parentLabels[i],
                    Font = new Font(parentLabels[i].Font.Name, 10, FontStyle.Regular),
                };
                //note.Font. = 8;
                this.Controls.Add(note);
                note.BringToFront();
                i++;
            }

        }
    }
}
