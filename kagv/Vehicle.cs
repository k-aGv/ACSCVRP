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
using System.Windows.Forms;
using System.Collections.Generic;

namespace kagv {

    class Vehicle {

        //****************************************
        //AGV Status
        internal class AGVStatus {
            public bool Busy { get; set; }
            public bool Loaded { get; set; }
        }

        private AGVStatus status = new AGVStatus();
        public AGVStatus Status
        {
            get { return this.status; }
        }
        //=========================================

        //*****************************************
        //AGV Steps
        internal class AGVSteps {
            public double X { get; set; }
            public double Y { get; set; }
        }

        private AGVSteps[] steps;
        public AGVSteps[] Steps
        {
            get { return this.steps; }
        }
        //=========================================
        //AGV Path
        public GridLine[] Paths = new GridLine[Globals._MaximumSteps];
        public Point Location;
        public Point MarkedLoad;

        //get-set is not a mandatory here
        public int ID = -1;
        public int LoadsDelivered = 0;

        private Point AgvLocation;
        private Form mirroredForm;

        public bool HasLoadToPick;

        //*****************************************
        //AGV JumpPoints
        private List<GridPos> jmp_pnts = new List<GridPos>();
        public List<GridPos> JumpPoints
        {
            get {
                return this.jmp_pnts;
            }
            set {
                this.jmp_pnts = value;
            }
        }
        //=========================================

        //*****************************************
        //AGV StepsCounter
        private int steps_counter;
        public int StepsCounter
        {
            get {
                return this.steps_counter;
            }
            set {
                this.steps_counter = value;
            }
        }
        //=========================================
        /// <summary>
        /// Returns the absolute Location of the Marked Load on the Grid
        /// </summary>
        /// <returns></returns>
        public Point GetMarkedLoad() {
            Point _p = new Point(
                (MarkedLoad.X * Globals._BlockSide) ,
                (MarkedLoad.Y * Globals._BlockSide) + Globals._TopBarOffset
                );
            return _p;
        }

        public Vehicle(Form handle) { //constructor
            mirroredForm = handle;
            this.status.Busy = false;
            this.status.Loaded = false;
            this.steps = new AGVSteps[Globals._MaximumSteps];
            for (int i = 0; i < steps.Length; i++) {
                steps[i] = new AGVSteps();
                steps[i].X = -1;
                steps[i].Y = -1;
            }
        }
        public void SetLocation(int X, int Y) {
            AgvLocation = new Point(X, Y);
            Location = AgvLocation;
        }
        public void SetLocation(Point loc) {
            AgvLocation = loc;
            Location = AgvLocation;
        }

        //AGVs[agv_index].SetLocation(stepx - ((Constants._BlockSide / 2) - 1) +1, stepy - ((Constants._BlockSide / 2) - 1) + 1); //this is how we move the AGV on the grid (Setlocation function)
        //                                                                     ^
        public Point GetLocation() { //has to be -1 to balance this            |   from functions.cs
            return new Point(AgvLocation.X - 1, AgvLocation.Y - 1);//          |  
        }


    }

}
