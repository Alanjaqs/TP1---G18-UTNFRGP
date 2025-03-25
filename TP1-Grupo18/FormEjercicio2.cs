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
    }
}
