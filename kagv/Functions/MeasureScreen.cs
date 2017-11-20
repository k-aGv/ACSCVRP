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

using System.Windows.Forms;
using System.Drawing;

namespace kagv {

    public partial class main_form {

        private void MeasureScreen() {
            Screen s = Screen.FromPoint(new Point(Cursor.Position.X, Cursor.Position.Y));
            int BoardersWidth = 2 * SystemInformation.Border3DSize.Width;

            Location = s.Bounds.Location;

            int usableSize = s.WorkingArea.Height - menuPanel.Height - Globals._BottomBarOffset - Globals._TopBarOffset;
            Globals._HeightBlocks = usableSize / Globals._BlockSide;

            usableSize = s.WorkingArea.Width - BoardersWidth;
            Globals._WidthBlocks = usableSize / Globals._BlockSide;


        }

    }
}