namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNEVALUAR = new System.Windows.Forms.Button();
            this.RBSUMA = new System.Windows.Forms.RadioButton();
            this.RBRESTA = new System.Windows.Forms.RadioButton();
            this.RBMULTI = new System.Windows.Forms.RadioButton();
            this.RBDIVI = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTD = new System.Windows.Forms.TextBox();
            this.TXTD1 = new System.Windows.Forms.TextBox();
            this.TXTD2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNEVALUAR
            // 
            this.BTNEVALUAR.Location = new System.Drawing.Point(96, 181);
            this.BTNEVALUAR.Name = "BTNEVALUAR";
            this.BTNEVALUAR.Size = new System.Drawing.Size(100, 47);
            this.BTNEVALUAR.TabIndex = 0;
            this.BTNEVALUAR.Text = "EVALUAR";
            this.BTNEVALUAR.UseVisualStyleBackColor = true;
            this.BTNEVALUAR.Click += new System.EventHandler(this.BTNEVALUAR_Click);
            // 
            // RBSUMA
            // 
            this.RBSUMA.AutoSize = true;
            this.RBSUMA.Location = new System.Drawing.Point(32, 27);
            this.RBSUMA.Name = "RBSUMA";
            this.RBSUMA.Size = new System.Drawing.Size(56, 17);
            this.RBSUMA.TabIndex = 1;
            this.RBSUMA.TabStop = true;
            this.RBSUMA.Text = "SUMA";
            this.RBSUMA.UseVisualStyleBackColor = true;
            // 
            // RBRESTA
            // 
            this.RBRESTA.AutoSize = true;
            this.RBRESTA.Location = new System.Drawing.Point(32, 50);
            this.RBRESTA.Name = "RBRESTA";
            this.RBRESTA.Size = new System.Drawing.Size(61, 17);
            this.RBRESTA.TabIndex = 2;
            this.RBRESTA.TabStop = true;
            this.RBRESTA.Text = "RESTA";
            this.RBRESTA.UseVisualStyleBackColor = true;
            // 
            // RBMULTI
            // 
            this.RBMULTI.AutoSize = true;
            this.RBMULTI.Location = new System.Drawing.Point(123, 27);
            this.RBMULTI.Name = "RBMULTI";
            this.RBMULTI.Size = new System.Drawing.Size(114, 17);
            this.RBMULTI.TabIndex = 3;
            this.RBMULTI.TabStop = true;
            this.RBMULTI.Text = "MULTIPLICACION";
            this.RBMULTI.UseVisualStyleBackColor = true;
            // 
            // RBDIVI
            // 
            this.RBDIVI.AutoSize = true;
            this.RBDIVI.Location = new System.Drawing.Point(123, 50);
            this.RBDIVI.Name = "RBDIVI";
            this.RBDIVI.Size = new System.Drawing.Size(72, 17);
            this.RBDIVI.TabIndex = 4;
            this.RBDIVI.TabStop = true;
            this.RBDIVI.Text = "DIVISION";
            this.RBDIVI.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTD);
            this.groupBox1.Controls.Add(this.TXTD1);
            this.groupBox1.Controls.Add(this.TXTD2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RBDIVI);
            this.groupBox1.Controls.Add(this.RBSUMA);
            this.groupBox1.Controls.Add(this.RBMULTI);
            this.groupBox1.Controls.Add(this.RBRESTA);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // TXTD
            // 
            this.TXTD.Location = new System.Drawing.Point(154, 107);
            this.TXTD.Name = "TXTD";
            this.TXTD.Size = new System.Drawing.Size(100, 20);
            this.TXTD.TabIndex = 9;
            // 
            // TXTD1
            // 
            this.TXTD1.Location = new System.Drawing.Point(6, 107);
            this.TXTD1.Name = "TXTD1";
            this.TXTD1.Size = new System.Drawing.Size(100, 20);
            this.TXTD1.TabIndex = 8;
            // 
            // TXTD2
            // 
            this.TXTD2.AutoSize = true;
            this.TXTD2.Location = new System.Drawing.Point(183, 91);
            this.TXTD2.Name = "TXTD2";
            this.TXTD2.Size = new System.Drawing.Size(46, 13);
            this.TXTD2.TabIndex = 7;
            this.TXTD2.Text = "DATO 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DATO 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 236);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNEVALUAR);
            this.Name = "Form1";
            this.Text = "Ejercicio de Operaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNEVALUAR;
        private System.Windows.Forms.RadioButton RBSUMA;
        private System.Windows.Forms.RadioButton RBRESTA;
        private System.Windows.Forms.RadioButton RBMULTI;
        private System.Windows.Forms.RadioButton RBDIVI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTD1;
        private System.Windows.Forms.Label TXTD2;
        private System.Windows.Forms.TextBox TXTD;
    }
}

