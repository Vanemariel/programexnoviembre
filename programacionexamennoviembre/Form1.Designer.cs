
namespace programacionexamennoviembre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bpresione = new System.Windows.Forms.Button();
            this.Bcargar = new System.Windows.Forms.Button();
            this.Blista = new System.Windows.Forms.Button();
            this.Bborrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.LBLresultado = new System.Windows.Forms.Label();
            this.lbllista = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bpresione
            // 
            this.Bpresione.Location = new System.Drawing.Point(1070, 165);
            this.Bpresione.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bpresione.Name = "Bpresione";
            this.Bpresione.Size = new System.Drawing.Size(124, 35);
            this.Bpresione.TabIndex = 0;
            this.Bpresione.Text = "PRESIONE";
            this.Bpresione.UseVisualStyleBackColor = true;
            this.Bpresione.Click += new System.EventHandler(this.Bpresione_Click);
            // 
            // Bcargar
            // 
            this.Bcargar.Location = new System.Drawing.Point(934, 265);
            this.Bcargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bcargar.Name = "Bcargar";
            this.Bcargar.Size = new System.Drawing.Size(124, 35);
            this.Bcargar.TabIndex = 1;
            this.Bcargar.Text = "CARGAR";
            this.Bcargar.UseVisualStyleBackColor = true;
            this.Bcargar.Click += new System.EventHandler(this.Bcargar_Click);
            // 
            // Blista
            // 
            this.Blista.Location = new System.Drawing.Point(1156, 265);
            this.Blista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Blista.Name = "Blista";
            this.Blista.Size = new System.Drawing.Size(124, 35);
            this.Blista.TabIndex = 2;
            this.Blista.Text = "LISTA";
            this.Blista.UseVisualStyleBackColor = true;
            this.Blista.Click += new System.EventHandler(this.Blista_Click);
            // 
            // Bborrar
            // 
            this.Bborrar.Location = new System.Drawing.Point(1035, 368);
            this.Bborrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bborrar.Name = "Bborrar";
            this.Bborrar.Size = new System.Drawing.Size(124, 35);
            this.Bborrar.TabIndex = 3;
            this.Bborrar.Text = "BORRAR";
            this.Bborrar.UseVisualStyleBackColor = true;
            this.Bborrar.Click += new System.EventHandler(this.Bborrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "CAPACITACION DE ***MAGIC IN THE WORD***";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(58, 115);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(85, 20);
            this.lblnombre.TabIndex = 5;
            this.lblnombre.Text = "NOMBRE";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.Location = new System.Drawing.Point(311, 115);
            this.lblapellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(96, 20);
            this.lblapellido.TabIndex = 6;
            this.lblapellido.Text = "APELLIDO";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(516, 115);
            this.lbledad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(59, 20);
            this.lbledad.TabIndex = 7;
            this.lbledad.Text = "EDAD";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreo.Location = new System.Drawing.Point(757, 115);
            this.lblcorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(51, 20);
            this.lblcorreo.TabIndex = 8;
            this.lblcorreo.Text = "MAIL";
            // 
            // LBLresultado
            // 
            this.LBLresultado.AutoSize = true;
            this.LBLresultado.Location = new System.Drawing.Point(311, 265);
            this.LBLresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLresultado.Name = "LBLresultado";
            this.LBLresultado.Size = new System.Drawing.Size(0, 20);
            this.LBLresultado.TabIndex = 9;
            // 
            // lbllista
            // 
            this.lbllista.AutoSize = true;
            this.lbllista.Location = new System.Drawing.Point(58, 357);
            this.lbllista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllista.Name = "lbllista";
            this.lbllista.Size = new System.Drawing.Size(59, 20);
            this.lbllista.TabIndex = 10;
            this.lbllista.Text = "LISTA";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(62, 174);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(164, 26);
            this.txtnombre.TabIndex = 11;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(290, 174);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(164, 26);
            this.txtapellido.TabIndex = 12;
            this.txtapellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(500, 174);
            this.txtedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(164, 26);
            this.txtedad.TabIndex = 13;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(729, 174);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(164, 26);
            this.txtcorreo.TabIndex = 14;
            this.txtcorreo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbllista);
            this.Controls.Add(this.LBLresultado);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bborrar);
            this.Controls.Add(this.Blista);
            this.Controls.Add(this.Bcargar);
            this.Controls.Add(this.Bpresione);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bpresione;
        private System.Windows.Forms.Button Bcargar;
        private System.Windows.Forms.Button Blista;
        private System.Windows.Forms.Button Bborrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label LBLresultado;
        private System.Windows.Forms.Label lbllista;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtcorreo;
    }
}

