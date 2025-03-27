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
            this.btnPasarTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNombre.Location = new System.Drawing.Point(52, 68);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(177, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese su nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(251, 68);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnAgregar.Location = new System.Drawing.Point(536, 60);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 38);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbNombres
            // 
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.ItemHeight = 16;
            this.lbNombres.Location = new System.Drawing.Point(56, 137);
            this.lbNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbNombres.Size = new System.Drawing.Size(228, 276);
            this.lbNombres.TabIndex = 3;
            // 
            // btnPasarUno
            // 
            this.btnPasarUno.BackColor = System.Drawing.SystemColors.Control;
            this.btnPasarUno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasarUno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPasarUno.Location = new System.Drawing.Point(333, 206);
            this.btnPasarUno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasarUno.Name = "btnPasarUno";
            this.btnPasarUno.Size = new System.Drawing.Size(100, 28);
            this.btnPasarUno.TabIndex = 4;
            this.btnPasarUno.Text = ">";
            this.btnPasarUno.UseVisualStyleBackColor = false;
            this.btnPasarUno.Click += new System.EventHandler(this.btnPasarUno_Click);
            // 
            // lbRecibeNombre
            // 
            this.lbRecibeNombre.FormattingEnabled = true;
            this.lbRecibeNombre.ItemHeight = 16;
            this.lbRecibeNombre.Location = new System.Drawing.Point(467, 137);
            this.lbRecibeNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbRecibeNombre.Name = "lbRecibeNombre";
            this.lbRecibeNombre.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbRecibeNombre.Size = new System.Drawing.Size(228, 276);
            this.lbRecibeNombre.TabIndex = 5;
            // 
            // btnPasarTodos
            // 
            this.btnPasarTodos.BackColor = System.Drawing.SystemColors.Control;
            this.btnPasarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasarTodos.Location = new System.Drawing.Point(333, 282);
            this.btnPasarTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasarTodos.Name = "btnPasarTodos";
            this.btnPasarTodos.Size = new System.Drawing.Size(100, 28);
            this.btnPasarTodos.TabIndex = 6;
            this.btnPasarTodos.Text = ">>";
            this.btnPasarTodos.UseVisualStyleBackColor = false;
            this.btnPasarTodos.Click += new System.EventHandler(this.btnPasarTodos_Click);
            // 
            // FormEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(779, 514);
            this.Controls.Add(this.btnPasarTodos);
            this.Controls.Add(this.lbRecibeNombre);
            this.Controls.Add(this.btnPasarUno);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio1_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio1_Load);
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
        private System.Windows.Forms.Button btnPasarTodos;
    }
}