﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Timetable_Mapper
{
    public class HoverButton : Button
    {
        private int maximumGrowingSize = 60;
        [
        Description("The maximum size that the button will grow. (must be divisible by speed property)")
        ]
        public int MaximumGrowingSize
        {
            get
            {
                return maximumGrowingSize;
            }
            set
            {
                maximumGrowingSize = value;
            }
        }

        private int speed = 16;
        [
        Description("Amount that button will grow every millisecond. (must be even)")
        ]
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        Timer timer;

        int originalTop;
        int originalLeft;
        int originalHeight;
        int originalWidth;

        int hasGrownBy = 0;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.MouseLeave += new System.EventHandler(this.OnMouseLeave);

            this.originalTop = this.Top;
            this.originalLeft = this.Left;
            this.originalHeight = this.Height;
            this.originalWidth = this.Width;
        }

        protected void OnMouseEnter(object sender, EventArgs e)
        {
            this.timer = new Timer();
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);

            this.timer.Enabled = true;
        }

        protected void OnMouseLeave(object sender, EventArgs e)
        {
            this.timer.Enabled = false;

            this.Top = originalTop;
            this.Left = originalLeft;
            this.Height = originalHeight;
            this.Width = originalWidth;


            hasGrownBy = 0;
        }

        protected void OnTimerTick(object sender, EventArgs e)
        {
            if (hasGrownBy < maximumGrowingSize)
            {
                this.Height += speed;
                this.Top -= (speed / 2);

                this.Width += speed;
                this.Left -= (speed / 2);

                hasGrownBy += speed;
            }
        }


    }
}

