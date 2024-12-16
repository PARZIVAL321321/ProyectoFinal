namespace ProyectoFinalV1
{
    partial class FormGrafica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrafica));
            label_Titulo = new Label();
            button_Regresar = new Button();
            label_VentaTotal = new Label();
            panel1 = new Panel();
            button_LogOut = new Button();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            chart_Admin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_Admin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_Titulo
            // 
            label_Titulo.AutoSize = true;
            label_Titulo.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label_Titulo.ForeColor = SystemColors.ActiveCaption;
            label_Titulo.Location = new Point(0, 0);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(265, 25);
            label_Titulo.TabIndex = 1;
            label_Titulo.Text = "Principales compradores";
            // 
            // button_Regresar
            // 
            button_Regresar.FlatAppearance.BorderSize = 0;
            button_Regresar.FlatStyle = FlatStyle.Flat;
            button_Regresar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Regresar.ForeColor = SystemColors.ActiveCaption;
            button_Regresar.Location = new Point(411, -2);
            button_Regresar.Name = "button_Regresar";
            button_Regresar.Size = new Size(116, 31);
            button_Regresar.TabIndex = 2;
            button_Regresar.Text = "Regresar";
            button_Regresar.UseVisualStyleBackColor = true;
            button_Regresar.Click += button_Regresar_Click;
            // 
            // label_VentaTotal
            // 
            label_VentaTotal.AutoSize = true;
            label_VentaTotal.Location = new Point(316, 388);
            label_VentaTotal.Name = "label_VentaTotal";
            label_VentaTotal.Size = new Size(0, 15);
            label_VentaTotal.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 26, 33);
            panel1.Controls.Add(button_Regresar);
            panel1.Controls.Add(button_LogOut);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label_Titulo);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 31);
            panel1.TabIndex = 51;
            panel1.Paint += panel1_Paint;
            // 
            // button_LogOut
            // 
            button_LogOut.BackColor = Color.FromArgb(23, 26, 33);
            button_LogOut.Cursor = Cursors.Hand;
            button_LogOut.FlatAppearance.BorderSize = 0;
            button_LogOut.FlatStyle = FlatStyle.Flat;
            button_LogOut.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            button_LogOut.ForeColor = Color.FromArgb(42, 71, 94);
            button_LogOut.Location = new Point(1368, -2);
            button_LogOut.Margin = new Padding(3, 2, 3, 2);
            button_LogOut.Name = "button_LogOut";
            button_LogOut.Size = new Size(114, 38);
            button_LogOut.TabIndex = 30;
            button_LogOut.Text = "Log-Out";
            button_LogOut.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(42, 71, 94);
            panel7.Location = new Point(271, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(400, 1);
            panel7.TabIndex = 55;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(42, 71, 94);
            panel6.Location = new Point(271, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(400, 1);
            panel6.TabIndex = 55;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(42, 71, 94);
            panel5.Location = new Point(271, -2);
            panel5.Name = "panel5";
            panel5.Size = new Size(400, 1);
            panel5.TabIndex = 54;
            // 
            // chart_Admin
            // 
            chart_Admin.BackColor = Color.FromArgb(27, 40, 56);
            chart_Admin.BackgroundImageLayout = ImageLayout.None;
            chart_Admin.BorderlineColor = Color.FromArgb(27, 40, 56);
            chart_Admin.BorderSkin.BackColor = Color.Transparent;
            chart_Admin.BorderSkin.PageColor = Color.Transparent;
            chartArea1.BackColor = Color.FromArgb(27, 40, 56);
            chartArea1.BackSecondaryColor = Color.FromArgb(27, 40, 56);
            chartArea1.BorderColor = Color.FromArgb(27, 40, 56);
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = Color.FromArgb(27, 40, 56);
            chart_Admin.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.FromArgb(27, 40, 56);
            legend1.ForeColor = SystemColors.ActiveCaption;
            legend1.HeaderSeparatorColor = Color.FromArgb(27, 40, 56);
            legend1.ItemColumnSeparatorColor = Color.FromArgb(27, 40, 56);
            legend1.Name = "Legend1";
            legend1.ShadowColor = Color.FromArgb(27, 40, 56);
            legend1.TitleBackColor = Color.FromArgb(27, 40, 56);
            legend1.TitleForeColor = Color.FromArgb(27, 40, 56);
            legend1.TitleSeparatorColor = Color.FromArgb(27, 40, 56);
            chart_Admin.Legends.Add(legend1);
            chart_Admin.Location = new Point(-98, 37);
            chart_Admin.Name = "chart_Admin";
            chart_Admin.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chart_Admin.PaletteCustomColors = new Color[]
    {
    Color.FromArgb(102, 192, 244),
    SystemColors.GradientActiveCaption,
    Color.FromArgb(42, 71, 94),
    Color.FromArgb(199, 213, 224),
    Color.FromArgb(50, 50, 60),
    SystemColors.ActiveCaption
    };
            series1.BackSecondaryColor = Color.FromArgb(27, 40, 56);
            series1.BorderColor = Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = Color.FromArgb(27, 40, 56);
            series1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            series1.LabelBackColor = Color.FromArgb(27, 40, 56);
            series1.LabelBorderColor = Color.FromArgb(27, 40, 56);
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelForeColor = Color.FromArgb(27, 40, 56);
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = Color.FromArgb(27, 40, 56);
            series1.MarkerColor = Color.FromArgb(27, 40, 56);
            series1.Name = "Series1";
            series1.ShadowColor = Color.FromArgb(27, 40, 56);
            series1.YValuesPerPoint = 4;
            chart_Admin.Series.Add(series1);
            chart_Admin.Size = new Size(625, 366);
            chart_Admin.TabIndex = 0;
            chart_Admin.Text = "chart1";
            chart_Admin.Click += chart_Admin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(371, 264);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(694, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // FormGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 40, 56);
            ClientSize = new Size(527, 400);
            Controls.Add(pictureBox1);
            Controls.Add(chart_Admin);
            Controls.Add(panel1);
            Controls.Add(label_VentaTotal);
            ForeColor = Color.FromArgb(27, 40, 56);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGrafica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGrafica";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_Admin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_Titulo;
        private Button button_Regresar;
        private Label label_VentaTotal;
        private Panel panel1;
        private Button button_LogOut;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Admin;
        private PictureBox pictureBox1;
    }
}