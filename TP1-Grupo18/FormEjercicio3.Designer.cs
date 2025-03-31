namespace TP1_Grupo18
{
    partial class FormEjercicio3
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
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.clbOficios = new System.Windows.Forms.CheckedListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.labelSeleccion = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.labelEstadoCivilTitulo = new System.Windows.Forms.Label();
            this.labelEstadoCivil = new System.Windows.Forms.Label();
            this.lblOficio = new System.Windows.Forms.Label();
            this.labelOficio = new System.Windows.Forms.Label();
            this.gbEstadoCivil.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Controls.Add(this.rbSoltero);
            this.gbEstadoCivil.Controls.Add(this.rbCasado);
            this.gbEstadoCivil.Location = new System.Drawing.Point(451, 25);
            this.gbEstadoCivil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEstadoCivil.Size = new System.Drawing.Size(247, 118);
            this.gbEstadoCivil.TabIndex = 0;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(60, 74);
            this.rbSoltero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(71, 20);
            this.rbSoltero.TabIndex = 1;
            this.rbSoltero.TabStop = true;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(60, 34);
            this.rbCasado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(76, 20);
            this.rbCasado.TabIndex = 0;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFemenino);
            this.gbSexo.Location = new System.Drawing.Point(32, 25);
            this.gbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSexo.Size = new System.Drawing.Size(275, 118);
            this.gbSexo.TabIndex = 1;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(47, 74);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(89, 20);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Location = new System.Drawing.Point(47, 34);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(88, 20);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // clbOficios
            // 
            this.clbOficios.CheckOnClick = true;
            this.clbOficios.FormattingEnabled = true;
            this.clbOficios.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbOficios.Location = new System.Drawing.Point(237, 158);
            this.clbOficios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbOficios.Name = "clbOficios";
            this.clbOficios.Size = new System.Drawing.Size(276, 106);
            this.clbOficios.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Location = new System.Drawing.Point(218, 272);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(311, 36);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar lo que se seleccionó";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // labelSeleccion
            // 
            this.labelSeleccion.AutoSize = true;
            this.labelSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccion.Location = new System.Drawing.Point(28, 326);
            this.labelSeleccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeleccion.Name = "labelSeleccion";
            this.labelSeleccion.Size = new System.Drawing.Size(375, 20);
            this.labelSeleccion.TabIndex = 4;
            this.labelSeleccion.Text = "Usted seleccionó los siguientes elementos:";
            this.labelSeleccion.Visible = false;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(28, 357);
            this.labelSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(56, 20);
            this.labelSexo.TabIndex = 5;
            this.labelSexo.Text = "Sexo:";
            this.labelSexo.Visible = false;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(88, 357);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(40, 20);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "N/A";
            this.lblGenero.Visible = false;
            // 
            // labelEstadoCivilTitulo
            // 
            this.labelEstadoCivilTitulo.AutoSize = true;
            this.labelEstadoCivilTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoCivilTitulo.Location = new System.Drawing.Point(28, 389);
            this.labelEstadoCivilTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstadoCivilTitulo.Name = "labelEstadoCivilTitulo";
            this.labelEstadoCivilTitulo.Size = new System.Drawing.Size(116, 20);
            this.labelEstadoCivilTitulo.TabIndex = 7;
            this.labelEstadoCivilTitulo.Text = "Estado Civil:";
            this.labelEstadoCivilTitulo.Visible = false;
            this.labelEstadoCivilTitulo.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelEstadoCivil
            // 
            this.labelEstadoCivil.AutoSize = true;
            this.labelEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoCivil.Location = new System.Drawing.Point(167, 389);
            this.labelEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstadoCivil.Name = "labelEstadoCivil";
            this.labelEstadoCivil.Size = new System.Drawing.Size(40, 20);
            this.labelEstadoCivil.TabIndex = 8;
            this.labelEstadoCivil.Text = "N/A";
            this.labelEstadoCivil.Visible = false;
            // 
            // lblOficio
            // 
            this.lblOficio.AutoSize = true;
            this.lblOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOficio.Location = new System.Drawing.Point(28, 422);
            this.lblOficio.Name = "lblOficio";
            this.lblOficio.Size = new System.Drawing.Size(65, 20);
            this.lblOficio.TabIndex = 9;
            this.lblOficio.Text = "Oficio:";
            this.lblOficio.Visible = false;
            // 
            // labelOficio
            // 
            this.labelOficio.AutoSize = true;
            this.labelOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOficio.Location = new System.Drawing.Point(45, 446);
            this.labelOficio.Name = "labelOficio";
            this.labelOficio.Size = new System.Drawing.Size(40, 20);
            this.labelOficio.TabIndex = 10;
            this.labelOficio.Text = "N/A";
            this.labelOficio.Visible = false;
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(732, 668);
            this.Controls.Add(this.labelOficio);
            this.Controls.Add(this.lblOficio);
            this.Controls.Add(this.labelEstadoCivil);
            this.Controls.Add(this.labelEstadoCivilTitulo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelSeleccion);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.clbOficios);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.gbEstadoCivil);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEjercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio3_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio3_Load);
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.CheckedListBox clbOficios;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label labelSeleccion;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label labelEstadoCivilTitulo;
        private System.Windows.Forms.Label labelEstadoCivil;
        private System.Windows.Forms.Label lblOficio;
        private System.Windows.Forms.Label labelOficio;
    }
}