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
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace kagv {

    public partial class main_form  {


        //function that resets all of the used objects so they are ready for reuse, preventing memory leaks
        private void FullyRestore() {

            if (trappedStatus != null)
                Array.Clear(trappedStatus, 0, trappedStatus.GetLength(0));

            if (importmap != null) {
                Array.Clear(importmap, 0, importmap.GetLength(0));
                Array.Clear(importmap, 0, importmap.GetLength(1));
            }

            if (BackgroundImage != null)
                BackgroundImage = null;

            startPos = new List<GridPos>();
            selectedColor = Color.DarkGray;

            for (int i = 0; i < startPos.Count(); i++)
                AGVs[i].JumpPoints = new List<GridPos>();


            searchGrid = new StaticGrid(Globals._WidthBlocks, Globals._HeightBlocks);

            alwaysCross =
            aGVIndexToolStripMenuItem.Checked =
            beforeStart =
            allowHighlight = true;

            atLeastOneObstacle =
            ifNoObstacles =
            never =
            imported =
            calibrated =
            isMouseDown =
            mapHasLoads =
            overImage = false;

            menuPanel.Enabled = false;

            use_Halt = false;
            priorityRulesbetaToolStripMenuItem.Checked = false;

            importedLayout = null;
            jumpParam = null;
            paper = null;

            a
            = b
            = new int();


            AGVs = new List<Vehicle>();

            allowHighlight = true;
            highlightOverCurrentBoxToolStripMenuItem.Enabled = true;
            highlightOverCurrentBoxToolStripMenuItem.Checked = true;



            isLoad = new int[Globals._WidthBlocks, Globals._HeightBlocks];
            m_rectangles = new GridBox[Globals._WidthBlocks][];
            for (int widthTrav = 0; widthTrav < Globals._WidthBlocks; widthTrav++)
                m_rectangles[widthTrav] = new GridBox[Globals._HeightBlocks];

            //jagged array has to be resetted like this
            for (int i = 0; i < Globals._WidthBlocks; i++)
                for (int j = 0; j < Globals._HeightBlocks; j++)
                    m_rectangles[i][j] = new GridBox(i * Globals._BlockSide, j * Globals._BlockSide + Globals._TopBarOffset, BoxType.Normal);


            Initialization();

            main_form_Load(new object(), new EventArgs());

            for (int i = 0; i < AGVs.Count; i++)
                AGVs[i].Status.Busy = false;

            Globals._TimerStep = 0;

            nUD_AGVs.Value = AGVs.Count;

        }
    }
}