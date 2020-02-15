namespace PlayerUI
{
    partial class frmAltaRelmatcarr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaRelmatcarr));
            this.gbConsultaCarrera = new System.Windows.Forms.GroupBox();
            this.dtllenadoma = new System.Windows.Forms.DataGridView();
            this.dtllenadoca = new System.Windows.Forms.DataGridView();
            this.cbmateria = new System.Windows.Forms.ComboBox();
            this.cbcarreras = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbConsultaCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtllenadoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtllenadoca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsultaCarrera
            // 
            this.gbConsultaCarrera.Controls.Add(this.dtllenadoma);
            this.gbConsultaCarrera.Controls.Add(this.dtllenadoca);
            this.gbConsultaCarrera.Controls.Add(this.cbmateria);
            this.gbConsultaCarrera.Controls.Add(this.cbcarreras);
            this.gbConsultaCarrera.Controls.Add(this.pictureBox1);
            this.gbConsultaCarrera.Controls.Add(this.label6);
            this.gbConsultaCarrera.Controls.Add(this.btnCerrar);
            this.gbConsultaCarrera.Controls.Add(this.btnGuardar);
            this.gbConsultaCarrera.Controls.Add(this.label3);
            this.gbConsultaCarrera.Controls.Add(this.label2);
            this.gbConsultaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaCarrera.Location = new System.Drawing.Point(11, 11);
            this.gbConsultaCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsultaCarrera.Name = "gbConsultaCarrera";
            this.gbConsultaCarrera.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsultaCarrera.Size = new System.Drawing.Size(662, 285);
            this.gbConsultaCarrera.TabIndex = 5;
            this.gbConsultaCarrera.TabStop = false;
            this.gbConsultaCarrera.Enter += new System.EventHandler(this.gbConsultaCarrera_Enter);
            // 
            // dtllenadoma
            // 
            this.dtllenadoma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtllenadoma.Location = new System.Drawing.Point(66, 217);
            this.dtllenadoma.Name = "dtllenadoma";
            this.dtllenadoma.Size = new System.Drawing.Size(10, 15);
            this.dtllenadoma.TabIndex = 27;
            this.dtllenadoma.Visible = false;
            // 
            // dtllenadoca
            // 
            this.dtllenadoca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtllenadoca.Location = new System.Drawing.Point(48, 216);
            this.dtllenadoca.Name = "dtllenadoca";
            this.dtllenadoca.Size = new System.Drawing.Size(12, 16);
            this.dtllenadoca.TabIndex = 25;
            this.dtllenadoca.Visible = false;
            // 
            // cbmateria
            // 
            this.cbmateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmateria.FormattingEnabled = true;
            this.cbmateria.Location = new System.Drawing.Point(335, 145);
            this.cbmateria.Name = "cbmateria";
            this.cbmateria.Size = new System.Drawing.Size(292, 28);
            this.cbmateria.TabIndex = 26;
            // 
            // cbcarreras
            // 
            this.cbcarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcarreras.FormattingEnabled = true;
            this.cbcarreras.Location = new System.Drawing.Point(335, 102);
            this.cbcarreras.Name = "cbcarreras";
            this.cbcarreras.Size = new System.Drawing.Size(292, 28);
            this.cbcarreras.TabIndex = 25;
            this.cbcarreras.SelectedIndexChanged += new System.EventHandler(this.cbcarreras_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 134);
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
            this.label6.Size = new System.Drawing.Size(465, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "RELACION MATERIA - CARRERA";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(514, 206);
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
            this.btnGuardar.Location = new System.Drawing.Point(335, 206);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 45);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(230, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(230, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Carrera:";
            // 
            // frmAltaRelmatcarr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(685, 305);
            this.Controls.Add(this.gbConsultaCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaRelmatcarr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaRelmatcarr";
            this.Load += new System.EventHandler(this.frmAltaRelmatcarr_Load);
            this.gbConsultaCarrera.ResumeLayout(false);
            this.gbConsultaCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtllenadoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtllenadoca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsultaCarrera;
        private System.Windows.Forms.DataGridView dtllenadoma;
        private System.Windows.Forms.DataGridView dtllenadoca;
        private System.Windows.Forms.ComboBox cbmateria;
        private System.Windows.Forms.ComboBox cbcarreras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}