namespace PlayerUI
{
    partial class frmConsultaAlumno
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCarrera = new System.Windows.Forms.DataGridView();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.cbTodas = new System.Windows.Forms.CheckBox();
            this.gbConsultaCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsultaCarrera
            // 
            this.gbConsultaCarrera.Controls.Add(this.button1);
            this.gbConsultaCarrera.Controls.Add(this.label6);
            this.gbConsultaCarrera.Controls.Add(this.btnConsultaCarrera);
            this.gbConsultaCarrera.Controls.Add(this.label2);
            this.gbConsultaCarrera.Controls.Add(this.dgvCarrera);
            this.gbConsultaCarrera.Controls.Add(this.txtAlumno);
            this.gbConsultaCarrera.Controls.Add(this.cbTodas);
            this.gbConsultaCarrera.Location = new System.Drawing.Point(11, 11);
            this.gbConsultaCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsultaCarrera.Name = "gbConsultaCarrera";
            this.gbConsultaCarrera.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsultaCarrera.Size = new System.Drawing.Size(912, 488);
            this.gbConsultaCarrera.TabIndex = 4;
            this.gbConsultaCarrera.TabStop = false;
            this.gbConsultaCarrera.Enter += new System.EventHandler(this.gbConsultaCarrera_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(773, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(244, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 41);
            this.label6.TabIndex = 7;
            this.label6.Text = "CONSULTAR ALUMNO";
            // 
            // btnConsultaCarrera
            // 
            this.btnConsultaCarrera.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCarrera.Location = new System.Drawing.Point(641, 69);
            this.btnConsultaCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaCarrera.Name = "btnConsultaCarrera";
            this.btnConsultaCarrera.Size = new System.Drawing.Size(117, 33);
            this.btnConsultaCarrera.TabIndex = 3;
            this.btnConsultaCarrera.Text = "Consulta";
            this.btnConsultaCarrera.UseVisualStyleBackColor = true;
            this.btnConsultaCarrera.Click += new System.EventHandler(this.btnConsultaCarrera_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alumno o Carrera:";
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
            this.dgvCarrera.Size = new System.Drawing.Size(860, 347);
            this.dgvCarrera.TabIndex = 0;
            this.dgvCarrera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrera_CellContentClick);
            // 
            // txtAlumno
            // 
            this.txtAlumno.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlumno.Location = new System.Drawing.Point(240, 68);
            this.txtAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(251, 33);
            this.txtAlumno.TabIndex = 1;
            this.txtAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarrera_KeyPress);
            // 
            // cbTodas
            // 
            this.cbTodas.AutoSize = true;
            this.cbTodas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbTodas.Location = new System.Drawing.Point(528, 72);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.Size = new System.Drawing.Size(90, 29);
            this.cbTodas.TabIndex = 2;
            this.cbTodas.Text = "Todas";
            this.cbTodas.UseVisualStyleBackColor = true;
            this.cbTodas.CheckedChanged += new System.EventHandler(this.cbTodas_CheckedChanged);
            // 
            // frmConsultaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(934, 510);
            this.Controls.Add(this.gbConsultaCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaAlumno";
            this.gbConsultaCarrera.ResumeLayout(false);
            this.gbConsultaCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsultaCarrera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsultaCarrera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCarrera;
        public System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.CheckBox cbTodas;
    }
}