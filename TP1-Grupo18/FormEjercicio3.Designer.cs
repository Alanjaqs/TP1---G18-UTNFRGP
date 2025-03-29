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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.gbEstadoCivil.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Controls.Add(this.rbSoltero);
            this.gbEstadoCivil.Controls.Add(this.rbCasado);
            this.gbEstadoCivil.Location = new System.Drawing.Point(338, 20);
            this.gbEstadoCivil.Margin = new System.Windows.Forms.Padding(2);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Padding = new System.Windows.Forms.Padding(2);
            this.gbEstadoCivil.Size = new System.Drawing.Size(185, 96);
            this.gbEstadoCivil.TabIndex = 0;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(45, 60);
            this.rbSoltero.Margin = new System.Windows.Forms.Padding(2);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbSoltero.TabIndex = 1;
            this.rbSoltero.TabStop = true;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(45, 28);
            this.rbCasado.Margin = new System.Windows.Forms.Padding(2);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 0;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFemenino);
            this.gbSexo.Location = new System.Drawing.Point(24, 20);
            this.gbSexo.Margin = new System.Windows.Forms.Padding(2);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Padding = new System.Windows.Forms.Padding(2);
            this.gbSexo.Size = new System.Drawing.Size(206, 96);
            this.gbSexo.TabIndex = 1;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(35, 60);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Location = new System.Drawing.Point(35, 28);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(2);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
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
            this.clbOficios.Location = new System.Drawing.Point(163, 132);
            this.clbOficios.Name = "clbOficios";
            this.clbOficios.Size = new System.Drawing.Size(233, 139);
            this.clbOficios.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Location = new System.Drawing.Point(163, 300);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(233, 29);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar lo que se seleccionó";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usted seleccionó los siguientes elementos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sexo:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(66, 400);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(34, 17);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "N/A";
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(549, 543);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.clbOficios);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.gbEstadoCivil);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGenero;
    }
}