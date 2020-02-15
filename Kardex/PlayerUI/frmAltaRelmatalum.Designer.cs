namespace PlayerUI
{
    partial class frmAltaRelmatalum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaRelmatalum));
            this.gbConsultaCarrera = new System.Windows.Forms.GroupBox();
            this.dtper = new System.Windows.Forms.DataGridView();
            this.dtma = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbperiodo = new System.Windows.Forms.ComboBox();
            this.cbmaestro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbrmc = new System.Windows.Forms.ComboBox();
            this.cbalumnos = new System.Windows.Forms.ComboBox();
            this.dtrelmc = new System.Windows.Forms.DataGridView();
            this.dtal = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbConsultaCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtrelmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsultaCarrera
            // 
            this.gbConsultaCarrera.Controls.Add(this.dtper);
            this.gbConsultaCarrera.Controls.Add(this.dtma);
            this.gbConsultaCarrera.Controls.Add(this.label3);
            this.gbConsultaCarrera.Controls.Add(this.label4);
            this.gbConsultaCarrera.Controls.Add(this.cbperiodo);
            this.gbConsultaCarrera.Controls.Add(this.cbmaestro);
            this.gbConsultaCarrera.Controls.Add(this.label2);
            this.gbConsultaCarrera.Controls.Add(this.label1);
            this.gbConsultaCarrera.Controls.Add(this.cbrmc);
            this.gbConsultaCarrera.Controls.Add(this.cbalumnos);
            this.gbConsultaCarrera.Controls.Add(this.dtrelmc);
            this.gbConsultaCarrera.Controls.Add(this.dtal);
            this.gbConsultaCarrera.Controls.Add(this.pictureBox1);
            this.gbConsultaCarrera.Controls.Add(this.label6);
            this.gbConsultaCarrera.Controls.Add(this.btnCerrar);
            this.gbConsultaCarrera.Controls.Add(this.btnGuardar);
            this.gbConsultaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaCarrera.Location = new System.Drawing.Point(11, 11);
            this.gbConsultaCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsultaCarrera.Name = "gbConsultaCarrera";
            this.gbConsultaCarrera.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsultaCarrera.Size = new System.Drawing.Size(591, 479);
            this.gbConsultaCarrera.TabIndex = 6;
            this.gbConsultaCarrera.TabStop = false;
            // 
            // dtper
            // 
            this.dtper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtper.Location = new System.Drawing.Point(135, 221);
            this.dtper.Name = "dtper";
            this.dtper.Size = new System.Drawing.Size(11, 11);
            this.dtper.TabIndex = 37;
            this.dtper.Visible = false;
            // 
            // dtma
            // 
            this.dtma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtma.Location = new System.Drawing.Point(110, 219);
            this.dtma.Name = "dtma";
            this.dtma.Size = new System.Drawing.Size(10, 13);
            this.dtma.TabIndex = 36;
            this.dtma.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(243, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "PERIODO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(238, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "MAESTRO:";
            // 
            // cbperiodo
            // 
            this.cbperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbperiodo.FormattingEnabled = true;
            this.cbperiodo.Location = new System.Drawing.Point(242, 346);
            this.cbperiodo.Name = "cbperiodo";
            this.cbperiodo.Size = new System.Drawing.Size(256, 33);
            this.cbperiodo.TabIndex = 33;
            // 
            // cbmaestro
            // 
            this.cbmaestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmaestro.FormattingEnabled = true;
            this.cbmaestro.Location = new System.Drawing.Point(242, 265);
            this.cbmaestro.Name = "cbmaestro";
            this.cbmaestro.Size = new System.Drawing.Size(256, 33);
            this.cbmaestro.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(238, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "RELACION MATERIA - CARRERA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(238, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "ALUMNO:";
            // 
            // cbrmc
            // 
            this.cbrmc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbrmc.FormattingEnabled = true;
            this.cbrmc.Location = new System.Drawing.Point(242, 183);
            this.cbrmc.Name = "cbrmc";
            this.cbrmc.Size = new System.Drawing.Size(256, 33);
            this.cbrmc.TabIndex = 29;
            // 
            // cbalumnos
            // 
            this.cbalumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbalumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbalumnos.FormattingEnabled = true;
            this.cbalumnos.Location = new System.Drawing.Point(242, 102);
            this.cbalumnos.Name = "cbalumnos";
            this.cbalumnos.Size = new System.Drawing.Size(256, 33);
            this.cbalumnos.TabIndex = 28;
            // 
            // dtrelmc
            // 
            this.dtrelmc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtrelmc.Location = new System.Drawing.Point(85, 217);
            this.dtrelmc.Name = "dtrelmc";
            this.dtrelmc.Size = new System.Drawing.Size(10, 15);
            this.dtrelmc.TabIndex = 27;
            this.dtrelmc.Visible = false;
            // 
            // dtal
            // 
            this.dtal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtal.Location = new System.Drawing.Point(54, 216);
            this.dtal.Name = "dtal";
            this.dtal.Size = new System.Drawing.Size(12, 16);
            this.dtal.TabIndex = 25;
            this.dtal.Visible = false;
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
            this.label6.Location = new System.Drawing.Point(52, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(446, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "RELACION MATERIA - ALUMNO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(385, 417);
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
            this.btnGuardar.Location = new System.Drawing.Point(242, 417);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 45);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAltaRelmatalum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(608, 496);
            this.Controls.Add(this.gbConsultaCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaRelmatalum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaRelmatalum";
            this.Load += new System.EventHandler(this.frmAltaRelmatalum_Load);
            this.gbConsultaCarrera.ResumeLayout(false);
            this.gbConsultaCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtrelmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsultaCarrera;
        private System.Windows.Forms.DataGridView dtper;
        private System.Windows.Forms.DataGridView dtma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbperiodo;
        private System.Windows.Forms.ComboBox cbmaestro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbrmc;
        private System.Windows.Forms.ComboBox cbalumnos;
        private System.Windows.Forms.DataGridView dtrelmc;
        private System.Windows.Forms.DataGridView dtal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
    }
}