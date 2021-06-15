
namespace Forms
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel_fondo = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_deposito = new System.Windows.Forms.RichTextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.listBox_almacenCentral = new System.Windows.Forms.ListBox();
            this.btn_empaquetar = new System.Windows.Forms.Button();
            this.button_fabricar = new System.Windows.Forms.Button();
            this.pictureBox_rgbGradient = new System.Windows.Forms.PictureBox();
            this.panel_BorderTop = new System.Windows.Forms.Panel();
            this.label_BorderTop_titulo = new System.Windows.Forms.Label();
            this.panel_salir = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.btn_ImprimirDeposito = new System.Windows.Forms.Button();
            this.panel_fondo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rgbGradient)).BeginInit();
            this.panel_BorderTop.SuspendLayout();
            this.panel_salir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_fondo
            // 
            this.panel_fondo.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel_fondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_fondo.Controls.Add(this.groupBox2);
            this.panel_fondo.Controls.Add(this.groupBox1);
            this.panel_fondo.Controls.Add(this.pictureBox_rgbGradient);
            this.panel_fondo.Controls.Add(this.panel_BorderTop);
            this.panel_fondo.Location = new System.Drawing.Point(0, 0);
            this.panel_fondo.Name = "panel_fondo";
            this.panel_fondo.Size = new System.Drawing.Size(1500, 600);
            this.panel_fondo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ImprimirDeposito);
            this.groupBox2.Controls.Add(this.richTextBox_deposito);
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(987, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 500);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Depósito";
            // 
            // richTextBox_deposito
            // 
            this.richTextBox_deposito.Font = new System.Drawing.Font("Roboto Lt", 13F);
            this.richTextBox_deposito.Location = new System.Drawing.Point(6, 32);
            this.richTextBox_deposito.Name = "richTextBox_deposito";
            this.richTextBox_deposito.ReadOnly = true;
            this.richTextBox_deposito.Size = new System.Drawing.Size(349, 453);
            this.richTextBox_deposito.TabIndex = 6;
            this.richTextBox_deposito.Text = "";
            this.richTextBox_deposito.TextChanged += new System.EventHandler(this.richTextBox_deposito_TextChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargar.Image = global::Forms.Properties.Resources.rgb_gif;
            this.btnCargar.Location = new System.Drawing.Point(363, 91);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(129, 50);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Image = global::Forms.Properties.Resources.rgb_gif;
            this.btnGuardar.Location = new System.Drawing.Point(363, 34);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 48);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.listBox_almacenCentral);
            this.groupBox1.Controls.Add(this.btn_empaquetar);
            this.groupBox1.Controls.Add(this.button_fabricar);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(13, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(918, 500);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Central";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_eliminar.Image = global::Forms.Properties.Resources.rgb_gif;
            this.btn_eliminar.Location = new System.Drawing.Point(177, 34);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(91, 50);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // listBox_almacenCentral
            // 
            this.listBox_almacenCentral.Font = new System.Drawing.Font("Roboto Lt", 10F);
            this.listBox_almacenCentral.FormattingEnabled = true;
            this.listBox_almacenCentral.ItemHeight = 15;
            this.listBox_almacenCentral.Location = new System.Drawing.Point(8, 93);
            this.listBox_almacenCentral.Name = "listBox_almacenCentral";
            this.listBox_almacenCentral.Size = new System.Drawing.Size(902, 394);
            this.listBox_almacenCentral.TabIndex = 7;
            // 
            // btn_empaquetar
            // 
            this.btn_empaquetar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_empaquetar.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.btn_empaquetar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_empaquetar.Image = global::Forms.Properties.Resources.rgb_gif;
            this.btn_empaquetar.Location = new System.Drawing.Point(783, 34);
            this.btn_empaquetar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_empaquetar.Name = "btn_empaquetar";
            this.btn_empaquetar.Size = new System.Drawing.Size(125, 50);
            this.btn_empaquetar.TabIndex = 6;
            this.btn_empaquetar.Text = "Empaquetar";
            this.btn_empaquetar.UseVisualStyleBackColor = true;
            this.btn_empaquetar.Click += new System.EventHandler(this.btn_empaquetar_Click);
            // 
            // button_fabricar
            // 
            this.button_fabricar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_fabricar.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.button_fabricar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_fabricar.Image = global::Forms.Properties.Resources.rgb_gif;
            this.button_fabricar.Location = new System.Drawing.Point(8, 34);
            this.button_fabricar.Margin = new System.Windows.Forms.Padding(5);
            this.button_fabricar.Name = "button_fabricar";
            this.button_fabricar.Size = new System.Drawing.Size(159, 50);
            this.button_fabricar.TabIndex = 2;
            this.button_fabricar.Text = "Nuevo Producto";
            this.button_fabricar.UseVisualStyleBackColor = true;
            this.button_fabricar.Click += new System.EventHandler(this.btn_fabricar_Click);
            // 
            // pictureBox_rgbGradient
            // 
            this.pictureBox_rgbGradient.Image = global::Forms.Properties.Resources.rgb_gif;
            this.pictureBox_rgbGradient.Location = new System.Drawing.Point(0, 50);
            this.pictureBox_rgbGradient.Name = "pictureBox_rgbGradient";
            this.pictureBox_rgbGradient.Size = new System.Drawing.Size(1501, 5);
            this.pictureBox_rgbGradient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_rgbGradient.TabIndex = 1;
            this.pictureBox_rgbGradient.TabStop = false;
            // 
            // panel_BorderTop
            // 
            this.panel_BorderTop.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel_BorderTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_BorderTop.Controls.Add(this.label_BorderTop_titulo);
            this.panel_BorderTop.Controls.Add(this.panel_salir);
            this.panel_BorderTop.Controls.Add(this.pictureBox_logo);
            this.panel_BorderTop.Location = new System.Drawing.Point(0, 0);
            this.panel_BorderTop.Name = "panel_BorderTop";
            this.panel_BorderTop.Size = new System.Drawing.Size(1498, 50);
            this.panel_BorderTop.TabIndex = 0;
            // 
            // label_BorderTop_titulo
            // 
            this.label_BorderTop_titulo.AutoSize = true;
            this.label_BorderTop_titulo.BackColor = System.Drawing.SystemColors.Desktop;
            this.label_BorderTop_titulo.Font = new System.Drawing.Font("Roboto Lt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BorderTop_titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.label_BorderTop_titulo.Location = new System.Drawing.Point(62, 5);
            this.label_BorderTop_titulo.Name = "label_BorderTop_titulo";
            this.label_BorderTop_titulo.Size = new System.Drawing.Size(286, 38);
            this.label_BorderTop_titulo.TabIndex = 1;
            this.label_BorderTop_titulo.Text = "Fábrica Periféricos";
            // 
            // panel_salir
            // 
            this.panel_salir.BackColor = System.Drawing.Color.Red;
            this.panel_salir.Controls.Add(this.btn_salir);
            this.panel_salir.Location = new System.Drawing.Point(1431, 10);
            this.panel_salir.Name = "panel_salir";
            this.panel_salir.Size = new System.Drawing.Size(55, 29);
            this.panel_salir.TabIndex = 1;
            // 
            // btn_salir
            // 
            this.btn_salir.AutoSize = true;
            this.btn_salir.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_salir.Font = new System.Drawing.Font("Roboto Bk", 14F);
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salir.Location = new System.Drawing.Point(3, 3);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 23);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Forms.Properties.Resources.icono2;
            this.pictureBox_logo.Location = new System.Drawing.Point(5, 5);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // btn_ImprimirDeposito
            // 
            this.btn_ImprimirDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ImprimirDeposito.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.btn_ImprimirDeposito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ImprimirDeposito.Image = global::Forms.Properties.Resources.rgb_gif;
            this.btn_ImprimirDeposito.Location = new System.Drawing.Point(363, 201);
            this.btn_ImprimirDeposito.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ImprimirDeposito.Name = "btn_ImprimirDeposito";
            this.btn_ImprimirDeposito.Size = new System.Drawing.Size(129, 50);
            this.btn_ImprimirDeposito.TabIndex = 7;
            this.btn_ImprimirDeposito.Text = "Imprimir";
            this.btn_ImprimirDeposito.UseVisualStyleBackColor = true;
            this.btn_ImprimirDeposito.Click += new System.EventHandler(this.btn_ImprimirDeposito_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 600);
            this.Controls.Add(this.panel_fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.panel_fondo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rgbGradient)).EndInit();
            this.panel_BorderTop.ResumeLayout(false);
            this.panel_BorderTop.PerformLayout();
            this.panel_salir.ResumeLayout(false);
            this.panel_salir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_fondo;
        private System.Windows.Forms.PictureBox pictureBox_rgbGradient;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_BorderTop;
        private System.Windows.Forms.Panel panel_salir;
        private System.Windows.Forms.Label btn_salir;
        private System.Windows.Forms.Label label_BorderTop_titulo;
        private System.Windows.Forms.Button button_fabricar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_empaquetar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.ListBox listBox_almacenCentral;
        private System.Windows.Forms.RichTextBox richTextBox_deposito;
        private System.Windows.Forms.Button btn_ImprimirDeposito;
    }
}

