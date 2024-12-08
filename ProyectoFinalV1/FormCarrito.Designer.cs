namespace ProyectoFinalV1
{
    partial class FormCarrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarrito));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            button_SeguirComprando = new Button();
            panel2 = new Panel();
            button_ContinuarPago = new Button();
            textBox_TotalIva = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox_Total = new TextBox();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btnminimizar = new PictureBox();
            dataGridView_CarritodeCompras = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Plataforma = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            button_BorrarCarrito = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CarritodeCompras).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(25, 55);
            label1.Name = "label1";
            label1.Size = new Size(370, 41);
            label1.TabIndex = 23;
            label1.Text = "Tu carrito de compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(199, 213, 224);
            label2.Location = new Point(29, 34);
            label2.Name = "label2";
            label2.Size = new Size(253, 18);
            label2.TabIndex = 24;
            label2.Text = "Productos > Tu carrito de compra";
            // 
            // button_SeguirComprando
            // 
            button_SeguirComprando.BackColor = Color.FromArgb(40, 40, 40);
            button_SeguirComprando.FlatAppearance.BorderSize = 0;
            button_SeguirComprando.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button_SeguirComprando.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            button_SeguirComprando.FlatStyle = FlatStyle.Flat;
            button_SeguirComprando.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_SeguirComprando.ForeColor = Color.FromArgb(199, 213, 224);
            button_SeguirComprando.Location = new Point(439, 408);
            button_SeguirComprando.Name = "button_SeguirComprando";
            button_SeguirComprando.Size = new Size(269, 41);
            button_SeguirComprando.TabIndex = 25;
            button_SeguirComprando.Text = "Seguir comprando";
            button_SeguirComprando.UseVisualStyleBackColor = false;
            button_SeguirComprando.Click += button_SeguirComprando_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 71, 94);
            panel2.Controls.Add(button_ContinuarPago);
            panel2.Controls.Add(textBox_TotalIva);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_Total);
            panel2.Location = new Point(408, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 135);
            panel2.TabIndex = 27;
            // 
            // button_ContinuarPago
            // 
            button_ContinuarPago.BackColor = Color.FromArgb(23, 26, 33);
            button_ContinuarPago.FlatAppearance.BorderSize = 0;
            button_ContinuarPago.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button_ContinuarPago.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            button_ContinuarPago.FlatStyle = FlatStyle.Flat;
            button_ContinuarPago.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_ContinuarPago.ForeColor = Color.FromArgb(199, 213, 224);
            button_ContinuarPago.Location = new Point(32, 93);
            button_ContinuarPago.Name = "button_ContinuarPago";
            button_ContinuarPago.Size = new Size(288, 28);
            button_ContinuarPago.TabIndex = 28;
            button_ContinuarPago.Text = "CONTINUAR CON EL PAGO";
            button_ContinuarPago.UseVisualStyleBackColor = false;
            button_ContinuarPago.Click += button_ContinuarPago_Click;
            // 
            // textBox_TotalIva
            // 
            textBox_TotalIva.BackColor = Color.FromArgb(42, 71, 94);
            textBox_TotalIva.BorderStyle = BorderStyle.None;
            textBox_TotalIva.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TotalIva.ForeColor = Color.LimeGreen;
            textBox_TotalIva.Location = new Point(242, 56);
            textBox_TotalIva.Name = "textBox_TotalIva";
            textBox_TotalIva.Size = new Size(96, 20);
            textBox_TotalIva.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(81, 53);
            label4.Name = "label4";
            label4.Size = new Size(132, 24);
            label4.TabIndex = 28;
            label4.Text = "TOTAL + IVA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(32, 19);
            label3.Name = "label3";
            label3.Size = new Size(182, 24);
            label3.TabIndex = 1;
            label3.Text = "TOTAL ESTIMADO:";
            // 
            // textBox_Total
            // 
            textBox_Total.BackColor = Color.FromArgb(42, 71, 94);
            textBox_Total.BorderStyle = BorderStyle.None;
            textBox_Total.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Total.ForeColor = Color.LightGray;
            textBox_Total.Location = new Point(242, 25);
            textBox_Total.Name = "textBox_Total";
            textBox_Total.Size = new Size(96, 20);
            textBox_Total.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(23, 26, 33);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(408, 246);
            panel3.Name = "panel3";
            panel3.Size = new Size(342, 106);
            panel3.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(13, 70);
            label7.Name = "label7";
            label7.Size = new Size(172, 21);
            label7.TabIndex = 2;
            label7.Text = "producto en ESTIM.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(13, 45);
            label6.Name = "label6";
            label6.Size = new Size(238, 21);
            label6.TabIndex = 1;
            label6.Text = "otorga una licencia para el";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(13, 20);
            label5.Name = "label5";
            label5.Size = new Size(294, 21);
            label5.TabIndex = 0;
            label5.Text = "La compra de un producto digital";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(329, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1500, 465);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // btnminimizar
            // 
            btnminimizar.BackColor = Color.FromArgb(27, 40, 56);
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(721, 25);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(25, 6);
            btnminimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnminimizar.TabIndex = 45;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click_1;
            // 
            // dataGridView_CarritodeCompras
            // 
            dataGridView_CarritodeCompras.AllowUserToAddRows = false;
            dataGridView_CarritodeCompras.AllowUserToDeleteRows = false;
            dataGridView_CarritodeCompras.AllowUserToResizeColumns = false;
            dataGridView_CarritodeCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(139, 153, 164);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(139, 153, 164);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView_CarritodeCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_CarritodeCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_CarritodeCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView_CarritodeCompras.BackgroundColor = Color.FromArgb(42, 81, 94);
            dataGridView_CarritodeCompras.BorderStyle = BorderStyle.None;
            dataGridView_CarritodeCompras.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView_CarritodeCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_CarritodeCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_CarritodeCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_CarritodeCompras.Columns.AddRange(new DataGridViewColumn[] { Nombre, Plataforma, Cantidad, Precio });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(199, 213, 224);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(199, 213, 224);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_CarritodeCompras.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_CarritodeCompras.EnableHeadersVisualStyles = false;
            dataGridView_CarritodeCompras.GridColor = SystemColors.Menu;
            dataGridView_CarritodeCompras.Location = new Point(25, 105);
            dataGridView_CarritodeCompras.Margin = new Padding(3, 2, 3, 2);
            dataGridView_CarritodeCompras.Name = "dataGridView_CarritodeCompras";
            dataGridView_CarritodeCompras.ReadOnly = true;
            dataGridView_CarritodeCompras.RowHeadersVisible = false;
            dataGridView_CarritodeCompras.RowHeadersWidth = 51;
            dataGridView_CarritodeCompras.Size = new Size(376, 405);
            dataGridView_CarritodeCompras.TabIndex = 46;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 86;
            // 
            // Plataforma
            // 
            Plataforma.HeaderText = "Plataforma";
            Plataforma.MinimumWidth = 6;
            Plataforma.Name = "Plataforma";
            Plataforma.ReadOnly = true;
            Plataforma.Width = 105;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 94;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 74;
            // 
            // button_BorrarCarrito
            // 
            button_BorrarCarrito.BackColor = Color.FromArgb(40, 40, 40);
            button_BorrarCarrito.FlatAppearance.BorderSize = 0;
            button_BorrarCarrito.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button_BorrarCarrito.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            button_BorrarCarrito.FlatStyle = FlatStyle.Flat;
            button_BorrarCarrito.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_BorrarCarrito.ForeColor = Color.FromArgb(199, 213, 224);
            button_BorrarCarrito.Location = new Point(138, 515);
            button_BorrarCarrito.Name = "button_BorrarCarrito";
            button_BorrarCarrito.Size = new Size(121, 28);
            button_BorrarCarrito.TabIndex = 47;
            button_BorrarCarrito.Text = "Borrar carrito";
            button_BorrarCarrito.UseVisualStyleBackColor = false;
            button_BorrarCarrito.Click += button_BorrarCarrito_Click;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 40, 56);
            ClientSize = new Size(760, 552);
            Controls.Add(button_BorrarCarrito);
            Controls.Add(dataGridView_CarritodeCompras);
            Controls.Add(btnminimizar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button_SeguirComprando);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCarrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += FormCarrito_MouseDown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CarritodeCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button_SeguirComprando;
        private Panel panel2;
        private TextBox textBox_Total;
        private Label label3;
        private Button button_ContinuarPago;
        private TextBox textBox_TotalIva;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox btnminimizar;
        private DataGridView dataGridView_CarritodeCompras;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Plataforma;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private Button button_BorrarCarrito;
    }
}