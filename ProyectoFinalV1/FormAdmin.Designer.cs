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
            buttonGUARDARPRODUCTO = new Button();
            txtSUBIRPRODUCTOS = new TextBox();
            txtID = new TextBox();
            textBoxID = new TextBox();
            textBoxTITULOJUEGO = new TextBox();
            txtTITULO = new TextBox();
            textBoxMODALIDAD = new TextBox();
            txtMODALIDAD = new TextBox();
            textBoxGENERO = new TextBox();
            txtGENERO = new TextBox();
            textBoxPLATAFORMA = new TextBox();
            txtPLATAFORMA = new TextBox();
            textBoxPRECIO = new TextBox();
            txtPRECIO = new TextBox();
            textBoxSTOCK = new TextBox();
            txtSTOCK = new TextBox();
            textBoxBAJAR = new TextBox();
            textBox_IDBorrar = new TextBox();
            textBox7 = new TextBox();
            button_EliminarProducto = new Button();
            pictureBoxIMAGEMODIFY = new PictureBox();
            buttonCARGARIMAGEN = new Button();
            dataGridView_Inventario = new DataGridView();
            button_LogOut = new Button();
            txtSTOCKMODIFY = new TextBox();
            txtSTOCKMODIFCAR = new TextBox();
            txtPRICEMODIFY = new TextBox();
            txtPRECIOMODIFICAR = new TextBox();
            txtGENREMODIFY = new TextBox();
            txtGENEROMODIFICAR = new TextBox();
            txtPLATFORMMODIFY = new TextBox();
            txtPLATAFORMAMODIFICAR = new TextBox();
            txtMODEMODIFY = new TextBox();
            txtMODALIDADMODIFY = new TextBox();
            txtGAMETITLE = new TextBox();
            txtTITULOMODIFICAR = new TextBox();
            txtIDENTIFYID = new TextBox();
            txtMODIFICARID = new TextBox();
            txtMODIFICAR = new TextBox();
            buttonCARGARIMAGEMODIFY = new Button();
            buttonCARGARCAMBIOS = new Button();
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
            // buttonGUARDARPRODUCTO
            // 
            buttonGUARDARPRODUCTO.Location = new Point(761, 389);
            buttonGUARDARPRODUCTO.Margin = new Padding(3, 2, 3, 2);
            buttonGUARDARPRODUCTO.Name = "buttonGUARDARPRODUCTO";
            buttonGUARDARPRODUCTO.Size = new Size(82, 22);
            buttonGUARDARPRODUCTO.TabIndex = 5;
            buttonGUARDARPRODUCTO.Text = "Guardar";
            buttonGUARDARPRODUCTO.UseVisualStyleBackColor = true;
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
            txtSUBIRPRODUCTOS.TextChanged += txtSUBIRPRODUCTOS_TextChanged;
            // 
            // txtID
            // 
            txtID.Font = new Font("Century Gothic", 9.75F);
            txtID.Location = new Point(761, 59);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(24, 23);
            txtID.TabIndex = 7;
            txtID.Text = "ID:";
            // 
            // textBoxID
            // 
            textBoxID.Font = new Font("Century Gothic", 9.75F);
            textBoxID.Location = new Point(790, 59);
            textBoxID.Margin = new Padding(3, 2, 3, 2);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "INGRESA ID";
            textBoxID.Size = new Size(110, 23);
            textBoxID.TabIndex = 8;
            textBoxID.TextChanged += textBoxID_TextChanged;
            // 
            // textBoxTITULOJUEGO
            // 
            textBoxTITULOJUEGO.Font = new Font("Century Gothic", 9.75F);
            textBoxTITULOJUEGO.Location = new Point(818, 83);
            textBoxTITULOJUEGO.Margin = new Padding(3, 2, 3, 2);
            textBoxTITULOJUEGO.Name = "textBoxTITULOJUEGO";
            textBoxTITULOJUEGO.PlaceholderText = "INGRESA TITULO DEL JUEGO";
            textBoxTITULOJUEGO.Size = new Size(172, 23);
            textBoxTITULOJUEGO.TabIndex = 10;
            textBoxTITULOJUEGO.TextChanged += textBoxTITULOJUEGO_TextChanged_1;
            // 
            // txtTITULO
            // 
            txtTITULO.Font = new Font("Century Gothic", 9.75F);
            txtTITULO.Location = new Point(761, 83);
            txtTITULO.Margin = new Padding(3, 2, 3, 2);
            txtTITULO.Name = "txtTITULO";
            txtTITULO.Size = new Size(52, 23);
            txtTITULO.TabIndex = 9;
            txtTITULO.Text = "TITULO:";
            // 
            // textBoxMODALIDAD
            // 
            textBoxMODALIDAD.Font = new Font("Century Gothic", 9.75F);
            textBoxMODALIDAD.Location = new Point(858, 108);
            textBoxMODALIDAD.Margin = new Padding(3, 2, 3, 2);
            textBoxMODALIDAD.Name = "textBoxMODALIDAD";
            textBoxMODALIDAD.PlaceholderText = "INGRESA MODALIDAD";
            textBoxMODALIDAD.Size = new Size(142, 23);
            textBoxMODALIDAD.TabIndex = 12;
            textBoxMODALIDAD.TextChanged += textBoxMODALIDAD_TextChanged;
            // 
            // txtMODALIDAD
            // 
            txtMODALIDAD.Font = new Font("Century Gothic", 9.75F);
            txtMODALIDAD.Location = new Point(761, 108);
            txtMODALIDAD.Margin = new Padding(3, 2, 3, 2);
            txtMODALIDAD.Name = "txtMODALIDAD";
            txtMODALIDAD.Size = new Size(92, 23);
            txtMODALIDAD.TabIndex = 11;
            txtMODALIDAD.Text = "MODALIDAD:";
            // 
            // textBoxGENERO
            // 
            textBoxGENERO.Font = new Font("Century Gothic", 9.75F);
            textBoxGENERO.Location = new Point(858, 158);
            textBoxGENERO.Margin = new Padding(3, 2, 3, 2);
            textBoxGENERO.Name = "textBoxGENERO";
            textBoxGENERO.PlaceholderText = "INGRESA EL GENERO";
            textBoxGENERO.Size = new Size(142, 23);
            textBoxGENERO.TabIndex = 16;
            textBoxGENERO.TextChanged += textBoxGENERO_TextChanged;
            // 
            // txtGENERO
            // 
            txtGENERO.Font = new Font("Century Gothic", 9.75F);
            txtGENERO.Location = new Point(761, 158);
            txtGENERO.Margin = new Padding(3, 2, 3, 2);
            txtGENERO.Name = "txtGENERO";
            txtGENERO.Size = new Size(92, 23);
            txtGENERO.TabIndex = 15;
            txtGENERO.Text = "GENERO:";
            // 
            // textBoxPLATAFORMA
            // 
            textBoxPLATAFORMA.Font = new Font("Century Gothic", 9.75F);
            textBoxPLATAFORMA.Location = new Point(858, 133);
            textBoxPLATAFORMA.Margin = new Padding(3, 2, 3, 2);
            textBoxPLATAFORMA.Name = "textBoxPLATAFORMA";
            textBoxPLATAFORMA.PlaceholderText = "INGRESA PLATAFORMA";
            textBoxPLATAFORMA.Size = new Size(172, 23);
            textBoxPLATAFORMA.TabIndex = 14;
            textBoxPLATAFORMA.TextChanged += textBoxPLATAFORMA_TextChanged;
            // 
            // txtPLATAFORMA
            // 
            txtPLATAFORMA.Font = new Font("Century Gothic", 9.75F);
            txtPLATAFORMA.Location = new Point(761, 133);
            txtPLATAFORMA.Margin = new Padding(3, 2, 3, 2);
            txtPLATAFORMA.Name = "txtPLATAFORMA";
            txtPLATAFORMA.Size = new Size(92, 23);
            txtPLATAFORMA.TabIndex = 13;
            txtPLATAFORMA.Text = "PLATAFORMA:";
            // 
            // textBoxPRECIO
            // 
            textBoxPRECIO.Font = new Font("Century Gothic", 9.75F);
            textBoxPRECIO.Location = new Point(858, 183);
            textBoxPRECIO.Margin = new Padding(3, 2, 3, 2);
            textBoxPRECIO.Name = "textBoxPRECIO";
            textBoxPRECIO.PlaceholderText = "INGRESA EL PRECIO";
            textBoxPRECIO.Size = new Size(142, 23);
            textBoxPRECIO.TabIndex = 18;
            textBoxPRECIO.TextChanged += textBoxPRECIO_TextChanged;
            // 
            // txtPRECIO
            // 
            txtPRECIO.Font = new Font("Century Gothic", 9.75F);
            txtPRECIO.Location = new Point(761, 183);
            txtPRECIO.Margin = new Padding(3, 2, 3, 2);
            txtPRECIO.Name = "txtPRECIO";
            txtPRECIO.Size = new Size(92, 23);
            txtPRECIO.TabIndex = 17;
            txtPRECIO.Text = "PRECIO:";
            // 
            // textBoxSTOCK
            // 
            textBoxSTOCK.Font = new Font("Century Gothic", 9.75F);
            textBoxSTOCK.Location = new Point(858, 207);
            textBoxSTOCK.Margin = new Padding(3, 2, 3, 2);
            textBoxSTOCK.Name = "textBoxSTOCK";
            textBoxSTOCK.PlaceholderText = "INGRESA LA CANTIDAD DE COPIAS";
            textBoxSTOCK.Size = new Size(217, 23);
            textBoxSTOCK.TabIndex = 20;
            textBoxSTOCK.TextChanged += textBoxSTOCK_TextChanged;
            // 
            // txtSTOCK
            // 
            txtSTOCK.Font = new Font("Century Gothic", 9.75F);
            txtSTOCK.Location = new Point(761, 207);
            txtSTOCK.Margin = new Padding(3, 2, 3, 2);
            txtSTOCK.Name = "txtSTOCK";
            txtSTOCK.Size = new Size(92, 23);
            txtSTOCK.TabIndex = 19;
            txtSTOCK.Text = "STOCK:";
            // 
            // textBoxBAJAR
            // 
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
            textBox_IDBorrar.TextChanged += textBox_IDBorrar_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Century Gothic", 9.75F);
            textBox7.Location = new Point(37, 321);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
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
            // buttonCARGARIMAGEN
            // 
            buttonCARGARIMAGEN.Location = new Point(761, 232);
            buttonCARGARIMAGEN.Margin = new Padding(3, 2, 3, 2);
            buttonCARGARIMAGEN.Name = "buttonCARGARIMAGEN";
            buttonCARGARIMAGEN.Size = new Size(138, 22);
            buttonCARGARIMAGEN.TabIndex = 28;
            buttonCARGARIMAGEN.Text = "CARGAR IMAGEN:";
            buttonCARGARIMAGEN.UseVisualStyleBackColor = true;
            buttonCARGARIMAGEN.Click += buttonCARGARIMAGEN_Click;
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
            // txtSTOCKMODIFY
            // 
            txtSTOCKMODIFY.Font = new Font("Century Gothic", 9.75F);
            txtSTOCKMODIFY.Location = new Point(290, 470);
            txtSTOCKMODIFY.Margin = new Padding(3, 2, 3, 2);
            txtSTOCKMODIFY.Name = "txtSTOCKMODIFY";
            txtSTOCKMODIFY.PlaceholderText = "INGRESA LA CANTIDAD DE COPIAS";
            txtSTOCKMODIFY.Size = new Size(217, 23);
            txtSTOCKMODIFY.TabIndex = 36;
            txtSTOCKMODIFY.TextChanged += txtSTOCKMODIFY_TextChanged;
            // 
            // txtSTOCKMODIFCAR
            // 
            txtSTOCKMODIFCAR.Font = new Font("Century Gothic", 9.75F);
            txtSTOCKMODIFCAR.Location = new Point(192, 470);
            txtSTOCKMODIFCAR.Margin = new Padding(3, 2, 3, 2);
            txtSTOCKMODIFCAR.Name = "txtSTOCKMODIFCAR";
            txtSTOCKMODIFCAR.Size = new Size(92, 23);
            txtSTOCKMODIFCAR.TabIndex = 35;
            txtSTOCKMODIFCAR.Text = "STOCK:";
            // 
            // txtPRICEMODIFY
            // 
            txtPRICEMODIFY.Font = new Font("Century Gothic", 9.75F);
            txtPRICEMODIFY.Location = new Point(290, 445);
            txtPRICEMODIFY.Margin = new Padding(3, 2, 3, 2);
            txtPRICEMODIFY.Name = "txtPRICEMODIFY";
            txtPRICEMODIFY.PlaceholderText = "INGRESA EL PRECIO";
            txtPRICEMODIFY.Size = new Size(142, 23);
            txtPRICEMODIFY.TabIndex = 34;
            txtPRICEMODIFY.TextChanged += txtPRICEMODIFY_TextChanged;
            // 
            // txtPRECIOMODIFICAR
            // 
            txtPRECIOMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtPRECIOMODIFICAR.Location = new Point(192, 445);
            txtPRECIOMODIFICAR.Margin = new Padding(3, 2, 3, 2);
            txtPRECIOMODIFICAR.Name = "txtPRECIOMODIFICAR";
            txtPRECIOMODIFICAR.Size = new Size(92, 23);
            txtPRECIOMODIFICAR.TabIndex = 33;
            txtPRECIOMODIFICAR.Text = "PRECIO:";
            // 
            // txtGENREMODIFY
            // 
            txtGENREMODIFY.Font = new Font("Century Gothic", 9.75F);
            txtGENREMODIFY.Location = new Point(290, 420);
            txtGENREMODIFY.Margin = new Padding(3, 2, 3, 2);
            txtGENREMODIFY.Name = "txtGENREMODIFY";
            txtGENREMODIFY.PlaceholderText = "INGRESA EL GENERO";
            txtGENREMODIFY.Size = new Size(142, 23);
            txtGENREMODIFY.TabIndex = 32;
            txtGENREMODIFY.TextChanged += txtGENREMODIFY_TextChanged;
            // 
            // txtGENEROMODIFICAR
            // 
            txtGENEROMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtGENEROMODIFICAR.Location = new Point(192, 420);
            txtGENEROMODIFICAR.Margin = new Padding(3, 2, 3, 2);
            txtGENEROMODIFICAR.Name = "txtGENEROMODIFICAR";
            txtGENEROMODIFICAR.Size = new Size(92, 23);
            txtGENEROMODIFICAR.TabIndex = 31;
            txtGENEROMODIFICAR.Text = "GENERO:";
            // 
            // txtPLATFORMMODIFY
            // 
            txtPLATFORMMODIFY.Font = new Font("Century Gothic", 9.75F);
            txtPLATFORMMODIFY.Location = new Point(290, 395);
            txtPLATFORMMODIFY.Margin = new Padding(3, 2, 3, 2);
            txtPLATFORMMODIFY.Name = "txtPLATFORMMODIFY";
            txtPLATFORMMODIFY.PlaceholderText = "INGRESA PLATAFORMA";
            txtPLATFORMMODIFY.Size = new Size(172, 23);
            txtPLATFORMMODIFY.TabIndex = 44;
            txtPLATFORMMODIFY.TextChanged += txtPLATFORMMODIFY_TextChanged;
            // 
            // txtPLATAFORMAMODIFICAR
            // 
            txtPLATAFORMAMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtPLATAFORMAMODIFICAR.Location = new Point(192, 395);
            txtPLATAFORMAMODIFICAR.Margin = new Padding(3, 2, 3, 2);
            txtPLATAFORMAMODIFICAR.Name = "txtPLATAFORMAMODIFICAR";
            txtPLATAFORMAMODIFICAR.Size = new Size(92, 23);
            txtPLATAFORMAMODIFICAR.TabIndex = 43;
            txtPLATAFORMAMODIFICAR.Text = "PLATAFORMA:";
            // 
            // txtMODEMODIFY
            // 
            txtMODEMODIFY.Font = new Font("Century Gothic", 9.75F);
            txtMODEMODIFY.Location = new Point(290, 370);
            txtMODEMODIFY.Margin = new Padding(3, 2, 3, 2);
            txtMODEMODIFY.Name = "txtMODEMODIFY";
            txtMODEMODIFY.PlaceholderText = "INGRESA MODALIDAD";
            txtMODEMODIFY.Size = new Size(142, 23);
            txtMODEMODIFY.TabIndex = 42;
            txtMODEMODIFY.TextChanged += txtMODEMODIFY_TextChanged;
            // 
            // txtMODALIDADMODIFY
            // 
            txtMODALIDADMODIFY.Font = new Font("Century Gothic", 9.75F);
            txtMODALIDADMODIFY.Location = new Point(192, 370);
            txtMODALIDADMODIFY.Margin = new Padding(3, 2, 3, 2);
            txtMODALIDADMODIFY.Name = "txtMODALIDADMODIFY";
            txtMODALIDADMODIFY.Size = new Size(92, 23);
            txtMODALIDADMODIFY.TabIndex = 41;
            txtMODALIDADMODIFY.Text = "MODALIDAD:";
            // 
            // txtGAMETITLE
            // 
            txtGAMETITLE.Font = new Font("Century Gothic", 9.75F);
            txtGAMETITLE.Location = new Point(249, 346);
            txtGAMETITLE.Margin = new Padding(3, 2, 3, 2);
            txtGAMETITLE.Name = "txtGAMETITLE";
            txtGAMETITLE.PlaceholderText = "INGRESA TITULO DEL JUEGO";
            txtGAMETITLE.Size = new Size(172, 23);
            txtGAMETITLE.TabIndex = 40;
            txtGAMETITLE.TextChanged += txtGAMETITLE_TextChanged;
            // 
            // txtTITULOMODIFICAR
            // 
            txtTITULOMODIFICAR.Font = new Font("Century Gothic", 9.75F);
            txtTITULOMODIFICAR.Location = new Point(192, 346);
            txtTITULOMODIFICAR.Margin = new Padding(3, 2, 3, 2);
            txtTITULOMODIFICAR.Name = "txtTITULOMODIFICAR";
            txtTITULOMODIFICAR.Size = new Size(52, 23);
            txtTITULOMODIFICAR.TabIndex = 39;
            txtTITULOMODIFICAR.Text = "TITULO:";
            // 
            // txtIDENTIFYID
            // 
            txtIDENTIFYID.Font = new Font("Century Gothic", 9.75F);
            txtIDENTIFYID.Location = new Point(221, 321);
            txtIDENTIFYID.Margin = new Padding(3, 2, 3, 2);
            txtIDENTIFYID.Name = "txtIDENTIFYID";
            txtIDENTIFYID.PlaceholderText = "IDENTIFICAR ID";
            txtIDENTIFYID.Size = new Size(110, 23);
            txtIDENTIFYID.TabIndex = 38;
            txtIDENTIFYID.TextChanged += txtIDENTIFYID_TextChanged;
            // 
            // txtMODIFICARID
            // 
            txtMODIFICARID.Font = new Font("Century Gothic", 9.75F);
            txtMODIFICARID.Location = new Point(192, 321);
            txtMODIFICARID.Margin = new Padding(3, 2, 3, 2);
            txtMODIFICARID.Name = "txtMODIFICARID";
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
            // buttonCARGARCAMBIOS
            // 
            buttonCARGARCAMBIOS.Location = new Point(536, 468);
            buttonCARGARCAMBIOS.Margin = new Padding(3, 2, 3, 2);
            buttonCARGARCAMBIOS.Name = "buttonCARGARCAMBIOS";
            buttonCARGARCAMBIOS.Size = new Size(162, 22);
            buttonCARGARCAMBIOS.TabIndex = 47;
            buttonCARGARCAMBIOS.Text = "Guardar Cambios";
            buttonCARGARCAMBIOS.UseVisualStyleBackColor = true;
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
            Controls.Add(buttonCARGARCAMBIOS);
            Controls.Add(buttonCARGARIMAGEMODIFY);
            Controls.Add(txtMODIFICAR);
            Controls.Add(txtPLATFORMMODIFY);
            Controls.Add(txtPLATAFORMAMODIFICAR);
            Controls.Add(txtMODEMODIFY);
            Controls.Add(txtMODALIDADMODIFY);
            Controls.Add(txtGAMETITLE);
            Controls.Add(txtTITULOMODIFICAR);
            Controls.Add(txtIDENTIFYID);
            Controls.Add(txtMODIFICARID);
            Controls.Add(txtSTOCKMODIFY);
            Controls.Add(txtSTOCKMODIFCAR);
            Controls.Add(txtPRICEMODIFY);
            Controls.Add(txtPRECIOMODIFICAR);
            Controls.Add(txtGENREMODIFY);
            Controls.Add(txtGENEROMODIFICAR);
            Controls.Add(button_LogOut);
            Controls.Add(dataGridView_Inventario);
            Controls.Add(buttonCARGARIMAGEN);
            Controls.Add(pictureBoxIMAGEMODIFY);
            Controls.Add(button_EliminarProducto);
            Controls.Add(textBox_IDBorrar);
            Controls.Add(textBox7);
            Controls.Add(textBoxBAJAR);
            Controls.Add(textBoxSTOCK);
            Controls.Add(txtSTOCK);
            Controls.Add(textBoxPRECIO);
            Controls.Add(txtPRECIO);
            Controls.Add(textBoxGENERO);
            Controls.Add(txtGENERO);
            Controls.Add(textBoxPLATAFORMA);
            Controls.Add(txtPLATAFORMA);
            Controls.Add(textBoxMODALIDAD);
            Controls.Add(txtMODALIDAD);
            Controls.Add(textBoxTITULOJUEGO);
            Controls.Add(txtTITULO);
            Controls.Add(textBoxID);
            Controls.Add(txtID);
            Controls.Add(txtSUBIRPRODUCTOS);
            Controls.Add(buttonGUARDARPRODUCTO);
            Controls.Add(button_MOSTRARINVENTARIO);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            Load += FormAdmin_Load;
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
        private Button buttonGUARDARPRODUCTO;
        private TextBox txtSUBIRPRODUCTOS;
        private TextBox txtID;
        private TextBox textBoxID;
        private TextBox textBoxTITULOJUEGO;
        private TextBox txtTITULO;
        private TextBox textBoxMODALIDAD;
        private TextBox txtMODALIDAD;
        private TextBox textBoxGENERO;
        private TextBox txtGENERO;
        private TextBox textBoxPLATAFORMA;
        private TextBox txtPLATAFORMA;
        private TextBox textBoxPRECIO;
        private TextBox txtPRECIO;
        private TextBox textBoxSTOCK;
        private TextBox txtSTOCK;
        private TextBox textBoxBAJAR;
        private TextBox textBox_IDBorrar;
        private TextBox textBox7;
        private Button button_EliminarProducto;
        private PictureBox pictureBoxIMAGEMODIFY;
        private Button buttonCARGARIMAGEN;
        private DataGridView dataGridView_Inventario;
        private Button button_LogOut;
        private TextBox txtSTOCKMODIFY;
        private TextBox txtSTOCKMODIFCAR;
        private TextBox txtPRICEMODIFY;
        private TextBox txtPRECIOMODIFICAR;
        private TextBox txtGENREMODIFY;
        private TextBox txtGENEROMODIFICAR;
        private TextBox txtPLATFORMMODIFY;
        private TextBox txtPLATAFORMAMODIFICAR;
        private TextBox txtMODEMODIFY;
        private TextBox txtMODALIDADMODIFY;
        private TextBox txtGAMETITLE;
        private TextBox txtTITULOMODIFICAR;
        private TextBox txtIDENTIFYID;
        private TextBox txtMODIFICARID;
        private TextBox txtMODIFICAR;
        private Button buttonCARGARIMAGEMODIFY;
        private Button buttonCARGARCAMBIOS;
        private PictureBox pictureBoxSUBERIMAGEN;
        private PictureBox btncerrar;
    }
}