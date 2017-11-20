namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.NumIts = new System.Windows.Forms.NumericUpDown();
            this.Ants = new System.Windows.Forms.NumericUpDown();
            this.q0value = new System.Windows.Forms.NumericUpDown();
            this.rvalue = new System.Windows.Forms.NumericUpDown();
            this.xvalue = new System.Windows.Forms.NumericUpDown();
            this.bvalue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ACS = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.Label();
            this.avalue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumIts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q0value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avalue)).BeginInit();
            this.SuspendLayout();
            // 
            // NumIts
            // 
            this.NumIts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumIts.Location = new System.Drawing.Point(12, 56);
            this.NumIts.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumIts.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NumIts.Name = "NumIts";
            this.NumIts.Size = new System.Drawing.Size(120, 20);
            this.NumIts.TabIndex = 0;
            this.NumIts.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NumIts.ValueChanged += new System.EventHandler(this.NumIts_ValueChanged);
            // 
            // Ants
            // 
            this.Ants.DecimalPlaces = 2;
            this.Ants.Location = new System.Drawing.Point(12, 110);
            this.Ants.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Ants.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Ants.Name = "Ants";
            this.Ants.Size = new System.Drawing.Size(120, 20);
            this.Ants.TabIndex = 1;
            this.Ants.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // q0value
            // 
            this.q0value.DecimalPlaces = 2;
            this.q0value.Location = new System.Drawing.Point(12, 152);
            this.q0value.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.q0value.Name = "q0value";
            this.q0value.Size = new System.Drawing.Size(120, 20);
            this.q0value.TabIndex = 2;
            this.q0value.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // rvalue
            // 
            this.rvalue.DecimalPlaces = 2;
            this.rvalue.Location = new System.Drawing.Point(12, 260);
            this.rvalue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.rvalue.Name = "rvalue";
            this.rvalue.Size = new System.Drawing.Size(120, 20);
            this.rvalue.TabIndex = 3;
            this.rvalue.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // xvalue
            // 
            this.xvalue.DecimalPlaces = 2;
            this.xvalue.Location = new System.Drawing.Point(12, 308);
            this.xvalue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.xvalue.Name = "xvalue";
            this.xvalue.Size = new System.Drawing.Size(120, 20);
            this.xvalue.TabIndex = 4;
            this.xvalue.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // bvalue
            // 
            this.bvalue.DecimalPlaces = 2;
            this.bvalue.Location = new System.Drawing.Point(12, 203);
            this.bvalue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.bvalue.Name = "bvalue";
            this.bvalue.Size = new System.Drawing.Size(120, 20);
            this.bvalue.TabIndex = 5;
            this.bvalue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of Iterations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ants";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "q0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Evaporation Rate Local";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Evaporation Rate ";
            // 
            // ACS
            // 
            this.ACS.Location = new System.Drawing.Point(1126, 16);
            this.ACS.Name = "ACS";
            this.ACS.Size = new System.Drawing.Size(112, 23);
            this.ACS.TabIndex = 12;
            this.ACS.Text = "Ant Colony System";
            this.ACS.UseVisualStyleBackColor = true;
            this.ACS.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(359, 56);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.Name = "Customers";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Trip";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(879, 571);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(368, 21);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(40, 13);
            this.Length.TabIndex = 15;
            this.Length.Text = "Length";
            // 
            // avalue
            // 
            this.avalue.DecimalPlaces = 2;
            this.avalue.Location = new System.Drawing.Point(12, 355);
            this.avalue.Name = "avalue";
            this.avalue.Size = new System.Drawing.Size(120, 20);
            this.avalue.TabIndex = 16;
            this.avalue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "a";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(751, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(699, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Error";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 639);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.avalue);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ACS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bvalue);
            this.Controls.Add(this.xvalue);
            this.Controls.Add(this.rvalue);
            this.Controls.Add(this.q0value);
            this.Controls.Add(this.Ants);
            this.Controls.Add(this.NumIts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumIts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q0value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumIts;
        private System.Windows.Forms.NumericUpDown Ants;
        private System.Windows.Forms.NumericUpDown q0value;
        private System.Windows.Forms.NumericUpDown rvalue;
        private System.Windows.Forms.NumericUpDown xvalue;
        private System.Windows.Forms.NumericUpDown bvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ACS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.NumericUpDown avalue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
    }
}

