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
    public class GhostTextBox : TextBox
    {
        private string ghostText = "Ghost Text Box";
        [
        Description("Text that appears on text box in grey while unused")
        ]
        public string GhostText
        {
            get
            {
                return ghostText;
            }
            set
            {
                ghostText = value;
            }
        }

        bool isUsed = false;
        bool isGhostMode = true;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.GotFocus += new System.EventHandler(this.OnGotFocus);
            this.LostFocus += new System.EventHandler(this.OnLostFocus);
            this.Text = ghostText;
            this.ForeColor = System.Drawing.Color.Gray;
        }

        protected void OnGotFocus(object sender, EventArgs e)
        {
            if (!isUsed)
            {
                this.ForeColor = System.Drawing.Color.Black;
                this.Text = "";
                isGhostMode = false;
            }
            isUsed = true;
        }

        protected void OnLostFocus(object sender, EventArgs e)
        {
            if(this.Text == "")
            {
                this.Text = ghostText;
                this.ForeColor = System.Drawing.Color.Gray;
                isUsed = false;
                isGhostMode = true;
            }
        }

        public string GetText()
        {
            if (isGhostMode)
            {
                return "";
            }

            return this.Text;
        }
    }
}
