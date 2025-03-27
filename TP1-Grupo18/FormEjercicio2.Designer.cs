namespace TP1_Grupo18
{
    partial class FormEjercicio2
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.lbIngresoNombres = new System.Windows.Forms.ListBox();
            this.grbIngresoDeDatos = new System.Windows.Forms.GroupBox();
            this.grbElementos = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grbIngresoDeDatos.SuspendLayout();
            this.grbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(70, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(70, 176);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(71, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(158, 125);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(147, 20);
            this.textNombre.TabIndex = 2;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(158, 175);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(147, 20);
            this.textApellido.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(118, 233);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(145, 39);
            this.buttonAgregar.TabIndex = 4;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbIngresoNombres
            // 
            this.lbIngresoNombres.FormattingEnabled = true;
            this.lbIngresoNombres.Location = new System.Drawing.Point(41, 29);
            this.lbIngresoNombres.Name = "lbIngresoNombres";
            this.lbIngresoNombres.Size = new System.Drawing.Size(244, 316);
            this.lbIngresoNombres.TabIndex = 6;
            // 
            // grbIngresoDeDatos
            // 
            this.grbIngresoDeDatos.Controls.Add(this.textNombre);
            this.grbIngresoDeDatos.Controls.Add(this.textApellido);
            this.grbIngresoDeDatos.Controls.Add(this.buttonAgregar);
            this.grbIngresoDeDatos.Controls.Add(this.lblNombre);
            this.grbIngresoDeDatos.Controls.Add(this.lblApellido);
            this.grbIngresoDeDatos.Location = new System.Drawing.Point(12, 12);
            this.grbIngresoDeDatos.Name = "grbIngresoDeDatos";
            this.grbIngresoDeDatos.Size = new System.Drawing.Size(352, 429);
            this.grbIngresoDeDatos.TabIndex = 7;
            this.grbIngresoDeDatos.TabStop = false;
            this.grbIngresoDeDatos.Text = "Ingreso de Datos";
            // 
            // grbElementos
            // 
            this.grbElementos.Controls.Add(this.btnBorrar);
            this.grbElementos.Controls.Add(this.lbIngresoNombres);
            this.grbElementos.Location = new System.Drawing.Point(406, 12);
            this.grbElementos.Name = "grbElementos";
            this.grbElementos.Size = new System.Drawing.Size(323, 429);
            this.grbElementos.TabIndex = 8;
            this.grbElementos.TabStop = false;
            this.grbElementos.Text = "Elementos";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(88, 366);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(145, 39);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FormEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(769, 487);
            this.Controls.Add(this.grbElementos);
            this.Controls.Add(this.grbIngresoDeDatos);
            this.Name = "FormEjercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre y apellido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio2_FormClosed);
            this.grbIngresoDeDatos.ResumeLayout(false);
            this.grbIngresoDeDatos.PerformLayout();
            this.grbElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.ListBox lbIngresoNombres;
        private System.Windows.Forms.GroupBox grbIngresoDeDatos;
        private System.Windows.Forms.GroupBox grbElementos;
        private System.Windows.Forms.Button btnBorrar;
    }
}