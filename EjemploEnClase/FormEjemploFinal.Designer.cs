namespace WindowsFormsApp6
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
            this.TbValor = new System.Windows.Forms.TextBox();
            this.TbPromedio = new System.Windows.Forms.TextBox();
            this.TbResultado = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValor2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TbValor2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbValor
            // 
            this.TbValor.Location = new System.Drawing.Point(63, 51);
            this.TbValor.Name = "TbValor";
            this.TbValor.Size = new System.Drawing.Size(100, 20);
            this.TbValor.TabIndex = 0;
            // 
            // TbPromedio
            // 
            this.TbPromedio.Location = new System.Drawing.Point(63, 107);
            this.TbPromedio.Name = "TbPromedio";
            this.TbPromedio.Size = new System.Drawing.Size(100, 20);
            this.TbPromedio.TabIndex = 1;
            // 
            // TbResultado
            // 
            this.TbResultado.Location = new System.Drawing.Point(63, 163);
            this.TbResultado.Name = "TbResultado";
            this.TbResultado.Size = new System.Drawing.Size(100, 20);
            this.TbResultado.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(321, 48);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(321, 104);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 4;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Promedio";
            // 
            // btnValor2
            // 
            this.btnValor2.Location = new System.Drawing.Point(321, 204);
            this.btnValor2.Name = "btnValor2";
            this.btnValor2.Size = new System.Drawing.Size(75, 23);
            this.btnValor2.TabIndex = 7;
            this.btnValor2.Text = "Valor 2";
            this.btnValor2.UseVisualStyleBackColor = true;
            this.btnValor2.Click += new System.EventHandler(this.btnValor2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor2";
            // 
            // TbValor2
            // 
            this.TbValor2.Location = new System.Drawing.Point(63, 206);
            this.TbValor2.Name = "TbValor2";
            this.TbValor2.Size = new System.Drawing.Size(100, 20);
            this.TbValor2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 266);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbValor2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.TbResultado);
            this.Controls.Add(this.TbPromedio);
            this.Controls.Add(this.TbValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbValor;
        private System.Windows.Forms.TextBox TbPromedio;
        private System.Windows.Forms.TextBox TbResultado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbValor2;
        private System.Windows.Forms.Label label4;
    }
}

