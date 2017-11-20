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

namespace kagv {

    public partial class main_form {

        //function that determines which loads are valid to keep and which are not
        private void KeepValidLoads(GridPos EndPoint) {
            int list_index = 0;
            bool removed;
            for (int i = 0; i < loadPos.Count; i++)
                searchGrid.SetWalkableAt(loadPos[i], true); //assumes that all loads are walkable
                                                            //and only walls are in fact the only obstacles in the grid

            do {
                removed = false;
                jumpParam.Reset(loadPos[list_index], EndPoint); //tries to find path between each Load and the exit
                if (AStarFinder.FindPath(jumpParam, nud_weight.Value).Count == 0) //if no path is found
                {
                    isLoad[loadPos[list_index].x, loadPos[list_index].y] = 2; //mark the corresponding load as NOT available
                    loadPos.RemoveAt(list_index); //remove that load from the list
                    removed = true;
                }
                if (!removed) {
                    list_index++;
                }

            } while (list_index < loadPos.Count); //loop repeats untill all loads are checked

            if (loadPos.Count == 0)
                mapHasLoads = false;
        }
    }
}