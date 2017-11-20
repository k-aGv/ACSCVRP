/*!
The Apache License 2.0 License

Copyright (c) 2017 Dimitris Katikaridis <dkatikaridis@gmail.com>,Giannis Menekses <johnmenex@hotmail.com>,Dimitrios Poulimenos <dimitrios.poulimenos@gmail.com>

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
    public static class TwoOptSwap {
        public static int[] OptSwap(int[] TempTour, int i, int v) {
            int size = TempTour.Length;
            int[] newtour = new int[size];

            for (int j = 0; j <= i - 1; ++j) {
                newtour[j] = TempTour[j];
            }

            int eff = 0;
            for (int j = i; j <= v; ++j) {
                newtour[j] = TempTour[v - eff];
                eff++;
            }

            for (int j = v + 1; j < size; ++j) {
                newtour[j] = TempTour[j];

            }

            return newtour;
        }
    }
}
