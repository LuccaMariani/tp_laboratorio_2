
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_abrirDeposito = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.listBox_almacenCentral = new System.Windows.Forms.ListBox();
            this.btn_empaquetar = new System.Windows.Forms.Button();
            this.button_fabricar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pictureBox_rgbGradient = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel_BorderTop = new System.Windows.Forms.Panel();
            this.panel_mover = new System.Windows.Forms.Panel();
            this.label_mover = new System.Windows.Forms.Label();
            this.pictureBox_mover = new System.Windows.Forms.PictureBox();
            this.label_BorderTop_titulo = new System.Windows.Forms.Label();
            this.panel_salir = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_fondo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rgbGradient)).BeginInit();
            this.panel_BorderTop.SuspendLayout();
            this.panel_mover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mover)).BeginInit();
            this.panel_salir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_fondo
            // 
            this.panel_fondo.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel_fondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_fondo.Controls.Add(this.button1);
            this.panel_fondo.Controls.Add(this.groupBox1);
            this.panel_fondo.Controls.Add(this.btnCargar);
            this.panel_fondo.Controls.Add(this.pictureBox_rgbGradient);
            this.panel_fondo.Controls.Add(this.btnGuardar);
            this.panel_fondo.Controls.Add(this.panel_BorderTop);
            this.panel_fondo.Location = new System.Drawing.Point(0, 0);
            this.panel_fondo.Name = "panel_fondo";
            this.panel_fondo.Size = new System.Drawing.Size(1101, 500);
            this.panel_fondo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::Forms.Properties.Resources.rgb_gif;
            this.button1.Location = new System.Drawing.Point(359, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Imprimir Central";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ImprimirCentral);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_abrirDeposito);
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
            this.groupBox1.Size = new System.Drawing.Size(1069, 342);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Central";
            // 
            // button_abrirDeposito
            // 
            this.button_abrirDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_abrirDeposito.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.button_abrirDeposito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_abrirDeposito.Image = global::Forms.Properties.Resources.rgb_gif;
            this.button_abrirDeposito.Location = new System.Drawing.Point(909, 34);
            this.button_abrirDeposito.Margin = new System.Windows.Forms.Padding(5);
            this.button_abrirDeposito.Name = "button_abrirDeposito";
            this.button_abrirDeposito.Size = new System.Drawing.Size(150, 50);
            this.button_abrirDeposito.TabIndex = 9;
            this.button_abrirDeposito.Text = "Abrir Deposito";
            this.button_abrirDeposito.UseVisualStyleBackColor = true;
            this.button_abrirDeposito.Click += new System.EventHandler(this.button_abrirDeposito_Click);
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
            this.listBox_almacenCentral.Font = new System.Drawing.Font("Roboto Lt", 11F);
            this.listBox_almacenCentral.FormattingEnabled = true;
            this.listBox_almacenCentral.ItemHeight = 18;
            this.listBox_almacenCentral.Location = new System.Drawing.Point(8, 94);
            this.listBox_almacenCentral.Name = "listBox_almacenCentral";
            this.listBox_almacenCentral.Size = new System.Drawing.Size(1051, 238);
            this.listBox_almacenCentral.TabIndex = 7;
            // 
            // btn_empaquetar
            // 
            this.btn_empaquetar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_empaquetar.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.btn_empaquetar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_empaquetar.Image = global::Forms.Properties.Resources.rgb_gif;
            this.btn_empaquetar.Location = new System.Drawing.Point(506, 34);
            this.btn_empaquetar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_empaquetar.Name = "btn_empaquetar";
            this.btn_empaquetar.Size = new System.Drawing.Size(393, 50);
            this.btn_empaquetar.TabIndex = 6;
            this.btn_empaquetar.Text = "Agregar producto seleccionado al Deposito";
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
            // btnCargar
            // 
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargar.Image = global::Forms.Properties.Resources.rgb_gif;
            this.btnCargar.Location = new System.Drawing.Point(190, 435);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(159, 50);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Cargar Central";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
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
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Image = global::Forms.Properties.Resources.rgb_gif;
            this.btnGuardar.Location = new System.Drawing.Point(13, 437);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(167, 48);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Central";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel_BorderTop
            // 
            this.panel_BorderTop.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel_BorderTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_BorderTop.Controls.Add(this.panel_mover);
            this.panel_BorderTop.Controls.Add(this.label_BorderTop_titulo);
            this.panel_BorderTop.Controls.Add(this.panel_salir);
            this.panel_BorderTop.Controls.Add(this.pictureBox_logo);
            this.panel_BorderTop.Location = new System.Drawing.Point(0, 0);
            this.panel_BorderTop.Name = "panel_BorderTop";
            this.panel_BorderTop.Size = new System.Drawing.Size(1099, 50);
            this.panel_BorderTop.TabIndex = 0;
            // 
            // panel_mover
            // 
            this.panel_mover.BackColor = System.Drawing.Color.Red;
            this.panel_mover.Controls.Add(this.label_mover);
            this.panel_mover.Controls.Add(this.pictureBox_mover);
            this.panel_mover.Location = new System.Drawing.Point(803, 10);
            this.panel_mover.Name = "panel_mover";
            this.panel_mover.Size = new System.Drawing.Size(108, 29);
            this.panel_mover.TabIndex = 2;
            // 
            // label_mover
            // 
            this.label_mover.AutoSize = true;
            this.label_mover.BackColor = System.Drawing.SystemColors.Desktop;
            this.label_mover.Font = new System.Drawing.Font("Roboto Bk", 14F);
            this.label_mover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_mover.Location = new System.Drawing.Point(3, 3);
            this.label_mover.Name = "label_mover";
            this.label_mover.Size = new System.Drawing.Size(65, 23);
            this.label_mover.TabIndex = 1;
            this.label_mover.Text = "Mover";
            // 
            // pictureBox_mover
            // 
            this.pictureBox_mover.Image = global::Forms.Properties.Resources.mover;
            this.pictureBox_mover.Location = new System.Drawing.Point(74, 0);
            this.pictureBox_mover.Name = "pictureBox_mover";
            this.pictureBox_mover.Size = new System.Drawing.Size(29, 29);
            this.pictureBox_mover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_mover.TabIndex = 3;
            this.pictureBox_mover.TabStop = false;
            this.pictureBox_mover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_mover_MouseDown);
            this.pictureBox_mover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_mover_MouseMove);
            this.pictureBox_mover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_mover_MouseUp);
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
            this.panel_salir.Location = new System.Drawing.Point(1026, 10);
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
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 500);
            this.Controls.Add(this.panel_fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.panel_fondo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rgbGradient)).EndInit();
            this.panel_BorderTop.ResumeLayout(false);
            this.panel_BorderTop.PerformLayout();
            this.panel_mover.ResumeLayout(false);
            this.panel_mover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mover)).EndInit();
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
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.ListBox listBox_almacenCentral;
        private System.Windows.Forms.Panel panel_mover;
        private System.Windows.Forms.Label label_mover;
        private System.Windows.Forms.PictureBox pictureBox_mover;
        private System.Windows.Forms.Button button_abrirDeposito;
        private System.Windows.Forms.Button button1;
    }
}

