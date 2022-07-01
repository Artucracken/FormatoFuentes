using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatoFuentes
{
    public partial class Form1 : Form
    {
        int d = 0;
        int a = 0;
        FontFamily[] fuentes = new InstalledFontCollection().Families;

        public Form1()
        {
           

            InitializeComponent();
           

            foreach (FontFamily fuente in FontFamily.Families)
            {
                String nombre = fuente.Name;
                Fuentes.Items.Add(nombre);

            }
            Fuentes.Text = this.Fuentes.Font.Name.ToString();
        }

        private void Aumentar_Click(object sender, EventArgs e)
        {
            a = this.Width;
            for ( int i = this.Width; i< a+100; i++)
            {
                this.Width = i;
                this.Height = i;
                d = 99;
            }
        }

        private void Reducir_Click(object sender, EventArgs e)
        {

            d = this.Width;
            for(int i = d; i>d-100; i--)
            {
                this.Width = i;
                this.Height = i;
            }
        }

        private void FormVerde_Click(object sender, EventArgs e)
        {
            
            this.BackColor = Color.Green;
        }

        private void FormAzul_Click(object sender, EventArgs e)
        {
            
            this.BackColor = Color.Blue;
        }

        private void FormRojo_Click(object sender, EventArgs e)
        {
          
            this.BackColor = Color.Red;
        }

        private void TextoVerde_Click(object sender, EventArgs e)
        {
            Texto.ForeColor = System.Drawing.Color.Green;
        }

        private void TextoAzul_Click(object sender, EventArgs e)
        {
            Texto.ForeColor = System.Drawing.Color.Blue;
        }

        private void TextoRojo_Click(object sender, EventArgs e)
        {
            Texto.ForeColor = System.Drawing.Color.Red;
        }

        private void EligeTamano_ValueChanged(object sender, EventArgs e)
        {

            int Tamano = Convert.ToInt32(EligeTamano.Value);

            Font fuente = new Font(Texto.Font.FontFamily, Tamano);
            Texto.Font = fuente;
            
           
        }

        private void Ocultar_Click(object sender, EventArgs e)
        {
            
            
                Texto.Visible = false;
           
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Texto.Visible = true;
        }

        private void Negrita_CheckedChanged(object sender, EventArgs e)
        {
            if (Negrita.Checked)
            {
                Texto.Font = new System.Drawing.Font(Texto.Font, FontStyle.Bold);

            }
            else
            {
                Texto.Font = new Font(Texto.Font, Texto.Font.Style ^ FontStyle.Bold);
            }
        }

        private void Cursiva_CheckedChanged(object sender, EventArgs e)
        {
            if (Cursiva.Checked)
            {
                Texto.Font = new Font(Texto.Font, Texto.Font.Style | FontStyle.Italic);
            }
            else
            {
                Texto.Font = new Font(Texto.Font, Texto.Font.Style ^ FontStyle.Italic);
            }

        }

        private void Subrayado_CheckedChanged(object sender, EventArgs e)
        {
            if (Subrayado.Checked)
            {
                //el construcotr es: fuente ya creada, estilo de fuente nueva con el caracter | le añadimos el estilo
                Texto.Font = new Font(Texto.Font, Texto.Font.Style | FontStyle.Underline);
            }
            else
            {
                // y con el caracter ^ se lo quitamos 
                Texto.Font = new Font(Texto.Font, Texto.Font.Style ^ FontStyle.Underline);
            }
        }

        private void Fuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Texto.Font =  new Font(fuentes[Fuentes.SelectedIndex].Name, Texto.Font.Size);
            
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cambiar_Click(object sender, EventArgs e)
        {
            Texto.Text = TxtTexto.Text;
        }
    }
}
