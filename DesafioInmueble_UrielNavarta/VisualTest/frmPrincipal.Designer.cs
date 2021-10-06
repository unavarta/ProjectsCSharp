
namespace VisualTest
{
    partial class frmPrincipal
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
            this.lblSup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.tbSuperficie = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.CalculadorSupremo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPiso = new System.Windows.Forms.RadioButton();
            this.btnLocal = new System.Windows.Forms.RadioButton();
            this.tbPiso = new System.Windows.Forms.TextBox();
            this.tbWinds = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblWinds = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSup
            // 
            this.lblSup.AutoSize = true;
            this.lblSup.Location = new System.Drawing.Point(12, 208);
            this.lblSup.Name = "lblSup";
            this.lblSup.Size = new System.Drawing.Size(80, 13);
            this.lblSup.TabIndex = 0;
            this.lblSup.Text = "Superficie: (m2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la dirección:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(200, 208);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(66, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio base:";
            this.lblPrecio.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(98, 208);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(96, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Antiguedad: (años)";
            // 
            // tbSuperficie
            // 
            this.tbSuperficie.Location = new System.Drawing.Point(15, 224);
            this.tbSuperficie.Name = "tbSuperficie";
            this.tbSuperficie.Size = new System.Drawing.Size(60, 20);
            this.tbSuperficie.TabIndex = 4;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(203, 224);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(63, 20);
            this.tbPrecio.TabIndex = 5;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(12, 185);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(254, 20);
            this.tbDireccion.TabIndex = 6;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(101, 224);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(65, 20);
            this.tbEdad.TabIndex = 7;
            // 
            // CalculadorSupremo
            // 
            this.CalculadorSupremo.Location = new System.Drawing.Point(15, 250);
            this.CalculadorSupremo.Name = "CalculadorSupremo";
            this.CalculadorSupremo.Size = new System.Drawing.Size(251, 58);
            this.CalculadorSupremo.TabIndex = 8;
            this.CalculadorSupremo.Text = "Calcular";
            this.CalculadorSupremo.UseVisualStyleBackColor = true;
            this.CalculadorSupremo.Click += new System.EventHandler(this.CalculadorSupremo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWinds);
            this.groupBox1.Controls.Add(this.lblPiso);
            this.groupBox1.Controls.Add(this.tbWinds);
            this.groupBox1.Controls.Add(this.tbPiso);
            this.groupBox1.Controls.Add(this.btnLocal);
            this.groupBox1.Controls.Add(this.btnPiso);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 143);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Inmueble";
            // 
            // btnPiso
            // 
            this.btnPiso.AutoSize = true;
            this.btnPiso.Location = new System.Drawing.Point(30, 35);
            this.btnPiso.Name = "btnPiso";
            this.btnPiso.Size = new System.Drawing.Size(50, 17);
            this.btnPiso.TabIndex = 0;
            this.btnPiso.TabStop = true;
            this.btnPiso.Text = "PISO";
            this.btnPiso.UseVisualStyleBackColor = true;
            this.btnPiso.CheckedChanged += new System.EventHandler(this.btnPiso_CheckedChanged);
            // 
            // btnLocal
            // 
            this.btnLocal.AutoSize = true;
            this.btnLocal.Location = new System.Drawing.Point(163, 35);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(59, 17);
            this.btnLocal.TabIndex = 1;
            this.btnLocal.TabStop = true;
            this.btnLocal.Text = "LOCAL";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.CheckedChanged += new System.EventHandler(this.btnLocal_CheckedChanged);
            // 
            // tbPiso
            // 
            this.tbPiso.Location = new System.Drawing.Point(17, 93);
            this.tbPiso.Name = "tbPiso";
            this.tbPiso.Size = new System.Drawing.Size(63, 20);
            this.tbPiso.TabIndex = 2;
            // 
            // tbWinds
            // 
            this.tbWinds.Location = new System.Drawing.Point(170, 93);
            this.tbWinds.Name = "tbWinds";
            this.tbWinds.Size = new System.Drawing.Size(63, 20);
            this.tbWinds.TabIndex = 3;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(14, 77);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(68, 13);
            this.lblPiso.TabIndex = 4;
            this.lblPiso.Text = "Nro. de Piso:";
            // 
            // lblWinds
            // 
            this.lblWinds.AutoSize = true;
            this.lblWinds.Location = new System.Drawing.Point(134, 77);
            this.lblWinds.Name = "lblWinds";
            this.lblWinds.Size = new System.Drawing.Size(101, 13);
            this.lblWinds.TabIndex = 5;
            this.lblWinds.Text = "Nro. de Ventanales:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 323);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CalculadorSupremo);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbSuperficie);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSup);
            this.Name = "frmPrincipal";
            this.Text = "Menu Inmobiliaria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox tbSuperficie;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Button CalculadorSupremo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnPiso;
        private System.Windows.Forms.Label lblWinds;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox tbWinds;
        private System.Windows.Forms.TextBox tbPiso;
        private System.Windows.Forms.RadioButton btnLocal;
    }
}

