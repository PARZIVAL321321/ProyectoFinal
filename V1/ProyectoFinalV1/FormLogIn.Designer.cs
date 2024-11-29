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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            label_Puntodeventa = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox_Cuenta = new TextBox();
            textBox_Contra = new TextBox();
            button_Acceder = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            SuspendLayout();
            // 
            // label_Puntodeventa
            // 
            label_Puntodeventa.AutoSize = true;
            label_Puntodeventa.BackColor = Color.Transparent;
            label_Puntodeventa.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Puntodeventa.ForeColor = Color.DimGray;
            label_Puntodeventa.Location = new Point(571, 21);
            label_Puntodeventa.Name = "label_Puntodeventa";
            label_Puntodeventa.Size = new Size(376, 56);
            label_Puntodeventa.TabIndex = 0;
            label_Puntodeventa.Text = "Punto de venta";
            label_Puntodeventa.Click += label_Puntodeventa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(633, 77);
            label1.Name = "label1";
            label1.Size = new Size(257, 16);
            label1.TabIndex = 2;
            label1.Text = "\"La diversion a la palma de tus manos\"";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Steam_Logo_PNG8;
            pictureBox1.Location = new Point(25, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1500, 465);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox_Cuenta
            // 
            textBox_Cuenta.BackColor = Color.FromArgb(15, 15, 15);
            textBox_Cuenta.BorderStyle = BorderStyle.None;
            textBox_Cuenta.Font = new Font("Century Gothic", 16F);
            textBox_Cuenta.ForeColor = Color.Transparent;
            textBox_Cuenta.Location = new Point(391, 151);
            textBox_Cuenta.Name = "textBox_Cuenta";
            textBox_Cuenta.PlaceholderText = "Cuenta";
            textBox_Cuenta.Size = new Size(700, 27);
            textBox_Cuenta.TabIndex = 4;
            textBox_Cuenta.TextChanged += textBox_Cuenta_TextChanged;
            textBox_Cuenta.Enter += textBox_Cuenta_Enter;
            textBox_Cuenta.Leave += textBox_Cuenta_Leave;
            // 
            // textBox_Contra
            // 
            textBox_Contra.BackColor = Color.FromArgb(15, 15, 15);
            textBox_Contra.BorderStyle = BorderStyle.None;
            textBox_Contra.Font = new Font("Century Gothic", 16F);
            textBox_Contra.ForeColor = Color.Transparent;
            textBox_Contra.Location = new Point(391, 216);
            textBox_Contra.Name = "textBox_Contra";
            textBox_Contra.PlaceholderText = "Contraseña";
            textBox_Contra.Size = new Size(700, 27);
            textBox_Contra.TabIndex = 5;
            textBox_Contra.Enter += textBox_Contra_Enter;
            textBox_Contra.Leave += textBox_Contra_Leave;
            // 
            // button_Acceder
            // 
            button_Acceder.BackColor = Color.FromArgb(40, 40, 40);
            button_Acceder.FlatAppearance.BorderSize = 0;
            button_Acceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button_Acceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button_Acceder.FlatStyle = FlatStyle.Flat;
            button_Acceder.Font = new Font("Century Gothic", 16F);
            button_Acceder.ForeColor = Color.LightGray;
            button_Acceder.Location = new Point(391, 326);
            button_Acceder.Name = "button_Acceder";
            button_Acceder.Size = new Size(700, 55);
            button_Acceder.TabIndex = 6;
            button_Acceder.Text = "ACCEDER";
            button_Acceder.UseVisualStyleBackColor = false;
            button_Acceder.Click += button_Acceder_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 500);
            panel1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.FondoLineadoAzul;
            pictureBox3.Location = new Point(945, -15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(353, 676);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(391, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Location = new Point(391, 249);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 1);
            panel3.TabIndex = 11;
            // 
            // btncerrar
            // 
            btncerrar.Image = Properties.Resources.cierrepagina;
            btncerrar.Location = new Point(1147, 12);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(25, 25);
            btncerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btncerrar.TabIndex = 12;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(1107, 21);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(25, 8);
            btnminimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnminimizar.TabIndex = 13;
            btnminimizar.TabStop = false;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1184, 500);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(label_Puntodeventa);
            Controls.Add(button_Acceder);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(textBox_Contra);
            Controls.Add(textBox_Cuenta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogIn";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormLogIn_Load;
            MouseDown += FormLogIn_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Panel panel3;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
    }
}