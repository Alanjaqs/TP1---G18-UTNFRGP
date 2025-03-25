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
    public partial class FormEjercicio1 : Form
    {
        FormPrincipal formPrincipal;
        public FormEjercicio1(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void FormEjercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim() != "")
            {
                lbNombres.Items.Add(txtNombre.Text.Trim());
                txtNombre.Text = string.Empty;
            }
        }
    }
}
