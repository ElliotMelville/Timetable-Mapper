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
    public partial class TimetableMapper : Form
    {
        public TimetableMapper()
        {
            InitializeComponent();
            InitialiseCustomFonts();

            picTitle.Parent = picForm;
            picTitle.Top = 0 - picTitle.Height;
            lblInfo.Left = picForm.Width;
            lblInfo.BackColor = ColorTranslator.FromHtml("#2e2a94");
            lblInfo.ForeColor = ColorTranslator.FromHtml("#a71a2a");

            btnMoreOptions.BackColor = ColorTranslator.FromHtml("#1c1c61");
            btnMap.BackColor = ColorTranslator.FromHtml("#1c1c61");
            btnRandomiseColours.BackColor = ColorTranslator.FromHtml("#1c1c61");

            lblLineOne.Parent = picForm;
            lblLineTwo.Parent = picForm;
            lblLineThree.Parent = picForm;
            lblLineFour.Parent = picForm;
            lblLineFive.Parent = picForm;
            lblLineSix.Parent = picForm;
        }

        public static string SetValueForLineOneText = "";
        public static Color SetValueForLineOneColor = System.Drawing.Color.Black;

        public static string SetValueForLineTwoText = "";
        public static Color SetValueForLineTwoColor = System.Drawing.Color.Black;

        public static string SetValueForLineThreeText = "";
        public static Color SetValueForLineThreeColor = System.Drawing.Color.Black;

        public static string SetValueForLineFourText = "";
        public static Color SetValueForLineFourColor = System.Drawing.Color.Black;

        public static string SetValueForLineFiveText = "";
        public static Color SetValueForLineFiveColor = System.Drawing.Color.Black;

        public static string SetValueForLineSixText = "";
        public static Color SetValueForLineSixColor = System.Drawing.Color.Black;

        public static string SetValueForLineOneNote = "";
        public static string SetValueForLineTwoNote = "";
        public static string SetValueForLineThreeNote = "";
        public static string SetValueForLineFourNote = "";
        public static string SetValueForLineFiveNote = "";
        public static string SetValueForLineSixNote = "";

        public static Font SetValueForCustomFont = null;

        //tmrTitle
        private void tmrAnimation_Tick_1(object sender, EventArgs e)
        {
            //drop-down title
            if (picTitle.Top < 0)
            {
                picTitle.Top += 10;
            }
            else
            {
                //slide-out information - grows and shrinks
                if (lblInfo.Left > 520)
                {
                    lblInfo.Left -= 10;
                }
                else
                {
                    tmrTitle.Enabled = false;
                }
            }
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            //color dialog default is black
            if(/*txtLineOne.Text == "" || txtLineTwo.Text == "" || txtLineThree.Text == "" || txtLineFour.Text == "" || txtLineFive.Text == "" || txtLineSix.Text == "" ||*/
                clrdLineOne.Color == System.Drawing.Color.Black || clrdLineTwo.Color == System.Drawing.Color.Black || clrdLineThree.Color == System.Drawing.Color.Black || clrdLineFour.Color == System.Drawing.Color.Black || clrdLineFive.Color == System.Drawing.Color.Black || clrdLineSix.Color == System.Drawing.Color.Black)
            {
                MessageBox.Show("Please select a colour for each line and ensure that the colour black has not been selected to continue. You can avoid this by selecting the black and white mode under more options.", "Insufficient information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //proceed

                //send text and colour values to Timetable form
                SetValueForLineOneText = txtLineOne.Text;
                SetValueForLineOneColor = clrdLineOne.Color;

                SetValueForLineTwoText = txtLineTwo.Text;
                SetValueForLineTwoColor = clrdLineTwo.Color;

                SetValueForLineThreeText = txtLineThree.Text;
                SetValueForLineThreeColor = clrdLineThree.Color;

                SetValueForLineFourText = txtLineFour.Text;
                SetValueForLineFourColor = clrdLineFour.Color;

                SetValueForLineFiveText = txtLineFive.Text;
                SetValueForLineFiveColor = clrdLineFive.Color;

                SetValueForLineSixText = txtLineSix.Text;
                SetValueForLineSixColor = clrdLineSix.Color;

                SetValueForLineOneNote = txtLineOneNote.Text;
                SetValueForLineTwoNote = txtLineTwoNote.Text;
                SetValueForLineThreeNote = txtLineThreeNote.Text;
                SetValueForLineFourNote = txtLineFourNote.Text;
                SetValueForLineFiveNote = txtLineFiveNote.Text;
                SetValueForLineSixNote = txtLineSixNote.Text;


                Timetable timetable = new Timetable();
                timetable.Show();
            }
        }

        //custom font
        private void InitialiseCustomFonts()
        {

            //Create your private font collection object.
            PrivateFontCollection pfc = new PrivateFontCollection();

            //Select your font from the resources.
            int fontLength = Properties.Resources.AndroidAssassin_grz1.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.AndroidAssassin_grz1;

            // create an unsafe memory block for the font data
            System.IntPtr data = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            System.Runtime.InteropServices.Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            btnLineOne.Font = new Font(pfc.Families[0], 8);
            btnLineTwo.Font = new Font(pfc.Families[0], 8);
            btnLineThree.Font = new Font(pfc.Families[0], 8);
            btnLineFour.Font = new Font(pfc.Families[0], 8);
            btnLineFive.Font = new Font(pfc.Families[0], 8);
            btnLineSix.Font = new Font(pfc.Families[0], 8);

            btnMap.Font = new Font(pfc.Families[0], 17);
            //btnMoreOptions.Font = new Font(pfc.Families[0], 13);
            btnRandomiseColours.Font = new Font(pfc.Families[0], 13);
            btnHelp.Font = new Font(pfc.Families[0], 8);
            lblInfo.Font = new Font(pfc.Families[0], 20);

            lblLineOne.Font = new Font(pfc.Families[0], 25);
            lblLineTwo.Font = new Font(pfc.Families[0], 25);
            lblLineThree.Font = new Font(pfc.Families[0], 25);
            lblLineFour.Font = new Font(pfc.Families[0], 25);
            lblLineFive.Font = new Font(pfc.Families[0], 25);
            lblLineSix.Font = new Font(pfc.Families[0], 25);

            SetValueForCustomFont = new Font(pfc.Families[0], 10);
        }

        private void btnLineOne_Click(object sender, EventArgs e)
        {
            if (clrdLineOne.ShowDialog() == DialogResult.OK)
            {
                btnLineOne.BackColor = clrdLineOne.Color;
            }
        }

        private void btnLineTwo_Click(object sender, EventArgs e)
        {
            if (clrdLineTwo.ShowDialog() == DialogResult.OK)
            {
                btnLineTwo.BackColor = clrdLineTwo.Color;
            }
        }

        private void btnLineThree_Click(object sender, EventArgs e)
        {
            if (clrdLineThree.ShowDialog() == DialogResult.OK)
            {
                btnLineThree.BackColor = clrdLineThree.Color;
            }
        }

        private void btnLineFour_Click(object sender, EventArgs e)
        {
            if (clrdLineFour.ShowDialog() == DialogResult.OK)
            {
                btnLineFour.BackColor = clrdLineFour.Color;
            }
        }

        private void btnLineFive_Click(object sender, EventArgs e)
        {
            if (clrdLineFive.ShowDialog() == DialogResult.OK)
            {
                btnLineFive.BackColor = clrdLineFive.Color;
            }
        }

        private void btnLineSix_Click(object sender, EventArgs e)
        {
            if (clrdLineSix.ShowDialog() == DialogResult.OK)
            {
                btnLineSix.BackColor = clrdLineSix.Color;
            }
        }

        private void btnRandomiseColours_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            var randomColours = new List<Color>();
            randomColours.Add(System.Drawing.Color.Red);
            randomColours.Add(System.Drawing.Color.SteelBlue);
            randomColours.Add(System.Drawing.Color.Yellow);
            randomColours.Add(System.Drawing.Color.Green);
            randomColours.Add(System.Drawing.Color.Teal);
            randomColours.Add(System.Drawing.Color.Orange);
            randomColours.Add(System.Drawing.Color.Maroon);
            randomColours.Add(System.Drawing.Color.LightBlue);
            randomColours.Add(System.Drawing.Color.Pink);
            randomColours.Add(System.Drawing.Color.Purple);
            randomColours.Add(System.Drawing.Color.PaleGreen);
            randomColours.Add(System.Drawing.Color.CornflowerBlue);

            var usedColours = new List<Color>();

            btnLineOne.BackColor = randomColours[random.Next(0, randomColours.Count)];
            clrdLineOne.Color = btnLineOne.BackColor;
            usedColours.Add(btnLineOne.BackColor);

            btnLineTwo.BackColor = randomColours[random.Next(0, randomColours.Count)];
            clrdLineTwo.Color = btnLineTwo.BackColor;
            while (true)
            {
                if (usedColours.Contains(btnLineTwo.BackColor))
                {
                    btnLineTwo.BackColor = randomColours[random.Next(0, randomColours.Count)];
                    clrdLineTwo.Color = btnLineTwo.BackColor;
                }
                else
                {
                    usedColours.Add(btnLineTwo.BackColor);
                    break;
                }
            }

            btnLineThree.BackColor = randomColours[random.Next(0, randomColours.Count)];
            clrdLineThree.Color = btnLineThree.BackColor;
            while (true)
            {
                if (usedColours.Contains(btnLineThree.BackColor))
                {
                    btnLineThree.BackColor = randomColours[random.Next(0, randomColours.Count)];
                    clrdLineThree.Color = btnLineThree.BackColor;
                }
                else
                {
                    usedColours.Add(btnLineThree.BackColor);
                    break;
                }
            }

            btnLineFour.BackColor = randomColours[random.Next(0, randomColours.Count)];
            clrdLineFour.Color = btnLineFour.BackColor;
            while (true)
            {
                if (usedColours.Contains(btnLineFour.BackColor))
                {
                    btnLineFour.BackColor = randomColours[random.Next(0, randomColours.Count)];
                    clrdLineFour.Color = btnLineFour.BackColor;
                }
                else
                {
                    usedColours.Add(btnLineFour.BackColor);
                    break;
                }
            }

            btnLineFive.BackColor = randomColours[random.Next(0, randomColours.Count)];
            clrdLineFive.Color = btnLineFive.BackColor;
            while (true)
            {
                if (usedColours.Contains(btnLineFive.BackColor))
                {
                    btnLineFive.BackColor = randomColours[random.Next(0, randomColours.Count)];
                    clrdLineFive.Color = btnLineFive.BackColor;
                }
                else
                {
                    usedColours.Add(btnLineFive.BackColor);
                    break;
                }
            }

            btnLineSix.BackColor = randomColours[random.Next(0, randomColours.Count)];
            clrdLineSix.Color = btnLineSix.BackColor;
            while (true)
            {
                if (usedColours.Contains(btnLineSix.BackColor))
                {
                    btnLineSix.BackColor = randomColours[random.Next(0, randomColours.Count)];
                    clrdLineSix.Color = btnLineSix.BackColor;
                }
                else
                {
                    usedColours.Add(btnLineSix.BackColor);
                    break;
                }
            }

        }

        public void SaveMoreOptions()
        {
            //update any options that may have changed

            //black and white mode
            if(MoreOptions.SetValueForBlackAndWhiteMode)
            {
                btnLineOne.Enabled = false;
            }
        }

        private void btnMoreOptions_Click_1(object sender, EventArgs e)
        {
            MoreOptions moreoptions = new MoreOptions();
            moreoptions.SetParentForm(this);
            moreoptions.Show();
        }
    }
}
