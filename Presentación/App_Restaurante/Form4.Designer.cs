namespace App_Restaurante
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_codigoC = new System.Windows.Forms.TextBox();
            this.txt_nombreC = new System.Windows.Forms.TextBox();
            this.txt_apellidosC = new System.Windows.Forms.TextBox();
            this.txt_contactoC = new System.Windows.Forms.TextBox();
            this.txt_direccionC = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ptb_ActualizarC = new System.Windows.Forms.PictureBox();
            this.ptb_ConsultarC = new System.Windows.Forms.PictureBox();
            this.ptb_GuardarC = new System.Windows.Forms.PictureBox();
            this.ptb_Nuevo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ActualizarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ConsultarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_GuardarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Nuevo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 84);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Restaurante.Properties.Resources.salida__2_1;
            this.pictureBox1.Location = new System.Drawing.Point(546, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contacto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion:";
            // 
            // txt_codigoC
            // 
            this.txt_codigoC.Location = new System.Drawing.Point(158, 112);
            this.txt_codigoC.Multiline = true;
            this.txt_codigoC.Name = "txt_codigoC";
            this.txt_codigoC.Size = new System.Drawing.Size(154, 23);
            this.txt_codigoC.TabIndex = 6;
            // 
            // txt_nombreC
            // 
            this.txt_nombreC.Location = new System.Drawing.Point(158, 160);
            this.txt_nombreC.Multiline = true;
            this.txt_nombreC.Name = "txt_nombreC";
            this.txt_nombreC.Size = new System.Drawing.Size(154, 23);
            this.txt_nombreC.TabIndex = 7;
            // 
            // txt_apellidosC
            // 
            this.txt_apellidosC.Location = new System.Drawing.Point(158, 204);
            this.txt_apellidosC.Multiline = true;
            this.txt_apellidosC.Name = "txt_apellidosC";
            this.txt_apellidosC.Size = new System.Drawing.Size(154, 23);
            this.txt_apellidosC.TabIndex = 8;
            // 
            // txt_contactoC
            // 
            this.txt_contactoC.Location = new System.Drawing.Point(158, 246);
            this.txt_contactoC.Multiline = true;
            this.txt_contactoC.Name = "txt_contactoC";
            this.txt_contactoC.Size = new System.Drawing.Size(154, 23);
            this.txt_contactoC.TabIndex = 9;
            // 
            // txt_direccionC
            // 
            this.txt_direccionC.Location = new System.Drawing.Point(158, 290);
            this.txt_direccionC.Multiline = true;
            this.txt_direccionC.Name = "txt_direccionC";
            this.txt_direccionC.Size = new System.Drawing.Size(154, 23);
            this.txt_direccionC.TabIndex = 10;
            // 
            // ptb_ActualizarC
            // 
            this.ptb_ActualizarC.Image = global::App_Restaurante.Properties.Resources.actualizar1;
            this.ptb_ActualizarC.Location = new System.Drawing.Point(475, 216);
            this.ptb_ActualizarC.Name = "ptb_ActualizarC";
            this.ptb_ActualizarC.Size = new System.Drawing.Size(85, 71);
            this.ptb_ActualizarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_ActualizarC.TabIndex = 14;
            this.ptb_ActualizarC.TabStop = false;
            this.toolTip1.SetToolTip(this.ptb_ActualizarC, "Actualizar Cliente");
            this.ptb_ActualizarC.Click += new System.EventHandler(this.ptb_ActualizarC_Click);
            // 
            // ptb_ConsultarC
            // 
            this.ptb_ConsultarC.Image = global::App_Restaurante.Properties.Resources.lupa1;
            this.ptb_ConsultarC.Location = new System.Drawing.Point(348, 216);
            this.ptb_ConsultarC.Name = "ptb_ConsultarC";
            this.ptb_ConsultarC.Size = new System.Drawing.Size(85, 71);
            this.ptb_ConsultarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_ConsultarC.TabIndex = 13;
            this.ptb_ConsultarC.TabStop = false;
            this.toolTip1.SetToolTip(this.ptb_ConsultarC, "Consultar Cliente");
            this.ptb_ConsultarC.Click += new System.EventHandler(this.ptb_ConsultarC_Click);
            // 
            // ptb_GuardarC
            // 
            this.ptb_GuardarC.Image = global::App_Restaurante.Properties.Resources.disquete1;
            this.ptb_GuardarC.Location = new System.Drawing.Point(475, 112);
            this.ptb_GuardarC.Name = "ptb_GuardarC";
            this.ptb_GuardarC.Size = new System.Drawing.Size(85, 71);
            this.ptb_GuardarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_GuardarC.TabIndex = 12;
            this.ptb_GuardarC.TabStop = false;
            this.toolTip1.SetToolTip(this.ptb_GuardarC, "Guardar Cliente");
            this.ptb_GuardarC.Click += new System.EventHandler(this.ptb_GuardarC_Click);
            // 
            // ptb_Nuevo
            // 
            this.ptb_Nuevo.Image = global::App_Restaurante.Properties.Resources.escasez;
            this.ptb_Nuevo.Location = new System.Drawing.Point(348, 112);
            this.ptb_Nuevo.Name = "ptb_Nuevo";
            this.ptb_Nuevo.Size = new System.Drawing.Size(85, 71);
            this.ptb_Nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Nuevo.TabIndex = 11;
            this.ptb_Nuevo.TabStop = false;
            this.toolTip1.SetToolTip(this.ptb_Nuevo, "Nuevo Cliente");
            this.ptb_Nuevo.Click += new System.EventHandler(this.ptb_Nuevo_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 368);
            this.Controls.Add(this.ptb_ActualizarC);
            this.Controls.Add(this.ptb_ConsultarC);
            this.Controls.Add(this.ptb_GuardarC);
            this.Controls.Add(this.ptb_Nuevo);
            this.Controls.Add(this.txt_direccionC);
            this.Controls.Add(this.txt_contactoC);
            this.Controls.Add(this.txt_apellidosC);
            this.Controls.Add(this.txt_nombreC);
            this.Controls.Add(this.txt_codigoC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ActualizarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ConsultarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_GuardarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Nuevo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_codigoC;
        private System.Windows.Forms.TextBox txt_nombreC;
        private System.Windows.Forms.TextBox txt_apellidosC;
        private System.Windows.Forms.TextBox txt_contactoC;
        private System.Windows.Forms.TextBox txt_direccionC;
        private System.Windows.Forms.PictureBox ptb_Nuevo;
        private System.Windows.Forms.PictureBox ptb_GuardarC;
        private System.Windows.Forms.PictureBox ptb_ConsultarC;
        private System.Windows.Forms.PictureBox ptb_ActualizarC;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}