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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            button_MOSTRARINVENTARIO = new Button();
            button_Subir = new Button();
            txtSUBIRPRODUCTOS = new TextBox();
            txtID = new TextBox();
            textBox_IDSubir = new TextBox();
            textBox_NombreSubir = new TextBox();
            txtTITULO = new TextBox();
            textBox_ModalidadSubir = new TextBox();
            txtMODALIDAD = new TextBox();
            textBox_GeneroSubir = new TextBox();
            txtGENERO = new TextBox();
            textBox_PlataformaSubir = new TextBox();
            txtPLATAFORMA = new TextBox();
            textBox_PrecioSubir = new TextBox();
            txtPRECIO = new TextBox();
            textBox_StockSubir = new TextBox();
            txtSTOCK = new TextBox();
            textBoxBAJAR = new TextBox();
            textBox_IDBorrar = new TextBox();
            textBox7 = new TextBox();
            button_EliminarProducto = new Button();
            pictureBox_Modificar = new PictureBox();
            button_CargarImagenSubir = new Button();
            dataGridView_Inventario = new DataGridView();
            button_LogOut = new Button();
            textBox_StockModificar = new TextBox();
            txtSTOCKMODIFCAR = new TextBox();
            textBox_PrecioModificar = new TextBox();
            txtPRECIOMODIFICAR = new TextBox();
            textBox_GeneroModificar = new TextBox();
            txtGENEROMODIFICAR = new TextBox();
            textBox_PlataformaModificar = new TextBox();
            txtPLATAFORMAMODIFICAR = new TextBox();
            textBox_ModalidadModificar = new TextBox();
            txtMODALIDADMODIFY = new TextBox();
            textBox_NombreModificar = new TextBox();
            txtTITULOMODIFICAR = new TextBox();
            textBox_IDModificar = new TextBox();
            txtMODIFICARID = new TextBox();
            txtMODIFICAR = new TextBox();
            button_CargarImagenModificar = new Button();
            button_Modificar = new Button();
            pictureBox_Subir = new PictureBox();
            btncerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Modificar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Inventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Subir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            SuspendLayout();
            // 
            // button_MOSTRARINVENTARIO
            // 
            button_MOSTRARINVENTARIO.Location = new Point(41, 3);
            button_MOSTRARINVENTARIO.Name = "button_MOSTRARINVENTARIO";
            button_MOSTRARINVENTARIO.Size = new Size(823, 29);
            button_MOSTRARINVENTARIO.TabIndex = 4;
            button_MOSTRARINVENTARIO.Text = "INVENTARIO";
            button_MOSTRARINVENTARIO.UseVisualStyleBackColor = true;
            button_MOSTRARINVENTARIO.Click += button_MostrarInventario_Click;
            // 
            // button_Subir
            // 
            button_Subir.Location = new Point(903, 519);
            button_Subir.Name = "button_Subir";
            button_Subir.Size = new Size(94, 29);
            button_Subir.TabIndex = 5;
            button_Subir.Text = "Subir";
            button_Subir.UseVisualStyleBackColor = true;
            button_Subir.Click += button_Subir_Click;
            // 
            // txtSUBIRPRODUCTOS
            // 
            txtSUBIRPRODUCTOS.Font = new Font("Century Gothic", 9.75F);
            txtSUBIRPRODUCTOS.Location = new Point(870, 45);
            txtSUBIRPRODUCTOS.Name = "txtSUBIRPRODUCTOS";
            txtSUBIRPRODUCTOS.Size = new Size(378, 27);
            txtSUBIRPRODUCTOS.TabIndex = 6;
            txtSUBIRPRODUCTOS.Text = "SUBIR PRODUCTO";
            txtSUBIRPRODUCTOS.TextAlign = HorizontalAlignment.Center;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Century Gothic", 9.75F);
            txtID.Location = new Point(870, 79);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(27, 27);
            txtID.TabIndex = 7;
            txtID.Text = "ID:";
            // 
            // textBox_IDSubir
            // 
            textBox_IDSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_IDSubir.Location = new Point(903, 79);
            textBox_IDSubir.Name = "textBox_IDSubir";
            textBox_IDSubir.Size = new Size(291, 27);
            textBox_IDSubir.TabIndex = 8;
            // 
            // textBox_NombreSubir
            // 
            textBox_NombreSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_NombreSubir.Location = new Point(956, 111);
            textBox_NombreSubir.Name = "textBox_NombreSubir";
            textBox_NombreSubir.Size = new Size(238, 27);
            textBox_NombreSubir.TabIndex = 10;
            // 
            // txtTITULO
            // 
            txtTITULO.Enabled = false;
            txtTITULO.Font = new Font("Century Gothic", 9.75F);
            txtTITULO.Location = new Point(870, 111);
            txtTITULO.Name = "txtTITULO";
            txtTITULO.ReadOnly = true;
            txtTITULO.Size = new Size(80, 27);
            txtTITULO.TabIndex = 9;
            txtTITULO.Text = "Nombre:";
            // 
            // textBox_ModalidadSubir
            // 
            textBox_ModalidadSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_ModalidadSubir.Location = new Point(998, 211);
            textBox_ModalidadSubir.Name = "textBox_ModalidadSubir";
            textBox_ModalidadSubir.Size = new Size(196, 27);
            textBox_ModalidadSubir.TabIndex = 12;
            // 
            // txtMODALIDAD
            // 
            txtMODALIDAD.Enabled = false;
            txtMODALIDAD.Font = new Font("Century Gothic", 9.75F);
            txtMODALIDAD.Location = new Point(870, 211);
            txtMODALIDAD.Name = "txtMODALIDAD";
            txtMODALIDAD.ReadOnly = true;
            txtMODALIDAD.Size = new Size(122, 27);
            txtMODALIDAD.TabIndex = 11;
            txtMODALIDAD.Text = "MODALIDAD:";
            // 
            // textBox_GeneroSubir
            // 
            textBox_GeneroSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_GeneroSubir.Location = new Point(981, 144);
            textBox_GeneroSubir.Name = "textBox_GeneroSubir";
            textBox_GeneroSubir.Size = new Size(213, 27);
            textBox_GeneroSubir.TabIndex = 16;
            // 
            // txtGENERO
            // 
            txtGENERO.Enabled = false;
            txtGENERO.Font = new Font("Century Gothic", 9.75F);
            txtGENERO.Location = new Point(870, 144);
            txtGENERO.Name = "txtGENERO";
            txtGENERO.ReadOnly = true;
            txtGENERO.Size = new Size(105, 27);
            txtGENERO.TabIndex = 15;
            txtGENERO.Text = "GENERO:";
            // 
            // textBox_PlataformaSubir
            // 
            textBox_PlataformaSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_PlataformaSubir.Location = new Point(998, 177);
            textBox_PlataformaSubir.Name = "textBox_PlataformaSubir";
            textBox_PlataformaSubir.Size = new Size(196, 27);
            textBox_PlataformaSubir.TabIndex = 14;
            // 
            // txtPLATAFORMA
            // 
            txtPLATAFORMA.Enabled = false;
            txtPLATAFORMA.Font = new Font("Century Gothic", 9.75F);
            txtPLATAFORMA.Location = new Point(870, 177);
            txtPLATAFORMA.Name = "txtPLATAFORMA";
            txtPLATAFORMA.ReadOnly = true;
            txtPLATAFORMA.Size = new Size(122, 27);
            txtPLATAFORMA.TabIndex = 13;
            txtPLATAFORMA.Text = "PLATAFORMA:";
            // 
            // textBox_PrecioSubir
            // 
            textBox_PrecioSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_PrecioSubir.Location = new Point(981, 244);
            textBox_PrecioSubir.Name = "textBox_PrecioSubir";
            textBox_PrecioSubir.Size = new Size(213, 27);
            textBox_PrecioSubir.TabIndex = 18;
            // 
            // txtPRECIO
            // 
            txtPRECIO.Enabled = false;
            txtPRECIO.Font = new Font("Century Gothic", 9.75F);
            txtPRECIO.Location = new Point(870, 244);
            txtPRECIO.Name = "txtPRECIO";
            txtPRECIO.ReadOnly = true;
            txtPRECIO.Size = new Size(105, 27);
            txtPRECIO.TabIndex = 17;
            txtPRECIO.Text = "PRECIO:";
            // 
            // textBox_StockSubir
            // 
            textBox_StockSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_StockSubir.Location = new Point(981, 276);
            textBox_StockSubir.Name = "textBox_StockSubir";
            textBox_StockSubir.Size = new Size(213, 27);
            textBox_StockSubir.TabIndex = 20;
            // 
            // txtSTOCK
            // 
            txtSTOCK.Enabled = false;
            txtSTOCK.Font = new Font("Century Gothic", 9.75F);
            txtSTOCK.Location = new Point(870, 276);
            txtSTOCK.Name = "txtSTOCK";
            txtSTOCK.ReadOnly = true;
            txtSTOCK.Size = new Size(105, 27);
            txtSTOCK.TabIndex = 19;
            txtSTOCK.Text = "STOCK:";
            // 
            // textBoxBAJAR
            // 
            textBoxBAJAR.Enabled = false;
            textBoxBAJAR.Font = new Font("Century Gothic", 9.75F);
            textBoxBAJAR.Location = new Point(41, 395);
            textBoxBAJAR.Name = "textBoxBAJAR";
            textBoxBAJAR.Size = new Size(173, 27);
            textBoxBAJAR.TabIndex = 23;
            textBoxBAJAR.Text = "BAJAR PRODUCTO";
            textBoxBAJAR.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_IDBorrar
            // 
            textBox_IDBorrar.Font = new Font("Century Gothic", 9.75F);
            textBox_IDBorrar.Location = new Point(75, 428);
            textBox_IDBorrar.Name = "textBox_IDBorrar";
            textBox_IDBorrar.Size = new Size(125, 27);
            textBox_IDBorrar.TabIndex = 25;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Font = new Font("Century Gothic", 9.75F);
            textBox7.Location = new Point(42, 428);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(27, 27);
            textBox7.TabIndex = 24;
            textBox7.Text = "ID:";
            // 
            // button_EliminarProducto
            // 
            button_EliminarProducto.Location = new Point(41, 464);
            button_EliminarProducto.Name = "button_EliminarProducto";
            button_EliminarProducto.Size = new Size(94, 29);
            button_EliminarProducto.TabIndex = 26;
            button_EliminarProducto.Text = "ELIMINAR";
            button_EliminarProducto.UseVisualStyleBackColor = true;
            button_EliminarProducto.Click += button_EliminarProducto_Click;
            // 
            // pictureBox_Modificar
            // 
            pictureBox_Modificar.Location = new Point(589, 430);
            pictureBox_Modificar.Name = "pictureBox_Modificar";
            pictureBox_Modificar.Size = new Size(291, 169);
            pictureBox_Modificar.TabIndex = 27;
            pictureBox_Modificar.TabStop = false;
            // 
            // button_CargarImagenSubir
            // 
            button_CargarImagenSubir.Location = new Point(903, 309);
            button_CargarImagenSubir.Name = "button_CargarImagenSubir";
            button_CargarImagenSubir.Size = new Size(158, 29);
            button_CargarImagenSubir.TabIndex = 28;
            button_CargarImagenSubir.Text = "CARGAR IMAGEN:";
            button_CargarImagenSubir.UseVisualStyleBackColor = true;
            button_CargarImagenSubir.Click += button_CargarImagenSubir_Click;
            // 
            // dataGridView_Inventario
            // 
            dataGridView_Inventario.AllowUserToAddRows = false;
            dataGridView_Inventario.AllowUserToDeleteRows = false;
            dataGridView_Inventario.AllowUserToResizeColumns = false;
            dataGridView_Inventario.AllowUserToResizeRows = false;
            dataGridView_Inventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Inventario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Inventario.Location = new Point(41, 45);
            dataGridView_Inventario.Name = "dataGridView_Inventario";
            dataGridView_Inventario.RowHeadersVisible = false;
            dataGridView_Inventario.RowHeadersWidth = 51;
            dataGridView_Inventario.Size = new Size(823, 344);
            dataGridView_Inventario.TabIndex = 29;
            // 
            // button_LogOut
            // 
            button_LogOut.Location = new Point(11, 613);
            button_LogOut.Name = "button_LogOut";
            button_LogOut.Size = new Size(130, 51);
            button_LogOut.TabIndex = 30;
            button_LogOut.Text = "Log-Out";
            button_LogOut.UseVisualStyleBackColor = true;
            button_LogOut.Click += button_LogOut_Click;
            // 
            // textBox_StockModificar
            // 
            textBox_StockModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_StockModificar.Location = new Point(331, 627);
            textBox_StockModificar.Name = "textBox_StockModificar";
            textBox_StockModificar.Size = new Size(196, 27);
            textBox_StockModificar.TabIndex = 36;
            // 
            // txtSTOCKMODIFCAR
            // 
            txtSTOCKMODIFCAR.Enabled = false;
            txtSTOCKMODIFCAR.Font = new Font("Century Gothic", 9.75F);
            txtSTOCKMODIFCAR.Location = new Point(219, 627);
            txtSTOCKMODIFCAR.Name = "txtSTOCKMODIFCAR";
            txtSTOCKMODIFCAR.ReadOnly = true;
            txtSTOCKMODIFCAR.Size = new Size(105, 27);
            txtSTOCKMODIFCAR.TabIndex = 35;
            txtSTOCKMODIFCAR.Text = "STOCK:";
            // 
            // textBox_PrecioModificar
            // 
            textBox_PrecioModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_PrecioModificar.Location = new Point(331, 593);
            textBox_PrecioModificar.Name = "textBox_PrecioModificar";
            textBox_PrecioModificar.Size = new Size(196, 27);
            textBox_PrecioModificar.TabIndex = 34;
            // 
            // txtPRECIOMODIFICAR
            // 
            txtPRECIOMODIFICAR.Enabled = false;
            txtPRECIOMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtPRECIOMODIFICAR.Location = new Point(219, 593);
            txtPRECIOMODIFICAR.Name = "txtPRECIOMODIFICAR";
            txtPRECIOMODIFICAR.ReadOnly = true;
            txtPRECIOMODIFICAR.Size = new Size(105, 27);
            txtPRECIOMODIFICAR.TabIndex = 33;
            txtPRECIOMODIFICAR.Text = "PRECIO:";
            // 
            // textBox_GeneroModificar
            // 
            textBox_GeneroModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_GeneroModificar.Location = new Point(331, 494);
            textBox_GeneroModificar.Name = "textBox_GeneroModificar";
            textBox_GeneroModificar.Size = new Size(196, 27);
            textBox_GeneroModificar.TabIndex = 32;
            // 
            // txtGENEROMODIFICAR
            // 
            txtGENEROMODIFICAR.Enabled = false;
            txtGENEROMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtGENEROMODIFICAR.Location = new Point(219, 494);
            txtGENEROMODIFICAR.Name = "txtGENEROMODIFICAR";
            txtGENEROMODIFICAR.ReadOnly = true;
            txtGENEROMODIFICAR.Size = new Size(105, 27);
            txtGENEROMODIFICAR.TabIndex = 31;
            txtGENEROMODIFICAR.Text = "GENERO:";
            // 
            // textBox_PlataformaModificar
            // 
            textBox_PlataformaModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_PlataformaModificar.Location = new Point(347, 527);
            textBox_PlataformaModificar.Name = "textBox_PlataformaModificar";
            textBox_PlataformaModificar.Size = new Size(180, 27);
            textBox_PlataformaModificar.TabIndex = 44;
            // 
            // txtPLATAFORMAMODIFICAR
            // 
            txtPLATAFORMAMODIFICAR.Enabled = false;
            txtPLATAFORMAMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtPLATAFORMAMODIFICAR.Location = new Point(219, 527);
            txtPLATAFORMAMODIFICAR.Name = "txtPLATAFORMAMODIFICAR";
            txtPLATAFORMAMODIFICAR.ReadOnly = true;
            txtPLATAFORMAMODIFICAR.Size = new Size(122, 27);
            txtPLATAFORMAMODIFICAR.TabIndex = 43;
            txtPLATAFORMAMODIFICAR.Text = "PLATAFORMA:";
            // 
            // textBox_ModalidadModificar
            // 
            textBox_ModalidadModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_ModalidadModificar.Location = new Point(347, 560);
            textBox_ModalidadModificar.Name = "textBox_ModalidadModificar";
            textBox_ModalidadModificar.Size = new Size(180, 27);
            textBox_ModalidadModificar.TabIndex = 42;
            // 
            // txtMODALIDADMODIFY
            // 
            txtMODALIDADMODIFY.Enabled = false;
            txtMODALIDADMODIFY.Font = new Font("Century Gothic", 9.75F);
            txtMODALIDADMODIFY.Location = new Point(219, 560);
            txtMODALIDADMODIFY.Name = "txtMODALIDADMODIFY";
            txtMODALIDADMODIFY.ReadOnly = true;
            txtMODALIDADMODIFY.Size = new Size(122, 27);
            txtMODALIDADMODIFY.TabIndex = 41;
            txtMODALIDADMODIFY.Text = "MODALIDAD:";
            // 
            // textBox_NombreModificar
            // 
            textBox_NombreModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_NombreModificar.Location = new Point(307, 461);
            textBox_NombreModificar.Name = "textBox_NombreModificar";
            textBox_NombreModificar.Size = new Size(220, 27);
            textBox_NombreModificar.TabIndex = 40;
            // 
            // txtTITULOMODIFICAR
            // 
            txtTITULOMODIFICAR.Enabled = false;
            txtTITULOMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtTITULOMODIFICAR.Location = new Point(219, 461);
            txtTITULOMODIFICAR.Name = "txtTITULOMODIFICAR";
            txtTITULOMODIFICAR.ReadOnly = true;
            txtTITULOMODIFICAR.Size = new Size(82, 27);
            txtTITULOMODIFICAR.TabIndex = 39;
            txtTITULOMODIFICAR.Text = "NOMBRE:";
            // 
            // textBox_IDModificar
            // 
            textBox_IDModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_IDModificar.Location = new Point(253, 428);
            textBox_IDModificar.Name = "textBox_IDModificar";
            textBox_IDModificar.Size = new Size(274, 27);
            textBox_IDModificar.TabIndex = 38;
            // 
            // txtMODIFICARID
            // 
            txtMODIFICARID.Enabled = false;
            txtMODIFICARID.Font = new Font("Century Gothic", 9.75F);
            txtMODIFICARID.Location = new Point(219, 428);
            txtMODIFICARID.Name = "txtMODIFICARID";
            txtMODIFICARID.ReadOnly = true;
            txtMODIFICARID.Size = new Size(27, 27);
            txtMODIFICARID.TabIndex = 37;
            txtMODIFICARID.Text = "ID:";
            // 
            // txtMODIFICAR
            // 
            txtMODIFICAR.Enabled = false;
            txtMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtMODIFICAR.Location = new Point(219, 395);
            txtMODIFICAR.Name = "txtMODIFICAR";
            txtMODIFICAR.Size = new Size(308, 27);
            txtMODIFICAR.TabIndex = 45;
            txtMODIFICAR.Text = "MODIFICAR";
            txtMODIFICAR.TextAlign = HorizontalAlignment.Center;
            // 
            // button_CargarImagenModificar
            // 
            button_CargarImagenModificar.Location = new Point(662, 395);
            button_CargarImagenModificar.Name = "button_CargarImagenModificar";
            button_CargarImagenModificar.Size = new Size(158, 29);
            button_CargarImagenModificar.TabIndex = 46;
            button_CargarImagenModificar.Text = "CARGAR IMAGEN:";
            button_CargarImagenModificar.UseVisualStyleBackColor = true;
            button_CargarImagenModificar.Click += button_CargarImagenModificar_Click;
            // 
            // button_Modificar
            // 
            button_Modificar.Location = new Point(644, 615);
            button_Modificar.Name = "button_Modificar";
            button_Modificar.Size = new Size(185, 29);
            button_Modificar.TabIndex = 47;
            button_Modificar.Text = "Modificar";
            button_Modificar.UseVisualStyleBackColor = true;
            button_Modificar.Click += button_Modificar_Click;
            // 
            // pictureBox_Subir
            // 
            pictureBox_Subir.Location = new Point(903, 344);
            pictureBox_Subir.Name = "pictureBox_Subir";
            pictureBox_Subir.Size = new Size(291, 169);
            pictureBox_Subir.TabIndex = 48;
            pictureBox_Subir.TabStop = false;
            // 
            // btncerrar
            // 
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(1219, 5);
            btncerrar.Margin = new Padding(3, 4, 3, 4);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(29, 33);
            btncerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btncerrar.TabIndex = 49;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1262, 673);
            Controls.Add(btncerrar);
            Controls.Add(pictureBox_Subir);
            Controls.Add(button_Modificar);
            Controls.Add(button_CargarImagenModificar);
            Controls.Add(txtMODIFICAR);
            Controls.Add(textBox_PlataformaModificar);
            Controls.Add(txtPLATAFORMAMODIFICAR);
            Controls.Add(textBox_ModalidadModificar);
            Controls.Add(txtMODALIDADMODIFY);
            Controls.Add(textBox_NombreModificar);
            Controls.Add(txtTITULOMODIFICAR);
            Controls.Add(textBox_IDModificar);
            Controls.Add(txtMODIFICARID);
            Controls.Add(textBox_StockModificar);
            Controls.Add(txtSTOCKMODIFCAR);
            Controls.Add(textBox_PrecioModificar);
            Controls.Add(txtPRECIOMODIFICAR);
            Controls.Add(textBox_GeneroModificar);
            Controls.Add(txtGENEROMODIFICAR);
            Controls.Add(button_LogOut);
            Controls.Add(dataGridView_Inventario);
            Controls.Add(button_CargarImagenSubir);
            Controls.Add(pictureBox_Modificar);
            Controls.Add(button_EliminarProducto);
            Controls.Add(textBox_IDBorrar);
            Controls.Add(textBox7);
            Controls.Add(textBoxBAJAR);
            Controls.Add(textBox_StockSubir);
            Controls.Add(txtSTOCK);
            Controls.Add(textBox_PrecioSubir);
            Controls.Add(txtPRECIO);
            Controls.Add(textBox_GeneroSubir);
            Controls.Add(txtGENERO);
            Controls.Add(textBox_PlataformaSubir);
            Controls.Add(txtPLATAFORMA);
            Controls.Add(textBox_ModalidadSubir);
            Controls.Add(txtMODALIDAD);
            Controls.Add(textBox_NombreSubir);
            Controls.Add(txtTITULO);
            Controls.Add(textBox_IDSubir);
            Controls.Add(txtID);
            Controls.Add(txtSUBIRPRODUCTOS);
            Controls.Add(button_Subir);
            Controls.Add(button_MOSTRARINVENTARIO);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            MouseDown += FormAdmin_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Modificar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Inventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Subir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_MOSTRARINVENTARIO;
        private Button button_Subir;
        private TextBox txtSUBIRPRODUCTOS;
        private TextBox txtID;
        private TextBox textBox_IDSubir;
        private TextBox textBox_NombreSubir;
        private TextBox txtTITULO;
        private TextBox textBox_ModalidadSubir;
        private TextBox txtMODALIDAD;
        private TextBox textBox_GeneroSubir;
        private TextBox txtGENERO;
        private TextBox textBox_PlataformaSubir;
        private TextBox txtPLATAFORMA;
        private TextBox textBox_PrecioSubir;
        private TextBox txtPRECIO;
        private TextBox textBox_StockSubir;
        private TextBox txtSTOCK;
        private TextBox textBoxBAJAR;
        private TextBox textBox_IDBorrar;
        private TextBox textBox7;
        private Button button_EliminarProducto;
        private PictureBox pictureBox_Modificar;
        private Button button_CargarImagenSubir;
        private DataGridView dataGridView_Inventario;
        private Button button_LogOut;
        private TextBox textBox_StockModificar;
        private TextBox txtSTOCKMODIFCAR;
        private TextBox textBox_PrecioModificar;
        private TextBox txtPRECIOMODIFICAR;
        private TextBox textBox_GeneroModificar;
        private TextBox txtGENEROMODIFICAR;
        private TextBox textBox_PlataformaModificar;
        private TextBox txtPLATAFORMAMODIFICAR;
        private TextBox textBox_ModalidadModificar;
        private TextBox txtMODALIDADMODIFY;
        private TextBox textBox_NombreModificar;
        private TextBox txtTITULOMODIFICAR;
        private TextBox textBox_IDModificar;
        private TextBox txtMODIFICARID;
        private TextBox txtMODIFICAR;
        private Button button_CargarImagenModificar;
        private Button button_Modificar;
        private PictureBox pictureBox_Subir;
        private PictureBox btncerrar;
    }
}