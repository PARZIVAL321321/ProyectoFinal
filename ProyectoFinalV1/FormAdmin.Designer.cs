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
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            buttonMOSTRARINVENTARIO = new Button();
            textBox2 = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
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
            textBoxSINOPSIS = new TextBox();
            textBox20 = new TextBox();
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            textBoxBAJAR = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            buttonELIMINARPRODUCTO = new Button();
            pictureBox1Juego1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Juego1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 676);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(285, 37);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(407, 362);
            textBox4.TabIndex = 3;
            // 
            // buttonMOSTRARINVENTARIO
            // 
            buttonMOSTRARINVENTARIO.Location = new Point(285, 2);
            buttonMOSTRARINVENTARIO.Name = "buttonMOSTRARINVENTARIO";
            buttonMOSTRARINVENTARIO.Size = new Size(407, 29);
            buttonMOSTRARINVENTARIO.TabIndex = 4;
            buttonMOSTRARINVENTARIO.Text = "INVENTARIO";
            buttonMOSTRARINVENTARIO.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(3, 646);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(273, 27);
            textBox2.TabIndex = 2;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
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
            // textBoxSINOPSIS
            // 
            textBoxSINOPSIS.Location = new Point(872, 301);
            textBoxSINOPSIS.Multiline = true;
            textBoxSINOPSIS.Name = "textBoxSINOPSIS";
            textBoxSINOPSIS.PlaceholderText = "INGRESA LA SINOPSIS";
            textBoxSINOPSIS.Size = new Size(358, 98);
            textBoxSINOPSIS.TabIndex = 22;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(872, 268);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(105, 27);
            textBox20.TabIndex = 21;
            textBox20.Text = "SINOPSIS:";
            // 
            // mySqlCommand2
            // 
            mySqlCommand2.CacheAge = 0;
            mySqlCommand2.Connection = null;
            mySqlCommand2.EnableCaching = false;
            mySqlCommand2.Transaction = null;
            // 
            // textBoxBAJAR
            // 
            textBoxBAJAR.Location = new Point(285, 405);
            textBoxBAJAR.Name = "textBoxBAJAR";
            textBoxBAJAR.Size = new Size(378, 27);
            textBoxBAJAR.TabIndex = 23;
            textBoxBAJAR.Text = "BAJAR PRODUCTO";
            textBoxBAJAR.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(318, 438);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "INGRESA ID";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(285, 438);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(27, 27);
            textBox7.TabIndex = 24;
            textBox7.Text = "ID:";
            // 
            // buttonELIMINARPRODUCTO
            // 
            buttonELIMINARPRODUCTO.Location = new Point(285, 486);
            buttonELIMINARPRODUCTO.Name = "buttonELIMINARPRODUCTO";
            buttonELIMINARPRODUCTO.Size = new Size(94, 29);
            buttonELIMINARPRODUCTO.TabIndex = 26;
            buttonELIMINARPRODUCTO.Text = "ELIMINAR";
            buttonELIMINARPRODUCTO.UseVisualStyleBackColor = true;
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
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(button1);
            Controls.Add(pictureBox1Juego1);
            Controls.Add(buttonELIMINARPRODUCTO);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBoxBAJAR);
            Controls.Add(textBoxSINOPSIS);
            Controls.Add(textBox20);
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
            Controls.Add(buttonMOSTRARINVENTARIO);
            Controls.Add(textBox4);
            Controls.Add(panel1);
            Name = "FormAdmin";
            Text = "FormAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Juego1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox4;
        private Button buttonMOSTRARINVENTARIO;
        private TextBox textBox2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
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
        private TextBox textBoxSINOPSIS;
        private TextBox textBox20;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private TextBox textBoxBAJAR;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button buttonELIMINARPRODUCTO;
        private PictureBox pictureBox1Juego1;
        private Button button1;
    }
}