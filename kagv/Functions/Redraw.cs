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

    public partial class main_form {

        //Basic path planner function
        private void Redraw() {
            return;

            bool start_found = false;
            bool end_found = false;
            mapHasLoads = false;

            GridPos endPos = new GridPos();

            pos_index = 0;
            startPos = new List<GridPos>(); //list that will be filled with the starting points of every AGV
            AGVs = new List<Vehicle>();  //list that will be filled with objects of the class Vehicle
            loadPos = new List<GridPos>(); //list that will be filled with the points of every Load

            
            //Double FOR-loops to scan the whole Grid and perform the needed actions
            for (int i = 0; i < Globals._WidthBlocks; i++)
                for (int j = 0; j < Globals._HeightBlocks; j++) {

                    if (m_rectangles[i][j].boxType == BoxType.Wall)
                        searchGrid.SetWalkableAt(new GridPos(i, j), false);//Walls are marked as non-walkable
                    else
                        searchGrid.SetWalkableAt(new GridPos(i, j), true);//every other block is marked as walkable (for now)

                    if (m_rectangles[i][j].boxType == BoxType.Load) {
                        mapHasLoads = true;
                        searchGrid.SetWalkableAt(new GridPos(i, j), false); //marks every Load as non-walkable
                        isLoad[i, j] = 1; //considers every Load as available
                        loadPos.Add(new GridPos(i, j)); //inserts the coordinates of the Load inside a list
                    }
                    if (m_rectangles[i][j].boxType == BoxType.Normal)
                        m_rectangles[i][j].onHover(Globals.boxDefaultColor);

                    if (m_rectangles[i][j].boxType == BoxType.Start) {

                        if (beforeStart) {
                            searchGrid.SetWalkableAt(new GridPos(i, j), false); //initial starting points of AGV are non walkable until 1st run is completed
                        } else
                            searchGrid.SetWalkableAt(new GridPos(i, j), true);

                        start_found = true;

                        AGVs.Add(new Vehicle(this));
                        AGVs[pos_index].ID = pos_index;

                        startPos.Add(new GridPos(i, j)); //adds the starting coordinates of an AGV to the StartPos list

                        //a & b are used by DrawPoints() as the starting x,y for calculation purposes
                        a = startPos[pos_index].x;
                        b = startPos[pos_index].y;

                        if (pos_index < startPos.Count) {
                            startPos[pos_index] = new GridPos(startPos[pos_index].x, startPos[pos_index].y);
                            pos_index++;
                        }
                    }

                    if (m_rectangles[i][j].boxType == BoxType.End) {
                        end_found = true;
                        endPos.x = i;
                        endPos.y = j;
                    }
                }
                


            if (!start_found || !end_found)
                return; //will return if there are no starting or end points in the Grid


            pos_index = 0;

            if (AGVs != null)
                for (int i = 0; i < AGVs.Count(); i++)
                    if (AGVs[i] != null) {
                        AGVs[i].Status.Busy = false; //initialize the status of AGVs, as 'available'
                    }

            startPos = NotTrappedVehicles(startPos, endPos); //replaces the List with all the inserted AGVs
                                                             //with a new one containing the right ones
            if (mapHasLoads)
                KeepValidLoads(endPos); //calls a function that checks which Loads are available
                                        //to be picked up by AGVs and removed the trapped ones.


            //For-loop to repeat the path-finding process for ALL the AGVs that participate in the simulation
            for (int i = 0; i < startPos.Count; i++) {
                if (loadPos.Count != 0)
                    loadPos = CheckForTrappedLoads(loadPos, endPos);

                if (loadPos.Count == 0) {
                    mapHasLoads = false;
                    AGVs[i].HasLoadToPick = false;
                } else {
                    mapHasLoads = true;
                    AGVs[i].HasLoadToPick = true;
                }


                if (AGVs[i].Status.Busy == false) {
                    List<GridPos> JumpPointsList;
                    switch (mapHasLoads) {
                        case true:
                            //====create the path FROM START TO LOAD, if load exists=====
                            for (int m = 0; m < loadPos.Count; m++)
                                searchGrid.SetWalkableAt(loadPos[m], false); //Do not allow walk over any other load except the targeted one
                            searchGrid.SetWalkableAt(loadPos[0], true);

                            //use of the A* alorithms to find the path between AGV and its marked Load
                            jumpParam.Reset(startPos[pos_index], loadPos[0]);
                            JumpPointsList = AStarFinder.FindPath(jumpParam, nud_weight.Value);
                            AGVs[i].JumpPoints = JumpPointsList;
                            AGVs[i].Status.Busy = true;
                            //====create the path FROM START TO LOAD, if load exists=====

                            //======FROM LOAD TO END======
                            for (int m = 0; m < loadPos.Count; m++)
                                searchGrid.SetWalkableAt(loadPos[m], false);
                            jumpParam.Reset(loadPos[0], endPos);
                            JumpPointsList = AStarFinder.FindPath(jumpParam, nud_weight.Value);
                            AGVs[i].JumpPoints.AddRange(JumpPointsList);

                            //marks the load that each AGV picks up on the 1st route, as 3, so each agv knows where to go after delivering the 1st load
                            isLoad[loadPos[0].x, loadPos[0].y] = 3;
                            AGVs[i].MarkedLoad = new Point(loadPos[0].x, loadPos[0].y);

                            loadPos.Remove(loadPos[0]);
                            //======FROM LOAD TO END======
                            break;
                        case false:
                            jumpParam.Reset(startPos[pos_index], endPos);
                            JumpPointsList = AStarFinder.FindPath(jumpParam, nud_weight.Value);

                            AGVs[i].JumpPoints = JumpPointsList;
                            break;
                    }
                }
                pos_index++;
            }

            int c = 0;
            for (int i = 0; i < startPos.Count; i++)
                c += AGVs[i].JumpPoints.Count;


            for (int i = 0; i < startPos.Count; i++)
                for (int j = 0; j < AGVs[i].JumpPoints.Count - 1; j++) {
                    GridLine line = new GridLine
                        (
                        m_rectangles[AGVs[i].JumpPoints[j].x][AGVs[i].JumpPoints[j].y],
                        m_rectangles[AGVs[i].JumpPoints[j + 1].x][AGVs[i].JumpPoints[j + 1].y]
                        );

                    AGVs[i].Paths[j] = line;
                }

            for (int i = 0; i < startPos.Count; i++)
                if ((c - 1) > 0)
                    Array.Resize(ref AGVs[i].Paths, c - 1); //resize of the AGVs steps Table

            Invalidate();
        }

    }
}