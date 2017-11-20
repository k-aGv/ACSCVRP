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

    public partial class main_form : IMessageFilter {




        //function that calculates all the intermediate points between each turning point (or jumpPoint if you may)
        private void DrawPoints(GridLine x, int agv_index) {
            //think of the incoming GridLine as follows:
            //If you want to move from A to B, there might be an obstacle in the way, which must be bypassed
            //For this purpose, there must be found a point to break the final route into 2 smaller (let's say A->b + b->B (AB in total)
            //The incoming GridLine contains the pair of Coordinates for each one of the smaller routes
            //So, for our example, GridLine x containts the starting A(x,y) & b(x,y)
            //In a nutshell, this functions calculates all the child-steps of the parent-Line, determined by x.fromX,x.fromY and x.toX,x.toY


            //the parent-Line will finaly consist of many pairs of (x,y): e.g [X1,Y1 / X2,Y2 / X3,Y3 ... Xn,Yn]
            Point[] currentLinePoints;//1d array of points.used to track all the points of current line

            int x1 = x.fromX;
            int y1 = x.fromY;
            int x2 = x.toX;
            int y2 = x.toY;
            double distance = __f.GetLength(x1, y1, x2, y2); //function that returns the Euclidean distance between 2 points

            double side = __f.getSide(m_rectangles[0][0].height
                            , m_rectangles[0][0].height); //function that returns the hypotenuse of a GridBox

            int distanceBlocks = -1; //the quantity of blocks,matching the current line's length

            //Calculates the number of GridBoxes that the Line consists of. Calculation depends on 2 scenarios:
            //Scenario 1: Line is Diagonal
            //Scenario 2: Line is Straight
            if ((x1 < x2) && (y1 < y2)) //diagonal-right bottom direction
                distanceBlocks = Convert.ToInt32(distance / side);
            else if ((x1 < x2) && (y1 > y2)) //diagonal-right top direction
                distanceBlocks = Convert.ToInt32(distance / side);
            else if ((x1 > x2) && (y1 < y2)) //diagonal-left bottom direction
                distanceBlocks = Convert.ToInt32(distance / side);
            else if ((x1 > x2) && (y1 > y2)) //diagonal-left top direction
                distanceBlocks = Convert.ToInt32(distance / side);
            else if ((y1 == y2) || (x1 == x2)) //horizontal or vertical
                distanceBlocks = Convert.ToInt32(distance / m_rectangles[0][0].width);
            else
                MessageBox.Show(this, "Unexpected error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);


            currentLinePoints = new Point[distanceBlocks];
            double t;
            //here we calculate the X,Y coordinates of all the intermediate points
            for (int i = 0; i < distanceBlocks; i++) {
                calibrated = false;

                if (distance != 0) //obviously, distance cannot be zero
                    t = ((side) / distance);
                else
                    return;

                //these are the x,y coord that are calculated in every for-loop
                a = Convert.ToInt32(((1 - t) * x1) + (t * x2));
                b = Convert.ToInt32(((1 - t) * y1) + (t * y2));
                Point _p = new Point(a, b); //merges the calculated x,y into 1 Point variable

                for (int k = 0; k < Globals._WidthBlocks; k++)
                    for (int l = 0; l < Globals._HeightBlocks; l++)
                        if (m_rectangles[k][l].boxRec.Contains(_p)) { //this is how we assign the previously calculated pair of X,Y to a GridBox

                            //a smart way to handle GridBoxes from their center
                            int sideX = m_rectangles[k][l].boxRec.X + ((Globals._BlockSide / 2) - 1);
                            int sideY = m_rectangles[k][l].boxRec.Y + ((Globals._BlockSide / 2) - 1);
                            currentLinePoints[i].X = sideX;
                            currentLinePoints[i].Y = sideY;

                            if (dotsToolStripMenuItem.Checked) {
                                using (SolidBrush br = new SolidBrush(Color.BlueViolet))
                                    paper.FillEllipse(br, currentLinePoints[i].X - 3,
                                        currentLinePoints[i].Y - 3,
                                        5, 5);
                            }

                            using (Font stepFont = new Font("Tahoma", 8, FontStyle.Bold))//Font used for numbering the steps/current block)
                            {
                                using (SolidBrush fontBR = new SolidBrush(Color.FromArgb(53, 153, 153)))
                                    if (stepsToolStripMenuItem.Checked)
                                        paper.DrawString(AGVs[agv_index].StepsCounter + ""
                                        , stepFont
                                        , fontBR
                                        , currentLinePoints[i]);

                            }
                            calibrated = true;

                        }

                if (calibrated) { //for each one of the above calculations, we check if the calibration has been done correctly and, if so, each pair is inserted to the corresponding AGV's steps List 
                    AGVs[agv_index].Steps[AGVs[agv_index].StepsCounter].X = currentLinePoints[i].X;
                    AGVs[agv_index].Steps[AGVs[agv_index].StepsCounter].Y = currentLinePoints[i].Y;
                    AGVs[agv_index].StepsCounter++;
                }
                //initialize next steps.
                x1 = currentLinePoints[i].X;
                y1 = currentLinePoints[i].Y;
                distance = __f.GetLength(x1, y1, x2, y2);

            }


        }
    }
}