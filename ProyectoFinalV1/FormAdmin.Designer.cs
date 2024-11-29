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
            ((System.ComponentModel.ISupportInitialize)pictureBoxIMAGEMODIFY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Inventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSUBERIMAGEN).BeginInit();
            SuspendLayout();
            // 
            // button_MOSTRARINVENTARIO
            // 
            button_MOSTRARINVENTARIO.Location = new Point(41, 2);
            button_MOSTRARINVENTARIO.Name = "button_MOSTRARINVENTARIO";
            button_MOSTRARINVENTARIO.Size = new Size(747, 29);
            button_MOSTRARINVENTARIO.TabIndex = 4;
            button_MOSTRARINVENTARIO.Text = "INVENTARIO";
            button_MOSTRARINVENTARIO.UseVisualStyleBackColor = true;
            button_MOSTRARINVENTARIO.Click += button_MostrarInventario_Click;
            // 
            // buttonGUARDARPRODUCTO
            // 
            buttonGUARDARPRODUCTO.Location = new Point(872, 478);
            buttonGUARDARPRODUCTO.Name = "buttonGUARDARPRODUCTO";
            buttonGUARDARPRODUCTO.Size = new Size(94, 29);
            buttonGUARDARPRODUCTO.TabIndex = 5;
            buttonGUARDARPRODUCTO.Text = "Guardar";
            buttonGUARDARPRODUCTO.UseVisualStyleBackColor = true;
            // 
            // txtSUBIRPRODUCTOS
            // 
            txtSUBIRPRODUCTOS.Location = new Point(872, 4);
            txtSUBIRPRODUCTOS.Name = "txtSUBIRPRODUCTOS";
            txtSUBIRPRODUCTOS.Size = new Size(378, 27);
            txtSUBIRPRODUCTOS.TabIndex = 6;
            txtSUBIRPRODUCTOS.Text = "SUBIR PRODUCTO";
            txtSUBIRPRODUCTOS.TextAlign = HorizontalAlignment.Center;
            // 
            // txtID
            // 
            txtID.Location = new Point(872, 37);
            txtID.Name = "txtID";
            txtID.Size = new Size(27, 27);
            txtID.TabIndex = 7;
            txtID.Text = "ID:";
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
            // txtTITULO
            // 
            txtTITULO.Location = new Point(872, 70);
            txtTITULO.Name = "txtTITULO";
            txtTITULO.Size = new Size(59, 27);
            txtTITULO.TabIndex = 9;
            txtTITULO.Text = "TITULO:";
            // 
            // textBoxMODALIDAD
            // 
            textBoxMODALIDAD.Location = new Point(983, 103);
            textBoxMODALIDAD.Name = "textBoxMODALIDAD";
            textBoxMODALIDAD.PlaceholderText = "INGRESA MODALIDAD";
            textBoxMODALIDAD.Size = new Size(162, 27);
            textBoxMODALIDAD.TabIndex = 12;
            // 
            // txtMODALIDAD
            // 
            txtMODALIDAD.Location = new Point(872, 103);
            txtMODALIDAD.Name = "txtMODALIDAD";
            txtMODALIDAD.Size = new Size(105, 27);
            txtMODALIDAD.TabIndex = 11;
            txtMODALIDAD.Text = "MODALIDAD:";
            // 
            // textBoxGENERO
            // 
            textBoxGENERO.Location = new Point(983, 169);
            textBoxGENERO.Name = "textBoxGENERO";
            textBoxGENERO.PlaceholderText = "INGRESA EL GENERO";
            textBoxGENERO.Size = new Size(162, 27);
            textBoxGENERO.TabIndex = 16;
            // 
            // txtGENERO
            // 
            txtGENERO.Location = new Point(872, 169);
            txtGENERO.Name = "txtGENERO";
            txtGENERO.Size = new Size(105, 27);
            txtGENERO.TabIndex = 15;
            txtGENERO.Text = "GENERO:";
            // 
            // textBoxPLATAFORMA
            // 
            textBoxPLATAFORMA.Location = new Point(983, 136);
            textBoxPLATAFORMA.Name = "textBoxPLATAFORMA";
            textBoxPLATAFORMA.PlaceholderText = "INGRESA PLATAFORMA";
            textBoxPLATAFORMA.Size = new Size(196, 27);
            textBoxPLATAFORMA.TabIndex = 14;
            // 
            // txtPLATAFORMA
            // 
            txtPLATAFORMA.Location = new Point(872, 136);
            txtPLATAFORMA.Name = "txtPLATAFORMA";
            txtPLATAFORMA.Size = new Size(105, 27);
            txtPLATAFORMA.TabIndex = 13;
            txtPLATAFORMA.Text = "PLATAFORMA:";
            // 
            // textBoxPRECIO
            // 
            textBoxPRECIO.Location = new Point(983, 202);
            textBoxPRECIO.Name = "textBoxPRECIO";
            textBoxPRECIO.PlaceholderText = "INGRESA EL PRECIO";
            textBoxPRECIO.Size = new Size(162, 27);
            textBoxPRECIO.TabIndex = 18;
            // 
            // txtPRECIO
            // 
            txtPRECIO.Location = new Point(872, 202);
            txtPRECIO.Name = "txtPRECIO";
            txtPRECIO.Size = new Size(105, 27);
            txtPRECIO.TabIndex = 17;
            txtPRECIO.Text = "PRECIO:";
            // 
            // textBoxSTOCK
            // 
            textBoxSTOCK.Location = new Point(983, 235);
            textBoxSTOCK.Name = "textBoxSTOCK";
            textBoxSTOCK.PlaceholderText = "INGRESA LA CANTIDAD DE COPIAS";
            textBoxSTOCK.Size = new Size(247, 27);
            textBoxSTOCK.TabIndex = 20;
            // 
            // txtSTOCK
            // 
            txtSTOCK.Location = new Point(872, 235);
            txtSTOCK.Name = "txtSTOCK";
            txtSTOCK.Size = new Size(105, 27);
            txtSTOCK.TabIndex = 19;
            txtSTOCK.Text = "STOCK:";
            // 
            // textBoxBAJAR
            // 
            textBoxBAJAR.Location = new Point(41, 395);
            textBoxBAJAR.Name = "textBoxBAJAR";
            textBoxBAJAR.Size = new Size(173, 27);
            textBoxBAJAR.TabIndex = 23;
            textBoxBAJAR.Text = "BAJAR PRODUCTO";
            textBoxBAJAR.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_IDBorrar
            // 
            textBox_IDBorrar.Location = new Point(75, 428);
            textBox_IDBorrar.Name = "textBox_IDBorrar";
            textBox_IDBorrar.PlaceholderText = "INGRESA ID";
            textBox_IDBorrar.Size = new Size(125, 27);
            textBox_IDBorrar.TabIndex = 25;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(42, 428);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(27, 27);
            textBox7.TabIndex = 24;
            textBox7.Text = "ID:";
            // 
            // button_EliminarProducto
            // 
            button_EliminarProducto.Location = new Point(65, 472);
            button_EliminarProducto.Name = "button_EliminarProducto";
            button_EliminarProducto.Size = new Size(94, 29);
            button_EliminarProducto.TabIndex = 26;
            button_EliminarProducto.Text = "ELIMINAR";
            button_EliminarProducto.UseVisualStyleBackColor = true;
            button_EliminarProducto.Click += button_EliminarProducto_Click;
            // 
            // pictureBoxIMAGEMODIFY
            // 
            pictureBoxIMAGEMODIFY.Location = new Point(533, 439);
            pictureBoxIMAGEMODIFY.Name = "pictureBoxIMAGEMODIFY";
            pictureBoxIMAGEMODIFY.Size = new Size(291, 169);
            pictureBoxIMAGEMODIFY.TabIndex = 27;
            pictureBoxIMAGEMODIFY.TabStop = false;
            // 
            // buttonCARGARIMAGEN
            // 
            buttonCARGARIMAGEN.Location = new Point(872, 268);
            buttonCARGARIMAGEN.Name = "buttonCARGARIMAGEN";
            buttonCARGARIMAGEN.Size = new Size(158, 29);
            buttonCARGARIMAGEN.TabIndex = 28;
            buttonCARGARIMAGEN.Text = "CARGAR IMAGEN:";
            buttonCARGARIMAGEN.UseVisualStyleBackColor = true;
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
            // txtSTOCKMODIFY
            // 
            txtSTOCKMODIFY.Location = new Point(331, 626);
            txtSTOCKMODIFY.Name = "txtSTOCKMODIFY";
            txtSTOCKMODIFY.PlaceholderText = "INGRESA LA CANTIDAD DE COPIAS";
            txtSTOCKMODIFY.Size = new Size(247, 27);
            txtSTOCKMODIFY.TabIndex = 36;
            // 
            // txtSTOCKMODIFCAR
            // 
            txtSTOCKMODIFCAR.Location = new Point(220, 626);
            txtSTOCKMODIFCAR.Name = "txtSTOCKMODIFCAR";
            txtSTOCKMODIFCAR.Size = new Size(105, 27);
            txtSTOCKMODIFCAR.TabIndex = 35;
            txtSTOCKMODIFCAR.Text = "STOCK:";
            // 
            // txtPRICEMODIFY
            // 
            txtPRICEMODIFY.Location = new Point(331, 593);
            txtPRICEMODIFY.Name = "txtPRICEMODIFY";
            txtPRICEMODIFY.PlaceholderText = "INGRESA EL PRECIO";
            txtPRICEMODIFY.Size = new Size(162, 27);
            txtPRICEMODIFY.TabIndex = 34;
            // 
            // txtPRECIOMODIFICAR
            // 
            txtPRECIOMODIFICAR.Location = new Point(220, 593);
            txtPRECIOMODIFICAR.Name = "txtPRECIOMODIFICAR";
            txtPRECIOMODIFICAR.Size = new Size(105, 27);
            txtPRECIOMODIFICAR.TabIndex = 33;
            txtPRECIOMODIFICAR.Text = "PRECIO:";
            // 
            // txtGENREMODIFY
            // 
            txtGENREMODIFY.Location = new Point(331, 560);
            txtGENREMODIFY.Name = "txtGENREMODIFY";
            txtGENREMODIFY.PlaceholderText = "INGRESA EL GENERO";
            txtGENREMODIFY.Size = new Size(162, 27);
            txtGENREMODIFY.TabIndex = 32;
            // 
            // txtGENEROMODIFICAR
            // 
            txtGENEROMODIFICAR.Location = new Point(220, 560);
            txtGENEROMODIFICAR.Name = "txtGENEROMODIFICAR";
            txtGENEROMODIFICAR.Size = new Size(105, 27);
            txtGENEROMODIFICAR.TabIndex = 31;
            txtGENEROMODIFICAR.Text = "GENERO:";
            // 
            // txtPLATFORMMODIFY
            // 
            txtPLATFORMMODIFY.Location = new Point(331, 527);
            txtPLATFORMMODIFY.Name = "txtPLATFORMMODIFY";
            txtPLATFORMMODIFY.PlaceholderText = "INGRESA PLATAFORMA";
            txtPLATFORMMODIFY.Size = new Size(196, 27);
            txtPLATFORMMODIFY.TabIndex = 44;
            // 
            // txtPLATAFORMAMODIFICAR
            // 
            txtPLATAFORMAMODIFICAR.Location = new Point(220, 527);
            txtPLATAFORMAMODIFICAR.Name = "txtPLATAFORMAMODIFICAR";
            txtPLATAFORMAMODIFICAR.Size = new Size(105, 27);
            txtPLATAFORMAMODIFICAR.TabIndex = 43;
            txtPLATAFORMAMODIFICAR.Text = "PLATAFORMA:";
            // 
            // txtMODEMODIFY
            // 
            txtMODEMODIFY.Location = new Point(331, 494);
            txtMODEMODIFY.Name = "txtMODEMODIFY";
            txtMODEMODIFY.PlaceholderText = "INGRESA MODALIDAD";
            txtMODEMODIFY.Size = new Size(162, 27);
            txtMODEMODIFY.TabIndex = 42;
            // 
            // txtMODALIDADMODIFY
            // 
            txtMODALIDADMODIFY.Location = new Point(220, 494);
            txtMODALIDADMODIFY.Name = "txtMODALIDADMODIFY";
            txtMODALIDADMODIFY.Size = new Size(105, 27);
            txtMODALIDADMODIFY.TabIndex = 41;
            txtMODALIDADMODIFY.Text = "MODALIDAD:";
            // 
            // txtGAMETITLE
            // 
            txtGAMETITLE.Location = new Point(285, 461);
            txtGAMETITLE.Name = "txtGAMETITLE";
            txtGAMETITLE.PlaceholderText = "INGRESA TITULO DEL JUEGO";
            txtGAMETITLE.Size = new Size(196, 27);
            txtGAMETITLE.TabIndex = 40;
            // 
            // txtTITULOMODIFICAR
            // 
            txtTITULOMODIFICAR.Location = new Point(220, 461);
            txtTITULOMODIFICAR.Name = "txtTITULOMODIFICAR";
            txtTITULOMODIFICAR.Size = new Size(59, 27);
            txtTITULOMODIFICAR.TabIndex = 39;
            txtTITULOMODIFICAR.Text = "TITULO:";
            // 
            // txtIDENTIFYID
            // 
            txtIDENTIFYID.Location = new Point(253, 428);
            txtIDENTIFYID.Name = "txtIDENTIFYID";
            txtIDENTIFYID.PlaceholderText = "IDENTIFICAR ID";
            txtIDENTIFYID.Size = new Size(125, 27);
            txtIDENTIFYID.TabIndex = 38;
            // 
            // txtMODIFICARID
            // 
            txtMODIFICARID.Location = new Point(220, 428);
            txtMODIFICARID.Name = "txtMODIFICARID";
            txtMODIFICARID.Size = new Size(27, 27);
            txtMODIFICARID.TabIndex = 37;
            txtMODIFICARID.Text = "ID:";
            // 
            // txtMODIFICAR
            // 
            txtMODIFICAR.Enabled = false;
            txtMODIFICAR.Location = new Point(220, 395);
            txtMODIFICAR.Name = "txtMODIFICAR";
            txtMODIFICAR.Size = new Size(125, 27);
            txtMODIFICAR.TabIndex = 45;
            txtMODIFICAR.Text = "MODIFICAR";
            // 
            // buttonCARGARIMAGEMODIFY
            // 
            buttonCARGARIMAGEMODIFY.Location = new Point(613, 404);
            buttonCARGARIMAGEMODIFY.Name = "buttonCARGARIMAGEMODIFY";
            buttonCARGARIMAGEMODIFY.Size = new Size(158, 29);
            buttonCARGARIMAGEMODIFY.TabIndex = 46;
            buttonCARGARIMAGEMODIFY.Text = "CARGAR IMAGEN:";
            buttonCARGARIMAGEMODIFY.UseVisualStyleBackColor = true;
            // 
            // buttonCARGARCAMBIOS
            // 
            buttonCARGARCAMBIOS.Location = new Point(613, 624);
            buttonCARGARCAMBIOS.Name = "buttonCARGARCAMBIOS";
            buttonCARGARCAMBIOS.Size = new Size(185, 29);
            buttonCARGARCAMBIOS.TabIndex = 47;
            buttonCARGARCAMBIOS.Text = "Guardar Cambios";
            buttonCARGARCAMBIOS.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSUBERIMAGEN
            // 
            pictureBoxSUBERIMAGEN.Location = new Point(872, 303);
            pictureBoxSUBERIMAGEN.Name = "pictureBoxSUBERIMAGEN";
            pictureBoxSUBERIMAGEN.Size = new Size(291, 169);
            pictureBoxSUBERIMAGEN.TabIndex = 48;
            pictureBoxSUBERIMAGEN.TabStop = false;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
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
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIMAGEMODIFY).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Inventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSUBERIMAGEN).EndInit();
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
    }
}