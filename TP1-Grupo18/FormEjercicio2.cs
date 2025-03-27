using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Grupo18
{
    public partial class FormEjercicio2 : Form
    {
        FormPrincipal formPrincipal;
        public FormEjercicio2(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void FormEjercicio2_Load(object sender, EventArgs e)
        {

        }

        private void FormEjercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Valida que no esté en blanco
            if (textNombre.Text.Trim() == "" && textApellido.Text.Trim() != "")
            {
                MessageBox.Show("Por favor ingrese su nombre", "Ventana emergente");
            }
            else if (textNombre.Text.Trim() != "" && textApellido.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese su apellido", "Ventana emergente");
            }
            else if (textNombre.Text.Trim() == "" && textApellido.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese su nombre y apellido", "Ventana emergente");
            }
            else
            {
                string nuevoItem = textNombre.Text.Trim().ToLower() + " " + textApellido.Text.Trim().ToLower();
                bool existe = false;

                //se compara cada item de la lista con la copia
                foreach (string item in lbIngresoNombres.Items)
                {
                    //si encuentra coincidencia cambia de estado la bandera y detiene el bucle
                    if (item.ToLower() == nuevoItem)
                    {
                        existe = true;

                        break;
                    }
                }

                //se verifica que el nombre ya fue ingresado
                if (existe==true)
                {
                    MessageBox.Show("El nombre ya fue ingresado", "Atencion");
                }
                //se agrega el contenido del texto original a la lista de items
                else
                {
                    lbIngresoNombres.Items.Add(nuevoItem);
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
