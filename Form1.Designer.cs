namespace LavaderoAPP
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
            this.lblProductos = new System.Windows.Forms.Label();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnUlt = new System.Windows.Forms.Button();
            this.lblProximo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(80, 33);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(110, 13);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Listado de Productos:";
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(83, 64);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(292, 21);
            this.cboProductos.TabIndex = 2;
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(83, 110);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(75, 23);
            this.btnProx.TabIndex = 3;
            this.btnProx.Text = "Próximo ID";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnUlt
            // 
            this.btnUlt.Location = new System.Drawing.Point(300, 110);
            this.btnUlt.Name = "btnUlt";
            this.btnUlt.Size = new System.Drawing.Size(75, 23);
            this.btnUlt.TabIndex = 4;
            this.btnUlt.Text = "Último ID";
            this.btnUlt.UseVisualStyleBackColor = true;
            this.btnUlt.Click += new System.EventHandler(this.btnUlt_Click);
            // 
            // lblProximo
            // 
            this.lblProximo.AutoSize = true;
            this.lblProximo.Location = new System.Drawing.Point(80, 167);
            this.lblProximo.Name = "lblProximo";
            this.lblProximo.Size = new System.Drawing.Size(47, 13);
            this.lblProximo.TabIndex = 5;
            this.lblProximo.Text = "Proximo:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(300, 167);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(444, 211);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblProximo);
            this.Controls.Add(this.btnUlt);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.lblProductos);
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listador de Articulos";
            this.TransparencyKey = System.Drawing.Color.Orange;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnUlt;
        private System.Windows.Forms.Label lblProximo;
        private System.Windows.Forms.Button btnSalir;
    }
}

