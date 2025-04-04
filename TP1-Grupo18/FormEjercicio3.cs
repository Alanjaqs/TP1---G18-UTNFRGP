﻿using System;
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
    public partial class FormEjercicio3 : Form
    {
        FormPrincipal formPrincipal;
        public FormEjercicio3(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void FormEjercicio3_Load(object sender, EventArgs e)
        {

        }

        private void FormEjercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rbFemenino.Checked)
            {
                lblGenero.Text = "Femenino";
            }
            else if (rbMasculino.Checked)
            {
                lblGenero.Text = "Masculino";
            }

            if (rbCasado.Checked) {
                labelEstadoCivil.Text = "Casado";
            }else if (rbSoltero.Checked)
            {
                labelEstadoCivil.Text = "Soltero";
            }

            labelSeleccion.Visible = true;
            labelSexo.Visible = true;
            labelEstadoCivilTitulo.Visible = true;
            labelEstadoCivil.Visible = true;
            lblGenero.Visible = true;

            string oficiosSeleccionados = "";

            foreach (var item in clbOficios.CheckedItems)
            {
                oficiosSeleccionados += "- " + item.ToString() + "\n";
            }

            labelOficio.Text = oficiosSeleccionados;  

            if (clbOficios.CheckedItems.Count > 0)
            {
                lblOficio.Visible = true;
                labelOficio.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
