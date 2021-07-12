
namespace Forms
{
    partial class FormDeposito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_base = new System.Windows.Forms.DataGridView();
            this.panel_salir = new System.Windows.Forms.Panel();
            this.label_salir = new System.Windows.Forms.Label();
            this.panel_mover = new System.Windows.Forms.Panel();
            this.label_mover = new System.Windows.Forms.Label();
            this.pictureBox_mover = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel_fondo = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_base)).BeginInit();
            this.panel_salir.SuspendLayout();
            this.panel_mover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mover)).BeginInit();
            this.panel_fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_base);
            this.groupBox2.Controls.Add(this.panel_salir);
            this.groupBox2.Controls.Add(this.panel_mover);
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1176, 676);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Depósito";
            // 
            // dataGridView_base
            // 
            this.dataGridView_base.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_base.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_base.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_base.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_base.Location = new System.Drawing.Point(18, 107);
            this.dataGridView_base.Name = "dataGridView_base";
            this.dataGridView_base.ReadOnly = true;
            this.dataGridView_base.RowTemplate.ReadOnly = true;
            this.dataGridView_base.Size = new System.Drawing.Size(1136, 548);
            this.dataGridView_base.TabIndex = 10;
            // 
            // panel_salir
            // 
            this.panel_salir.BackColor = System.Drawing.Color.Red;
            this.panel_salir.Controls.Add(this.label_salir);
            this.panel_salir.Location = new System.Drawing.Point(1126, 3);
            this.panel_salir.Name = "panel_salir";
            this.panel_salir.Size = new System.Drawing.Size(28, 29);
            this.panel_salir.TabIndex = 8;
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
            // panel_mover
            // 
            this.panel_mover.BackColor = System.Drawing.Color.Red;
            this.panel_mover.Controls.Add(this.label_mover);
            this.panel_mover.Controls.Add(this.pictureBox_mover);
            this.panel_mover.Location = new System.Drawing.Point(1001, 3);
            this.panel_mover.Name = "panel_mover";
            this.panel_mover.Size = new System.Drawing.Size(108, 29);
            this.panel_mover.TabIndex = 9;
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
            // btnCargar
            // 
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargar.Image = global::Forms.Properties.Resources.rgb_gif;
            this.btnCargar.Location = new System.Drawing.Point(18, 39);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(221, 50);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Base de Datos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Roboto Lt", 14F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Image = global::Forms.Properties.Resources.rgb_gif;
            this.btnGuardar.Location = new System.Drawing.Point(262, 39);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(247, 48);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Base de Datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel_fondo
            // 
            this.panel_fondo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_fondo.Controls.Add(this.groupBox2);
            this.panel_fondo.Location = new System.Drawing.Point(-1, -3);
            this.panel_fondo.Name = "panel_fondo";
            this.panel_fondo.Size = new System.Drawing.Size(1206, 714);
            this.panel_fondo.TabIndex = 10;
            // 
            // FormDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel_fondo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDeposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeposito";
            this.Activated += new System.EventHandler(this.FormDeposito_Activated);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_base)).EndInit();
            this.panel_salir.ResumeLayout(false);
            this.panel_salir.PerformLayout();
            this.panel_mover.ResumeLayout(false);
            this.panel_mover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mover)).EndInit();
            this.panel_fondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel_fondo;
        private System.Windows.Forms.Panel panel_salir;
        private System.Windows.Forms.Label label_salir;
        private System.Windows.Forms.Panel panel_mover;
        private System.Windows.Forms.Label label_mover;
        private System.Windows.Forms.PictureBox pictureBox_mover;
        private System.Windows.Forms.DataGridView dataGridView_base;
    }
}