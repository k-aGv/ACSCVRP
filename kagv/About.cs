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

using System.IO;

namespace kagv {
    public partial class About : Form {
        public About() {
            InitializeComponent();
        }

        private Image _getEmbedResource(string a) {
            System.Reflection.Assembly _assembly;
            Stream _myStream;
            _assembly = System.Reflection.Assembly.GetExecutingAssembly();


            _myStream = _assembly.GetManifestResourceStream("kagv.Resources." + a);
            Image _b = Image.FromStream(_myStream);
            return _b;
        }

        private void About_Load(object sender, EventArgs e) {
            this.CenterToScreen();
            pb.Image = _getEmbedResource("LASCM.png");
            pb_divider.Image = _getEmbedResource("divider.png");
            pb_divider2.Image = _getEmbedResource("divider.png");

        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("http://lascm.meng.auth.gr/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/k-aGv");
        }
    }
}
