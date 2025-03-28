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
                //se crea una bandera y una copia del texto para hacer las verificaciones
                string texto = txtNombre.Text.Trim().ToLower();
                bool existe = false;

                //se compara cada item de la lista con la copia
                foreach (string item in lbNombres.Items)
                {
                    //si encuentra coincidencia cambia de estado la bandera y detiene el bucle
                    if (item.ToLower() == texto)
                    {
                        existe = true;
                        break;
                    }
                }

                //se verifica si el nombre ya fue ingresado
                if (existe)
                {
                    MessageBox.Show("El nombre ya fue ingresado", "Ventana Emergente");
                }
                //se agrega el contenido del texto original a la lista de items
                else
                {
                    lbNombres.Items.Add(txtNombre.Text.Trim());
                }
                //se limpia el cuadro de texto
                txtNombre.Text = "";
            }
        }

        private void btnPasarUno_Click(object sender, EventArgs e)
        {
            //se verifica que haya seleccionado por lo menos un item
            if (lbNombres.SelectedItems.Count > 0)
            {
                //se crea un array del tamaño de los elementos selecionados
                string[] iteamsSeleccionados = new string[lbNombres.SelectedItems.Count];

                //se llena el array con el elemento seleccionado en cada posicion
                for (int i = 0; i < lbNombres.SelectedItems.Count; i++)
                {
                    iteamsSeleccionados[i] = lbNombres.SelectedItems[i].ToString();
                }

                //se mueven los elementos a lbPasados y se eliminan de lbAgregados
                foreach (var item in iteamsSeleccionados)
                {
                    lbRecibeNombre.Items.Add(item);
                    lbNombres.Items.Remove(item);
                }
            }

            else
            {
                MessageBox.Show("Por favor seleccione al menos un item", "Atencion");
            }
        }

        private void btnPasarTodos_Click(object sender, EventArgs e)
        {
            if (lbNombres.Items.Count > 0){

                foreach (var item in lbNombres.Items){
                    lbRecibeNombre.Items.Add(item);
                }
                lbNombres.Items.Clear();
            }
            else
            {
                MessageBox.Show("Debe haber por lo menos un item ", "Atencion");
            }
        }

        private void FormEjercicio1_Load(object sender, EventArgs e)
        {

        }
    }
}
