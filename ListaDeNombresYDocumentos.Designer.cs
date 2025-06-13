namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LbAlumno = new System.Windows.Forms.ListBox();
            this.btnOrdenado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(52, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 34);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(52, 63);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(121, 33);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-253, 268);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // LbAlumno
            // 
            this.LbAlumno.FormattingEnabled = true;
            this.LbAlumno.Location = new System.Drawing.Point(53, 157);
            this.LbAlumno.Name = "LbAlumno";
            this.LbAlumno.Size = new System.Drawing.Size(120, 95);
            this.LbAlumno.TabIndex = 3;
            // 
            // btnOrdenado
            // 
            this.btnOrdenado.Location = new System.Drawing.Point(53, 102);
            this.btnOrdenado.Name = "btnOrdenado";
            this.btnOrdenado.Size = new System.Drawing.Size(120, 30);
            this.btnOrdenado.TabIndex = 4;
            this.btnOrdenado.Text = "Ver Ordenado";
            this.btnOrdenado.UseVisualStyleBackColor = true;
            this.btnOrdenado.Click += new System.EventHandler(this.btnOrdenado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondo_de_textura_de_hormigon_negro_grunge;
            this.ClientSize = new System.Drawing.Size(225, 294);
            this.Controls.Add(this.btnOrdenado);
            this.Controls.Add(this.LbAlumno);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox LbAlumno;
        private System.Windows.Forms.Button btnOrdenado;
    }
}

