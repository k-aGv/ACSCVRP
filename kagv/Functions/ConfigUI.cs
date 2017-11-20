/*!
The Apache License 2.0 License

Copyright (c) 2017 Dimitris Katikaridis <dkatikaridis@gmail.com>,Giannis Menekses <johnmenex@hotmail.com>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace kagv {

    public partial class main_form {

        private void ConfigUI() {

            for (int i = 0; i < startPos.Count; i++) {
                AGVs[i] = new Vehicle(this);
                AGVs[i].ID = i;
            }

            int BoardersWidth = 2 * SystemInformation.Border3DSize.Width;
            Width = ((Globals._WidthBlocks ) * Globals._BlockSide) - BoardersWidth;
            Height = (Globals._HeightBlocks ) * Globals._BlockSide  ;
            Size = new Size(Width, Height + Globals._BottomBarOffset);

            

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;


            stepsToolStripMenuItem.Checked = false;
            linesToolStripMenuItem.Checked =
            dotsToolStripMenuItem.Checked =
            bordersToolStripMenuItem.Checked =
            aGVIndexToolStripMenuItem.Checked =
            highlightOverCurrentBoxToolStripMenuItem.Checked = true;

            rb_load.Checked = true;
            BackColor = Color.DarkGray;

            CenterToScreen();

            alwaysCrossMenu.Checked = alwaysCross;
            atLeastOneMenu.Checked = atLeastOneObstacle;
            neverCrossMenu.Checked = never;
            noObstaclesMenu.Checked = ifNoObstacles;

            manhattanToolStripMenuItem.Checked = true;

            //dynamically add the location of menupanel.
            //We have to do it dynamically because the forms size is always depended on PCs actual screen size
            menuPanel.Width = Width;
            menuPanel.Location = new Point(0, settings_menu.Height);
            panel_resize.Location = new Point(Width / 2 - (panel_resize.Width / 2), Height / 2 - menuPanel.Height);
            panel_resize.Visible = false;
            nud_side.BackColor = panel_resize.BackColor;

            nud_weight.Value = Convert.ToDecimal(Globals._AStarWeight);

            statusStrip1.BringToFront();

            tp = new ToolTip
            {

                AutomaticDelay = 0,
                ReshowDelay = 0,
                InitialDelay = 0,
                AutoPopDelay = 0,
                IsBalloon = true,
                ToolTipIcon = ToolTipIcon.Info,
                ToolTipTitle = "Grid Block Information",
            };

        }
    }
}