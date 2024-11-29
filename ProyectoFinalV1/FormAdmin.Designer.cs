namespace ProyectoFinalV1
{
    partial class FormAdmin
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
            button_MostrarInventario = new Button();
            buttonCARGARPRODUCTO = new Button();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBoxID = new TextBox();
            textBoxTITULOJUEGO = new TextBox();
            textBox8 = new TextBox();
            textBoxMODALIDAD = new TextBox();
            textBox10 = new TextBox();
            textBoxGENERO = new TextBox();
            textBox12 = new TextBox();
            textBoxPLATAFORMA = new TextBox();
            textBox14 = new TextBox();
            textBoxPRECIO = new TextBox();
            textBox16 = new TextBox();
            textBoxSTOCK = new TextBox();
            textBox18 = new TextBox();
            textBoxBAJAR = new TextBox();
            textBox_IDBorrar = new TextBox();
            textBox7 = new TextBox();
            button_EliminarProducto = new Button();
            pictureBox1Juego1 = new PictureBox();
            button1 = new Button();
            dataGridView_Inventario = new DataGridView();
            button_LogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Juego1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Inventario).BeginInit();
            SuspendLayout();
            // 
            // button_MostrarInventario
            // 
            button_MostrarInventario.Location = new Point(41, 2);
            button_MostrarInventario.Name = "button_MostrarInventario";
            button_MostrarInventario.Size = new Size(747, 29);
            button_MostrarInventario.TabIndex = 4;
            button_MostrarInventario.Text = "INVENTARIO";
            button_MostrarInventario.UseVisualStyleBackColor = true;
            button_MostrarInventario.Click += button_MostrarInventario_Click;
            // 
            // buttonCARGARPRODUCTO
            // 
            buttonCARGARPRODUCTO.Location = new Point(883, 632);
            buttonCARGARPRODUCTO.Name = "buttonCARGARPRODUCTO";
            buttonCARGARPRODUCTO.Size = new Size(94, 29);
            buttonCARGARPRODUCTO.TabIndex = 5;
            buttonCARGARPRODUCTO.Text = "Guardar";
            buttonCARGARPRODUCTO.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(872, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(378, 27);
            textBox3.TabIndex = 6;
            textBox3.Text = "SUBIR PRODUCTO";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(872, 37);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(27, 27);
            textBox5.TabIndex = 7;
            textBox5.Text = "ID:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(905, 37);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "INGRESA ID";
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 8;
            // 
            // textBoxTITULOJUEGO
            // 
            textBoxTITULOJUEGO.Location = new Point(937, 70);
            textBoxTITULOJUEGO.Name = "textBoxTITULOJUEGO";
            textBoxTITULOJUEGO.PlaceholderText = "INGRESA TITULO DEL JUEGO";
            textBoxTITULOJUEGO.Size = new Size(196, 27);
            textBoxTITULOJUEGO.TabIndex = 10;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(872, 70);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(59, 27);
            textBox8.TabIndex = 9;
            textBox8.Text = "TITULO:";
            // 
            // textBoxMODALIDAD
            // 
            textBoxMODALIDAD.Location = new Point(983, 103);
            textBoxMODALIDAD.Name = "textBoxMODALIDAD";
            textBoxMODALIDAD.PlaceholderText = "INGRESA MODALIDAD";
            textBoxMODALIDAD.Size = new Size(162, 27);
            textBoxMODALIDAD.TabIndex = 12;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(872, 103);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(105, 27);
            textBox10.TabIndex = 11;
            textBox10.Text = "MODALIDAD:";
            // 
            // textBoxGENERO
            // 
            textBoxGENERO.Location = new Point(983, 169);
            textBoxGENERO.Name = "textBoxGENERO";
            textBoxGENERO.PlaceholderText = "INGRESA EL GENERO";
            textBoxGENERO.Size = new Size(162, 27);
            textBoxGENERO.TabIndex = 16;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(872, 169);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(105, 27);
            textBox12.TabIndex = 15;
            textBox12.Text = "GENERO:";
            // 
            // textBoxPLATAFORMA
            // 
            textBoxPLATAFORMA.Location = new Point(983, 136);
            textBoxPLATAFORMA.Name = "textBoxPLATAFORMA";
            textBoxPLATAFORMA.PlaceholderText = "INGRESA PLATAFORMA";
            textBoxPLATAFORMA.Size = new Size(196, 27);
            textBoxPLATAFORMA.TabIndex = 14;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(872, 136);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(105, 27);
            textBox14.TabIndex = 13;
            textBox14.Text = "PLATAFORMA:";
            // 
            // textBoxPRECIO
            // 
            textBoxPRECIO.Location = new Point(983, 202);
            textBoxPRECIO.Name = "textBoxPRECIO";
            textBoxPRECIO.PlaceholderText = "INGRESA EL PRECIO";
            textBoxPRECIO.Size = new Size(162, 27);
            textBoxPRECIO.TabIndex = 18;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(872, 202);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(105, 27);
            textBox16.TabIndex = 17;
            textBox16.Text = "PRECIO:";
            // 
            // textBoxSTOCK
            // 
            textBoxSTOCK.Location = new Point(983, 235);
            textBoxSTOCK.Name = "textBoxSTOCK";
            textBoxSTOCK.PlaceholderText = "INGRESA LA CANTIDAD DE COPIAS";
            textBoxSTOCK.Size = new Size(247, 27);
            textBoxSTOCK.TabIndex = 20;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(872, 235);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(105, 27);
            textBox18.TabIndex = 19;
            textBox18.Text = "STOCK:";
            // 
            // textBoxBAJAR
            // 
            textBoxBAJAR.Location = new Point(219, 406);
            textBoxBAJAR.Name = "textBoxBAJAR";
            textBoxBAJAR.Size = new Size(378, 27);
            textBoxBAJAR.TabIndex = 23;
            textBoxBAJAR.Text = "BAJAR PRODUCTO";
            textBoxBAJAR.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_IDBorrar
            // 
            textBox_IDBorrar.Location = new Point(352, 439);
            textBox_IDBorrar.Name = "textBox_IDBorrar";
            textBox_IDBorrar.PlaceholderText = "INGRESA ID";
            textBox_IDBorrar.Size = new Size(125, 27);
            textBox_IDBorrar.TabIndex = 25;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(319, 439);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(27, 27);
            textBox7.TabIndex = 24;
            textBox7.Text = "ID:";
            // 
            // button_EliminarProducto
            // 
            button_EliminarProducto.Location = new Point(342, 483);
            button_EliminarProducto.Name = "button_EliminarProducto";
            button_EliminarProducto.Size = new Size(94, 29);
            button_EliminarProducto.TabIndex = 26;
            button_EliminarProducto.Text = "ELIMINAR";
            button_EliminarProducto.UseVisualStyleBackColor = true;
            button_EliminarProducto.Click += button_EliminarProducto_Click;
            // 
            // pictureBox1Juego1
            // 
            pictureBox1Juego1.Location = new Point(872, 438);
            pictureBox1Juego1.Name = "pictureBox1Juego1";
            pictureBox1Juego1.Size = new Size(291, 169);
            pictureBox1Juego1.TabIndex = 27;
            pictureBox1Juego1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(872, 404);
            button1.Name = "button1";
            button1.Size = new Size(158, 29);
            button1.TabIndex = 28;
            button1.Text = "CARGAR IMAGEN:";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Inventario
            // 
            dataGridView_Inventario.AllowUserToAddRows = false;
            dataGridView_Inventario.AllowUserToDeleteRows = false;
            dataGridView_Inventario.AllowUserToResizeColumns = false;
            dataGridView_Inventario.AllowUserToResizeRows = false;
            dataGridView_Inventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Inventario.Location = new Point(41, 45);
            dataGridView_Inventario.Name = "dataGridView_Inventario";
            dataGridView_Inventario.RowHeadersVisible = false;
            dataGridView_Inventario.RowHeadersWidth = 51;
            dataGridView_Inventario.Size = new Size(747, 344);
            dataGridView_Inventario.TabIndex = 29;
            // 
            // button_LogOut
            // 
            button_LogOut.Location = new Point(12, 614);
            button_LogOut.Name = "button_LogOut";
            button_LogOut.Size = new Size(130, 50);
            button_LogOut.TabIndex = 30;
            button_LogOut.Text = "Log-Out";
            button_LogOut.UseVisualStyleBackColor = true;
            button_LogOut.Click += button_LogOut_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(button_LogOut);
            Controls.Add(dataGridView_Inventario);
            Controls.Add(button1);
            Controls.Add(pictureBox1Juego1);
            Controls.Add(button_EliminarProducto);
            Controls.Add(textBox_IDBorrar);
            Controls.Add(textBox7);
            Controls.Add(textBoxBAJAR);
            Controls.Add(textBoxSTOCK);
            Controls.Add(textBox18);
            Controls.Add(textBoxPRECIO);
            Controls.Add(textBox16);
            Controls.Add(textBoxGENERO);
            Controls.Add(textBox12);
            Controls.Add(textBoxPLATAFORMA);
            Controls.Add(textBox14);
            Controls.Add(textBoxMODALIDAD);
            Controls.Add(textBox10);
            Controls.Add(textBoxTITULOJUEGO);
            Controls.Add(textBox8);
            Controls.Add(textBoxID);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(buttonCARGARPRODUCTO);
            Controls.Add(button_MostrarInventario);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1Juego1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Inventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_MostrarInventario;
        private Button buttonCARGARPRODUCTO;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBoxID;
        private TextBox textBoxTITULOJUEGO;
        private TextBox textBox8;
        private TextBox textBoxMODALIDAD;
        private TextBox textBox10;
        private TextBox textBoxGENERO;
        private TextBox textBox12;
        private TextBox textBoxPLATAFORMA;
        private TextBox textBox14;
        private TextBox textBoxPRECIO;
        private TextBox textBox16;
        private TextBox textBoxSTOCK;
        private TextBox textBox18;
        private TextBox textBoxBAJAR;
        private TextBox textBox_IDBorrar;
        private TextBox textBox7;
        private Button button_EliminarProducto;
        private PictureBox pictureBox1Juego1;
        private Button button1;
        private DataGridView dataGridView_Inventario;
        private Button button_LogOut;
    }
}