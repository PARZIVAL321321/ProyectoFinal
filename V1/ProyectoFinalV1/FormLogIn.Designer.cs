namespace ProyectoFinalV1
{
    partial class FormLogIn
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
            label_Puntodeventa = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox_Cuenta = new TextBox();
            textBox_Contra = new TextBox();
            button_Acceder = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_Puntodeventa
            // 
            label_Puntodeventa.AutoSize = true;
            label_Puntodeventa.BackColor = Color.Transparent;
            label_Puntodeventa.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Puntodeventa.ForeColor = Color.White;
            label_Puntodeventa.Location = new Point(395, 13);
            label_Puntodeventa.Name = "label_Puntodeventa";
            label_Puntodeventa.Size = new Size(523, 74);
            label_Puntodeventa.TabIndex = 0;
            label_Puntodeventa.Text = "Punto de venta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Dubai", 17.9999981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(411, 93);
            label1.Name = "label1";
            label1.Size = new Size(491, 51);
            label1.TabIndex = 2;
            label1.Text = "\"La diversion a la palma de tus manos\"";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_punto_de_venta;
            pictureBox1.Location = new Point(550, 164);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox_Cuenta
            // 
            textBox_Cuenta.Location = new Point(544, 396);
            textBox_Cuenta.Margin = new Padding(3, 4, 3, 4);
            textBox_Cuenta.Name = "textBox_Cuenta";
            textBox_Cuenta.PlaceholderText = "Cuenta";
            textBox_Cuenta.Size = new Size(228, 27);
            textBox_Cuenta.TabIndex = 4;
            // 
            // textBox_Contra
            // 
            textBox_Contra.Location = new Point(544, 457);
            textBox_Contra.Margin = new Padding(3, 4, 3, 4);
            textBox_Contra.Name = "textBox_Contra";
            textBox_Contra.PlaceholderText = "Contraseña";
            textBox_Contra.Size = new Size(228, 27);
            textBox_Contra.TabIndex = 5;
            // 
            // button_Acceder
            // 
            button_Acceder.Location = new Point(597, 518);
            button_Acceder.Margin = new Padding(3, 4, 3, 4);
            button_Acceder.Name = "button_Acceder";
            button_Acceder.Size = new Size(127, 40);
            button_Acceder.TabIndex = 6;
            button_Acceder.Text = "Acceder";
            button_Acceder.UseVisualStyleBackColor = true;
            button_Acceder.Click += button_Acceder_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Fondo_form;
            ClientSize = new Size(1262, 673);
            Controls.Add(button_Acceder);
            Controls.Add(textBox_Contra);
            Controls.Add(textBox_Cuenta);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label_Puntodeventa);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Puntodeventa;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox_Cuenta;
        private TextBox textBox_Contra;
        private Button button_Acceder;
    }
}