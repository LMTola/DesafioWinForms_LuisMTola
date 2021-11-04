namespace DesafioIntegrador
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
            this.labelTituloForms = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPantalon = new System.Windows.Forms.RadioButton();
            this.rbCamisa = new System.Windows.Forms.RadioButton();
            this.chkBermuda = new System.Windows.Forms.CheckBox();
            this.chkMangaCorta = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtPremium = new System.Windows.Forms.RadioButton();
            this.rbtStandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTituloForms
            // 
            this.labelTituloForms.AutoSize = true;
            this.labelTituloForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloForms.ForeColor = System.Drawing.Color.Teal;
            this.labelTituloForms.Location = new System.Drawing.Point(20, 7);
            this.labelTituloForms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTituloForms.Name = "labelTituloForms";
            this.labelTituloForms.Size = new System.Drawing.Size(392, 26);
            this.labelTituloForms.TabIndex = 0;
            this.labelTituloForms.Text = "VENTAS AL POR MAYOR - Pradbit";
            this.labelTituloForms.Click += new System.EventHandler(this.labelTituloForms_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPantalon);
            this.groupBox1.Controls.Add(this.rbCamisa);
            this.groupBox1.Controls.Add(this.chkBermuda);
            this.groupBox1.Controls.Add(this.chkMangaCorta);
            this.groupBox1.Location = new System.Drawing.Point(41, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(318, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de prenda";
            // 
            // rbPantalon
            // 
            this.rbPantalon.AutoSize = true;
            this.rbPantalon.Location = new System.Drawing.Point(62, 50);
            this.rbPantalon.Margin = new System.Windows.Forms.Padding(2);
            this.rbPantalon.Name = "rbPantalon";
            this.rbPantalon.Size = new System.Drawing.Size(67, 17);
            this.rbPantalon.TabIndex = 3;
            this.rbPantalon.TabStop = true;
            this.rbPantalon.Text = "Pantalon";
            this.rbPantalon.UseVisualStyleBackColor = true;
            this.rbPantalon.CheckedChanged += new System.EventHandler(this.rbPantalon_CheckedChanged);
            // 
            // rbCamisa
            // 
            this.rbCamisa.AutoSize = true;
            this.rbCamisa.Location = new System.Drawing.Point(62, 18);
            this.rbCamisa.Margin = new System.Windows.Forms.Padding(2);
            this.rbCamisa.Name = "rbCamisa";
            this.rbCamisa.Size = new System.Drawing.Size(59, 17);
            this.rbCamisa.TabIndex = 2;
            this.rbCamisa.TabStop = true;
            this.rbCamisa.Text = "Camisa";
            this.rbCamisa.UseVisualStyleBackColor = true;
            this.rbCamisa.CheckedChanged += new System.EventHandler(this.rbCamisa_CheckedChanged);
            // 
            // chkBermuda
            // 
            this.chkBermuda.AutoSize = true;
            this.chkBermuda.Location = new System.Drawing.Point(158, 51);
            this.chkBermuda.Margin = new System.Windows.Forms.Padding(2);
            this.chkBermuda.Name = "chkBermuda";
            this.chkBermuda.Size = new System.Drawing.Size(68, 17);
            this.chkBermuda.TabIndex = 1;
            this.chkBermuda.Text = "Bermuda";
            this.chkBermuda.UseVisualStyleBackColor = true;
            this.chkBermuda.CheckedChanged += new System.EventHandler(this.chkBermuda_CheckedChanged);
            // 
            // chkMangaCorta
            // 
            this.chkMangaCorta.AutoSize = true;
            this.chkMangaCorta.Location = new System.Drawing.Point(158, 18);
            this.chkMangaCorta.Margin = new System.Windows.Forms.Padding(2);
            this.chkMangaCorta.Name = "chkMangaCorta";
            this.chkMangaCorta.Size = new System.Drawing.Size(86, 17);
            this.chkMangaCorta.TabIndex = 0;
            this.chkMangaCorta.Text = "Manga corta";
            this.chkMangaCorta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtPremium);
            this.groupBox2.Controls.Add(this.rbtStandard);
            this.groupBox2.Location = new System.Drawing.Point(99, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(187, 81);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad";
            // 
            // rbtPremium
            // 
            this.rbtPremium.AutoSize = true;
            this.rbtPremium.Location = new System.Drawing.Point(100, 28);
            this.rbtPremium.Margin = new System.Windows.Forms.Padding(2);
            this.rbtPremium.Name = "rbtPremium";
            this.rbtPremium.Size = new System.Drawing.Size(65, 17);
            this.rbtPremium.TabIndex = 1;
            this.rbtPremium.TabStop = true;
            this.rbtPremium.Text = "Premium";
            this.rbtPremium.UseVisualStyleBackColor = true;
            // 
            // rbtStandard
            // 
            this.rbtStandard.AutoSize = true;
            this.rbtStandard.Location = new System.Drawing.Point(4, 28);
            this.rbtStandard.Margin = new System.Windows.Forms.Padding(2);
            this.rbtStandard.Name = "rbtStandard";
            this.rbtStandard.Size = new System.Drawing.Size(68, 17);
            this.rbtStandard.TabIndex = 0;
            this.rbtStandard.TabStop = true;
            this.rbtStandard.Text = "Standard";
            this.rbtStandard.UseVisualStyleBackColor = true;
            this.rbtStandard.CheckedChanged += new System.EventHandler(this.rbtStandard_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Location = new System.Drawing.Point(41, 258);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(97, 46);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(14, 17);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(76, 20);
            this.txtPrecio.TabIndex = 0;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCantidad);
            this.groupBox4.Location = new System.Drawing.Point(265, 258);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(94, 46);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(12, 17);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 20);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightGreen;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCalcular.Location = new System.Drawing.Point(87, 357);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(221, 50);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular precio final";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(416, 442);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTituloForms);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloForms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPantalon;
        private System.Windows.Forms.RadioButton rbCamisa;
        private System.Windows.Forms.CheckBox chkBermuda;
        private System.Windows.Forms.CheckBox chkMangaCorta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtPremium;
        private System.Windows.Forms.RadioButton rbtStandard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}


