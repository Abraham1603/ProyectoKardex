namespace PlayerUI
{
    partial class frmModificacion_rel_matcarr_horario
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsultaCarrera = new System.Windows.Forms.Button();
            this.dgvCarrera = new System.Windows.Forms.DataGridView();
            this.cbhorario2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbgrupo = new System.Windows.Forms.ComboBox();
            this.cbper = new System.Windows.Forms.ComboBox();
            this.cbhorario = new System.Windows.Forms.ComboBox();
            this.cbmatcarr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtvalidamateriahorario = new System.Windows.Forms.DataGridView();
            this.dtgrupo = new System.Windows.Forms.DataGridView();
            this.dtper = new System.Windows.Forms.DataGridView();
            this.dtmatcarr = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbConsultaCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvalidamateriahorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmatcarr)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsultaCarrera
            // 
            this.gbConsultaCarrera.Controls.Add(this.textBox1);
            this.gbConsultaCarrera.Controls.Add(this.button2);
            this.gbConsultaCarrera.Controls.Add(this.dtvalidamateriahorario);
            this.gbConsultaCarrera.Controls.Add(this.dtgrupo);
            this.gbConsultaCarrera.Controls.Add(this.dtper);
            this.gbConsultaCarrera.Controls.Add(this.dtmatcarr);
            this.gbConsultaCarrera.Controls.Add(this.cbhorario2);
            this.gbConsultaCarrera.Controls.Add(this.label3);
            this.gbConsultaCarrera.Controls.Add(this.cbgrupo);
            this.gbConsultaCarrera.Controls.Add(this.cbper);
            this.gbConsultaCarrera.Controls.Add(this.cbhorario);
            this.gbConsultaCarrera.Controls.Add(this.cbmatcarr);
            this.gbConsultaCarrera.Controls.Add(this.label1);
            this.gbConsultaCarrera.Controls.Add(this.label5);
            this.gbConsultaCarrera.Controls.Add(this.label2);
            this.gbConsultaCarrera.Controls.Add(this.label4);
            this.gbConsultaCarrera.Controls.Add(this.button1);
            this.gbConsultaCarrera.Controls.Add(this.label6);
            this.gbConsultaCarrera.Controls.Add(this.btnConsultaCarrera);
            this.gbConsultaCarrera.Controls.Add(this.dgvCarrera);
            this.gbConsultaCarrera.Location = new System.Drawing.Point(11, 11);
            this.gbConsultaCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsultaCarrera.Name = "gbConsultaCarrera";
            this.gbConsultaCarrera.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsultaCarrera.Size = new System.Drawing.Size(1196, 582);
            this.gbConsultaCarrera.TabIndex = 5;
            this.gbConsultaCarrera.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(985, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(101, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(967, 41);
            this.label6.TabIndex = 7;
            this.label6.Text = "MODIFICACION RELACION MATERIA-CARRERA-HORARIO";
            // 
            // btnConsultaCarrera
            // 
            this.btnConsultaCarrera.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCarrera.Location = new System.Drawing.Point(685, 115);
            this.btnConsultaCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaCarrera.Name = "btnConsultaCarrera";
            this.btnConsultaCarrera.Size = new System.Drawing.Size(117, 46);
            this.btnConsultaCarrera.TabIndex = 3;
            this.btnConsultaCarrera.Text = "Consulta";
            this.btnConsultaCarrera.UseVisualStyleBackColor = true;
            this.btnConsultaCarrera.Click += new System.EventHandler(this.btnConsultaCarrera_Click);
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.AllowUserToAddRows = false;
            this.dgvCarrera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarrera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCarrera.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrera.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarrera.Location = new System.Drawing.Point(29, 115);
            this.dgvCarrera.Name = "dgvCarrera";
            this.dgvCarrera.Size = new System.Drawing.Size(630, 221);
            this.dgvCarrera.TabIndex = 0;
            this.dgvCarrera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrera_CellContentClick);
            // 
            // cbhorario2
            // 
            this.cbhorario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbhorario2.FormattingEnabled = true;
            this.cbhorario2.Location = new System.Drawing.Point(864, 271);
            this.cbhorario2.Name = "cbhorario2";
            this.cbhorario2.Size = new System.Drawing.Size(288, 33);
            this.cbhorario2.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(742, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Horario 2:";
            // 
            // cbgrupo
            // 
            this.cbgrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbgrupo.FormattingEnabled = true;
            this.cbgrupo.Location = new System.Drawing.Point(868, 371);
            this.cbgrupo.Name = "cbgrupo";
            this.cbgrupo.Size = new System.Drawing.Size(288, 33);
            this.cbgrupo.TabIndex = 45;
            // 
            // cbper
            // 
            this.cbper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbper.FormattingEnabled = true;
            this.cbper.Location = new System.Drawing.Point(868, 321);
            this.cbper.Name = "cbper";
            this.cbper.Size = new System.Drawing.Size(288, 33);
            this.cbper.TabIndex = 44;
            // 
            // cbhorario
            // 
            this.cbhorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbhorario.FormattingEnabled = true;
            this.cbhorario.Location = new System.Drawing.Point(864, 220);
            this.cbhorario.Name = "cbhorario";
            this.cbhorario.Size = new System.Drawing.Size(288, 33);
            this.cbhorario.TabIndex = 43;
            // 
            // cbmatcarr
            // 
            this.cbmatcarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbmatcarr.FormattingEnabled = true;
            this.cbmatcarr.Location = new System.Drawing.Point(864, 174);
            this.cbmatcarr.Name = "cbmatcarr";
            this.cbmatcarr.Size = new System.Drawing.Size(288, 33);
            this.cbmatcarr.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(775, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Grupo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(758, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(742, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Horario 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(680, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Materia-Carrera";
            // 
            // dtvalidamateriahorario
            // 
            this.dtvalidamateriahorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvalidamateriahorario.Location = new System.Drawing.Point(165, 397);
            this.dtvalidamateriahorario.Name = "dtvalidamateriahorario";
            this.dtvalidamateriahorario.Size = new System.Drawing.Size(10, 12);
            this.dtvalidamateriahorario.TabIndex = 51;
            // 
            // dtgrupo
            // 
            this.dtgrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrupo.Location = new System.Drawing.Point(147, 393);
            this.dtgrupo.Name = "dtgrupo";
            this.dtgrupo.Size = new System.Drawing.Size(12, 16);
            this.dtgrupo.TabIndex = 50;
            this.dtgrupo.Visible = false;
            // 
            // dtper
            // 
            this.dtper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtper.Location = new System.Drawing.Point(120, 393);
            this.dtper.Name = "dtper";
            this.dtper.Size = new System.Drawing.Size(12, 16);
            this.dtper.TabIndex = 49;
            this.dtper.Visible = false;
            // 
            // dtmatcarr
            // 
            this.dtmatcarr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtmatcarr.Location = new System.Drawing.Point(89, 393);
            this.dtmatcarr.Name = "dtmatcarr";
            this.dtmatcarr.Size = new System.Drawing.Size(12, 16);
            this.dtmatcarr.TabIndex = 48;
            this.dtmatcarr.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(794, 466);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 46);
            this.button2.TabIndex = 52;
            this.button2.Text = "Modificacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1084, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 29);
            this.textBox1.TabIndex = 53;
            // 
            // frmModificacion_rel_matcarr_horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1218, 614);
            this.Controls.Add(this.gbConsultaCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificacion_rel_matcarr_horario";
            this.Text = "frmModificacion_rel_matcarr_horario";
            this.Load += new System.EventHandler(this.frmModificacion_rel_matcarr_horario_Load);
            this.gbConsultaCarrera.ResumeLayout(false);
            this.gbConsultaCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvalidamateriahorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmatcarr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsultaCarrera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsultaCarrera;
        private System.Windows.Forms.DataGridView dgvCarrera;
        private System.Windows.Forms.ComboBox cbhorario2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbgrupo;
        private System.Windows.Forms.ComboBox cbper;
        private System.Windows.Forms.ComboBox cbhorario;
        private System.Windows.Forms.ComboBox cbmatcarr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtvalidamateriahorario;
        private System.Windows.Forms.DataGridView dtgrupo;
        private System.Windows.Forms.DataGridView dtper;
        private System.Windows.Forms.DataGridView dtmatcarr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}