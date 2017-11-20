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

using System.Drawing;

namespace kagv {

    public partial class main_form {

        //Function that validates the user's click 
        private bool Isvalid(Point _temp) {
            return true;
            //The function received the coordinates of the user's click.
            //Clicking anywhere but on the Grid itself, will cause a "false" return, preventing
            //the click from giving any results

            if (_temp.Y < menuPanel.Location.Y)
                return false;

            if (_temp.X > m_rectangles[Globals._WidthBlocks - 1][Globals._HeightBlocks - 1].boxRec.X + (Globals._BlockSide - 1)
            || _temp.Y > m_rectangles[Globals._WidthBlocks - 1][Globals._HeightBlocks - 1].boxRec.Y + (Globals._BlockSide - 1)) // 18 because its 20-boarder size
                return false;

            if (!m_rectangles[_temp.X / Globals._BlockSide][(_temp.Y - Globals._TopBarOffset) / Globals._BlockSide].boxRec.Contains(_temp))
                return false;

            return true;
        }
    }
}