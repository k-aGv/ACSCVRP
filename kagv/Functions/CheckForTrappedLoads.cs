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

        //function that scans and finds which loads are surrounded by other loads
        private List<GridPos> CheckForTrappedLoads(List<GridPos> pos, GridPos endPos) {
            int list_index = 0;

            for (int i = 0; i < pos.Count; i++) {
                searchGrid.SetWalkableAt(pos[i], false);
                isLoad[pos[i].x, pos[i].y] = 4;
            }

            //if the 1st AGV  cannot reach a Load, then that Load is  
            //removed from the loadPos and not considered as available - marked as "4"  (temporarily trapped)
            do {
                searchGrid.SetWalkableAt(new GridPos(pos[0].x, pos[0].y), true);
                jumpParam.Reset(pos[0], endPos);
                if (AStarFinder.FindPath(jumpParam, nud_weight.Value).Count == 0) {
                    searchGrid.SetWalkableAt(new GridPos(pos[0].x, pos[0].y), false);
                    pos.Remove(pos[0]); //load is removed from the List with available Loads

                } else {
                    isLoad[pos[0].x, pos[0].y] = 1; //otherwise, Load is marked as available
                    list_index = pos.Count;
                }
            } while (list_index < pos.Count);

            return pos;
        }
    }
}
