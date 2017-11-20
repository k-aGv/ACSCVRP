/*! 
@file GridBox.cs
@author Woong Gyu La a.k.a Chris. <juhgiyo@gmail.com>
		<http://github.com/juhgiyo/eppathfinding.cs>
@date July 16, 2013
@brief GridBox Interface
@version 2.0

@section LICENSE

The MIT License (MIT)

Copyright (c) 2013 Woong Gyu La <juhgiyo@gmail.com>
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

namespace kagv {
    enum BoxType { Start, End, Wall, Normal, Load };

    class GridBox : IDisposable {
        public int x, y, width, height;

        public Rectangle boxRec;
        public BoxType boxType;

        private Color myBrown = Color.FromArgb(138, 109, 86);
        private SolidBrush brush;
        public GridBox(int iX, int iY, BoxType iType) {
            x = iX;
            y = iY;
            boxType = iType;
            switch (iType) {
                case BoxType.Normal:
                    brush = Globals._SemiTransparency ? new SolidBrush(Globals.boxDefaultColor) : new SolidBrush(Color.WhiteSmoke);
                    break;
                case BoxType.End:
                    brush = new SolidBrush(Color.Red);
                    break;
                case BoxType.Start:
                    brush = new SolidBrush(Color.Green);
                    break;
                case BoxType.Wall:
                    brush = new SolidBrush(Color.Gray);
                    break;
                case BoxType.Load:
                    brush = new SolidBrush(myBrown);
                    break;

            }
            width = height = Globals._BlockSide -1;

            boxRec = new Rectangle(x, y, width, height);
        }

        public void DrawBox(Graphics iPaper, BoxType iType) {
            if (iType == boxType) {
                boxRec.X = x;
                boxRec.Y = y;
                iPaper.FillRectangle(brush, boxRec);
            }
        }

        public void onHover(Color c) {
            brush = new SolidBrush(c);
        }

        public void SwitchEnd_StartToNormal() {
            if (brush != null)
                brush.Dispose();
            brush = Globals._SemiTransparency ? new SolidBrush(Globals._SemiTransparent) : new SolidBrush(Color.WhiteSmoke);
            boxType = BoxType.Normal;

        }


        public void SetAsTargetted(Graphics iPaper) {
            iPaper.FillRectangle(new SolidBrush(Color.Orange), boxRec);
        }


        public void BeTransparent() {
            switch (boxType) {
                case BoxType.Normal:
                    brush = new SolidBrush(Color.Transparent);
                    break;
            }
        }

        public void BeVisible() {
            switch (boxType) {
                case BoxType.Normal:
                    brush = new SolidBrush(Globals.boxDefaultColor); 
                    //brush = new SolidBrush(Color.Transparent);
                    break;
                case BoxType.Wall:
                    if (brush != null)
                        brush.Dispose();
                    boxType = BoxType.Normal;
                    break;
            }
        }


        public void SwitchLoad() {
            switch (boxType) {
                case BoxType.Normal:
                    if (brush != null)
                        brush.Dispose();
                    brush = new SolidBrush(myBrown);
                    boxType = BoxType.Load;
                    break;
                case BoxType.Load:
                    if (brush != null)
                        brush.Dispose();

                    brush = new SolidBrush(Globals.boxDefaultColor);   
                    boxType = BoxType.Normal;
                    break;

            }
        }


        public void SwitchBox() {
            switch (boxType) {
                case BoxType.Normal:
                    if (brush != null)
                        brush.Dispose();
                    brush = new SolidBrush(Color.Gray);
                    boxType = BoxType.Wall;
                    break;
                case BoxType.Wall:
                    if (brush != null)
                        brush.Dispose();
                    brush = new SolidBrush(Globals.boxDefaultColor);
                    boxType = BoxType.Normal;
                    break;

            }
        }

        public void SetNormalBox() {
            if (brush != null)
                brush.Dispose();
            brush = new SolidBrush(Globals.boxDefaultColor);
            boxType = BoxType.Normal;
        }

        public void SetStartBox() {
            if (brush != null)
                brush.Dispose();
            brush = new SolidBrush(Color.Green);
            boxType = BoxType.Start;
        }

        public void SetEndBox() {
            if (brush != null)
                brush.Dispose();
            brush = new SolidBrush(Color.Red);
            boxType = BoxType.End;
        }


        public void Dispose() {
            if (brush != null)
                brush.Dispose();

        }
    }
}
