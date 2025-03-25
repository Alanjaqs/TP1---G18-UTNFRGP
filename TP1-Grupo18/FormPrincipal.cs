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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            FormEjercicio1 formEjercicio1 = new FormEjercicio1(this);
            formEjercicio1.Show();
            this.Hide();
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            FormEjercicio2 formEjercicio2 = new FormEjercicio2(this);
            formEjercicio2.Show();
            this.Hide();
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            FormEjercicio3 formEjercicio3 = new FormEjercicio3(this);
            formEjercicio3.Show();
            this.Hide();
        }
    }
}
