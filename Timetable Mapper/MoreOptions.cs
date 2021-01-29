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

            lblFont.Parent = picForm;
            lblColourPresets.Parent = picForm;
            chkBlackAndWhite.Parent = picForm;
            btnSave.Parent = picForm;

            btnSave.BackColor = ColorTranslator.FromHtml("#1c1c61");
        }

        public void SetParentForm(TimetableMapper form)
        {
            parentForm = form;
        }

        //setting up custom font
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

            lblFont.Font = new Font(pfc.Families[0], 10);
            lblColourPresets.Font = new Font(pfc.Families[0], 10);
            chkBlackAndWhite.Font = new Font(pfc.Families[0], 10);
            btnSave.Font = new Font(pfc.Families[0], 10);
        }

        bool isBlackAndWhite = false;
        public static bool SetValueForBlackAndWhiteMode = false;
        TimetableMapper parentForm;

        private void chkBlackAndWhite_CheckedChanged(object sender, EventArgs e)
        {
            isBlackAndWhite = chkBlackAndWhite.Checked;
            SetValueForBlackAndWhiteMode = isBlackAndWhite;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            parentForm.SaveMoreOptions();
        }
    }
}
