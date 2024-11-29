namespace ProyectoFinalV1
{
    partial class FormPortada
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox_LogoUAA = new PictureBox();
            button_LogIn = new Button();
            btncerrar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_LogoUAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_LogoUAA
            // 
            pictureBox_LogoUAA.Image = Properties.Resources.Logo_UAA;
            pictureBox_LogoUAA.Location = new Point(362, 12);
            pictureBox_LogoUAA.Name = "pictureBox_LogoUAA";
            pictureBox_LogoUAA.Size = new Size(400, 194);
            pictureBox_LogoUAA.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_LogoUAA.TabIndex = 0;
            pictureBox_LogoUAA.TabStop = false;
            // 
            // button_LogIn
            // 
            button_LogIn.BackColor = Color.FromArgb(40, 40, 40);
            button_LogIn.Cursor = Cursors.Hand;
            button_LogIn.FlatAppearance.BorderSize = 0;
            button_LogIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button_LogIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            button_LogIn.FlatStyle = FlatStyle.Flat;
            button_LogIn.Font = new Font("Century Gothic", 16F);
            button_LogIn.ForeColor = Color.LightGray;
            button_LogIn.Location = new Point(482, 427);
            button_LogIn.Name = "button_LogIn";
            button_LogIn.Size = new Size(160, 54);
            button_LogIn.TabIndex = 1;
            button_LogIn.Text = "Log-In";
            button_LogIn.UseVisualStyleBackColor = false;
            button_LogIn.Click += button_LogIn_Click;
            // 
            // btncerrar
            // 
            btncerrar.Image = Properties.Resources.cierrepagina;
            btncerrar.Location = new Point(1067, 12);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(25, 25);
            btncerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btncerrar.TabIndex = 13;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(381, 377);
            label1.Name = "label1";
            label1.Size = new Size(381, 25);
            label1.TabIndex = 14;
            label1.Text = "Uriel Ezequiel Ortiz Rosales - 349695";
            label1.Click += Integrante1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(381, 338);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 15;
            label2.Text = "Alegria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16F);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(388, 297);
            label3.Name = "label3";
            label3.Size = new Size(254, 25);
            label3.TabIndex = 16;
            label3.Text = "Oscar de Jesus Guillen";
            // 
            // FormPortada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1104, 505);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btncerrar);
            Controls.Add(button_LogIn);
            Controls.Add(pictureBox_LogoUAA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPortada";
            Opacity = 0.96D;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormPortada_Load;
            MouseDown += FormPortada_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox_LogoUAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_LogoUAA;
        private Button button_LogIn;
        private PictureBox btncerrar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
