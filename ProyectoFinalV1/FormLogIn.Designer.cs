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
            textBox_Cuenta = new TextBox();
            textBox_Contra = new TextBox();
            button_Acceder = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            SuspendLayout();
            // 
            // label_Puntodeventa
            // 
            label_Puntodeventa.AutoSize = true;
            label_Puntodeventa.BackColor = Color.Transparent;
            label_Puntodeventa.Font = new Font("Century Gothic", 36F, FontStyle.Bold);
            label_Puntodeventa.ForeColor = Color.DimGray;
            label_Puntodeventa.Location = new Point(512, 9);
            label_Puntodeventa.Name = "label_Puntodeventa";
            label_Puntodeventa.Size = new Size(376, 56);
            label_Puntodeventa.TabIndex = 0;
            label_Puntodeventa.Text = "Punto de venta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(574, 66);
            label1.Name = "label1";
            label1.Size = new Size(257, 16);
            label1.TabIndex = 2;
            label1.Text = "\"La diversion a la palma de tus manos\"";
            // 
            // textBox_Cuenta
            // 
            textBox_Cuenta.BackColor = Color.FromArgb(15, 15, 15);
            textBox_Cuenta.BorderStyle = BorderStyle.None;
            textBox_Cuenta.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Cuenta.ForeColor = Color.Transparent;
            textBox_Cuenta.Location = new Point(347, 169);
            textBox_Cuenta.Name = "textBox_Cuenta";
            textBox_Cuenta.PlaceholderText = "Cuenta";
            textBox_Cuenta.Size = new Size(700, 26);
            textBox_Cuenta.TabIndex = 4;
            textBox_Cuenta.Enter += textBox_Cuenta_Enter;
            textBox_Cuenta.Leave += textBox_Cuenta_Leave;
            // 
            // textBox_Contra
            // 
            textBox_Contra.BackColor = Color.FromArgb(15, 15, 15);
            textBox_Contra.BorderStyle = BorderStyle.None;
            textBox_Contra.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Contra.ForeColor = Color.Transparent;
            textBox_Contra.Location = new Point(347, 233);
            textBox_Contra.Name = "textBox_Contra";
            textBox_Contra.PlaceholderText = "Contraseña";
            textBox_Contra.Size = new Size(700, 26);
            textBox_Contra.TabIndex = 5;
            textBox_Contra.Enter += textBox_Contra_Enter;
            textBox_Contra.Leave += textBox_Contra_Leave;
            // 
            // button_Acceder
            // 
            button_Acceder.BackColor = Color.FromArgb(40, 40, 40);
            button_Acceder.FlatAppearance.BorderSize = 0;
            button_Acceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button_Acceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            button_Acceder.FlatStyle = FlatStyle.Flat;
            button_Acceder.Font = new Font("Century Gothic", 15.75F);
            button_Acceder.ForeColor = Color.LightGray;
            button_Acceder.Location = new Point(357, 355);
            button_Acceder.Name = "button_Acceder";
            button_Acceder.Size = new Size(680, 55);
            button_Acceder.TabIndex = 6;
            button_Acceder.Text = "ACCEDER";
            button_Acceder.UseVisualStyleBackColor = false;
            button_Acceder.Click += button_Acceder_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Location = new Point(347, 265);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 1);
            panel3.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(347, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 1);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 500);
            panel2.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1500, 465);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(989, -40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 603);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btncerrar
            // 
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(1137, 12);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(25, 25);
            btncerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btncerrar.TabIndex = 15;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(1106, 20);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(25, 8);
            btnminimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnminimizar.TabIndex = 16;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1184, 500);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(button_Acceder);
            Controls.Add(textBox_Contra);
            Controls.Add(textBox_Cuenta);
            Controls.Add(label1);
            Controls.Add(label_Puntodeventa);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogIn";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormLogIn_Load;
            MouseDown += FormLogIn_MouseDown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Puntodeventa;
        private Label label1;
        private TextBox textBox_Cuenta;
        private TextBox textBox_Contra;
        private Button button_Acceder;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
    }
}