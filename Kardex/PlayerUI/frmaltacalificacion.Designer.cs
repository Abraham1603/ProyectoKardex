namespace PlayerUI
{
    partial class frmaltacalificacion
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
            this.gbConsultaCarrera = new System.Windows.Forms.GroupBox();
            this.txtunidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcali = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtllenadoma = new System.Windows.Forms.DataGridView();
            this.dtllenadorma = new System.Windows.Forms.DataGridView();
            this.cbrma = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbConsultaCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtllenadoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtllenadorma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsultaCarrera
            // 
            this.gbConsultaCarrera.Controls.Add(this.txtunidad);
            this.gbConsultaCarrera.Controls.Add(this.label3);
            this.gbConsultaCarrera.Controls.Add(this.txtcali);
            this.gbConsultaCarrera.Controls.Add(this.label1);
            this.gbConsultaCarrera.Controls.Add(this.dtllenadoma);
            this.gbConsultaCarrera.Controls.Add(this.dtllenadorma);
            this.gbConsultaCarrera.Controls.Add(this.cbrma);
            this.gbConsultaCarrera.Controls.Add(this.pictureBox1);
            this.gbConsultaCarrera.Controls.Add(this.label6);
            this.gbConsultaCarrera.Controls.Add(this.btnCerrar);
            this.gbConsultaCarrera.Controls.Add(this.btnGuardar);
            this.gbConsultaCarrera.Controls.Add(this.label2);
            this.gbConsultaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaCarrera.Location = new System.Drawing.Point(11, 11);
            this.gbConsultaCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsultaCarrera.Name = "gbConsultaCarrera";
            this.gbConsultaCarrera.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsultaCarrera.Size = new System.Drawing.Size(535, 331);
            this.gbConsultaCarrera.TabIndex = 7;
            this.gbConsultaCarrera.TabStop = false;
            // 
            // txtunidad
            // 
            this.txtunidad.Location = new System.Drawing.Point(229, 223);
            this.txtunidad.Name = "txtunidad";
            this.txtunidad.Size = new System.Drawing.Size(288, 26);
            this.txtunidad.TabIndex = 31;
            this.txtunidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcali_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(235, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Unidad:";
            // 
            // txtcali
            // 
            this.txtcali.Location = new System.Drawing.Point(229, 159);
            this.txtcali.Name = "txtcali";
            this.txtcali.Size = new System.Drawing.Size(288, 26);
            this.txtcali.TabIndex = 29;
            this.txtcali.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcali_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(225, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Calificacion:";
            // 
            // dtllenadoma
            // 
            this.dtllenadoma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtllenadoma.Location = new System.Drawing.Point(61, 303);
            this.dtllenadoma.Name = "dtllenadoma";
            this.dtllenadoma.Size = new System.Drawing.Size(14, 16);
            this.dtllenadoma.TabIndex = 27;
            this.dtllenadoma.Visible = false;
            // 
            // dtllenadorma
            // 
            this.dtllenadorma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtllenadorma.Location = new System.Drawing.Point(43, 303);
            this.dtllenadorma.Name = "dtllenadorma";
            this.dtllenadorma.Size = new System.Drawing.Size(12, 16);
            this.dtllenadorma.TabIndex = 25;
            this.dtllenadorma.Visible = false;
            // 
            // cbrma
            // 
            this.cbrma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrma.FormattingEnabled = true;
            this.cbrma.Location = new System.Drawing.Point(225, 96);
            this.cbrma.Name = "cbrma";
            this.cbrma.Size = new System.Drawing.Size(292, 28);
            this.cbrma.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(21, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 172);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(98, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "ALTA CALIFICACION";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(404, 274);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(113, 45);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "Regresar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(229, 274);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 45);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(221, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID Relacion Materia Alumno";
            // 
            // frmaltacalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(554, 350);
            this.Controls.Add(this.gbConsultaCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmaltacalificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmaltacalificacion";
            this.Load += new System.EventHandler(this.frmaltacalificacion_Load);
            this.gbConsultaCarrera.ResumeLayout(false);
            this.gbConsultaCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtllenadoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtllenadorma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsultaCarrera;
        private System.Windows.Forms.TextBox txtunidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtllenadoma;
        private System.Windows.Forms.DataGridView dtllenadorma;
        private System.Windows.Forms.ComboBox cbrma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
    }
}