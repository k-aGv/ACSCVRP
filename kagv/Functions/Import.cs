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
using System.IO;

namespace kagv {

    public partial class main_form {

        //Function for importing a map 
        private void Import() {
            MessageBox.Show("Not available yet");
            return;
            ofd_importmap.Filter = "kagv Map (*.kmap)|*.kmap";
            ofd_importmap.FileName = "";


            if (ofd_importmap.ShowDialog() == DialogResult.OK) {
                bool proceed = false;
                string _line = "";
                char[] sep = { ':', ' ' };

                StreamReader reader = new StreamReader(ofd_importmap.FileName);
                do {
                    _line = reader.ReadLine();
                    if (_line.Contains("Width blocks:") && _line.Contains("Height blocks:") && _line.Contains("BlockSide:"))
                        proceed = true;
                } while (!(_line.Contains("Width blocks:") && _line.Contains("Height blocks:") && _line.Contains("BlockSide:")) &&
                         !reader.EndOfStream);
                string[] _lineArray = _line.Split(sep);


                if (proceed) {

                    Globals._WidthBlocks = Convert.ToInt32(_lineArray[3]);
                    Globals._HeightBlocks = Convert.ToInt32(_lineArray[8]);
                    Globals._BlockSide = Convert.ToInt32(_lineArray[12]);

                    FullyRestore();

                    string[] words;
                    char[] delim = { ' ' };
                    reader.ReadLine();
                    importmap = new BoxType[Globals._WidthBlocks, Globals._HeightBlocks];
                    words = reader.ReadLine().Split(delim);

                    int starts_counter = 0;
                    for (int z = 0; z < importmap.GetLength(0); z++) {
                        int i = 0;
                        foreach (string _s in words)
                            if (i < importmap.GetLength(1)) {
                                if (_s == "Start") {
                                    importmap[z, i] = BoxType.Start;
                                    starts_counter++;
                                } else if (_s == "End")
                                    importmap[z, i] = BoxType.End;
                                else if (_s == "Normal")
                                    importmap[z, i] = BoxType.Normal;
                                else if (_s == "Wall")
                                    importmap[z, i] = BoxType.Wall;
                                else if (_s == "Load")
                                    importmap[z, i] = BoxType.Load;
                                i++;
                            }
                        if (z == importmap.GetLength(0) - 1) { } else
                            words = reader.ReadLine().Split(delim);
                    }
                    reader.Close();

                    nUD_AGVs.Value = starts_counter;
                    imported = true;
                    Initialization();
                    Redraw();
                    if (overImage) {
                        overImage = false;
                    }
                } else
                    MessageBox.Show(this, "You have chosen an incompatible file import.\r\nPlease try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
