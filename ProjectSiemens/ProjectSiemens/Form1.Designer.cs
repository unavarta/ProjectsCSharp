namespace ProjectSiemens
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
            this.rb_Telesivor = new System.Windows.Forms.RadioButton();
            this.rb_Lavadora = new System.Windows.Forms.RadioButton();
            this.rb_Electrodomestico = new System.Windows.Forms.RadioButton();
            this.gb_electrodomestico = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Consumo = new System.Windows.Forms.TextBox();
            this.tb_Peso = new System.Windows.Forms.TextBox();
            this.tb_Color = new System.Windows.Forms.TextBox();
            this.tb_Precio = new System.Windows.Forms.TextBox();
            this.lb_Consumo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Color = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_SintoNo = new System.Windows.Forms.RadioButton();
            this.rb_SintoSi = new System.Windows.Forms.RadioButton();
            this.lb_Sintonizador = new System.Windows.Forms.Label();
            this.tb_Resolu = new System.Windows.Forms.TextBox();
            this.lb_Resolu = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_Carga = new System.Windows.Forms.TextBox();
            this.lb_carga = new System.Windows.Forms.Label();
            this.but_CalculadorSupremo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_ListaArticulos = new System.Windows.Forms.Label();
            this.lb_Precio = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.gb_electrodomestico.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_Telesivor
            // 
            this.rb_Telesivor.AutoSize = true;
            this.rb_Telesivor.Location = new System.Drawing.Point(11, 32);
            this.rb_Telesivor.Name = "rb_Telesivor";
            this.rb_Telesivor.Size = new System.Drawing.Size(68, 17);
            this.rb_Telesivor.TabIndex = 0;
            this.rb_Telesivor.TabStop = true;
            this.rb_Telesivor.Text = "Televisor";
            this.rb_Telesivor.UseVisualStyleBackColor = true;
            this.rb_Telesivor.CheckedChanged += new System.EventHandler(this.rb_Telesivor_CheckedChanged);
            // 
            // rb_Lavadora
            // 
            this.rb_Lavadora.AutoSize = true;
            this.rb_Lavadora.Location = new System.Drawing.Point(119, 32);
            this.rb_Lavadora.Name = "rb_Lavadora";
            this.rb_Lavadora.Size = new System.Drawing.Size(70, 17);
            this.rb_Lavadora.TabIndex = 1;
            this.rb_Lavadora.TabStop = true;
            this.rb_Lavadora.Text = "Lavadora";
            this.rb_Lavadora.UseVisualStyleBackColor = true;
            this.rb_Lavadora.CheckedChanged += new System.EventHandler(this.rb_Lavadora_CheckedChanged);
            // 
            // rb_Electrodomestico
            // 
            this.rb_Electrodomestico.AutoSize = true;
            this.rb_Electrodomestico.Location = new System.Drawing.Point(217, 32);
            this.rb_Electrodomestico.Name = "rb_Electrodomestico";
            this.rb_Electrodomestico.Size = new System.Drawing.Size(106, 17);
            this.rb_Electrodomestico.TabIndex = 2;
            this.rb_Electrodomestico.TabStop = true;
            this.rb_Electrodomestico.Text = "Electrodomestico";
            this.rb_Electrodomestico.UseVisualStyleBackColor = true;
            this.rb_Electrodomestico.CheckedChanged += new System.EventHandler(this.rb_Electrodomestico_CheckedChanged);
            // 
            // gb_electrodomestico
            // 
            this.gb_electrodomestico.Controls.Add(this.rb_Telesivor);
            this.gb_electrodomestico.Controls.Add(this.rb_Electrodomestico);
            this.gb_electrodomestico.Controls.Add(this.rb_Lavadora);
            this.gb_electrodomestico.Location = new System.Drawing.Point(12, 12);
            this.gb_electrodomestico.Name = "gb_electrodomestico";
            this.gb_electrodomestico.Size = new System.Drawing.Size(329, 61);
            this.gb_electrodomestico.TabIndex = 3;
            this.gb_electrodomestico.TabStop = false;
            this.gb_electrodomestico.Text = "¿Qué tipo de Electrodomestico llevará?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Consumo);
            this.groupBox1.Controls.Add(this.tb_Peso);
            this.groupBox1.Controls.Add(this.tb_Color);
            this.groupBox1.Controls.Add(this.tb_Precio);
            this.groupBox1.Controls.Add(this.lb_Consumo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_Color);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especificaciones Generales";
            // 
            // tb_Consumo
            // 
            this.tb_Consumo.Location = new System.Drawing.Point(274, 52);
            this.tb_Consumo.Name = "tb_Consumo";
            this.tb_Consumo.Size = new System.Drawing.Size(34, 20);
            this.tb_Consumo.TabIndex = 7;
            // 
            // tb_Peso
            // 
            this.tb_Peso.Location = new System.Drawing.Point(251, 26);
            this.tb_Peso.Name = "tb_Peso";
            this.tb_Peso.Size = new System.Drawing.Size(57, 20);
            this.tb_Peso.TabIndex = 6;
            // 
            // tb_Color
            // 
            this.tb_Color.Location = new System.Drawing.Point(43, 52);
            this.tb_Color.Name = "tb_Color";
            this.tb_Color.Size = new System.Drawing.Size(116, 20);
            this.tb_Color.TabIndex = 5;
            // 
            // tb_Precio
            // 
            this.tb_Precio.Location = new System.Drawing.Point(85, 26);
            this.tb_Precio.Name = "tb_Precio";
            this.tb_Precio.Size = new System.Drawing.Size(74, 20);
            this.tb_Precio.TabIndex = 4;
            // 
            // lb_Consumo
            // 
            this.lb_Consumo.AutoSize = true;
            this.lb_Consumo.Location = new System.Drawing.Point(189, 55);
            this.lb_Consumo.Name = "lb_Consumo";
            this.lb_Consumo.Size = new System.Drawing.Size(79, 13);
            this.lb_Consumo.TabIndex = 3;
            this.lb_Consumo.Text = "Consumo: (A-F)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso: (Kg)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_Color
            // 
            this.lb_Color.AutoSize = true;
            this.lb_Color.Location = new System.Drawing.Point(3, 57);
            this.lb_Color.Name = "lb_Color";
            this.lb_Color.Size = new System.Drawing.Size(34, 13);
            this.lb_Color.TabIndex = 1;
            this.lb_Color.Text = "Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio Base: $";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_SintoNo);
            this.groupBox2.Controls.Add(this.rb_SintoSi);
            this.groupBox2.Controls.Add(this.lb_Sintonizador);
            this.groupBox2.Controls.Add(this.tb_Resolu);
            this.groupBox2.Controls.Add(this.lb_Resolu);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Especificaciones Televisor";
            // 
            // rb_SintoNo
            // 
            this.rb_SintoNo.AutoSize = true;
            this.rb_SintoNo.Location = new System.Drawing.Point(178, 47);
            this.rb_SintoNo.Name = "rb_SintoNo";
            this.rb_SintoNo.Size = new System.Drawing.Size(84, 17);
            this.rb_SintoNo.TabIndex = 12;
            this.rb_SintoNo.TabStop = true;
            this.rb_SintoNo.Text = "No Contiene";
            this.rb_SintoNo.UseVisualStyleBackColor = true;
            // 
            // rb_SintoSi
            // 
            this.rb_SintoSi.AutoSize = true;
            this.rb_SintoSi.Location = new System.Drawing.Point(105, 47);
            this.rb_SintoSi.Name = "rb_SintoSi";
            this.rb_SintoSi.Size = new System.Drawing.Size(67, 17);
            this.rb_SintoSi.TabIndex = 11;
            this.rb_SintoSi.TabStop = true;
            this.rb_SintoSi.Text = "Contiene";
            this.rb_SintoSi.UseVisualStyleBackColor = true;
            // 
            // lb_Sintonizador
            // 
            this.lb_Sintonizador.AutoSize = true;
            this.lb_Sintonizador.Location = new System.Drawing.Point(6, 49);
            this.lb_Sintonizador.Name = "lb_Sintonizador";
            this.lb_Sintonizador.Size = new System.Drawing.Size(93, 13);
            this.lb_Sintonizador.TabIndex = 10;
            this.lb_Sintonizador.Text = "Sintonizador TDT:";
            // 
            // tb_Resolu
            // 
            this.tb_Resolu.Location = new System.Drawing.Point(75, 23);
            this.tb_Resolu.Name = "tb_Resolu";
            this.tb_Resolu.Size = new System.Drawing.Size(84, 20);
            this.tb_Resolu.TabIndex = 9;
            this.tb_Resolu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_Resolu
            // 
            this.lb_Resolu.AutoSize = true;
            this.lb_Resolu.Location = new System.Drawing.Point(6, 26);
            this.lb_Resolu.Name = "lb_Resolu";
            this.lb_Resolu.Size = new System.Drawing.Size(71, 13);
            this.lb_Resolu.TabIndex = 9;
            this.lb_Resolu.Text = "Resolución: \"";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_Carga);
            this.groupBox3.Controls.Add(this.lb_carga);
            this.groupBox3.Location = new System.Drawing.Point(12, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 55);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Especificaciones Lavadora";
            // 
            // tb_Carga
            // 
            this.tb_Carga.Location = new System.Drawing.Point(53, 24);
            this.tb_Carga.Name = "tb_Carga";
            this.tb_Carga.Size = new System.Drawing.Size(106, 20);
            this.tb_Carga.TabIndex = 8;
            this.tb_Carga.TextChanged += new System.EventHandler(this.tb_Carga_TextChanged);
            // 
            // lb_carga
            // 
            this.lb_carga.AutoSize = true;
            this.lb_carga.Location = new System.Drawing.Point(6, 27);
            this.lb_carga.Name = "lb_carga";
            this.lb_carga.Size = new System.Drawing.Size(41, 13);
            this.lb_carga.TabIndex = 8;
            this.lb_carga.Text = "Carga: ";
            // 
            // but_CalculadorSupremo
            // 
            this.but_CalculadorSupremo.Location = new System.Drawing.Point(12, 325);
            this.but_CalculadorSupremo.Name = "but_CalculadorSupremo";
            this.but_CalculadorSupremo.Size = new System.Drawing.Size(159, 46);
            this.but_CalculadorSupremo.TabIndex = 7;
            this.but_CalculadorSupremo.Text = "Agregar Artículo";
            this.but_CalculadorSupremo.UseVisualStyleBackColor = true;
            this.but_CalculadorSupremo.Click += new System.EventHandler(this.but_CalculadorSupremo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mostrar Carrito";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_ListaArticulos
            // 
            this.lb_ListaArticulos.AutoSize = true;
            this.lb_ListaArticulos.Location = new System.Drawing.Point(365, 23);
            this.lb_ListaArticulos.Name = "lb_ListaArticulos";
            this.lb_ListaArticulos.Size = new System.Drawing.Size(0, 13);
            this.lb_ListaArticulos.TabIndex = 9;
            // 
            // lb_Precio
            // 
            this.lb_Precio.AutoSize = true;
            this.lb_Precio.Location = new System.Drawing.Point(365, 155);
            this.lb_Precio.Name = "lb_Precio";
            this.lb_Precio.Size = new System.Drawing.Size(0, 13);
            this.lb_Precio.TabIndex = 10;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(12, 377);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 13);
            this.lbl_status.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 399);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lb_Precio);
            this.Controls.Add(this.lb_ListaArticulos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_CalculadorSupremo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_electrodomestico);
            this.Name = "Form1";
            this.Text = "Vendedor digital Electrodomesticos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_electrodomestico.ResumeLayout(false);
            this.gb_electrodomestico.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Telesivor;
        private System.Windows.Forms.RadioButton rb_Lavadora;
        private System.Windows.Forms.RadioButton rb_Electrodomestico;
        private System.Windows.Forms.GroupBox gb_electrodomestico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Consumo;
        private System.Windows.Forms.TextBox tb_Peso;
        private System.Windows.Forms.TextBox tb_Color;
        private System.Windows.Forms.TextBox tb_Precio;
        private System.Windows.Forms.Label lb_Consumo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_Resolu;
        private System.Windows.Forms.Label lb_Resolu;
        private System.Windows.Forms.TextBox tb_Carga;
        private System.Windows.Forms.Label lb_carga;
        private System.Windows.Forms.RadioButton rb_SintoNo;
        private System.Windows.Forms.RadioButton rb_SintoSi;
        private System.Windows.Forms.Label lb_Sintonizador;
        private System.Windows.Forms.Button but_CalculadorSupremo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_ListaArticulos;
        private System.Windows.Forms.Label lb_Precio;
        private System.Windows.Forms.Label lbl_status;
    }
}

