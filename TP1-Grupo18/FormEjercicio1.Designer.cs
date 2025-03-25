namespace TP1_Grupo18
{
    partial class FormEjercicio1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.btnPasarUno = new System.Windows.Forms.Button();
            this.lbRecibeNombre = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNombre.Location = new System.Drawing.Point(39, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(153, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese su nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(188, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnAgregar.Location = new System.Drawing.Point(402, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 31);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbNombres
            // 
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.Location = new System.Drawing.Point(42, 111);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbNombres.Size = new System.Drawing.Size(172, 225);
            this.lbNombres.TabIndex = 3;
            // 
            // btnPasarUno
            // 
            this.btnPasarUno.Location = new System.Drawing.Point(250, 167);
            this.btnPasarUno.Name = "btnPasarUno";
            this.btnPasarUno.Size = new System.Drawing.Size(75, 23);
            this.btnPasarUno.TabIndex = 4;
            this.btnPasarUno.Text = ">";
            this.btnPasarUno.UseVisualStyleBackColor = true;
            this.btnPasarUno.Click += new System.EventHandler(this.btnPasarUno_Click);
            // 
            // lbRecibeNombre
            // 
            this.lbRecibeNombre.FormattingEnabled = true;
            this.lbRecibeNombre.Location = new System.Drawing.Point(350, 111);
            this.lbRecibeNombre.Name = "lbRecibeNombre";
            this.lbRecibeNombre.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbRecibeNombre.Size = new System.Drawing.Size(172, 225);
            this.lbRecibeNombre.TabIndex = 5;
            // 
            // FormEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(584, 418);
            this.Controls.Add(this.lbRecibeNombre);
            this.Controls.Add(this.btnPasarUno);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbNombres;
        private System.Windows.Forms.Button btnPasarUno;
        private System.Windows.Forms.ListBox lbRecibeNombre;
    }
}