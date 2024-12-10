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
            chart_Admin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label_Titulo = new Label();
            button_Regresar = new Button();
            ((System.ComponentModel.ISupportInitialize)chart_Admin).BeginInit();
            SuspendLayout();
            // 
            // chart_Admin
            // 
            chartArea1.Name = "ChartArea1";
            chart_Admin.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_Admin.Legends.Add(legend1);
            chart_Admin.Location = new Point(232, 55);
            chart_Admin.Name = "chart_Admin";
            chart_Admin.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_Admin.Series.Add(series1);
            chart_Admin.Size = new Size(300, 300);
            chart_Admin.TabIndex = 0;
            chart_Admin.Text = "chart1";
            // 
            // label_Titulo
            // 
            label_Titulo.AutoSize = true;
            label_Titulo.Location = new Point(316, 9);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(137, 15);
            label_Titulo.TabIndex = 1;
            label_Titulo.Text = "Principales compradores";
            // 
            // button_Regresar
            // 
            button_Regresar.Location = new Point(619, 221);
            button_Regresar.Name = "button_Regresar";
            button_Regresar.Size = new Size(75, 23);
            button_Regresar.TabIndex = 2;
            button_Regresar.Text = "Regresar";
            button_Regresar.UseVisualStyleBackColor = true;
            button_Regresar.Click += button_Regresar_Click;
            // 
            // FormGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Regresar);
            Controls.Add(label_Titulo);
            Controls.Add(chart_Admin);
            Name = "FormGrafica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGrafica";
            ((System.ComponentModel.ISupportInitialize)chart_Admin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Admin;
        private Label label_Titulo;
        private Button button_Regresar;
    }
}