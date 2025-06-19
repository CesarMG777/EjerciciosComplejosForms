namespace Piedra__papel_y_Tijeras
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
            this.lblScore1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtnPiedra = new System.Windows.Forms.RadioButton();
            this.rtnPapel = new System.Windows.Forms.RadioButton();
            this.rtnTijeras = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtnBotPiedra = new System.Windows.Forms.RadioButton();
            this.rtnBotPapel = new System.Windows.Forms.RadioButton();
            this.rtnBotTijeras = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.Color.Teal;
            this.lblScore1.Location = new System.Drawing.Point(35, 21);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(48, 13);
            this.lblScore1.TabIndex = 0;
            this.lblScore1.Text = "Score :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(573, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(679, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = ": Score";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtnTijeras);
            this.groupBox1.Controls.Add(this.rtnPapel);
            this.groupBox1.Controls.Add(this.rtnPiedra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(29, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jugador 1";
            // 
            // rtnPiedra
            // 
            this.rtnPiedra.AutoSize = true;
            this.rtnPiedra.Location = new System.Drawing.Point(36, 34);
            this.rtnPiedra.Name = "rtnPiedra";
            this.rtnPiedra.Size = new System.Drawing.Size(61, 17);
            this.rtnPiedra.TabIndex = 0;
            this.rtnPiedra.TabStop = true;
            this.rtnPiedra.Text = "Piedra";
            this.rtnPiedra.UseVisualStyleBackColor = true;
            // 
            // rtnPapel
            // 
            this.rtnPapel.AutoSize = true;
            this.rtnPapel.Location = new System.Drawing.Point(36, 109);
            this.rtnPapel.Name = "rtnPapel";
            this.rtnPapel.Size = new System.Drawing.Size(57, 17);
            this.rtnPapel.TabIndex = 1;
            this.rtnPapel.TabStop = true;
            this.rtnPapel.Text = "Papel";
            this.rtnPapel.UseVisualStyleBackColor = true;
            // 
            // rtnTijeras
            // 
            this.rtnTijeras.AutoSize = true;
            this.rtnTijeras.Location = new System.Drawing.Point(36, 194);
            this.rtnTijeras.Name = "rtnTijeras";
            this.rtnTijeras.Size = new System.Drawing.Size(63, 17);
            this.rtnTijeras.TabIndex = 2;
            this.rtnTijeras.TabStop = true;
            this.rtnTijeras.Text = "Tijeras";
            this.rtnTijeras.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(332, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Jugar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtnBotTijeras);
            this.groupBox2.Controls.Add(this.rtnBotPapel);
            this.groupBox2.Controls.Add(this.rtnBotPiedra);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(514, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 275);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bot";
            // 
            // rtnBotPiedra
            // 
            this.rtnBotPiedra.AutoSize = true;
            this.rtnBotPiedra.Location = new System.Drawing.Point(47, 41);
            this.rtnBotPiedra.Name = "rtnBotPiedra";
            this.rtnBotPiedra.Size = new System.Drawing.Size(71, 20);
            this.rtnBotPiedra.TabIndex = 0;
            this.rtnBotPiedra.TabStop = true;
            this.rtnBotPiedra.Text = "Piedra";
            this.rtnBotPiedra.UseVisualStyleBackColor = true;
            // 
            // rtnBotPapel
            // 
            this.rtnBotPapel.AutoSize = true;
            this.rtnBotPapel.Location = new System.Drawing.Point(47, 99);
            this.rtnBotPapel.Name = "rtnBotPapel";
            this.rtnBotPapel.Size = new System.Drawing.Size(66, 20);
            this.rtnBotPapel.TabIndex = 1;
            this.rtnBotPapel.TabStop = true;
            this.rtnBotPapel.Text = "Papel";
            this.rtnBotPapel.UseVisualStyleBackColor = true;
            // 
            // rtnBotTijeras
            // 
            this.rtnBotTijeras.AutoSize = true;
            this.rtnBotTijeras.Location = new System.Drawing.Point(47, 184);
            this.rtnBotTijeras.Name = "rtnBotTijeras";
            this.rtnBotTijeras.Size = new System.Drawing.Size(74, 20);
            this.rtnBotTijeras.TabIndex = 2;
            this.rtnBotTijeras.TabStop = true;
            this.rtnBotTijeras.Text = "Tijeras";
            this.rtnBotTijeras.UseVisualStyleBackColor = true;
            this.rtnBotTijeras.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::Piedra__papel_y_Tijeras.Properties.Resources.icons8_battle_50;
            this.label2.Location = new System.Drawing.Point(364, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::Piedra__papel_y_Tijeras.Properties.Resources.icons8_battle_50;
            this.pictureBox1.Location = new System.Drawing.Point(352, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 58);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblScore1);
            this.Name = "Form1";
            this.Text = "Piedra, Papel o Tijera";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rtnTijeras;
        private System.Windows.Forms.RadioButton rtnPapel;
        private System.Windows.Forms.RadioButton rtnPiedra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rtnBotTijeras;
        private System.Windows.Forms.RadioButton rtnBotPapel;
        private System.Windows.Forms.RadioButton rtnBotPiedra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

