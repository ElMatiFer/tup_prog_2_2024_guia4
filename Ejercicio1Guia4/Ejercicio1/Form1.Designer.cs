namespace Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCoperativa = new System.Windows.Forms.TextBox();
            this.btIniciarCoperativa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCargaClientes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btVerConsumo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lPeriodo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCargarConsumo = new System.Windows.Forms.Button();
            this.tbConsumo = new System.Windows.Forms.TextBox();
            this.tbNumeroServicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSeleccionar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coperativa";
            // 
            // tbCoperativa
            // 
            this.tbCoperativa.Location = new System.Drawing.Point(83, 8);
            this.tbCoperativa.Name = "tbCoperativa";
            this.tbCoperativa.Size = new System.Drawing.Size(185, 20);
            this.tbCoperativa.TabIndex = 1;
            // 
            // btIniciarCoperativa
            // 
            this.btIniciarCoperativa.Location = new System.Drawing.Point(274, 6);
            this.btIniciarCoperativa.Name = "btIniciarCoperativa";
            this.btIniciarCoperativa.Size = new System.Drawing.Size(131, 23);
            this.btIniciarCoperativa.TabIndex = 2;
            this.btIniciarCoperativa.Text = "Iniciar Coperativa";
            this.btIniciarCoperativa.UseVisualStyleBackColor = true;
            this.btIniciarCoperativa.Click += new System.EventHandler(this.btIniciarCoperativa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCargaClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de Clientes";
            // 
            // btCargaClientes
            // 
            this.btCargaClientes.Location = new System.Drawing.Point(262, 19);
            this.btCargaClientes.Name = "btCargaClientes";
            this.btCargaClientes.Size = new System.Drawing.Size(131, 23);
            this.btCargaClientes.TabIndex = 3;
            this.btCargaClientes.Text = "Carga de clientes";
            this.btCargaClientes.UseVisualStyleBackColor = true;
            this.btCargaClientes.Click += new System.EventHandler(this.btCargaClientes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.tbNumeroServicio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btSeleccionar);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 224);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas de clientes";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btVerConsumo);
            this.groupBox4.Location = new System.Drawing.Point(9, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(391, 51);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Carga de consumos";
            // 
            // btVerConsumo
            // 
            this.btVerConsumo.Location = new System.Drawing.Point(253, 16);
            this.btVerConsumo.Name = "btVerConsumo";
            this.btVerConsumo.Size = new System.Drawing.Size(131, 23);
            this.btVerConsumo.TabIndex = 7;
            this.btVerConsumo.Text = "Ver Consumo";
            this.btVerConsumo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lPeriodo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btCargarConsumo);
            this.groupBox3.Controls.Add(this.tbConsumo);
            this.groupBox3.Location = new System.Drawing.Point(9, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 66);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carga de consumos";
            // 
            // lPeriodo
            // 
            this.lPeriodo.AutoSize = true;
            this.lPeriodo.Location = new System.Drawing.Point(92, 42);
            this.lPeriodo.Name = "lPeriodo";
            this.lPeriodo.Size = new System.Drawing.Size(0, 13);
            this.lPeriodo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Último periodo: ";
            // 
            // btCargarConsumo
            // 
            this.btCargarConsumo.Location = new System.Drawing.Point(253, 16);
            this.btCargarConsumo.Name = "btCargarConsumo";
            this.btCargarConsumo.Size = new System.Drawing.Size(131, 23);
            this.btCargarConsumo.TabIndex = 7;
            this.btCargarConsumo.Text = "Cargar Consumo";
            this.btCargarConsumo.UseVisualStyleBackColor = true;
            // 
            // tbConsumo
            // 
            this.tbConsumo.Location = new System.Drawing.Point(6, 19);
            this.tbConsumo.Name = "tbConsumo";
            this.tbConsumo.Size = new System.Drawing.Size(241, 20);
            this.tbConsumo.TabIndex = 6;
            // 
            // tbNumeroServicio
            // 
            this.tbNumeroServicio.Location = new System.Drawing.Point(127, 21);
            this.tbNumeroServicio.Name = "tbNumeroServicio";
            this.tbNumeroServicio.Size = new System.Drawing.Size(129, 20);
            this.tbNumeroServicio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de Servicio";
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.Location = new System.Drawing.Point(262, 19);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(131, 23);
            this.btSeleccionar.TabIndex = 3;
            this.btSeleccionar.Text = "Seleccionar";
            this.btSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(164, 325);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 5;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 359);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btIniciarCoperativa);
            this.Controls.Add(this.tbCoperativa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCoperativa;
        private System.Windows.Forms.Button btIniciarCoperativa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCargaClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSeleccionar;
        private System.Windows.Forms.TextBox tbNumeroServicio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbConsumo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btVerConsumo;
        private System.Windows.Forms.Label lPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCargarConsumo;
        private System.Windows.Forms.Button btCerrar;
    }
}

