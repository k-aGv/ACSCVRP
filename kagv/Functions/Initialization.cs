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

        //Initializes all the objects in main_form
        private void Initialization() {

            int BoardersWidth = 2 * SystemInformation.Border3DSize.Width;

            if (Globals._FirstFormLoad) {
                if (File.Exists("info.txt")) {
                    StreamReader reader = new StreamReader("info.txt");
                    try {
                        Globals._WidthBlocks = Convert.ToInt32(reader.ReadLine());
                        Globals._HeightBlocks = Convert.ToInt32(reader.ReadLine());
                        Globals._BlockSide = Convert.ToInt32(reader.ReadLine());
                    } catch { MessageBox.Show("An error has occured while parsing the file to initialize form.\nPlease delete the file."); }
                    reader.Dispose();
                }
                Globals._FirstFormLoad = false;
            }


            isLoad = new int[Globals._WidthBlocks, Globals._HeightBlocks];
            //m_rectangels is an array of two 1d arrays
            //declares the length of the first 1d array
            m_rectangles = new GridBox[Globals._WidthBlocks][];


            for (int widthTrav = 0; widthTrav < Globals._WidthBlocks; widthTrav++) {
                //declares the length of the seconds 1d array
                m_rectangles[widthTrav] = new GridBox[Globals._HeightBlocks];
                for (int heightTrav = 0; heightTrav < Globals._HeightBlocks; heightTrav++) {

                    //dynamically add the gridboxes into the m_rectangles.
                    //size of the m_rectangels is constantly increasing (while adding
                    //the gridbox values) until size=height or size = width.
                    if (imported) { //this IF is executed as long as the user has imported a map of his choice
                        m_rectangles[widthTrav][heightTrav] = new GridBox((widthTrav * Globals._BlockSide)-BoardersWidth, heightTrav * Globals._BlockSide + Globals._TopBarOffset, importmap[widthTrav, heightTrav]);
                        if (importmap[widthTrav, heightTrav] == BoxType.Load) {
                            isLoad[widthTrav, heightTrav] = 1;
                        }
                    } else {
                        m_rectangles[widthTrav][heightTrav] = new GridBox((widthTrav * Globals._BlockSide)-BoardersWidth, heightTrav * Globals._BlockSide + Globals._TopBarOffset, BoxType.Normal);
                        isLoad[widthTrav, heightTrav] = 2;
                    }


                }
            }
            if (imported)
                imported = false;


            searchGrid = new StaticGrid(Globals._WidthBlocks, Globals._HeightBlocks);
            jumpParam = new AStarParam(searchGrid, Convert.ToSingle(Globals._AStarWeight));//Default value until user edit it
            jumpParam.SetHeuristic(HeuristicMode.MANHATTAN); //default value until user edit it

            ConfigUI();
        }
    }
}