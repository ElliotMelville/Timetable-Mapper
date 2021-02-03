using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable_Mapper
{
    public partial class MoreOptions : Form
    {
        public MoreOptions()
        {
            InitializeComponent();
            InitialiseCustomFonts();
            LinePresetColours = new Color[6];

            lblFont.Parent = picForm;
            lblFontExample.Parent = picForm;
            lblColourPresets.Parent = picForm;
            chkBlackAndWhite.Parent = picForm;
            chkBold.Parent = picForm;
            chkItalic.Parent = picForm;
            btnSave.Parent = picForm;

            lblFontExample.Font = new Font("Arial", 12);
            btnSave.BackColor = ColorTranslator.FromHtml("#1c1c61");
        }

        public void SetParentForm(TimetableMapper form)
        {
            parentForm = form;
        }

        //setting up custom font
        PrivateFontCollection pfc;
        private void InitialiseCustomFonts()
        {
            //Create your private font collection object.
            pfc = new PrivateFontCollection();

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

            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(data);

            lblFont.Font = new Font(pfc.Families[0], 10);
            lblColourPresets.Font = new Font(pfc.Families[0], 7);
            chkBlackAndWhite.Font = new Font(pfc.Families[0], 10);
            chkBold.Font = new Font(pfc.Families[0], 10);
            chkItalic.Font = new Font(pfc.Families[0], 10);
            btnSave.Font = new Font(pfc.Families[0], 10);
        }

        bool isBlackAndWhite = false;
        public static bool SetValueForBlackAndWhiteMode = false;
        public static bool SetValueForPresetHasBeenUsed = false;

        public static Font SetValueForUsedFont = new Font("Arial", 12);
        public static Font SetValueForUsedFontStyle = new Font("Arial", 12);

        public Color[] LinePresetColours;

        TimetableMapper parentForm;
        
        //black and white mode
        private void chkBlackAndWhite_CheckedChanged(object sender, EventArgs e)
        {
            var colourPresets = new List<Button>();
            colourPresets.Add(btnPresetOne);
            colourPresets.Add(btnPresetTwo);
            colourPresets.Add(btnPresetThree);
            colourPresets.Add(btnPresetFour);
            colourPresets.Add(btnPresetFive);

            int i = 0;

            isBlackAndWhite = chkBlackAndWhite.Checked;
            SetValueForBlackAndWhiteMode = isBlackAndWhite;
            if (isBlackAndWhite)
            {
                while(i < colourPresets.Count)
                {
                    colourPresets[i].Enabled = false;
                    colourPresets[i].Image = Properties.Resources.ColourPalette_Disabled;

                    i++;
                }
            }
            else if (!isBlackAndWhite)
            {
                while (i < colourPresets.Count)
                {
                    colourPresets[i].Enabled = true;
                    
                    if(i == 0)
                    {
                        colourPresets[i].Image = Properties.Resources.Palette1;
                    }
                    else if (i == 1)
                    {
                        colourPresets[i].Image = Properties.Resources.Palette2;
                    }
                    else if (i == 2)
                    {
                        colourPresets[i].Image = Properties.Resources.Palette3;
                    }
                    else if (i == 3)
                    {
                        colourPresets[i].Image = Properties.Resources.Palette4;
                    }
                    else if (i == 4)
                    {
                        colourPresets[i].Image = Properties.Resources.Palette5;
                    }

                    i++;
                }
            }
            parentForm.SaveMoreOptions(this);
        }

        //preset colours
        private void RandomisePresetColours(Color colour1, Color colour2, Color colour3, Color colour4, Color colour5, Color colour6)
        {
            var colours = new List<Color>();
            colours.Add(colour1);
            colours.Add(colour2);
            colours.Add(colour3);
            colours.Add(colour4);
            colours.Add(colour5);
            colours.Add(colour6);

            Random random = new Random();

            Array.Clear(LinePresetColours, 0, LinePresetColours.Length);

            int i = 0;
            while (i < 6)
            {
                while (true)
                {
                    Color pickedColor = colours[random.Next(0, colours.Count)];
                    if (LinePresetColours.Contains(pickedColor))
                        continue;
                    LinePresetColours[i] = pickedColor;
                    break;
                }

                i++;
            }

            SetValueForPresetHasBeenUsed = true;
            parentForm.SaveMoreOptions(this);
        }

        private void btnPresetOne_Click(object sender, EventArgs e)
        {
            RandomisePresetColours(ColorTranslator.FromHtml("#4c5270"), ColorTranslator.FromHtml("#f875b3"), ColorTranslator.FromHtml("#36eee0"), ColorTranslator.FromHtml("#bcece0"), ColorTranslator.FromHtml("#df164d"), ColorTranslator.FromHtml("#9188de"));
        }
        private void btnPresetTwo_Click(object sender, EventArgs e)
        {
            RandomisePresetColours(ColorTranslator.FromHtml("#c3e0e5"), ColorTranslator.FromHtml("#274472"), ColorTranslator.FromHtml("#5885af"), ColorTranslator.FromHtml("#41729f"), ColorTranslator.FromHtml("#82aab2"), ColorTranslator.FromHtml("#483a93"));
        }
        private void btnPresetThree_Click(object sender, EventArgs e)
        {
            RandomisePresetColours(ColorTranslator.FromHtml("#ffaebc"), ColorTranslator.FromHtml("#a0e7e5"), ColorTranslator.FromHtml("#b4f8c8"), ColorTranslator.FromHtml("#fbe7c6"), ColorTranslator.FromHtml("#d1c6fb"), ColorTranslator.FromHtml("#c2d7d5"));
        }
        private void btnPresetFour_Click(object sender, EventArgs e)
        {
            RandomisePresetColours(ColorTranslator.FromHtml("#dc0303"), ColorTranslator.FromHtml("#f2d603"), ColorTranslator.FromHtml("#2476ce"), ColorTranslator.FromHtml("#e38537"), ColorTranslator.FromHtml("#35d93e"), ColorTranslator.FromHtml("#ea3ef5"));
        }
        private void btnPresetFive_Click(object sender, EventArgs e)
        {
            RandomisePresetColours(ColorTranslator.FromHtml("#4b8b04"), ColorTranslator.FromHtml("#4d8e97"), ColorTranslator.FromHtml("#81b622"), ColorTranslator.FromHtml("#3c540c"), ColorTranslator.FromHtml("#a3d6df"), ColorTranslator.FromHtml("#30aa98"));
        }

        //fonts
        private void lstFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateExampleLabel();
            SetValueForUsedFont = lblFontExample.Font;
            parentForm.SaveMoreOptions(this);
        }
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBold.Checked)
            {
                chkItalic.Checked = false;
                SetValueForUsedFontStyle = new Font("Arial", 12, FontStyle.Bold);
            }
            else
            {
                SetValueForUsedFontStyle = new Font("Arial", 12);
            }

            UpdateExampleLabel();
            parentForm.SaveMoreOptions(this);
        }
        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.Checked)
            {
                chkBold.Checked = false;
                SetValueForUsedFontStyle = new Font("Arial", 12, FontStyle.Italic);
            }
            else
            {
                SetValueForUsedFontStyle = new Font("Arial", 12);
            }

            UpdateExampleLabel();
            parentForm.SaveMoreOptions(this);
        }
        private void UpdateExampleLabel()
        {
            if (lstFonts.SelectedIndex == 0)
            {
                lblFontExample.Font = new Font("Arial", 12, SetValueForUsedFontStyle.Style);
            }
            else if (lstFonts.SelectedIndex == 1)
            {
                lblFontExample.Font = new Font("Comic Sans MS", 12, SetValueForUsedFontStyle.Style);
            }
            else if (lstFonts.SelectedIndex == 2)
            {
                lblFontExample.Font = new Font("Yu Gothic UI", 12, SetValueForUsedFontStyle.Style);
            }
            else if (lstFonts.SelectedIndex == 3)
            {
                lblFontExample.Font = new Font("Microsoft Himalaya", 12, SetValueForUsedFontStyle.Style);
            }
            else if (lstFonts.SelectedIndex == 4)
            {
                lblFontExample.Font = new Font("Segoe Script", 12, SetValueForUsedFontStyle.Style);
            }
            else if (lstFonts.SelectedIndex == 5)
            {
                lblFontExample.Font = new Font("Times New Roman", 12, SetValueForUsedFontStyle.Style);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            parentForm.SaveMoreOptions(this);
            this.Close();
        }

    }
}
