namespace Estado_Civil
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.rtnCasado = new System.Windows.Forms.RadioButton();
            this.rtnSoltero = new System.Windows.Forms.RadioButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtnMasc = new System.Windows.Forms.RadioButton();
            this.rtnFem = new System.Windows.Forms.RadioButton();
            this.lblImprimir = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.rtnSoltero);
            this.groupBox1.Controls.Add(this.rtnCasado);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(45, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(45, 70);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(45, 127);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(82, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado Civil :";
            // 
            // rtnCasado
            // 
            this.rtnCasado.AutoSize = true;
            this.rtnCasado.Location = new System.Drawing.Point(48, 159);
            this.rtnCasado.Name = "rtnCasado";
            this.rtnCasado.Size = new System.Drawing.Size(67, 17);
            this.rtnCasado.TabIndex = 4;
            this.rtnCasado.TabStop = true;
            this.rtnCasado.Text = "Casado";
            this.rtnCasado.UseVisualStyleBackColor = true;
            // 
            // rtnSoltero
            // 
            this.rtnSoltero.AutoSize = true;
            this.rtnSoltero.Location = new System.Drawing.Point(48, 182);
            this.rtnSoltero.Name = "rtnSoltero";
            this.rtnSoltero.Size = new System.Drawing.Size(65, 17);
            this.rtnSoltero.TabIndex = 5;
            this.rtnSoltero.TabStop = true;
            this.rtnSoltero.Text = "Soltero";
            this.rtnSoltero.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(372, 117);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(153, 82);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblImprimir);
            this.groupBox2.Controls.Add(this.rtnFem);
            this.groupBox2.Controls.Add(this.rtnMasc);
            this.groupBox2.Location = new System.Drawing.Point(60, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genero";
            // 
            // rtnMasc
            // 
            this.rtnMasc.AutoSize = true;
            this.rtnMasc.Location = new System.Drawing.Point(31, 39);
            this.rtnMasc.Name = "rtnMasc";
            this.rtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rtnMasc.TabIndex = 0;
            this.rtnMasc.TabStop = true;
            this.rtnMasc.Text = "Masculino";
            this.rtnMasc.UseVisualStyleBackColor = true;
            // 
            // rtnFem
            // 
            this.rtnFem.AutoSize = true;
            this.rtnFem.Location = new System.Drawing.Point(31, 62);
            this.rtnFem.Name = "rtnFem";
            this.rtnFem.Size = new System.Drawing.Size(71, 17);
            this.rtnFem.TabIndex = 1;
            this.rtnFem.TabStop = true;
            this.rtnFem.Text = "Femenino";
            this.rtnFem.UseVisualStyleBackColor = true;
            // 
            // lblImprimir
            // 
            this.lblImprimir.AutoSize = true;
            this.lblImprimir.Location = new System.Drawing.Point(321, 43);
            this.lblImprimir.Name = "lblImprimir";
            this.lblImprimir.Size = new System.Drawing.Size(0, 13);
            this.lblImprimir.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(118, 67);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(273, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.RadioButton rtnSoltero;
        private System.Windows.Forms.RadioButton rtnCasado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblImprimir;
        private System.Windows.Forms.RadioButton rtnFem;
        private System.Windows.Forms.RadioButton rtnMasc;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox textBox1;
    }
}

