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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            InitialiseCustomFonts();

            btnChangeLog.BackColor = ColorTranslator.FromHtml("#6cafbb");

            picChangeLog.Visible = false;
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

            btnChangeLog.Font = new Font(pfc.Families[0], 10);
        }

        private void btnChangeLog_Click(object sender, EventArgs e)
        {
            picChangeLog.Visible = true;
        }
    }
}
