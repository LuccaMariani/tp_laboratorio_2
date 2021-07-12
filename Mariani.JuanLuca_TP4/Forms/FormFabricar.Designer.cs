
namespace Forms
{
    partial class FormFabricar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFabricar));
            this.panel_fondo = new System.Windows.Forms.Panel();
            this.groupBox_general = new System.Windows.Forms.GroupBox();
            this.comboBox_tecladoTipo = new System.Windows.Forms.ComboBox();
            this.label_tecladoTipo = new System.Windows.Forms.Label();
            this.comboBox_auricularMicrofono = new System.Windows.Forms.ComboBox();
            this.label_auricularMicrofono = new System.Windows.Forms.Label();
            this.comboBox_auricularModelo = new System.Windows.Forms.ComboBox();
            this.label_auricularModelo = new System.Windows.Forms.Label();
            this.comboBox_Producto = new System.Windows.Forms.ComboBox();
            this.label_marcaRazer = new System.Windows.Forms.Label();
            this.label_marca = new System.Windows.Forms.Label();
            this.label_producto = new System.Windows.Forms.Label();
            this.label_inalambrico = new System.Windows.Forms.Label();
            this.label_ColorLuces = new System.Windows.Forms.Label();
            this.label_Color = new System.Windows.Forms.Label();
            this.comboBox_Inalambrico = new System.Windows.Forms.ComboBox();
            this.comboBox_ColorLuces = new System.Windows.Forms.ComboBox();
            this.comboBox_Color = new System.Windows.Forms.ComboBox();
            this.panel_salir = new System.Windows.Forms.Panel();
            this.label_salir = new System.Windows.Forms.Label();
            this.button_fabricar = new System.Windows.Forms.Button();
            this.pictureBox_fondoBordeGif = new System.Windows.Forms.PictureBox();
            this.panel_fondo.SuspendLayout();
            this.groupBox_general.SuspendLayout();
            this.panel_salir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fondoBordeGif)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_fondo
            // 
            this.panel_fondo.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel_fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_fondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_fondo.Controls.Add(this.groupBox_general);
            this.panel_fondo.Location = new System.Drawing.Point(3, 3);
            this.panel_fondo.Name = "panel_fondo";
            this.panel_fondo.Size = new System.Drawing.Size(344, 594);
            this.panel_fondo.TabIndex = 1;
            // 
            // groupBox_general
            // 
            this.groupBox_general.Controls.Add(this.comboBox_tecladoTipo);
            this.groupBox_general.Controls.Add(this.label_tecladoTipo);
            this.groupBox_general.Controls.Add(this.comboBox_auricularMicrofono);
            this.groupBox_general.Controls.Add(this.label_auricularMicrofono);
            this.groupBox_general.Controls.Add(this.comboBox_auricularModelo);
            this.groupBox_general.Controls.Add(this.label_auricularModelo);
            this.groupBox_general.Controls.Add(this.button_fabricar);
            this.groupBox_general.Controls.Add(this.comboBox_Producto);
            this.groupBox_general.Controls.Add(this.label_marcaRazer);
            this.groupBox_general.Controls.Add(this.label_marca);
            this.groupBox_general.Controls.Add(this.label_producto);
            this.groupBox_general.Controls.Add(this.label_inalambrico);
            this.groupBox_general.Controls.Add(this.label_ColorLuces);
            this.groupBox_general.Controls.Add(this.label_Color);
            this.groupBox_general.Controls.Add(this.comboBox_Inalambrico);
            this.groupBox_general.Controls.Add(this.comboBox_ColorLuces);
            this.groupBox_general.Controls.Add(this.comboBox_Color);
            this.groupBox_general.Controls.Add(this.panel_salir);
            this.groupBox_general.Font = new System.Drawing.Font("Roboto Lt", 18.75F);
            this.groupBox_general.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox_general.Location = new System.Drawing.Point(6, 6);
            this.groupBox_general.Name = "groupBox_general";
            this.groupBox_general.Size = new System.Drawing.Size(328, 579);
            this.groupBox_general.TabIndex = 7;
            this.groupBox_general.TabStop = false;
            this.groupBox_general.Text = "Fabricacion";
            // 
            // comboBox_tecladoTipo
            // 
            this.comboBox_tecladoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tecladoTipo.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.comboBox_tecladoTipo.FormattingEnabled = true;
            this.comboBox_tecladoTipo.Location = new System.Drawing.Point(144, 321);
            this.comboBox_tecladoTipo.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_tecladoTipo.Name = "comboBox_tecladoTipo";
            this.comboBox_tecladoTipo.Size = new System.Drawing.Size(174, 32);
            this.comboBox_tecladoTipo.TabIndex = 24;
            this.comboBox_tecladoTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox_tecladoTipo_SelectedIndexChanged);
            // 
            // label_tecladoTipo
            // 
            this.label_tecladoTipo.AutoSize = true;
            this.label_tecladoTipo.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.label_tecladoTipo.Location = new System.Drawing.Point(77, 329);
            this.label_tecladoTipo.Name = "label_tecladoTipo";
            this.label_tecladoTipo.Size = new System.Drawing.Size(59, 24);
            this.label_tecladoTipo.TabIndex = 23;
            this.label_tecladoTipo.Text = "Tipo :";
            // 
            // comboBox_auricularMicrofono
            // 
            this.comboBox_auricularMicrofono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_auricularMicrofono.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.comboBox_auricularMicrofono.FormattingEnabled = true;
            this.comboBox_auricularMicrofono.Location = new System.Drawing.Point(144, 321);
            this.comboBox_auricularMicrofono.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_auricularMicrofono.Name = "comboBox_auricularMicrofono";
            this.comboBox_auricularMicrofono.Size = new System.Drawing.Size(174, 32);
            this.comboBox_auricularMicrofono.TabIndex = 22;
            this.comboBox_auricularMicrofono.SelectedIndexChanged += new System.EventHandler(this.comboBox_auricularMicrofono_SelectedIndexChanged);
            // 
            // label_auricularMicrofono
            // 
            this.label_auricularMicrofono.AutoSize = true;
            this.label_auricularMicrofono.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.label_auricularMicrofono.Location = new System.Drawing.Point(25, 329);
            this.label_auricularMicrofono.Name = "label_auricularMicrofono";
            this.label_auricularMicrofono.Size = new System.Drawing.Size(110, 24);
            this.label_auricularMicrofono.TabIndex = 21;
            this.label_auricularMicrofono.Text = "Microfono :";
            // 
            // comboBox_auricularModelo
            // 
            this.comboBox_auricularModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_auricularModelo.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.comboBox_auricularModelo.FormattingEnabled = true;
            this.comboBox_auricularModelo.Location = new System.Drawing.Point(145, 145);
            this.comboBox_auricularModelo.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_auricularModelo.Name = "comboBox_auricularModelo";
            this.comboBox_auricularModelo.Size = new System.Drawing.Size(174, 32);
            this.comboBox_auricularModelo.TabIndex = 20;
            this.comboBox_auricularModelo.SelectedIndexChanged += new System.EventHandler(this.comboBox_auricularModelo_SelectedIndexChanged);
            // 
            // label_auricularModelo
            // 
            this.label_auricularModelo.AutoSize = true;
            this.label_auricularModelo.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.label_auricularModelo.Location = new System.Drawing.Point(50, 153);
            this.label_auricularModelo.Name = "label_auricularModelo";
            this.label_auricularModelo.Size = new System.Drawing.Size(85, 24);
            this.label_auricularModelo.TabIndex = 19;
            this.label_auricularModelo.Text = "Modelo :";
            // 
            // comboBox_Producto
            // 
            this.comboBox_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Producto.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.comboBox_Producto.FormattingEnabled = true;
            this.comboBox_Producto.Location = new System.Drawing.Point(145, 98);
            this.comboBox_Producto.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Producto.Name = "comboBox_Producto";
            this.comboBox_Producto.Size = new System.Drawing.Size(174, 32);
            this.comboBox_Producto.TabIndex = 17;
            this.comboBox_Producto.SelectedIndexChanged += new System.EventHandler(this.comboBox_Producto_SelectedIndexChanged);
            // 
            // label_marcaRazer
            // 
            this.label_marcaRazer.AutoSize = true;
            this.label_marcaRazer.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.label_marcaRazer.Location = new System.Drawing.Point(141, 58);
            this.label_marcaRazer.Name = "label_marcaRazer";
            this.label_marcaRazer.Size = new System.Drawing.Size(61, 24);
            this.label_marcaRazer.TabIndex = 16;
            this.label_marcaRazer.Text = "Razer";
            // 
            // label_marca
            // 
            this.label_marca.AutoSize = true;
            this.label_marca.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.label_marca.Location = new System.Drawing.Point(59, 58);
            this.label_marca.Name = "label_marca";
            this.label_marca.Size = new System.Drawing.Size(76, 24);
            this.label_marca.TabIndex = 15;
            this.label_marca.Text = "Marca :";
            // 
            // label_producto
            // 
            this.label_producto.AutoSize = true;
            this.label_producto.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_producto.Location = new System.Drawing.Point(34, 106);
            this.label_producto.Name = "label_producto";
            this.label_producto.Size = new System.Drawing.Size(102, 24);
            this.label_producto.TabIndex = 14;
            this.label_producto.Text = "Producto :";
            // 
            // label_inalambrico
            // 
            this.label_inalambrico.AutoSize = true;
            this.label_inalambrico.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.label_inalambrico.Location = new System.Drawing.Point(10, 285);
            this.label_inalambrico.Name = "label_inalambrico";
            this.label_inalambrico.Size = new System.Drawing.Size(125, 24);
            this.label_inalambrico.TabIndex = 13;
            this.label_inalambrico.Text = "Inalambrico :";
            // 
            // label_ColorLuces
            // 
            this.label_ColorLuces.AutoSize = true;
            this.label_ColorLuces.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.label_ColorLuces.Location = new System.Drawing.Point(12, 241);
            this.label_ColorLuces.Name = "label_ColorLuces";
            this.label_ColorLuces.Size = new System.Drawing.Size(123, 24);
            this.label_ColorLuces.TabIndex = 12;
            this.label_ColorLuces.Text = "Color  luces :";
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.label_Color.Location = new System.Drawing.Point(68, 197);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(67, 24);
            this.label_Color.TabIndex = 11;
            this.label_Color.Text = "Color :";
            // 
            // comboBox_Inalambrico
            // 
            this.comboBox_Inalambrico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Inalambrico.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.comboBox_Inalambrico.FormattingEnabled = true;
            this.comboBox_Inalambrico.Location = new System.Drawing.Point(145, 277);
            this.comboBox_Inalambrico.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Inalambrico.Name = "comboBox_Inalambrico";
            this.comboBox_Inalambrico.Size = new System.Drawing.Size(174, 32);
            this.comboBox_Inalambrico.TabIndex = 10;
            this.comboBox_Inalambrico.SelectedIndexChanged += new System.EventHandler(this.comboBox_Inalambrico_SelectedIndexChanged);
            // 
            // comboBox_ColorLuces
            // 
            this.comboBox_ColorLuces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ColorLuces.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.comboBox_ColorLuces.FormattingEnabled = true;
            this.comboBox_ColorLuces.Location = new System.Drawing.Point(145, 233);
            this.comboBox_ColorLuces.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_ColorLuces.Name = "comboBox_ColorLuces";
            this.comboBox_ColorLuces.Size = new System.Drawing.Size(174, 32);
            this.comboBox_ColorLuces.TabIndex = 9;
            this.comboBox_ColorLuces.SelectedIndexChanged += new System.EventHandler(this.comboBox_ColorLuces_SelectedIndexChanged);
            // 
            // comboBox_Color
            // 
            this.comboBox_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Color.Font = new System.Drawing.Font("Roboto Lt", 15F);
            this.comboBox_Color.FormattingEnabled = true;
            this.comboBox_Color.Location = new System.Drawing.Point(145, 189);
            this.comboBox_Color.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Color.Name = "comboBox_Color";
            this.comboBox_Color.Size = new System.Drawing.Size(174, 32);
            this.comboBox_Color.TabIndex = 8;
            this.comboBox_Color.SelectedIndexChanged += new System.EventHandler(this.comboBox_Color_SelectedIndexChanged);
            // 
            // panel_salir
            // 
            this.panel_salir.BackColor = System.Drawing.Color.Red;
            this.panel_salir.Controls.Add(this.label_salir);
            this.panel_salir.Location = new System.Drawing.Point(280, 2);
            this.panel_salir.Name = "panel_salir";
            this.panel_salir.Size = new System.Drawing.Size(28, 29);
            this.panel_salir.TabIndex = 7;
            // 
            // label_salir
            // 
            this.label_salir.AutoSize = true;
            this.label_salir.BackColor = System.Drawing.SystemColors.Desktop;
            this.label_salir.Font = new System.Drawing.Font("Roboto Bk", 14F);
            this.label_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_salir.Location = new System.Drawing.Point(3, 3);
            this.label_salir.Name = "label_salir";
            this.label_salir.Size = new System.Drawing.Size(22, 23);
            this.label_salir.TabIndex = 0;
            this.label_salir.Text = "X";
            this.label_salir.Click += new System.EventHandler(this.label_salir_Click);
            // 
            // button_fabricar
            // 
            this.button_fabricar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_fabricar.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.button_fabricar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_fabricar.Image = global::Forms.Properties.Resources.rgb_gif;
            this.button_fabricar.Location = new System.Drawing.Point(15, 512);
            this.button_fabricar.Margin = new System.Windows.Forms.Padding(5);
            this.button_fabricar.Name = "button_fabricar";
            this.button_fabricar.Size = new System.Drawing.Size(159, 50);
            this.button_fabricar.TabIndex = 18;
            this.button_fabricar.Text = "Fabricar";
            this.button_fabricar.UseVisualStyleBackColor = true;
            this.button_fabricar.Click += new System.EventHandler(this.button_fabricar_Click);
            // 
            // pictureBox_fondoBordeGif
            // 
            this.pictureBox_fondoBordeGif.Image = global::Forms.Properties.Resources.rgb_gif;
            this.pictureBox_fondoBordeGif.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_fondoBordeGif.Name = "pictureBox_fondoBordeGif";
            this.pictureBox_fondoBordeGif.Size = new System.Drawing.Size(1687, 600);
            this.pictureBox_fondoBordeGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_fondoBordeGif.TabIndex = 8;
            this.pictureBox_fondoBordeGif.TabStop = false;
            // 
            // FormFabricar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 600);
            this.Controls.Add(this.panel_fondo);
            this.Controls.Add(this.pictureBox_fondoBordeGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFabricar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFabricar";
            this.Load += new System.EventHandler(this.FormFabricar_Load);
            this.panel_fondo.ResumeLayout(false);
            this.groupBox_general.ResumeLayout(false);
            this.groupBox_general.PerformLayout();
            this.panel_salir.ResumeLayout(false);
            this.panel_salir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fondoBordeGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_fondo;
        private System.Windows.Forms.PictureBox pictureBox_fondoBordeGif;
        private System.Windows.Forms.GroupBox groupBox_general;
        private System.Windows.Forms.Panel panel_salir;
        private System.Windows.Forms.Label label_salir;
        private System.Windows.Forms.ComboBox comboBox_Color;
        private System.Windows.Forms.ComboBox comboBox_Inalambrico;
        private System.Windows.Forms.ComboBox comboBox_ColorLuces;
        private System.Windows.Forms.Label label_inalambrico;
        private System.Windows.Forms.Label label_ColorLuces;
        private System.Windows.Forms.Label label_Color;
        private System.Windows.Forms.ComboBox comboBox_Producto;
        private System.Windows.Forms.Label label_marcaRazer;
        private System.Windows.Forms.Label label_marca;
        private System.Windows.Forms.Label label_producto;
        private System.Windows.Forms.Button button_fabricar;
        private System.Windows.Forms.ComboBox comboBox_auricularModelo;
        private System.Windows.Forms.Label label_auricularModelo;
        private System.Windows.Forms.Label label_auricularMicrofono;
        private System.Windows.Forms.ComboBox comboBox_auricularMicrofono;
        private System.Windows.Forms.ComboBox comboBox_tecladoTipo;
        private System.Windows.Forms.Label label_tecladoTipo;
    }
}