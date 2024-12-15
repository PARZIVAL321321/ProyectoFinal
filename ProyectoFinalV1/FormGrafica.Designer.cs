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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart_Admin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label_Titulo = new Label();
            button_Regresar = new Button();
            label_VentaTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)chart_Admin).BeginInit();
            SuspendLayout();
            // 
            // chart_Admin
            // 
            chartArea2.Name = "ChartArea1";
            chart_Admin.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart_Admin.Legends.Add(legend2);
            chart_Admin.Location = new Point(232, 55);
            chart_Admin.Name = "chart_Admin";
            chart_Admin.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_Admin.Series.Add(series2);
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
            // label_VentaTotal
            // 
            label_VentaTotal.AutoSize = true;
            label_VentaTotal.Location = new Point(316, 388);
            label_VentaTotal.Name = "label_VentaTotal";
            label_VentaTotal.Size = new Size(0, 15);
            label_VentaTotal.TabIndex = 3;
            // 
            // FormGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_VentaTotal);
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
        private Label label_VentaTotal;
    }
}