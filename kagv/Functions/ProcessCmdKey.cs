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
using System.Windows.Forms;

namespace kagv {

    public partial class main_form {

        //function for handling keystrokes and assigning specific actions to them
        protected override bool ProcessCmdKey(ref Message _msg, Keys _keyData) {
            bool emptymap = true;
            if (ModifierKeys.HasFlag(Keys.Control) && !holdCTRL) {



                for (int k = 0; k < Globals._WidthBlocks; k++) {
                    for (int l = 0; l < Globals._HeightBlocks; l++) {
                        if (m_rectangles[k][l].boxType != BoxType.Normal) {
                            emptymap = false;
                            break;
                        }
                    }
                    if (!emptymap) {
                        break;
                    }
                }

                if (!emptymap) {
                    DialogResult s = MessageBox.Show("Grid resize is only possible in an empty grid\nThe grid will be deleted.\nProceed?"
                                   , "Grid Resize triggered", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (s == DialogResult.Yes) {
                        holdCTRL = true;
                        UpdateGridStats();
                        toolStripStatusLabel1.Text = "Release CTRL to return...";
                        panel_resize.Visible = true;
                        FullyRestore();
                        return true;
                    } else return false;
                }

                if (overImage) {
                    DialogResult s = MessageBox.Show("Grid resize is only possible in an empty grid\nThe grid will be deleted.\nProceed?"
                                  , "Grid Resize triggered", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (s == DialogResult.Yes) {
                        holdCTRL = true;
                        UpdateGridStats();
                        toolStripStatusLabel1.Text = "Release CTRL to return...";
                        panel_resize.Visible = true;
                        overImage = false;
                        FullyRestore();
                        return true;
                    } else return false;
                } else {
                    holdCTRL = true;
                    UpdateGridStats();
                    toolStripStatusLabel1.Text = "Release CTRL to return...";
                    panel_resize.Visible = true;
                    return true;
                }

            }

            switch (_keyData) {
                case Keys.F5:
                    allToolStripMenuItem_Click(new object(), new EventArgs());
                    return true;
                default:
                    return false;
            }

        }
    }
}