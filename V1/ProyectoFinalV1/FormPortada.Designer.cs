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
            ((System.ComponentModel.ISupportInitialize)pictureBox_LogoUAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_LogoUAA
            // 
            pictureBox_LogoUAA.Image = Properties.Resources.Logo_UAA;
            pictureBox_LogoUAA.Location = new Point(850, 13);
            pictureBox_LogoUAA.Margin = new Padding(3, 4, 3, 4);
            pictureBox_LogoUAA.Name = "pictureBox_LogoUAA";
            pictureBox_LogoUAA.Size = new Size(400, 194);
            pictureBox_LogoUAA.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_LogoUAA.TabIndex = 0;
            pictureBox_LogoUAA.TabStop = false;
            // 
            // button_LogIn
            // 
            button_LogIn.Cursor = Cursors.Hand;
            button_LogIn.Font = new Font("Dubai", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_LogIn.Location = new Point(551, 569);
            button_LogIn.Margin = new Padding(3, 4, 3, 4);
            button_LogIn.Name = "button_LogIn";
            button_LogIn.Size = new Size(183, 72);
            button_LogIn.TabIndex = 1;
            button_LogIn.Text = "Log-In";
            button_LogIn.UseVisualStyleBackColor = true;
            button_LogIn.Click += button_LogIn_Click;
            // 
            // FormPortada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1262, 673);
            Controls.Add(button_LogIn);
            Controls.Add(pictureBox_LogoUAA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPortada";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox_LogoUAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_LogoUAA;
        private Button button_LogIn;
    }
}
