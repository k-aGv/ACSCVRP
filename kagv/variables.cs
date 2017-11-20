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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kagv {

    public partial class main_form {

        //Handle our custom functions
        k_aGv_functions.Functions __f = new k_aGv_functions.Functions();

        //cells that represent Load can have 4 vallues:
        //available Load = 1
        //not a Load = 2
        //Marked by an AGV Load = 3
        //Temporarily trapped Load = 4
        int[,] isLoad; 

        BoxType[,] importmap;

        GridBox[][] m_rectangles;//2d jagged array. Contains grid information (coords of each box, boxtype, etc etc)  

        List<Vehicle> AGVs = new List<Vehicle>();
        List<GridPos> startPos = new List<GridPos>(); //Contains the coords of the Start boxes
        List<GridPos> loadPos;
        bool[] trappedStatus = new bool[5];


        int a; //temporary X.Used to calculate the remained length of current line
        int b; //temporary Y.Used to calculate the remained length of current line
        int pos_index = 0;
        BaseGrid searchGrid;
        AStarParam jumpParam;//custom jump method with its features exposed
        static Graphics paper;//main graphics for grid

        GridBox m_lastBoxSelect;
        BoxType m_lastBoxType = new BoxType();
        ToolTip tp;
       
        bool holdCTRL;
        bool use_Halt = false;
        bool overImage=false;
        bool imported;
        bool beforeStart = true;
        bool calibrated = false;//flag checking if current point is correctly callibrated in the middle of the rectangle
        bool isMouseDown = false;
        bool mapHasLoads = false;
        bool allowHighlight = true;

        bool alwaysCross = true;
        bool atLeastOneObstacle = false;
        bool ifNoObstacles = false;
        bool never = false;
       
        Color selectedColor = Color.DarkGray;
        
        Image importedLayout = null;
        Image importedImageFile;
        


    }
}
