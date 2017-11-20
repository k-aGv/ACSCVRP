namespace kagv {
    partial class main_form {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.gb_settings = new System.Windows.Forms.GroupBox();
            this.gb_agvs = new System.Windows.Forms.GroupBox();
            this.nUD_AGVs = new System.Windows.Forms.NumericUpDown();
            this.rb_wall = new System.Windows.Forms.RadioButton();
            this.rb_start = new System.Windows.Forms.RadioButton();
            this.rb_stop = new System.Windows.Forms.RadioButton();
            this.rb_load = new System.Windows.Forms.RadioButton();
            this.gb_AStar = new System.Windows.Forms.GroupBox();
            this.nud_weight = new System.Windows.Forms.NumericUpDown();
            this.tp_info = new System.Windows.Forms.ToolTip(this.components);
            this.sfd_exportmap = new System.Windows.Forms.SaveFileDialog();
            this.ofd_importmap = new System.Windows.Forms.OpenFileDialog();
            this.ofd_importpic = new System.Windows.Forms.OpenFileDialog();
            this.settings_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importImageLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysCrossMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.neverCrossMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.noObstaclesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.atLeastOneMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.priorityRulesbetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heuristicModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manhattanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euclideanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chebyshevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highlightOverCurrentBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGVIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultGridSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.implementGoogleMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridBlockLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cd_grid = new System.Windows.Forms.ColorDialog();
            this.panel_resize = new System.Windows.Forms.Panel();
            this.lb_blockside = new System.Windows.Forms.Label();
            this.nud_side = new System.Windows.Forms.NumericUpDown();
            this.lb_height = new System.Windows.Forms.Label();
            this.lb_width = new System.Windows.Forms.Label();
            this.btn_rightup = new System.Windows.Forms.Button();
            this.btn_rightdown = new System.Windows.Forms.Button();
            this.btn_leftdown = new System.Windows.Forms.Button();
            this.btn_leftup = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_noSettings = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.gb_type.SuspendLayout();
            this.gb_settings.SuspendLayout();
            this.gb_agvs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_AGVs)).BeginInit();
            this.gb_AStar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_weight)).BeginInit();
            this.settings_menu.SuspendLayout();
            this.panel_resize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_side)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuPanel.Controls.Add(this.lb_noSettings);
            this.menuPanel.Controls.Add(this.gb_type);
            this.menuPanel.Controls.Add(this.gb_settings);
            this.menuPanel.Controls.Add(this.gb_AStar);
            this.menuPanel.Location = new System.Drawing.Point(12, 36);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(656, 75);
            this.menuPanel.TabIndex = 7;
            // 
            // gb_type
            // 
            this.gb_type.Controls.Add(this.cb_type);
            this.gb_type.Location = new System.Drawing.Point(226, 5);
            this.gb_type.Name = "gb_type";
            this.gb_type.Size = new System.Drawing.Size(68, 45);
            this.gb_type.TabIndex = 27;
            this.gb_type.TabStop = false;
            this.gb_type.Text = "Type";
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "LPG",
            "DSL",
            "ELE"});
            this.cb_type.Location = new System.Drawing.Point(7, 20);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(55, 21);
            this.cb_type.TabIndex = 0;
            this.cb_type.Text = "LPG";
            // 
            // gb_settings
            // 
            this.gb_settings.Controls.Add(this.gb_agvs);
            this.gb_settings.Controls.Add(this.rb_wall);
            this.gb_settings.Controls.Add(this.rb_start);
            this.gb_settings.Controls.Add(this.rb_stop);
            this.gb_settings.Controls.Add(this.rb_load);
            this.gb_settings.Location = new System.Drawing.Point(3, 5);
            this.gb_settings.Name = "gb_settings";
            this.gb_settings.Size = new System.Drawing.Size(216, 65);
            this.gb_settings.TabIndex = 25;
            this.gb_settings.TabStop = false;
            this.gb_settings.Text = "Settings";
            // 
            // gb_agvs
            // 
            this.gb_agvs.Controls.Add(this.nUD_AGVs);
            this.gb_agvs.Location = new System.Drawing.Point(145, 13);
            this.gb_agvs.Name = "gb_agvs";
            this.gb_agvs.Size = new System.Drawing.Size(65, 43);
            this.gb_agvs.TabIndex = 18;
            this.gb_agvs.TabStop = false;
            this.gb_agvs.Text = "AGVs";
            // 
            // nUD_AGVs
            // 
            this.nUD_AGVs.Location = new System.Drawing.Point(16, 17);
            this.nUD_AGVs.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_AGVs.Name = "nUD_AGVs";
            this.nUD_AGVs.Size = new System.Drawing.Size(30, 20);
            this.nUD_AGVs.TabIndex = 10;
            this.nUD_AGVs.ValueChanged += new System.EventHandler(this.nUD_AGVs_ValueChanged);
            // 
            // rb_wall
            // 
            this.rb_wall.AutoSize = true;
            this.rb_wall.Checked = true;
            this.rb_wall.Location = new System.Drawing.Point(9, 19);
            this.rb_wall.Name = "rb_wall";
            this.rb_wall.Size = new System.Drawing.Size(46, 17);
            this.rb_wall.TabIndex = 4;
            this.rb_wall.TabStop = true;
            this.rb_wall.Text = "Wall";
            this.rb_wall.UseVisualStyleBackColor = true;
            // 
            // rb_start
            // 
            this.rb_start.AutoSize = true;
            this.rb_start.Location = new System.Drawing.Point(91, 19);
            this.rb_start.Name = "rb_start";
            this.rb_start.Size = new System.Drawing.Size(47, 17);
            this.rb_start.TabIndex = 4;
            this.rb_start.Text = "Start";
            this.rb_start.UseVisualStyleBackColor = true;
            // 
            // rb_stop
            // 
            this.rb_stop.AutoSize = true;
            this.rb_stop.Location = new System.Drawing.Point(91, 42);
            this.rb_stop.Name = "rb_stop";
            this.rb_stop.Size = new System.Drawing.Size(47, 17);
            this.rb_stop.TabIndex = 4;
            this.rb_stop.Text = "Stop";
            this.rb_stop.UseVisualStyleBackColor = true;
            // 
            // rb_load
            // 
            this.rb_load.AutoSize = true;
            this.rb_load.Location = new System.Drawing.Point(9, 42);
            this.rb_load.Name = "rb_load";
            this.rb_load.Size = new System.Drawing.Size(49, 17);
            this.rb_load.TabIndex = 17;
            this.rb_load.Text = "Load";
            this.rb_load.UseVisualStyleBackColor = true;
            // 
            // gb_AStar
            // 
            this.gb_AStar.Controls.Add(this.nud_weight);
            this.gb_AStar.Location = new System.Drawing.Point(301, 5);
            this.gb_AStar.Name = "gb_AStar";
            this.gb_AStar.Size = new System.Drawing.Size(69, 45);
            this.gb_AStar.TabIndex = 29;
            this.gb_AStar.TabStop = false;
            this.gb_AStar.Text = "A* Weight";
            // 
            // nud_weight
            // 
            this.nud_weight.DecimalPlaces = 2;
            this.nud_weight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_weight.Location = new System.Drawing.Point(3, 20);
            this.nud_weight.Name = "nud_weight";
            this.nud_weight.Size = new System.Drawing.Size(64, 20);
            this.nud_weight.TabIndex = 28;
            this.nud_weight.ValueChanged += new System.EventHandler(this.nud_weight_ValueChanged);
            // 
            // ofd_importmap
            // 
            this.ofd_importmap.FileName = "openFileDialog1";
            // 
            // ofd_importpic
            // 
            this.ofd_importpic.FileName = "openFileDialog1";
            // 
            // settings_menu
            // 
            this.settings_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.antsToolStripMenuItem,
            this.aToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.settings_menu.Location = new System.Drawing.Point(0, 0);
            this.settings_menu.Name = "settings_menu";
            this.settings_menu.Size = new System.Drawing.Size(804, 24);
            this.settings_menu.TabIndex = 8;
            this.settings_menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importImageLayoutToolStripMenuItem,
            this.exportMapToolStripMenuItem,
            this.importMapToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "Map";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exportMapToolStripMenuItem
            // 
            this.exportMapToolStripMenuItem.Name = "exportMapToolStripMenuItem";
            this.exportMapToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.exportMapToolStripMenuItem.Text = "Export map to ACS compatible format";
            this.exportMapToolStripMenuItem.Click += new System.EventHandler(this.exportMapToolStripMenuItem_Click);
            // 
            // importMapToolStripMenuItem
            // 
            this.importMapToolStripMenuItem.Name = "importMapToolStripMenuItem";
            this.importMapToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.importMapToolStripMenuItem.Text = "Import map";
            this.importMapToolStripMenuItem.Click += new System.EventHandler(this.importMapToolStripMenuItem_Click);
            // 
            // importImageLayoutToolStripMenuItem
            // 
            this.importImageLayoutToolStripMenuItem.Name = "importImageLayoutToolStripMenuItem";
            this.importImageLayoutToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.importImageLayoutToolStripMenuItem.Text = "Import image layout";
            this.importImageLayoutToolStripMenuItem.Click += new System.EventHandler(this.importImageLayoutToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametresToolStripMenuItem,
            this.heuristicModeToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.aToolStripMenuItem.Text = "Algorithm";
            // 
            // parametresToolStripMenuItem
            // 
            this.parametresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysCrossMenu,
            this.neverCrossMenu,
            this.noObstaclesMenu,
            this.atLeastOneMenu,
            this.toolStripSeparator2,
            this.priorityRulesbetaToolStripMenuItem});
            this.parametresToolStripMenuItem.Name = "parametresToolStripMenuItem";
            this.parametresToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.parametresToolStripMenuItem.Text = "Parametres";
            // 
            // alwaysCrossMenu
            // 
            this.alwaysCrossMenu.Name = "alwaysCrossMenu";
            this.alwaysCrossMenu.Size = new System.Drawing.Size(299, 22);
            this.alwaysCrossMenu.Text = "Always cross corners";
            this.alwaysCrossMenu.Click += new System.EventHandler(this.useRecursiveToolStripMenuItem_Click);
            // 
            // neverCrossMenu
            // 
            this.neverCrossMenu.Name = "neverCrossMenu";
            this.neverCrossMenu.Size = new System.Drawing.Size(299, 22);
            this.neverCrossMenu.Text = "Never cross corners";
            this.neverCrossMenu.Click += new System.EventHandler(this.crossAdjacentPointToolStripMenuItem_Click);
            // 
            // noObstaclesMenu
            // 
            this.noObstaclesMenu.Name = "noObstaclesMenu";
            this.noObstaclesMenu.Size = new System.Drawing.Size(299, 22);
            this.noObstaclesMenu.Text = "Cross corner only when no obstacles";
            this.noObstaclesMenu.Click += new System.EventHandler(this.crossCornerOnlyWhenNoObstaclesToolStripMenuItem_Click);
            // 
            // atLeastOneMenu
            // 
            this.atLeastOneMenu.Name = "atLeastOneMenu";
            this.atLeastOneMenu.Size = new System.Drawing.Size(299, 22);
            this.atLeastOneMenu.Text = "Cross corner only if at least one is walkable";
            this.atLeastOneMenu.Click += new System.EventHandler(this.crossCornerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(296, 6);
            // 
            // priorityRulesbetaToolStripMenuItem
            // 
            this.priorityRulesbetaToolStripMenuItem.Name = "priorityRulesbetaToolStripMenuItem";
            this.priorityRulesbetaToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.priorityRulesbetaToolStripMenuItem.Text = "Priority rules (beta)";
            this.priorityRulesbetaToolStripMenuItem.Click += new System.EventHandler(this.priorityRulesbetaToolStripMenuItem_Click);
            // 
            // heuristicModeToolStripMenuItem
            // 
            this.heuristicModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manhattanToolStripMenuItem,
            this.euclideanToolStripMenuItem,
            this.chebyshevToolStripMenuItem});
            this.heuristicModeToolStripMenuItem.Name = "heuristicModeToolStripMenuItem";
            this.heuristicModeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.heuristicModeToolStripMenuItem.Text = "Heuristic Mode";
            // 
            // manhattanToolStripMenuItem
            // 
            this.manhattanToolStripMenuItem.Name = "manhattanToolStripMenuItem";
            this.manhattanToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.manhattanToolStripMenuItem.Text = "Manhattan";
            this.manhattanToolStripMenuItem.Click += new System.EventHandler(this.manhattanToolStripMenuItem_Click);
            // 
            // euclideanToolStripMenuItem
            // 
            this.euclideanToolStripMenuItem.Name = "euclideanToolStripMenuItem";
            this.euclideanToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.euclideanToolStripMenuItem.Text = "Euclidean";
            this.euclideanToolStripMenuItem.Click += new System.EventHandler(this.euclideanToolStripMenuItem_Click);
            // 
            // chebyshevToolStripMenuItem
            // 
            this.chebyshevToolStripMenuItem.Name = "chebyshevToolStripMenuItem";
            this.chebyshevToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.chebyshevToolStripMenuItem.Text = "Chebyshev";
            this.chebyshevToolStripMenuItem.Click += new System.EventHandler(this.chebyshevToolStripMenuItem_Click);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.implementGoogleMapsToolStripMenuItem,
            this.borderColorToolStripMenuItem,
            this.toolStripMenuItem2,
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.showToolStripMenuItem});
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.gridToolStripMenuItem.Text = "Grid";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stepsToolStripMenuItem,
            this.linesToolStripMenuItem,
            this.dotsToolStripMenuItem,
            this.bordersToolStripMenuItem,
            this.highlightOverCurrentBoxToolStripMenuItem,
            this.aGVIndexToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.showToolStripMenuItem.Text = "Show...";
            // 
            // stepsToolStripMenuItem
            // 
            this.stepsToolStripMenuItem.Name = "stepsToolStripMenuItem";
            this.stepsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.stepsToolStripMenuItem.Text = "...Steps";
            this.stepsToolStripMenuItem.Click += new System.EventHandler(this.stepsToolStripMenuItem_Click);
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.linesToolStripMenuItem.Text = "...Lines";
            this.linesToolStripMenuItem.Click += new System.EventHandler(this.stepsToolStripMenuItem_Click);
            // 
            // dotsToolStripMenuItem
            // 
            this.dotsToolStripMenuItem.Name = "dotsToolStripMenuItem";
            this.dotsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.dotsToolStripMenuItem.Text = "...Dots";
            this.dotsToolStripMenuItem.Click += new System.EventHandler(this.stepsToolStripMenuItem_Click);
            // 
            // bordersToolStripMenuItem
            // 
            this.bordersToolStripMenuItem.Name = "bordersToolStripMenuItem";
            this.bordersToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.bordersToolStripMenuItem.Text = "...Borders";
            this.bordersToolStripMenuItem.Click += new System.EventHandler(this.stepsToolStripMenuItem_Click);
            // 
            // highlightOverCurrentBoxToolStripMenuItem
            // 
            this.highlightOverCurrentBoxToolStripMenuItem.Name = "highlightOverCurrentBoxToolStripMenuItem";
            this.highlightOverCurrentBoxToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.highlightOverCurrentBoxToolStripMenuItem.Text = "...Highlight over current box";
            this.highlightOverCurrentBoxToolStripMenuItem.Click += new System.EventHandler(this.stepsToolStripMenuItem_Click);
            // 
            // aGVIndexToolStripMenuItem
            // 
            this.aGVIndexToolStripMenuItem.Name = "aGVIndexToolStripMenuItem";
            this.aGVIndexToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.aGVIndexToolStripMenuItem.Text = "...AGV index";
            this.aGVIndexToolStripMenuItem.Click += new System.EventHandler(this.stepsToolStripMenuItem_Click);
            // 
            // borderColorToolStripMenuItem
            // 
            this.borderColorToolStripMenuItem.Name = "borderColorToolStripMenuItem";
            this.borderColorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.borderColorToolStripMenuItem.Text = "Border Color";
            this.borderColorToolStripMenuItem.Click += new System.EventHandler(this.borderColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(202, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wallsToolStripMenuItem,
            this.allToolStripMenuItem,
            this.borderColorToolStripMenuItem1,
            this.defaultGridSizeToolStripMenuItem});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // wallsToolStripMenuItem
            // 
            this.wallsToolStripMenuItem.Name = "wallsToolStripMenuItem";
            this.wallsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.wallsToolStripMenuItem.Text = "Walls";
            this.wallsToolStripMenuItem.Click += new System.EventHandler(this.wallsToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.ShortcutKeyDisplayString = "(F5)";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // borderColorToolStripMenuItem1
            // 
            this.borderColorToolStripMenuItem1.Name = "borderColorToolStripMenuItem1";
            this.borderColorToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.borderColorToolStripMenuItem1.Text = "Border Color";
            this.borderColorToolStripMenuItem1.Click += new System.EventHandler(this.borderColorToolStripMenuItem1_Click);
            // 
            // defaultGridSizeToolStripMenuItem
            // 
            this.defaultGridSizeToolStripMenuItem.Name = "defaultGridSizeToolStripMenuItem";
            this.defaultGridSizeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.defaultGridSizeToolStripMenuItem.Text = "Default Grid size";
            this.defaultGridSizeToolStripMenuItem.Click += new System.EventHandler(this.defaultGridSizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // implementGoogleMapsToolStripMenuItem
            // 
            this.implementGoogleMapsToolStripMenuItem.Name = "implementGoogleMapsToolStripMenuItem";
            this.implementGoogleMapsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.implementGoogleMapsToolStripMenuItem.Text = "Implement Google Maps";
            this.implementGoogleMapsToolStripMenuItem.Click += new System.EventHandler(this.implementGoogleMapsToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGridBlockLocationsToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // showGridBlockLocationsToolStripMenuItem
            // 
            this.showGridBlockLocationsToolStripMenuItem.Name = "showGridBlockLocationsToolStripMenuItem";
            this.showGridBlockLocationsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.showGridBlockLocationsToolStripMenuItem.Text = "Show grid block locations";
            this.showGridBlockLocationsToolStripMenuItem.MouseEnter += new System.EventHandler(this.showGridBlockLocationsToolStripMenuItem_MouseEnter);
            this.showGridBlockLocationsToolStripMenuItem.MouseLeave += new System.EventHandler(this.showGridBlockLocationsToolStripMenuItem_MouseLeave);
            // 
            // antsToolStripMenuItem
            // 
            this.antsToolStripMenuItem.Name = "antsToolStripMenuItem";
            this.antsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.antsToolStripMenuItem.Text = "Run ACS";
            this.antsToolStripMenuItem.Click += new System.EventHandler(this.antsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel_resize
            // 
            this.panel_resize.Controls.Add(this.lb_blockside);
            this.panel_resize.Controls.Add(this.nud_side);
            this.panel_resize.Controls.Add(this.lb_height);
            this.panel_resize.Controls.Add(this.lb_width);
            this.panel_resize.Controls.Add(this.btn_rightup);
            this.panel_resize.Controls.Add(this.btn_rightdown);
            this.panel_resize.Controls.Add(this.btn_leftdown);
            this.panel_resize.Controls.Add(this.btn_leftup);
            this.panel_resize.Controls.Add(this.btn_down);
            this.panel_resize.Controls.Add(this.btn_up);
            this.panel_resize.Controls.Add(this.btn_left);
            this.panel_resize.Controls.Add(this.btn_right);
            this.panel_resize.Location = new System.Drawing.Point(226, 176);
            this.panel_resize.Name = "panel_resize";
            this.panel_resize.Size = new System.Drawing.Size(259, 202);
            this.panel_resize.TabIndex = 9;
            // 
            // lb_blockside
            // 
            this.lb_blockside.AutoSize = true;
            this.lb_blockside.Location = new System.Drawing.Point(4, 39);
            this.lb_blockside.Name = "lb_blockside";
            this.lb_blockside.Size = new System.Drawing.Size(61, 13);
            this.lb_blockside.TabIndex = 9;
            this.lb_blockside.Text = "Block Side:";
            // 
            // nud_side
            // 
            this.nud_side.Location = new System.Drawing.Point(71, 37);
            this.nud_side.Name = "nud_side";
            this.nud_side.Size = new System.Drawing.Size(41, 20);
            this.nud_side.TabIndex = 8;
            this.nud_side.ValueChanged += new System.EventHandler(this.nud_side_ValueChanged);
            // 
            // lb_height
            // 
            this.lb_height.AutoSize = true;
            this.lb_height.Location = new System.Drawing.Point(4, 21);
            this.lb_height.Name = "lb_height";
            this.lb_height.Size = new System.Drawing.Size(75, 13);
            this.lb_height.TabIndex = 7;
            this.lb_height.Text = "Height blocks:";
            // 
            // lb_width
            // 
            this.lb_width.AutoSize = true;
            this.lb_width.Location = new System.Drawing.Point(4, 4);
            this.lb_width.Name = "lb_width";
            this.lb_width.Size = new System.Drawing.Size(72, 13);
            this.lb_width.TabIndex = 6;
            this.lb_width.Text = "Width blocks:";
            // 
            // btn_rightup
            // 
            this.btn_rightup.Location = new System.Drawing.Point(165, 77);
            this.btn_rightup.Name = "btn_rightup";
            this.btn_rightup.Size = new System.Drawing.Size(26, 23);
            this.btn_rightup.TabIndex = 5;
            this.btn_rightup.Text = "/";
            this.btn_rightup.UseVisualStyleBackColor = true;
            this.btn_rightup.Click += new System.EventHandler(this.btn_rightup_Click);
            // 
            // btn_rightdown
            // 
            this.btn_rightdown.Location = new System.Drawing.Point(165, 157);
            this.btn_rightdown.Name = "btn_rightdown";
            this.btn_rightdown.Size = new System.Drawing.Size(26, 23);
            this.btn_rightdown.TabIndex = 5;
            this.btn_rightdown.Text = "\\";
            this.btn_rightdown.UseVisualStyleBackColor = true;
            this.btn_rightdown.Click += new System.EventHandler(this.btn_rightdown_Click);
            // 
            // btn_leftdown
            // 
            this.btn_leftdown.Location = new System.Drawing.Point(66, 157);
            this.btn_leftdown.Name = "btn_leftdown";
            this.btn_leftdown.Size = new System.Drawing.Size(26, 23);
            this.btn_leftdown.TabIndex = 5;
            this.btn_leftdown.Text = "/";
            this.btn_leftdown.UseVisualStyleBackColor = true;
            this.btn_leftdown.Click += new System.EventHandler(this.btn_leftdown_Click);
            // 
            // btn_leftup
            // 
            this.btn_leftup.Location = new System.Drawing.Point(66, 77);
            this.btn_leftup.Name = "btn_leftup";
            this.btn_leftup.Size = new System.Drawing.Size(26, 23);
            this.btn_leftup.TabIndex = 5;
            this.btn_leftup.Text = "\\";
            this.btn_leftup.UseVisualStyleBackColor = true;
            this.btn_leftup.Click += new System.EventHandler(this.btn_leftup_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(98, 153);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(64, 45);
            this.btn_down.TabIndex = 1;
            this.btn_down.Text = "Increase height";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(98, 60);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(64, 45);
            this.btn_up.TabIndex = 2;
            this.btn_up.Text = "Decrease height";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(28, 106);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(64, 45);
            this.btn_left.TabIndex = 3;
            this.btn_left.Text = "Decrease width";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(168, 106);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(64, 45);
            this.btn_right.TabIndex = 4;
            this.btn_right.Text = "Increase width";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(190, 17);
            this.toolStripStatusLabel1.Text = "Hold CTRL for grid configuration...";
            // 
            // lb_noSettings
            // 
            this.lb_noSettings.AutoSize = true;
            this.lb_noSettings.Location = new System.Drawing.Point(409, 24);
            this.lb_noSettings.Name = "lb_noSettings";
            this.lb_noSettings.Size = new System.Drawing.Size(35, 13);
            this.lb_noSettings.TabIndex = 30;
            this.lb_noSettings.Text = "label1";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 466);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_resize);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.settings_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.settings_menu;
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.Text = "K-aGv Simulation-Logistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_form_FormClosing);
            this.Load += new System.EventHandler(this.main_form_Load);
            this.Click += new System.EventHandler(this.main_form_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.main_form_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_form_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.main_form_MouseUp);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.gb_type.ResumeLayout(false);
            this.gb_settings.ResumeLayout(false);
            this.gb_settings.PerformLayout();
            this.gb_agvs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_AGVs)).EndInit();
            this.gb_AStar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_weight)).EndInit();
            this.settings_menu.ResumeLayout(false);
            this.settings_menu.PerformLayout();
            this.panel_resize.ResumeLayout(false);
            this.panel_resize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_side)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.RadioButton rb_stop;
        private System.Windows.Forms.RadioButton rb_start;
        private System.Windows.Forms.RadioButton rb_wall;
        private System.Windows.Forms.ToolTip tp_info;
        private System.Windows.Forms.SaveFileDialog sfd_exportmap;
        private System.Windows.Forms.OpenFileDialog ofd_importmap;
        private System.Windows.Forms.NumericUpDown nUD_AGVs;
        private System.Windows.Forms.RadioButton rb_load;
        private System.Windows.Forms.OpenFileDialog ofd_importpic;
        private System.Windows.Forms.MenuStrip settings_menu;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysCrossMenu;
        private System.Windows.Forms.ToolStripMenuItem neverCrossMenu;
        private System.Windows.Forms.ToolStripMenuItem atLeastOneMenu;
        private System.Windows.Forms.ToolStripMenuItem heuristicModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manhattanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem euclideanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chebyshevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cd_grid;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.GroupBox gb_settings;
        private System.Windows.Forms.GroupBox gb_agvs;
        private System.Windows.Forms.ToolStripMenuItem bordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem highlightOverCurrentBoxToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_type;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.ToolStripMenuItem aGVIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priorityRulesbetaToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nud_weight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem noObstaclesMenu;
        private System.Windows.Forms.GroupBox gb_AStar;
        private System.Windows.Forms.Panel panel_resize;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_rightup;
        private System.Windows.Forms.Button btn_rightdown;
        private System.Windows.Forms.Button btn_leftdown;
        private System.Windows.Forms.Button btn_leftup;
        private System.Windows.Forms.Label lb_height;
        private System.Windows.Forms.Label lb_width;
        private System.Windows.Forms.Label lb_blockside;
        private System.Windows.Forms.NumericUpDown nud_side;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridBlockLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultGridSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importImageLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem implementGoogleMapsToolStripMenuItem;
        private System.Windows.Forms.Label lb_noSettings;
    }
}

