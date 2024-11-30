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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPortada));
            pictureBox_LogoUAA = new PictureBox();
            button_LogIn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_LogoUAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_LogoUAA
            // 
            pictureBox_LogoUAA.Image = Properties.Resources.Logo_UAA;
            pictureBox_LogoUAA.Location = new Point(363, 12);
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
            button_LogIn.Font = new Font("Century Gothic", 15.75F);
            button_LogIn.ForeColor = Color.LightGray;
            button_LogIn.Location = new Point(482, 427);
            button_LogIn.Name = "button_LogIn";
            button_LogIn.Size = new Size(160, 54);
            button_LogIn.TabIndex = 1;
            button_LogIn.Text = "Log-In";
            button_LogIn.UseVisualStyleBackColor = false;
            button_LogIn.Click += button_LogIn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16F);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(370, 289);
            label3.Name = "label3";
            label3.Size = new Size(254, 25);
            label3.TabIndex = 19;
            label3.Text = "Oscar de Jesus Guillen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(363, 330);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 18;
            label2.Text = "Alegria";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(363, 369);
            label1.Name = "label1";
            label1.Size = new Size(381, 25);
            label1.TabIndex = 17;
            label1.Text = "Uriel Ezequiel Ortiz Rosales - 349695";
            label1.Click += label1_Click;
            // 
            // btncerrar
            // 
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(1067, 12);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(25, 25);
            btncerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btncerrar.TabIndex = 20;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(1036, 20);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(25, 8);
            btnminimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnminimizar.TabIndex = 21;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // FormPortada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1104, 505);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_LogIn);
            Controls.Add(pictureBox_LogoUAA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPortada";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormPortada_Load;
            MouseDown += FormPortada_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox_LogoUAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_LogoUAA;
        private Button button_LogIn;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
    }
}
