/*!
The MIT License (MIT)

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

using GMap.NET;
using GMap.NET.WindowsForms;


namespace kagv {
    public partial class gmaps : Form {
        internal readonly GMapOverlay myobjects = new GMapOverlay("objects");

        public gmaps() {
            InitializeComponent();
        }

        public void ReloadMap() {
            gmaps_Load(new object(), new EventArgs());
        }
        private void gmaps_Load(object sender, EventArgs e) {
            //calculate margin
            int margin = mymap.Location.X + SystemInformation.Border3DSize.Width;

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            CenterToScreen();
            Screen s = Screen.FromControl(this);
            int usableSizeWidth = s.WorkingArea.Width;
            int usableSizeHeight = s.WorkingArea.Height;
            int BoardersWidth = 2 * SystemInformation.Border3DSize.Width;
            Location = new Point(s.WorkingArea.X, s.WorkingArea.Y);
            Size = new Size(usableSizeWidth, usableSizeHeight);


            gb_settings.Location = new Point(Size.Width - gb_settings.Width - BoardersWidth - margin, gb_settings.Location.Y);

            nud_opacity.Maximum = 255;
            nud_opacity.Minimum = 0;

            //map implementation
            //get title's bar size
            Rectangle screenRectangle = RectangleToScreen(ClientRectangle);
            int titleHeight = screenRectangle.Top - Top;

            mymap.Width = gb_settings.Location.X - margin;
            mymap.Height = Size.Height - margin - titleHeight - (2 * label1.Height);
            mymap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;//using it as FULL reference to have the complete list of providers
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            cb_provider.Items.Add("GoogleMapProvider");
            cb_provider.Items.Add("GoogleTerrainMapProvider");
            cb_provider.Items.Add("BingSatelliteMapProvider");
            cb_provider.Text = "GoogleMapProvider";

            mymap.SetPositionByKeywords("greece,thessaloniki");
            mymap.MinZoom = 0;
            mymap.MaxZoom = 18;
            mymap.Zoom = 8;
            mymap.Overlays.Add(myobjects);
            mymap.DragButton = MouseButtons.Left;
            mymap.InvertedMouseWheelZooming = false;
            cb_wheel.Checked = false;


            //its not a joke ->
            //____________________________________________________________________opacity______________R___________________________G_______________________B
            mymap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            nud_opacity.Value = 33;

            //resize GB ...just A E S T H I T I C 
            gb_settings.Size = new Size(gb_settings.Size.Width, mymap.Size.Height);
            //set the label to the bottom
            label1.Location = new Point(10, mymap.Location.X + mymap.Size.Height + 5);
        }


        
        private void cb_cross_CheckedChanged(object sender, EventArgs e) {
            mymap.ShowCenter = cb_cross.Checked;
            mymap.Refresh();
        }

        private void btn_marker_Click(object sender, EventArgs e) {
            if (btn_rec.Enabled) {
                btn_rec.Enabled = false;
            }
            Screenshot st = new Screenshot(this);
            st.Owner = this;
            st.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            mymap.Zoom += 1;
            mymap.Refresh();
        }

        private void mymap_MouseClick(object sender, MouseEventArgs e) {

        }

        private void cb_provider_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_provider.SelectedItem.ToString() == "GoogleTerrainMapProvider")
                mymap.MapProvider = GMap.NET.MapProviders.GoogleTerrainMapProvider.Instance;
            if (cb_provider.SelectedItem.ToString() == "GoogleMapProvider")
                mymap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            if (cb_provider.SelectedItem.ToString() == "BingSatelliteMapProvider")
                mymap.MapProvider = GMap.NET.MapProviders.BingSatelliteMapProvider.Instance;

            mymap.Refresh();
        }

        private void mymap_MouseMove(object sender, MouseEventArgs e) {
            //latitude = width
            //longitude = height
            //THERE IS A FUNCTION mymap.FromLatLngToLocal :D :D :D
            double remoteLat = mymap.FromLocalToLatLng(e.X, e.Y).Lat;
            double remoteLng = mymap.FromLocalToLatLng(e.X, e.Y).Lng;

            label1.Text = mymap.ViewArea + "";

            label2.Text = "Lat:\r\n" + mymap.Position.Lat + "";
            label3.Text = "Lng:\r\n" + mymap.Position.Lng + "";
            label4.Text = "WidthLng:\r\n" + mymap.ViewArea.WidthLng + "";
            label5.Text = "HeightLat:\r\n" + mymap.ViewArea.HeightLat + "";

            label6.Text = "Current coordinates:\r\n" + "X/Lat:" + remoteLat + "\r\n" + "Y/Lng:" + remoteLng;
        }

        private void cb_wheel_CheckedChanged(object sender, EventArgs e) {
            mymap.InvertedMouseWheelZooming = cb_wheel.Checked;
            mymap.Refresh();
        }

        private void btn_color_Click(object sender, EventArgs e) {
            if (cd.ShowDialog() == DialogResult.OK) {
                mymap.SelectedAreaFillColor = Color.FromArgb((int)nud_opacity.Value, cd.Color);

                mymap.Refresh();
            }
        }

        private void nud_opacity_ValueChanged(object sender, EventArgs e) {
            mymap.SelectedAreaFillColor = Color.FromArgb((int)nud_opacity.Value, mymap.SelectedAreaFillColor);
            mymap.Refresh();

        }

        private void refreshURL_Tick(object sender, EventArgs e) {

        }

        private void btn_refresh_Click(object sender, EventArgs e) {
           
            mymap.Refresh();
            if (!btn_rec.Enabled) btn_rec.Enabled = true;
            
        }
    }
}
