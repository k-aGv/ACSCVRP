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


namespace kagv {

    public partial class main_form {

        //function that returns a list that contains the Available for action AGVs
        private List<GridPos> NotTrappedVehicles(List<GridPos> Vehicles, GridPos End) {
            //Vehicles is a list with all the AGVs that are inserted in the Grid by the user
            int list_index = 0;
            int trapped_index = 0;
            bool removed;

            //First, we must assume that ALL the AGVs are trapped and cannot move (trapped means they are prevented from reaching the END block)
            for (int i = 0; i < trappedStatus.Length; i++)
                trappedStatus[i] = true;

            do {
                removed = false;
                jumpParam.Reset(Vehicles[list_index], End); //we use the A* setting function and pass the 
                                                            //initial start point of every AGV and the final destination (end block)
                if (AStarFinder.FindPath(jumpParam, nud_weight.Value).Count == 0) //if the number of JumpPoints that is calculated is 0 (zero)
                {                                                          //it means that there was no path found
                    Vehicles.Remove(Vehicles[list_index]); //we removed, from the returning list, the AGV for which there was no path found
                    AGVs.Remove(AGVs[list_index]); //we remove the corresponding AGV from the public list that contains all the AGVs which will participate in the simulation
                    removed = true;
                } else
                    trappedStatus[trapped_index] = false; //since it's not trapped, we switch its state to false 

                if (!removed) {
                    AGVs[list_index].ID = list_index;
                    list_index++;
                }
                trapped_index++;
            }
            while (list_index < Vehicles.Count); //the above process will be repeated until all elements of the incoming List are parsed.
            return Vehicles; //list with NOT TRAPPED AGVs' starting points (trapped AGVs have been removed)


            //the point of this function is to consider every AGV as trap and then find out which AGVs
            //eventually, are not trapped and keep ONLY those ones.
        }

    }
}