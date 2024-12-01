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
            pictureBoxIMAGEMODIFY = new PictureBox();
            button_CargarImagen = new Button();
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
            buttonCARGARIMAGEMODIFY = new Button();
            button_Modificar = new Button();
            pictureBoxSUBERIMAGEN = new PictureBox();
            btncerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIMAGEMODIFY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Inventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSUBERIMAGEN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            SuspendLayout();
            // 
            // button_MOSTRARINVENTARIO
            // 
            button_MOSTRARINVENTARIO.Location = new Point(36, 2);
            button_MOSTRARINVENTARIO.Margin = new Padding(3, 2, 3, 2);
            button_MOSTRARINVENTARIO.Name = "button_MOSTRARINVENTARIO";
            button_MOSTRARINVENTARIO.Size = new Size(654, 22);
            button_MOSTRARINVENTARIO.TabIndex = 4;
            button_MOSTRARINVENTARIO.Text = "INVENTARIO";
            button_MOSTRARINVENTARIO.UseVisualStyleBackColor = true;
            button_MOSTRARINVENTARIO.Click += button_MostrarInventario_Click;
            // 
            // button_Subir
            // 
            button_Subir.Location = new Point(761, 389);
            button_Subir.Margin = new Padding(3, 2, 3, 2);
            button_Subir.Name = "button_Subir";
            button_Subir.Size = new Size(82, 22);
            button_Subir.TabIndex = 5;
            button_Subir.Text = "Subir";
            button_Subir.UseVisualStyleBackColor = true;
            button_Subir.Click += button_Subir_Click;
            // 
            // txtSUBIRPRODUCTOS
            // 
            txtSUBIRPRODUCTOS.Font = new Font("Century Gothic", 9.75F);
            txtSUBIRPRODUCTOS.Location = new Point(761, 34);
            txtSUBIRPRODUCTOS.Margin = new Padding(3, 2, 3, 2);
            txtSUBIRPRODUCTOS.Name = "txtSUBIRPRODUCTOS";
            txtSUBIRPRODUCTOS.Size = new Size(331, 23);
            txtSUBIRPRODUCTOS.TabIndex = 6;
            txtSUBIRPRODUCTOS.Text = "SUBIR PRODUCTO";
            txtSUBIRPRODUCTOS.TextAlign = HorizontalAlignment.Center;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Century Gothic", 9.75F);
            txtID.Location = new Point(761, 59);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(24, 23);
            txtID.TabIndex = 7;
            txtID.Text = "ID:";
            // 
            // textBox_IDSubir
            // 
            textBox_IDSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_IDSubir.Location = new Point(790, 59);
            textBox_IDSubir.Margin = new Padding(3, 2, 3, 2);
            textBox_IDSubir.Name = "textBox_IDSubir";
            textBox_IDSubir.PlaceholderText = "INGRESA ID";
            textBox_IDSubir.Size = new Size(110, 23);
            textBox_IDSubir.TabIndex = 8;
            // 
            // textBox_NombreSubir
            // 
            textBox_NombreSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_NombreSubir.Location = new Point(818, 83);
            textBox_NombreSubir.Margin = new Padding(3, 2, 3, 2);
            textBox_NombreSubir.Name = "textBox_NombreSubir";
            textBox_NombreSubir.PlaceholderText = "INGRESA TITULO DEL JUEGO";
            textBox_NombreSubir.Size = new Size(212, 23);
            textBox_NombreSubir.TabIndex = 10;
            // 
            // txtTITULO
            // 
            txtTITULO.Enabled = false;
            txtTITULO.Font = new Font("Century Gothic", 9.75F);
            txtTITULO.Location = new Point(761, 83);
            txtTITULO.Margin = new Padding(3, 2, 3, 2);
            txtTITULO.Name = "txtTITULO";
            txtTITULO.ReadOnly = true;
            txtTITULO.Size = new Size(52, 23);
            txtTITULO.TabIndex = 9;
            txtTITULO.Text = "TITULO:";
            // 
            // textBox_ModalidadSubir
            // 
            textBox_ModalidadSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_ModalidadSubir.Location = new Point(858, 108);
            textBox_ModalidadSubir.Margin = new Padding(3, 2, 3, 2);
            textBox_ModalidadSubir.Name = "textBox_ModalidadSubir";
            textBox_ModalidadSubir.PlaceholderText = "INGRESA MODALIDAD";
            textBox_ModalidadSubir.Size = new Size(142, 23);
            textBox_ModalidadSubir.TabIndex = 12;
            // 
            // txtMODALIDAD
            // 
            txtMODALIDAD.Enabled = false;
            txtMODALIDAD.Font = new Font("Century Gothic", 9.75F);
            txtMODALIDAD.Location = new Point(761, 108);
            txtMODALIDAD.Margin = new Padding(3, 2, 3, 2);
            txtMODALIDAD.Name = "txtMODALIDAD";
            txtMODALIDAD.ReadOnly = true;
            txtMODALIDAD.Size = new Size(92, 23);
            txtMODALIDAD.TabIndex = 11;
            txtMODALIDAD.Text = "MODALIDAD:";
            // 
            // textBox_GeneroSubir
            // 
            textBox_GeneroSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_GeneroSubir.Location = new Point(858, 158);
            textBox_GeneroSubir.Margin = new Padding(3, 2, 3, 2);
            textBox_GeneroSubir.Name = "textBox_GeneroSubir";
            textBox_GeneroSubir.PlaceholderText = "INGRESA EL GENERO";
            textBox_GeneroSubir.Size = new Size(142, 23);
            textBox_GeneroSubir.TabIndex = 16;
            // 
            // txtGENERO
            // 
            txtGENERO.Enabled = false;
            txtGENERO.Font = new Font("Century Gothic", 9.75F);
            txtGENERO.Location = new Point(761, 158);
            txtGENERO.Margin = new Padding(3, 2, 3, 2);
            txtGENERO.Name = "txtGENERO";
            txtGENERO.ReadOnly = true;
            txtGENERO.Size = new Size(92, 23);
            txtGENERO.TabIndex = 15;
            txtGENERO.Text = "GENERO:";
            // 
            // textBox_PlataformaSubir
            // 
            textBox_PlataformaSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_PlataformaSubir.Location = new Point(858, 133);
            textBox_PlataformaSubir.Margin = new Padding(3, 2, 3, 2);
            textBox_PlataformaSubir.Name = "textBox_PlataformaSubir";
            textBox_PlataformaSubir.PlaceholderText = "INGRESA PLATAFORMA";
            textBox_PlataformaSubir.Size = new Size(172, 23);
            textBox_PlataformaSubir.TabIndex = 14;
            // 
            // txtPLATAFORMA
            // 
            txtPLATAFORMA.Enabled = false;
            txtPLATAFORMA.Font = new Font("Century Gothic", 9.75F);
            txtPLATAFORMA.Location = new Point(761, 133);
            txtPLATAFORMA.Margin = new Padding(3, 2, 3, 2);
            txtPLATAFORMA.Name = "txtPLATAFORMA";
            txtPLATAFORMA.ReadOnly = true;
            txtPLATAFORMA.Size = new Size(92, 23);
            txtPLATAFORMA.TabIndex = 13;
            txtPLATAFORMA.Text = "PLATAFORMA:";
            // 
            // textBox_PrecioSubir
            // 
            textBox_PrecioSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_PrecioSubir.Location = new Point(858, 183);
            textBox_PrecioSubir.Margin = new Padding(3, 2, 3, 2);
            textBox_PrecioSubir.Name = "textBox_PrecioSubir";
            textBox_PrecioSubir.PlaceholderText = "INGRESA EL PRECIO";
            textBox_PrecioSubir.Size = new Size(142, 23);
            textBox_PrecioSubir.TabIndex = 18;
            // 
            // txtPRECIO
            // 
            txtPRECIO.Enabled = false;
            txtPRECIO.Font = new Font("Century Gothic", 9.75F);
            txtPRECIO.Location = new Point(761, 183);
            txtPRECIO.Margin = new Padding(3, 2, 3, 2);
            txtPRECIO.Name = "txtPRECIO";
            txtPRECIO.ReadOnly = true;
            txtPRECIO.Size = new Size(92, 23);
            txtPRECIO.TabIndex = 17;
            txtPRECIO.Text = "PRECIO:";
            // 
            // textBox_StockSubir
            // 
            textBox_StockSubir.Font = new Font("Century Gothic", 9.75F);
            textBox_StockSubir.Location = new Point(858, 207);
            textBox_StockSubir.Margin = new Padding(3, 2, 3, 2);
            textBox_StockSubir.Name = "textBox_StockSubir";
            textBox_StockSubir.PlaceholderText = "INGRESA LA CANTIDAD DE COPIAS";
            textBox_StockSubir.Size = new Size(234, 23);
            textBox_StockSubir.TabIndex = 20;
            // 
            // txtSTOCK
            // 
            txtSTOCK.Enabled = false;
            txtSTOCK.Font = new Font("Century Gothic", 9.75F);
            txtSTOCK.Location = new Point(761, 207);
            txtSTOCK.Margin = new Padding(3, 2, 3, 2);
            txtSTOCK.Name = "txtSTOCK";
            txtSTOCK.ReadOnly = true;
            txtSTOCK.Size = new Size(92, 23);
            txtSTOCK.TabIndex = 19;
            txtSTOCK.Text = "STOCK:";
            // 
            // textBoxBAJAR
            // 
            textBoxBAJAR.Enabled = false;
            textBoxBAJAR.Font = new Font("Century Gothic", 9.75F);
            textBoxBAJAR.Location = new Point(36, 296);
            textBoxBAJAR.Margin = new Padding(3, 2, 3, 2);
            textBoxBAJAR.Name = "textBoxBAJAR";
            textBoxBAJAR.Size = new Size(152, 23);
            textBoxBAJAR.TabIndex = 23;
            textBoxBAJAR.Text = "BAJAR PRODUCTO";
            textBoxBAJAR.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_IDBorrar
            // 
            textBox_IDBorrar.Font = new Font("Century Gothic", 9.75F);
            textBox_IDBorrar.Location = new Point(66, 321);
            textBox_IDBorrar.Margin = new Padding(3, 2, 3, 2);
            textBox_IDBorrar.Name = "textBox_IDBorrar";
            textBox_IDBorrar.PlaceholderText = "INGRESA ID";
            textBox_IDBorrar.Size = new Size(110, 23);
            textBox_IDBorrar.TabIndex = 25;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Font = new Font("Century Gothic", 9.75F);
            textBox7.Location = new Point(37, 321);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(24, 23);
            textBox7.TabIndex = 24;
            textBox7.Text = "ID:";
            // 
            // button_EliminarProducto
            // 
            button_EliminarProducto.Location = new Point(36, 348);
            button_EliminarProducto.Margin = new Padding(3, 2, 3, 2);
            button_EliminarProducto.Name = "button_EliminarProducto";
            button_EliminarProducto.Size = new Size(82, 22);
            button_EliminarProducto.TabIndex = 26;
            button_EliminarProducto.Text = "ELIMINAR";
            button_EliminarProducto.UseVisualStyleBackColor = true;
            button_EliminarProducto.Click += button_EliminarProducto_Click;
            // 
            // pictureBoxIMAGEMODIFY
            // 
            pictureBoxIMAGEMODIFY.Location = new Point(488, 329);
            pictureBoxIMAGEMODIFY.Margin = new Padding(3, 2, 3, 2);
            pictureBoxIMAGEMODIFY.Name = "pictureBoxIMAGEMODIFY";
            pictureBoxIMAGEMODIFY.Size = new Size(255, 127);
            pictureBoxIMAGEMODIFY.TabIndex = 27;
            pictureBoxIMAGEMODIFY.TabStop = false;
            // 
            // button_CargarImagen
            // 
            button_CargarImagen.Location = new Point(761, 232);
            button_CargarImagen.Margin = new Padding(3, 2, 3, 2);
            button_CargarImagen.Name = "button_CargarImagen";
            button_CargarImagen.Size = new Size(138, 22);
            button_CargarImagen.TabIndex = 28;
            button_CargarImagen.Text = "CARGAR IMAGEN:";
            button_CargarImagen.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Inventario
            // 
            dataGridView_Inventario.AllowUserToAddRows = false;
            dataGridView_Inventario.AllowUserToDeleteRows = false;
            dataGridView_Inventario.AllowUserToResizeColumns = false;
            dataGridView_Inventario.AllowUserToResizeRows = false;
            dataGridView_Inventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Inventario.Location = new Point(36, 34);
            dataGridView_Inventario.Margin = new Padding(3, 2, 3, 2);
            dataGridView_Inventario.Name = "dataGridView_Inventario";
            dataGridView_Inventario.RowHeadersVisible = false;
            dataGridView_Inventario.RowHeadersWidth = 51;
            dataGridView_Inventario.Size = new Size(654, 258);
            dataGridView_Inventario.TabIndex = 29;
            // 
            // button_LogOut
            // 
            button_LogOut.Location = new Point(10, 460);
            button_LogOut.Margin = new Padding(3, 2, 3, 2);
            button_LogOut.Name = "button_LogOut";
            button_LogOut.Size = new Size(114, 38);
            button_LogOut.TabIndex = 30;
            button_LogOut.Text = "Log-Out";
            button_LogOut.UseVisualStyleBackColor = true;
            button_LogOut.Click += button_LogOut_Click;
            // 
            // textBox_StockModificar
            // 
            textBox_StockModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_StockModificar.Location = new Point(290, 470);
            textBox_StockModificar.Margin = new Padding(3, 2, 3, 2);
            textBox_StockModificar.Name = "textBox_StockModificar";
            textBox_StockModificar.PlaceholderText = "INGRESA LA CANTIDAD DE COPIAS";
            textBox_StockModificar.Size = new Size(217, 23);
            textBox_StockModificar.TabIndex = 36;
            // 
            // txtSTOCKMODIFCAR
            // 
            txtSTOCKMODIFCAR.Enabled = false;
            txtSTOCKMODIFCAR.Font = new Font("Century Gothic", 9.75F);
            txtSTOCKMODIFCAR.Location = new Point(192, 470);
            txtSTOCKMODIFCAR.Margin = new Padding(3, 2, 3, 2);
            txtSTOCKMODIFCAR.Name = "txtSTOCKMODIFCAR";
            txtSTOCKMODIFCAR.ReadOnly = true;
            txtSTOCKMODIFCAR.Size = new Size(92, 23);
            txtSTOCKMODIFCAR.TabIndex = 35;
            txtSTOCKMODIFCAR.Text = "STOCK:";
            // 
            // textBox_PrecioModificar
            // 
            textBox_PrecioModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_PrecioModificar.Location = new Point(290, 445);
            textBox_PrecioModificar.Margin = new Padding(3, 2, 3, 2);
            textBox_PrecioModificar.Name = "textBox_PrecioModificar";
            textBox_PrecioModificar.PlaceholderText = "INGRESA EL PRECIO";
            textBox_PrecioModificar.Size = new Size(142, 23);
            textBox_PrecioModificar.TabIndex = 34;
            // 
            // txtPRECIOMODIFICAR
            // 
            txtPRECIOMODIFICAR.Enabled = false;
            txtPRECIOMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtPRECIOMODIFICAR.Location = new Point(192, 445);
            txtPRECIOMODIFICAR.Margin = new Padding(3, 2, 3, 2);
            txtPRECIOMODIFICAR.Name = "txtPRECIOMODIFICAR";
            txtPRECIOMODIFICAR.ReadOnly = true;
            txtPRECIOMODIFICAR.Size = new Size(92, 23);
            txtPRECIOMODIFICAR.TabIndex = 33;
            txtPRECIOMODIFICAR.Text = "PRECIO:";
            // 
            // textBox_GeneroModificar
            // 
            textBox_GeneroModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_GeneroModificar.Location = new Point(290, 420);
            textBox_GeneroModificar.Margin = new Padding(3, 2, 3, 2);
            textBox_GeneroModificar.Name = "textBox_GeneroModificar";
            textBox_GeneroModificar.PlaceholderText = "INGRESA EL GENERO";
            textBox_GeneroModificar.Size = new Size(142, 23);
            textBox_GeneroModificar.TabIndex = 32;
            // 
            // txtGENEROMODIFICAR
            // 
            txtGENEROMODIFICAR.Enabled = false;
            txtGENEROMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtGENEROMODIFICAR.Location = new Point(192, 420);
            txtGENEROMODIFICAR.Margin = new Padding(3, 2, 3, 2);
            txtGENEROMODIFICAR.Name = "txtGENEROMODIFICAR";
            txtGENEROMODIFICAR.ReadOnly = true;
            txtGENEROMODIFICAR.Size = new Size(92, 23);
            txtGENEROMODIFICAR.TabIndex = 31;
            txtGENEROMODIFICAR.Text = "GENERO:";
            // 
            // textBox_PlataformaModificar
            // 
            textBox_PlataformaModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_PlataformaModificar.Location = new Point(290, 395);
            textBox_PlataformaModificar.Margin = new Padding(3, 2, 3, 2);
            textBox_PlataformaModificar.Name = "textBox_PlataformaModificar";
            textBox_PlataformaModificar.PlaceholderText = "INGRESA PLATAFORMA";
            textBox_PlataformaModificar.Size = new Size(172, 23);
            textBox_PlataformaModificar.TabIndex = 44;
            // 
            // txtPLATAFORMAMODIFICAR
            // 
            txtPLATAFORMAMODIFICAR.Enabled = false;
            txtPLATAFORMAMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtPLATAFORMAMODIFICAR.Location = new Point(192, 395);
            txtPLATAFORMAMODIFICAR.Margin = new Padding(3, 2, 3, 2);
            txtPLATAFORMAMODIFICAR.Name = "txtPLATAFORMAMODIFICAR";
            txtPLATAFORMAMODIFICAR.ReadOnly = true;
            txtPLATAFORMAMODIFICAR.Size = new Size(92, 23);
            txtPLATAFORMAMODIFICAR.TabIndex = 43;
            txtPLATAFORMAMODIFICAR.Text = "PLATAFORMA:";
            // 
            // textBox_ModalidadModificar
            // 
            textBox_ModalidadModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_ModalidadModificar.Location = new Point(290, 370);
            textBox_ModalidadModificar.Margin = new Padding(3, 2, 3, 2);
            textBox_ModalidadModificar.Name = "textBox_ModalidadModificar";
            textBox_ModalidadModificar.PlaceholderText = "INGRESA MODALIDAD";
            textBox_ModalidadModificar.Size = new Size(142, 23);
            textBox_ModalidadModificar.TabIndex = 42;
            // 
            // txtMODALIDADMODIFY
            // 
            txtMODALIDADMODIFY.Enabled = false;
            txtMODALIDADMODIFY.Font = new Font("Century Gothic", 9.75F);
            txtMODALIDADMODIFY.Location = new Point(192, 370);
            txtMODALIDADMODIFY.Margin = new Padding(3, 2, 3, 2);
            txtMODALIDADMODIFY.Name = "txtMODALIDADMODIFY";
            txtMODALIDADMODIFY.ReadOnly = true;
            txtMODALIDADMODIFY.Size = new Size(92, 23);
            txtMODALIDADMODIFY.TabIndex = 41;
            txtMODALIDADMODIFY.Text = "MODALIDAD:";
            // 
            // textBox_NombreModificar
            // 
            textBox_NombreModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_NombreModificar.Location = new Point(249, 346);
            textBox_NombreModificar.Margin = new Padding(3, 2, 3, 2);
            textBox_NombreModificar.Name = "textBox_NombreModificar";
            textBox_NombreModificar.PlaceholderText = "INGRESA TITULO DEL JUEGO";
            textBox_NombreModificar.Size = new Size(172, 23);
            textBox_NombreModificar.TabIndex = 40;
            // 
            // txtTITULOMODIFICAR
            // 
            txtTITULOMODIFICAR.Enabled = false;
            txtTITULOMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtTITULOMODIFICAR.Location = new Point(192, 346);
            txtTITULOMODIFICAR.Margin = new Padding(3, 2, 3, 2);
            txtTITULOMODIFICAR.Name = "txtTITULOMODIFICAR";
            txtTITULOMODIFICAR.ReadOnly = true;
            txtTITULOMODIFICAR.Size = new Size(52, 23);
            txtTITULOMODIFICAR.TabIndex = 39;
            txtTITULOMODIFICAR.Text = "TITULO:";
            // 
            // textBox_IDModificar
            // 
            textBox_IDModificar.Font = new Font("Century Gothic", 9.75F);
            textBox_IDModificar.Location = new Point(221, 321);
            textBox_IDModificar.Margin = new Padding(3, 2, 3, 2);
            textBox_IDModificar.Name = "textBox_IDModificar";
            textBox_IDModificar.PlaceholderText = "IDENTIFICAR ID";
            textBox_IDModificar.Size = new Size(110, 23);
            textBox_IDModificar.TabIndex = 38;
            // 
            // txtMODIFICARID
            // 
            txtMODIFICARID.Enabled = false;
            txtMODIFICARID.Font = new Font("Century Gothic", 9.75F);
            txtMODIFICARID.Location = new Point(192, 321);
            txtMODIFICARID.Margin = new Padding(3, 2, 3, 2);
            txtMODIFICARID.Name = "txtMODIFICARID";
            txtMODIFICARID.ReadOnly = true;
            txtMODIFICARID.Size = new Size(24, 23);
            txtMODIFICARID.TabIndex = 37;
            txtMODIFICARID.Text = "ID:";
            // 
            // txtMODIFICAR
            // 
            txtMODIFICAR.Enabled = false;
            txtMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtMODIFICAR.Location = new Point(192, 296);
            txtMODIFICAR.Margin = new Padding(3, 2, 3, 2);
            txtMODIFICAR.Name = "txtMODIFICAR";
            txtMODIFICAR.Size = new Size(110, 23);
            txtMODIFICAR.TabIndex = 45;
            txtMODIFICAR.Text = "MODIFICAR";
            // 
            // buttonCARGARIMAGEMODIFY
            // 
            buttonCARGARIMAGEMODIFY.Location = new Point(552, 303);
            buttonCARGARIMAGEMODIFY.Margin = new Padding(3, 2, 3, 2);
            buttonCARGARIMAGEMODIFY.Name = "buttonCARGARIMAGEMODIFY";
            buttonCARGARIMAGEMODIFY.Size = new Size(138, 22);
            buttonCARGARIMAGEMODIFY.TabIndex = 46;
            buttonCARGARIMAGEMODIFY.Text = "CARGAR IMAGEN:";
            buttonCARGARIMAGEMODIFY.UseVisualStyleBackColor = true;
            // 
            // button_Modificar
            // 
            button_Modificar.Location = new Point(536, 468);
            button_Modificar.Margin = new Padding(3, 2, 3, 2);
            button_Modificar.Name = "button_Modificar";
            button_Modificar.Size = new Size(162, 22);
            button_Modificar.TabIndex = 47;
            button_Modificar.Text = "Modificar";
            button_Modificar.UseVisualStyleBackColor = true;
            button_Modificar.Click += button_Modificar_Click;
            // 
            // pictureBoxSUBERIMAGEN
            // 
            pictureBoxSUBERIMAGEN.Location = new Point(761, 258);
            pictureBoxSUBERIMAGEN.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSUBERIMAGEN.Name = "pictureBoxSUBERIMAGEN";
            pictureBoxSUBERIMAGEN.Size = new Size(255, 127);
            pictureBoxSUBERIMAGEN.TabIndex = 48;
            pictureBoxSUBERIMAGEN.TabStop = false;
            // 
            // btncerrar
            // 
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(1067, 4);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(25, 25);
            btncerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btncerrar.TabIndex = 49;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1104, 505);
            Controls.Add(btncerrar);
            Controls.Add(pictureBoxSUBERIMAGEN);
            Controls.Add(button_Modificar);
            Controls.Add(buttonCARGARIMAGEMODIFY);
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
            Controls.Add(button_CargarImagen);
            Controls.Add(pictureBoxIMAGEMODIFY);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            MouseDown += FormAdmin_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIMAGEMODIFY).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Inventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSUBERIMAGEN).EndInit();
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
        private PictureBox pictureBoxIMAGEMODIFY;
        private Button button_CargarImagen;
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
        private Button buttonCARGARIMAGEMODIFY;
        private Button button_Modificar;
        private PictureBox pictureBoxSUBERIMAGEN;
        private PictureBox btncerrar;
    }
}