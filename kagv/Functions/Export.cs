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
using System.IO;

namespace kagv {

    public partial class main_form {
        //Function for exporting the map
        private void Export() {

            int loads = 0;
            for (int i = 0; i < Globals._HeightBlocks; i++)
                for (int j = 0; j < Globals._WidthBlocks; j++)
                    if (m_rectangles[j][i].boxType == BoxType.Load)
                        loads++;

            if (loads == 0) {
                MessageBox.Show("No loads were found on the Grid.\nExported file was not created.");
                return;
            }

            sfd_exportmap.FileName = "";
            sfd_exportmap.Filter = "kagv Map (*.kmap)|*.kmap";

            if (sfd_exportmap.ShowDialog() == DialogResult.OK) {
                StreamWriter _writer = new StreamWriter(sfd_exportmap.FileName);
                for (int i = 0; i < Globals._HeightBlocks; i++)
                    for (int j = 0; j < Globals._WidthBlocks; j++)
                        if (m_rectangles[j][i].boxType == BoxType.Load) {
                            _writer.WriteLine(m_rectangles[j][i].x + "," + (this.Size.Height - m_rectangles[j][i].y));
                        }
                _writer.Close();
            } else
                return;
        }
    }
}