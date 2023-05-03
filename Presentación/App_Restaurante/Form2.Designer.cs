namespace App_Restaurante
{
    partial class Form2
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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_ingredientes = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.ptb_consultar = new System.Windows.Forms.PictureBox();
            this.ptb_actualizar = new System.Windows.Forms.PictureBox();
            this.ptb_nuevo = new System.Windows.Forms.PictureBox();
            this.ptb_guardar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_consultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_nuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_guardar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 56);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::App_Restaurante.Properties.Resources.salida__2_;
            this.pictureBox5.Location = new System.Drawing.Point(575, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 45);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Salir");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registros de platos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingredientes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(140, 98);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(223, 20);
            this.txt_codigo.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(143, 135);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(220, 20);
            this.txt_nombre.TabIndex = 8;
            // 
            // txt_ingredientes
            // 
            this.txt_ingredientes.Location = new System.Drawing.Point(143, 167);
            this.txt_ingredientes.Multiline = true;
            this.txt_ingredientes.Name = "txt_ingredientes";
            this.txt_ingredientes.Size = new System.Drawing.Size(220, 97);
            this.txt_ingredientes.TabIndex = 9;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(143, 272);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(220, 20);
            this.txt_valor.TabIndex = 10;
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Location = new System.Drawing.Point(143, 312);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(220, 21);
            this.cbx_tipo.TabIndex = 11;
            // 
            // cbx_estado
            // 
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Location = new System.Drawing.Point(143, 349);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(220, 21);
            this.cbx_estado.TabIndex = 12;
            // 
            // ptb_consultar
            // 
            this.ptb_consultar.Image = global::App_Restaurante.Properties.Resources.lupa;
            this.ptb_consultar.Location = new System.Drawing.Point(515, 302);
            this.ptb_consultar.Name = "ptb_consultar";
            this.ptb_consultar.Size = new System.Drawing.Size(84, 68);
            this.ptb_consultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_consultar.TabIndex = 16;
            this.ptb_consultar.TabStop = false;
            this.toolTip1.SetToolTip(this.ptb_consultar, "Consultar");
            this.ptb_consultar.Click += new System.EventHandler(this.ptb_consultar_Click);
            // 
            // ptb_actualizar
            // 
            this.ptb_actualizar.Image = global::App_Restaurante.Properties.Resources.actualizar;
            this.ptb_actualizar.Location = new System.Drawing.Point(394, 302);
            this.ptb_actualizar.Name = "ptb_actualizar";
            this.ptb_actualizar.Size = new System.Drawing.Size(84, 68);
            this.ptb_actualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_actualizar.TabIndex = 15;
            this.ptb_actualizar.TabStop = false;
            this.toolTip1.SetToolTip(this.ptb_actualizar, "Actualizar");
            this.ptb_actualizar.Click += new System.EventHandler(this.ptb_actualizar_Click);
            // 
            // ptb_nuevo
            // 
            this.ptb_nuevo.Image = global::App_Restaurante.Properties.Resources.comida;
            this.ptb_nuevo.Location = new System.Drawing.Point(515, 198);
            this.ptb_nuevo.Name = "ptb_nuevo";
            this.ptb_nuevo.Size = new System.Drawing.Size(84, 66);
            this.ptb_nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_nuevo.TabIndex = 14;
            this.ptb_nuevo.TabStop = false;
            this.toolTip1.SetToolTip(this.ptb_nuevo, "Nuevo");
            this.ptb_nuevo.Click += new System.EventHandler(this.ptb_nuevo_Click);
            // 
            // ptb_guardar
            // 
            this.ptb_guardar.Image = global::App_Restaurante.Properties.Resources.disquete;
            this.ptb_guardar.Location = new System.Drawing.Point(394, 198);
            this.ptb_guardar.Name = "ptb_guardar";
            this.ptb_guardar.Size = new System.Drawing.Size(84, 66);
            this.ptb_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_guardar.TabIndex = 13;
            this.ptb_guardar.TabStop = false;
            this.toolTip1.SetToolTip(this.ptb_guardar, "Guardar");
            this.ptb_guardar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 395);
            this.Controls.Add(this.ptb_consultar);
            this.Controls.Add(this.ptb_actualizar);
            this.Controls.Add(this.ptb_nuevo);
            this.Controls.Add(this.ptb_guardar);
            this.Controls.Add(this.cbx_estado);
            this.Controls.Add(this.cbx_tipo);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_ingredientes);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_consultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_nuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_guardar)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_ingredientes;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.PictureBox ptb_guardar;
        private System.Windows.Forms.PictureBox ptb_nuevo;
        private System.Windows.Forms.PictureBox ptb_actualizar;
        private System.Windows.Forms.PictureBox ptb_consultar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}