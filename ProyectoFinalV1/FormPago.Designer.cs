namespace ProyectoFinalV1
{
    partial class FormPago
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
            label1_Titulo = new Label();
            textBox_NumeroTarjeta = new TextBox();
            textBox_NombreCuenta = new TextBox();
            textBox_MesTarjeta = new TextBox();
            textBox_YearTarjeta = new TextBox();
            textBox_CVVTarjeta = new TextBox();
            textBox_TotalCompra = new TextBox();
            button_Pagar = new Button();
            label_Pregunta = new Label();
            textBox_Efectivo = new TextBox();
            radioButton_Efectivo = new RadioButton();
            radioButton_Tarjeta = new RadioButton();
            SuspendLayout();
            // 
            // label1_Titulo
            // 
            label1_Titulo.AutoSize = true;
            label1_Titulo.Location = new Point(318, 81);
            label1_Titulo.Name = "label1_Titulo";
            label1_Titulo.Size = new Size(122, 20);
            label1_Titulo.TabIndex = 0;
            label1_Titulo.Text = "Metodo de pago";
            // 
            // textBox_NumeroTarjeta
            // 
            textBox_NumeroTarjeta.Location = new Point(615, 179);
            textBox_NumeroTarjeta.Name = "textBox_NumeroTarjeta";
            textBox_NumeroTarjeta.PlaceholderText = "Numero cuenta";
            textBox_NumeroTarjeta.Size = new Size(215, 27);
            textBox_NumeroTarjeta.TabIndex = 3;
            // 
            // textBox_NombreCuenta
            // 
            textBox_NombreCuenta.Location = new Point(615, 234);
            textBox_NombreCuenta.Name = "textBox_NombreCuenta";
            textBox_NombreCuenta.PlaceholderText = "Nombre dueño";
            textBox_NombreCuenta.Size = new Size(215, 27);
            textBox_NombreCuenta.TabIndex = 4;
            // 
            // textBox_MesTarjeta
            // 
            textBox_MesTarjeta.Location = new Point(615, 293);
            textBox_MesTarjeta.Name = "textBox_MesTarjeta";
            textBox_MesTarjeta.PlaceholderText = "Mes";
            textBox_MesTarjeta.Size = new Size(82, 27);
            textBox_MesTarjeta.TabIndex = 5;
            // 
            // textBox_YearTarjeta
            // 
            textBox_YearTarjeta.Location = new Point(740, 293);
            textBox_YearTarjeta.Name = "textBox_YearTarjeta";
            textBox_YearTarjeta.PlaceholderText = "Año";
            textBox_YearTarjeta.Size = new Size(90, 27);
            textBox_YearTarjeta.TabIndex = 6;
            // 
            // textBox_CVVTarjeta
            // 
            textBox_CVVTarjeta.Location = new Point(698, 342);
            textBox_CVVTarjeta.Name = "textBox_CVVTarjeta";
            textBox_CVVTarjeta.PlaceholderText = "CVV";
            textBox_CVVTarjeta.Size = new Size(49, 27);
            textBox_CVVTarjeta.TabIndex = 7;
            // 
            // textBox_TotalCompra
            // 
            textBox_TotalCompra.Location = new Point(512, 81);
            textBox_TotalCompra.Name = "textBox_TotalCompra";
            textBox_TotalCompra.PlaceholderText = "Total compra";
            textBox_TotalCompra.Size = new Size(125, 27);
            textBox_TotalCompra.TabIndex = 8;
            // 
            // button_Pagar
            // 
            button_Pagar.Location = new Point(814, 479);
            button_Pagar.Name = "button_Pagar";
            button_Pagar.Size = new Size(134, 29);
            button_Pagar.TabIndex = 9;
            button_Pagar.Text = "Completar pago";
            button_Pagar.UseVisualStyleBackColor = true;
            button_Pagar.Click += button_Pagar_Click;
            // 
            // label_Pregunta
            // 
            label_Pregunta.AutoSize = true;
            label_Pregunta.Location = new Point(944, 186);
            label_Pregunta.Name = "label_Pregunta";
            label_Pregunta.Size = new Size(136, 20);
            label_Pregunta.TabIndex = 10;
            label_Pregunta.Text = "¿Con cuanto paga?";
            // 
            // textBox_Efectivo
            // 
            textBox_Efectivo.Location = new Point(944, 234);
            textBox_Efectivo.Name = "textBox_Efectivo";
            textBox_Efectivo.PlaceholderText = "Cantidad";
            textBox_Efectivo.Size = new Size(125, 27);
            textBox_Efectivo.TabIndex = 11;
            // 
            // radioButton_Efectivo
            // 
            radioButton_Efectivo.AutoSize = true;
            radioButton_Efectivo.Location = new Point(146, 182);
            radioButton_Efectivo.Name = "radioButton_Efectivo";
            radioButton_Efectivo.Size = new Size(83, 24);
            radioButton_Efectivo.TabIndex = 12;
            radioButton_Efectivo.TabStop = true;
            radioButton_Efectivo.Text = "Efectivo";
            radioButton_Efectivo.UseVisualStyleBackColor = true;
            radioButton_Efectivo.CheckedChanged += radioButton_Efectivo_CheckedChanged;
            // 
            // radioButton_Tarjeta
            // 
            radioButton_Tarjeta.AutoSize = true;
            radioButton_Tarjeta.Location = new Point(146, 319);
            radioButton_Tarjeta.Name = "radioButton_Tarjeta";
            radioButton_Tarjeta.Size = new Size(74, 24);
            radioButton_Tarjeta.TabIndex = 13;
            radioButton_Tarjeta.TabStop = true;
            radioButton_Tarjeta.Text = "Tarjeta";
            radioButton_Tarjeta.UseVisualStyleBackColor = true;
            radioButton_Tarjeta.CheckedChanged += radioButton_Tarjeta_CheckedChanged;
            // 
            // FormPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 579);
            Controls.Add(radioButton_Tarjeta);
            Controls.Add(radioButton_Efectivo);
            Controls.Add(textBox_Efectivo);
            Controls.Add(label_Pregunta);
            Controls.Add(button_Pagar);
            Controls.Add(textBox_TotalCompra);
            Controls.Add(textBox_CVVTarjeta);
            Controls.Add(textBox_YearTarjeta);
            Controls.Add(textBox_MesTarjeta);
            Controls.Add(textBox_NombreCuenta);
            Controls.Add(textBox_NumeroTarjeta);
            Controls.Add(label1_Titulo);
            Name = "FormPago";
            Text = "FormPago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1_Titulo;
        private TextBox textBox_NumeroTarjeta;
        private TextBox textBox_NombreCuenta;
        private TextBox textBox_MesTarjeta;
        private TextBox textBox_YearTarjeta;
        private TextBox textBox_CVVTarjeta;
        private TextBox textBox_TotalCompra;
        private Button button_Pagar;
        private Label label_Pregunta;
        private TextBox textBox_Efectivo;
        private RadioButton radioButton_Efectivo;
        private RadioButton radioButton_Tarjeta;
    }
}