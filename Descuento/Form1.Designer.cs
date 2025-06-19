namespace Descuento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIngresoPrecio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gpGrupo1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gpDescuento = new System.Windows.Forms.GroupBox();
            this.rtn5porciento = new System.Windows.Forms.RadioButton();
            this.rtn10porciento = new System.Windows.Forms.RadioButton();
            this.rtn20porciento = new System.Windows.Forms.RadioButton();
            this.lblnegativo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpGrupo1.SuspendLayout();
            this.gpDescuento.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblIngresoPrecio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 186);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // lblIngresoPrecio
            // 
            this.lblIngresoPrecio.AutoSize = true;
            this.lblIngresoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoPrecio.Location = new System.Drawing.Point(17, 34);
            this.lblIngresoPrecio.Name = "lblIngresoPrecio";
            this.lblIngresoPrecio.Size = new System.Drawing.Size(142, 16);
            this.lblIngresoPrecio.TabIndex = 1;
            this.lblIngresoPrecio.Text = "Ingreso del Precio :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(343, 70);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 39);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gpGrupo1
            // 
            this.gpGrupo1.Controls.Add(this.lblnegativo);
            this.gpGrupo1.Controls.Add(this.txtTotal);
            this.gpGrupo1.Location = new System.Drawing.Point(53, 283);
            this.gpGrupo1.Name = "gpGrupo1";
            this.gpGrupo1.Size = new System.Drawing.Size(483, 125);
            this.gpGrupo1.TabIndex = 1;
            this.gpGrupo1.TabStop = false;
            this.gpGrupo1.Text = "Total";
            this.gpGrupo1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(30, 49);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(311, 20);
            this.txtTotal.TabIndex = 0;
            // 
            // gpDescuento
            // 
            this.gpDescuento.Controls.Add(this.rtn20porciento);
            this.gpDescuento.Controls.Add(this.rtn10porciento);
            this.gpDescuento.Controls.Add(this.rtn5porciento);
            this.gpDescuento.Location = new System.Drawing.Point(574, 59);
            this.gpDescuento.Name = "gpDescuento";
            this.gpDescuento.Size = new System.Drawing.Size(213, 224);
            this.gpDescuento.TabIndex = 2;
            this.gpDescuento.TabStop = false;
            this.gpDescuento.Text = "Descuento %";
            // 
            // rtn5porciento
            // 
            this.rtn5porciento.AutoSize = true;
            this.rtn5porciento.Location = new System.Drawing.Point(39, 36);
            this.rtn5porciento.Name = "rtn5porciento";
            this.rtn5porciento.Size = new System.Drawing.Size(39, 17);
            this.rtn5porciento.TabIndex = 0;
            this.rtn5porciento.TabStop = true;
            this.rtn5porciento.Text = "5%";
            this.rtn5porciento.UseVisualStyleBackColor = true;
            // 
            // rtn10porciento
            // 
            this.rtn10porciento.AutoSize = true;
            this.rtn10porciento.Location = new System.Drawing.Point(39, 61);
            this.rtn10porciento.Name = "rtn10porciento";
            this.rtn10porciento.Size = new System.Drawing.Size(45, 17);
            this.rtn10porciento.TabIndex = 1;
            this.rtn10porciento.TabStop = true;
            this.rtn10porciento.Text = "10%";
            this.rtn10porciento.UseVisualStyleBackColor = true;
            // 
            // rtn20porciento
            // 
            this.rtn20porciento.AutoSize = true;
            this.rtn20porciento.Location = new System.Drawing.Point(39, 84);
            this.rtn20porciento.Name = "rtn20porciento";
            this.rtn20porciento.Size = new System.Drawing.Size(45, 17);
            this.rtn20porciento.TabIndex = 2;
            this.rtn20porciento.TabStop = true;
            this.rtn20porciento.Text = "20%";
            this.rtn20porciento.UseVisualStyleBackColor = true;
            // 
            // lblnegativo
            // 
            this.lblnegativo.AutoSize = true;
            this.lblnegativo.Location = new System.Drawing.Point(385, 52);
            this.lblnegativo.Name = "lblnegativo";
            this.lblnegativo.Size = new System.Drawing.Size(66, 13);
            this.lblnegativo.TabIndex = 3;
            this.lblnegativo.Text = "No se aplico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpDescuento);
            this.Controls.Add(this.gpGrupo1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Descuento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpGrupo1.ResumeLayout(false);
            this.gpGrupo1.PerformLayout();
            this.gpDescuento.ResumeLayout(false);
            this.gpDescuento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIngresoPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gpGrupo1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox gpDescuento;
        private System.Windows.Forms.RadioButton rtn5porciento;
        private System.Windows.Forms.Label lblnegativo;
        private System.Windows.Forms.RadioButton rtn20porciento;
        private System.Windows.Forms.RadioButton rtn10porciento;
    }
}

