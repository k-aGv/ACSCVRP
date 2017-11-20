namespace kagv {
    partial class gmaps {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gmaps));
            this.refreshURL = new System.Windows.Forms.Timer(this.components);
            this.mymap = new GMap.NET.WindowsForms.GMapControl();
            this.gb_settings = new System.Windows.Forms.GroupBox();
            this.gb_preferences = new System.Windows.Forms.GroupBox();
            this.nud_opacity = new System.Windows.Forms.NumericUpDown();
            this.lb_opacity = new System.Windows.Forms.Label();
            this.btn_color = new System.Windows.Forms.Button();
            this.cb_wheel = new System.Windows.Forms.CheckBox();
            this.cb_cross = new System.Windows.Forms.CheckBox();
            this.gb_coords = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_provider = new System.Windows.Forms.GroupBox();
            this.cb_provider = new System.Windows.Forms.ComboBox();
            this.btn_rec = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.gb_settings.SuspendLayout();
            this.gb_preferences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_opacity)).BeginInit();
            this.gb_coords.SuspendLayout();
            this.gb_provider.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshURL
            // 
            this.refreshURL.Tick += new System.EventHandler(this.refreshURL_Tick);
            // 
            // mymap
            // 
            this.mymap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mymap.Bearing = 0F;
            this.mymap.CanDragMap = true;
            this.mymap.EmptyTileColor = System.Drawing.Color.LightSkyBlue;
            this.mymap.GrayScaleMode = false;
            this.mymap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mymap.LevelsKeepInMemmory = 5;
            this.mymap.Location = new System.Drawing.Point(12, 12);
            this.mymap.MarkersEnabled = true;
            this.mymap.MaxZoom = 2;
            this.mymap.MinZoom = 2;
            this.mymap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mymap.Name = "mymap";
            this.mymap.NegativeMode = false;
            this.mymap.PolygonsEnabled = true;
            this.mymap.RetryLoadTile = 0;
            this.mymap.RoutesEnabled = true;
            this.mymap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mymap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mymap.ShowTileGridLines = false;
            this.mymap.Size = new System.Drawing.Size(877, 624);
            this.mymap.TabIndex = 3;
            this.mymap.Zoom = 0D;
            this.mymap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mymap_MouseClick);
            this.mymap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mymap_MouseMove);
            // 
            // gb_settings
            // 
            this.gb_settings.Controls.Add(this.gb_preferences);
            this.gb_settings.Controls.Add(this.gb_coords);
            this.gb_settings.Controls.Add(this.gb_provider);
            this.gb_settings.Controls.Add(this.btn_rec);
            this.gb_settings.Location = new System.Drawing.Point(895, 12);
            this.gb_settings.Name = "gb_settings";
            this.gb_settings.Size = new System.Drawing.Size(167, 562);
            this.gb_settings.TabIndex = 4;
            this.gb_settings.TabStop = false;
            this.gb_settings.Text = "Settings";
            // 
            // gb_preferences
            // 
            this.gb_preferences.Controls.Add(this.nud_opacity);
            this.gb_preferences.Controls.Add(this.lb_opacity);
            this.gb_preferences.Controls.Add(this.btn_color);
            this.gb_preferences.Controls.Add(this.cb_wheel);
            this.gb_preferences.Controls.Add(this.cb_cross);
            this.gb_preferences.Location = new System.Drawing.Point(6, 423);
            this.gb_preferences.Name = "gb_preferences";
            this.gb_preferences.Size = new System.Drawing.Size(148, 125);
            this.gb_preferences.TabIndex = 7;
            this.gb_preferences.TabStop = false;
            this.gb_preferences.Text = "Preferences";
            // 
            // nud_opacity
            // 
            this.nud_opacity.Location = new System.Drawing.Point(65, 98);
            this.nud_opacity.Name = "nud_opacity";
            this.nud_opacity.Size = new System.Drawing.Size(77, 20);
            this.nud_opacity.TabIndex = 6;
            this.nud_opacity.ValueChanged += new System.EventHandler(this.nud_opacity_ValueChanged);
            // 
            // lb_opacity
            // 
            this.lb_opacity.AutoSize = true;
            this.lb_opacity.Location = new System.Drawing.Point(6, 100);
            this.lb_opacity.Name = "lb_opacity";
            this.lb_opacity.Size = new System.Drawing.Size(43, 13);
            this.lb_opacity.TabIndex = 5;
            this.lb_opacity.Text = "Opacity";
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(7, 67);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(135, 23);
            this.btn_color.TabIndex = 4;
            this.btn_color.Text = "Rectangle Color";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // cb_wheel
            // 
            this.cb_wheel.AutoSize = true;
            this.cb_wheel.Checked = true;
            this.cb_wheel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_wheel.Location = new System.Drawing.Point(9, 43);
            this.cb_wheel.Name = "cb_wheel";
            this.cb_wheel.Size = new System.Drawing.Size(106, 17);
            this.cb_wheel.TabIndex = 3;
            this.cb_wheel.Text = "Reversed Wheel";
            this.cb_wheel.UseVisualStyleBackColor = true;
            this.cb_wheel.CheckedChanged += new System.EventHandler(this.cb_wheel_CheckedChanged);
            // 
            // cb_cross
            // 
            this.cb_cross.AutoSize = true;
            this.cb_cross.Checked = true;
            this.cb_cross.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_cross.Location = new System.Drawing.Point(9, 19);
            this.cb_cross.Name = "cb_cross";
            this.cb_cross.Size = new System.Drawing.Size(82, 17);
            this.cb_cross.TabIndex = 2;
            this.cb_cross.Text = "Show Cross";
            this.cb_cross.UseVisualStyleBackColor = true;
            this.cb_cross.CheckedChanged += new System.EventHandler(this.cb_cross_CheckedChanged);
            // 
            // gb_coords
            // 
            this.gb_coords.Controls.Add(this.label6);
            this.gb_coords.Controls.Add(this.label5);
            this.gb_coords.Controls.Add(this.label4);
            this.gb_coords.Controls.Add(this.label3);
            this.gb_coords.Controls.Add(this.label2);
            this.gb_coords.Location = new System.Drawing.Point(6, 141);
            this.gb_coords.Name = "gb_coords";
            this.gb_coords.Size = new System.Drawing.Size(148, 276);
            this.gb_coords.TabIndex = 6;
            this.gb_coords.TabStop = false;
            this.gb_coords.Text = "Coordinates";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // gb_provider
            // 
            this.gb_provider.Controls.Add(this.cb_provider);
            this.gb_provider.Location = new System.Drawing.Point(6, 78);
            this.gb_provider.Name = "gb_provider";
            this.gb_provider.Size = new System.Drawing.Size(154, 57);
            this.gb_provider.TabIndex = 5;
            this.gb_provider.TabStop = false;
            this.gb_provider.Text = "Map provider";
            // 
            // cb_provider
            // 
            this.cb_provider.FormattingEnabled = true;
            this.cb_provider.Location = new System.Drawing.Point(6, 19);
            this.cb_provider.Name = "cb_provider";
            this.cb_provider.Size = new System.Drawing.Size(142, 21);
            this.cb_provider.TabIndex = 4;
            this.cb_provider.SelectedIndexChanged += new System.EventHandler(this.cb_provider_SelectedIndexChanged);
            // 
            // btn_rec
            // 
            this.btn_rec.Location = new System.Drawing.Point(6, 19);
            this.btn_rec.Name = "btn_rec";
            this.btn_rec.Size = new System.Drawing.Size(154, 53);
            this.btn_rec.TabIndex = 3;
            this.btn_rec.Text = "Mark rectangle";
            this.btn_rec.UseVisualStyleBackColor = true;
            this.btn_rec.Click += new System.EventHandler(this.btn_marker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // gmaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_settings);
            this.Controls.Add(this.mymap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "gmaps";
            this.Text = "Google Maps implementation";
            this.Load += new System.EventHandler(this.gmaps_Load);
            this.gb_settings.ResumeLayout(false);
            this.gb_preferences.ResumeLayout(false);
            this.gb_preferences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_opacity)).EndInit();
            this.gb_coords.ResumeLayout(false);
            this.gb_coords.PerformLayout();
            this.gb_provider.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer refreshURL;
        public GMap.NET.WindowsForms.GMapControl mymap;//BE CAREFUL WITH THIS ONE
        private System.Windows.Forms.GroupBox gb_settings;
        private System.Windows.Forms.CheckBox cb_cross;
        private System.Windows.Forms.Button btn_rec;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.GroupBox gb_provider;
        private System.Windows.Forms.ComboBox cb_provider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_coords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_preferences;
        private System.Windows.Forms.CheckBox cb_wheel;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.NumericUpDown nud_opacity;
        private System.Windows.Forms.Label lb_opacity;
    }
}