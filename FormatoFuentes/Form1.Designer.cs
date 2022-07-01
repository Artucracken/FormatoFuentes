
namespace FormatoFuentes
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FormRojo = new System.Windows.Forms.Button();
            this.FormAzul = new System.Windows.Forms.Button();
            this.FormVerde = new System.Windows.Forms.Button();
            this.Reducir = new System.Windows.Forms.Button();
            this.Aumentar = new System.Windows.Forms.Button();
            this.Propiedades = new System.Windows.Forms.Label();
            this.ColorTexto = new System.Windows.Forms.GroupBox();
            this.TextoRojo = new System.Windows.Forms.Button();
            this.TextoAzul = new System.Windows.Forms.Button();
            this.TextoVerde = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EligeTamano = new System.Windows.Forms.NumericUpDown();
            this.TamanoTexto = new System.Windows.Forms.Label();
            this.Fuentes = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Subrayado = new System.Windows.Forms.CheckBox();
            this.Cursiva = new System.Windows.Forms.CheckBox();
            this.Negrita = new System.Windows.Forms.CheckBox();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.Ocultar = new System.Windows.Forms.Button();
            this.Texto = new System.Windows.Forms.Label();
            this.TxtTexto = new System.Windows.Forms.TextBox();
            this.Cambiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ColorTexto.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EligeTamano)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Reducir);
            this.panel1.Controls.Add(this.Aumentar);
            this.panel1.Controls.Add(this.Propiedades);
            this.panel1.Location = new System.Drawing.Point(32, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 149);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FormRojo);
            this.groupBox1.Controls.Add(this.FormAzul);
            this.groupBox1.Controls.Add(this.FormVerde);
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color del formulario";
            // 
            // FormRojo
            // 
            this.FormRojo.BackColor = System.Drawing.Color.Red;
            this.FormRojo.Location = new System.Drawing.Point(108, 40);
            this.FormRojo.Name = "FormRojo";
            this.FormRojo.Size = new System.Drawing.Size(27, 29);
            this.FormRojo.TabIndex = 2;
            this.FormRojo.UseVisualStyleBackColor = false;
            this.FormRojo.Click += new System.EventHandler(this.FormRojo_Click);
            // 
            // FormAzul
            // 
            this.FormAzul.BackColor = System.Drawing.Color.Blue;
            this.FormAzul.Location = new System.Drawing.Point(54, 40);
            this.FormAzul.Name = "FormAzul";
            this.FormAzul.Size = new System.Drawing.Size(31, 29);
            this.FormAzul.TabIndex = 1;
            this.FormAzul.UseVisualStyleBackColor = false;
            this.FormAzul.Click += new System.EventHandler(this.FormAzul_Click);
            // 
            // FormVerde
            // 
            this.FormVerde.BackColor = System.Drawing.Color.Lime;
            this.FormVerde.Location = new System.Drawing.Point(7, 40);
            this.FormVerde.Name = "FormVerde";
            this.FormVerde.Size = new System.Drawing.Size(26, 29);
            this.FormVerde.TabIndex = 0;
            this.FormVerde.UseVisualStyleBackColor = false;
            this.FormVerde.Click += new System.EventHandler(this.FormVerde_Click);
            // 
            // Reducir
            // 
            this.Reducir.Location = new System.Drawing.Point(131, 27);
            this.Reducir.Name = "Reducir";
            this.Reducir.Size = new System.Drawing.Size(84, 29);
            this.Reducir.TabIndex = 2;
            this.Reducir.Text = "Reducir";
            this.Reducir.UseVisualStyleBackColor = true;
            this.Reducir.Click += new System.EventHandler(this.Reducir_Click);
            // 
            // Aumentar
            // 
            this.Aumentar.Location = new System.Drawing.Point(13, 27);
            this.Aumentar.Name = "Aumentar";
            this.Aumentar.Size = new System.Drawing.Size(85, 29);
            this.Aumentar.TabIndex = 1;
            this.Aumentar.Text = "Aumentar";
            this.Aumentar.UseVisualStyleBackColor = true;
            this.Aumentar.Click += new System.EventHandler(this.Aumentar_Click);
            // 
            // Propiedades
            // 
            this.Propiedades.AutoSize = true;
            this.Propiedades.Location = new System.Drawing.Point(44, 4);
            this.Propiedades.Name = "Propiedades";
            this.Propiedades.Size = new System.Drawing.Size(153, 20);
            this.Propiedades.TabIndex = 0;
            this.Propiedades.Text = "Propiedades del form";
            // 
            // ColorTexto
            // 
            this.ColorTexto.Controls.Add(this.TextoRojo);
            this.ColorTexto.Controls.Add(this.TextoAzul);
            this.ColorTexto.Controls.Add(this.TextoVerde);
            this.ColorTexto.Location = new System.Drawing.Point(26, 68);
            this.ColorTexto.Name = "ColorTexto";
            this.ColorTexto.Size = new System.Drawing.Size(123, 73);
            this.ColorTexto.TabIndex = 1;
            this.ColorTexto.TabStop = false;
            this.ColorTexto.Text = "Color Texto";
            // 
            // TextoRojo
            // 
            this.TextoRojo.BackColor = System.Drawing.Color.Red;
            this.TextoRojo.Location = new System.Drawing.Point(78, 38);
            this.TextoRojo.Name = "TextoRojo";
            this.TextoRojo.Size = new System.Drawing.Size(27, 29);
            this.TextoRojo.TabIndex = 2;
            this.TextoRojo.UseVisualStyleBackColor = false;
            this.TextoRojo.Click += new System.EventHandler(this.TextoRojo_Click);
            // 
            // TextoAzul
            // 
            this.TextoAzul.BackColor = System.Drawing.Color.Blue;
            this.TextoAzul.Location = new System.Drawing.Point(42, 38);
            this.TextoAzul.Name = "TextoAzul";
            this.TextoAzul.Size = new System.Drawing.Size(31, 29);
            this.TextoAzul.TabIndex = 1;
            this.TextoAzul.UseVisualStyleBackColor = false;
            this.TextoAzul.Click += new System.EventHandler(this.TextoAzul_Click);
            // 
            // TextoVerde
            // 
            this.TextoVerde.BackColor = System.Drawing.Color.Lime;
            this.TextoVerde.Location = new System.Drawing.Point(6, 38);
            this.TextoVerde.Name = "TextoVerde";
            this.TextoVerde.Size = new System.Drawing.Size(27, 29);
            this.TextoVerde.TabIndex = 0;
            this.TextoVerde.UseVisualStyleBackColor = false;
            this.TextoVerde.Click += new System.EventHandler(this.TextoVerde_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EligeTamano);
            this.panel2.Controls.Add(this.TamanoTexto);
            this.panel2.Controls.Add(this.ColorTexto);
            this.panel2.Location = new System.Drawing.Point(32, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 154);
            this.panel2.TabIndex = 2;
            // 
            // EligeTamano
            // 
            this.EligeTamano.Location = new System.Drawing.Point(20, 34);
            this.EligeTamano.Name = "EligeTamano";
            this.EligeTamano.Size = new System.Drawing.Size(129, 27);
            this.EligeTamano.TabIndex = 3;
            this.EligeTamano.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EligeTamano.ValueChanged += new System.EventHandler(this.EligeTamano_ValueChanged);
            // 
            // TamanoTexto
            // 
            this.TamanoTexto.AutoSize = true;
            this.TamanoTexto.Location = new System.Drawing.Point(20, 11);
            this.TamanoTexto.Name = "TamanoTexto";
            this.TamanoTexto.Size = new System.Drawing.Size(124, 20);
            this.TamanoTexto.TabIndex = 2;
            this.TamanoTexto.Text = "Tamaño del texto";
            // 
            // Fuentes
            // 
            this.Fuentes.FormattingEnabled = true;
            this.Fuentes.ItemHeight = 20;
            this.Fuentes.Location = new System.Drawing.Point(567, 26);
            this.Fuentes.Name = "Fuentes";
            this.Fuentes.Size = new System.Drawing.Size(182, 424);
            this.Fuentes.TabIndex = 3;
            this.Fuentes.SelectedIndexChanged += new System.EventHandler(this.Fuentes_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Subrayado);
            this.panel3.Controls.Add(this.Cursiva);
            this.panel3.Controls.Add(this.Negrita);
            this.panel3.Controls.Add(this.Cerrar);
            this.panel3.Controls.Add(this.Mostrar);
            this.panel3.Controls.Add(this.Ocultar);
            this.panel3.Location = new System.Drawing.Point(32, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 125);
            this.panel3.TabIndex = 4;
            // 
            // Subrayado
            // 
            this.Subrayado.AutoSize = true;
            this.Subrayado.Location = new System.Drawing.Point(283, 81);
            this.Subrayado.Name = "Subrayado";
            this.Subrayado.Size = new System.Drawing.Size(102, 24);
            this.Subrayado.TabIndex = 5;
            this.Subrayado.Text = "Subrayado";
            this.Subrayado.UseVisualStyleBackColor = true;
            this.Subrayado.CheckedChanged += new System.EventHandler(this.Subrayado_CheckedChanged);
            // 
            // Cursiva
            // 
            this.Cursiva.AutoSize = true;
            this.Cursiva.Location = new System.Drawing.Point(146, 81);
            this.Cursiva.Name = "Cursiva";
            this.Cursiva.Size = new System.Drawing.Size(78, 24);
            this.Cursiva.TabIndex = 4;
            this.Cursiva.Text = "Cursiva";
            this.Cursiva.UseVisualStyleBackColor = true;
            this.Cursiva.CheckedChanged += new System.EventHandler(this.Cursiva_CheckedChanged);
            // 
            // Negrita
            // 
            this.Negrita.AutoSize = true;
            this.Negrita.Location = new System.Drawing.Point(20, 81);
            this.Negrita.Name = "Negrita";
            this.Negrita.Size = new System.Drawing.Size(81, 24);
            this.Negrita.TabIndex = 3;
            this.Negrita.Text = "Negrita";
            this.Negrita.UseVisualStyleBackColor = true;
            this.Negrita.CheckedChanged += new System.EventHandler(this.Negrita_CheckedChanged);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(283, 26);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(124, 29);
            this.Cerrar.TabIndex = 2;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(146, 26);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(124, 29);
            this.Mostrar.TabIndex = 1;
            this.Mostrar.Text = "Mostrar Texto";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // Ocultar
            // 
            this.Ocultar.Location = new System.Drawing.Point(20, 26);
            this.Ocultar.Name = "Ocultar";
            this.Ocultar.Size = new System.Drawing.Size(111, 29);
            this.Ocultar.TabIndex = 0;
            this.Ocultar.Text = "Ocultar Texto";
            this.Ocultar.UseVisualStyleBackColor = true;
            this.Ocultar.Click += new System.EventHandler(this.Ocultar_Click);
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.ForeColor = System.Drawing.Color.Black;
            this.Texto.Location = new System.Drawing.Point(383, 167);
            this.Texto.MaximumSize = new System.Drawing.Size(400, 400);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(45, 20);
            this.Texto.TabIndex = 5;
            this.Texto.Text = "Texto";
            // 
            // TxtTexto
            // 
            this.TxtTexto.Location = new System.Drawing.Point(567, 465);
            this.TxtTexto.Name = "TxtTexto";
            this.TxtTexto.Size = new System.Drawing.Size(125, 27);
            this.TxtTexto.TabIndex = 6;
            // 
            // Cambiar
            // 
            this.Cambiar.Location = new System.Drawing.Point(567, 499);
            this.Cambiar.Name = "Cambiar";
            this.Cambiar.Size = new System.Drawing.Size(94, 29);
            this.Cambiar.TabIndex = 7;
            this.Cambiar.Text = "Cambiar texto";
            this.Cambiar.UseVisualStyleBackColor = true;
            this.Cambiar.Click += new System.EventHandler(this.Cambiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.Cambiar);
            this.Controls.Add(this.TxtTexto);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Fuentes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ColorTexto.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EligeTamano)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FormRojo;
        private System.Windows.Forms.Button FormAzul;
        private System.Windows.Forms.Button FormVerde;
        private System.Windows.Forms.Button Reducir;
        private System.Windows.Forms.Button Aumentar;
        private System.Windows.Forms.Label Propiedades;
        private System.Windows.Forms.GroupBox ColorTexto;
        private System.Windows.Forms.Button TextoRojo;
        private System.Windows.Forms.Button TextoAzul;
        private System.Windows.Forms.Button TextoVerde;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown EligeTamano;
        private System.Windows.Forms.Label TamanoTexto;
        private System.Windows.Forms.ListBox Fuentes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox Subrayado;
        private System.Windows.Forms.CheckBox Cursiva;
        private System.Windows.Forms.CheckBox Negrita;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Button Ocultar;
        private System.Windows.Forms.Label Texto;
        private System.Windows.Forms.TextBox TxtTexto;
        private System.Windows.Forms.Button Cambiar;
    }
}

