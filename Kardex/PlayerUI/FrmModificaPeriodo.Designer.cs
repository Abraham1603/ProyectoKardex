namespace PlayerUI
{
    partial class FrmModificaPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificaPeriodo));
            this.gbPeriodo = new System.Windows.Forms.GroupBox();
            this.dtpFechaModi = new System.Windows.Forms.DateTimePicker();
            this.dtca = new System.Windows.Forms.DataGridView();
            this.txtcnueva = new System.Windows.Forms.TextBox();
            this.txtmodi = new System.Windows.Forms.TextBox();
            this.dgvPeriodo = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConsultaPeriodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTodas = new System.Windows.Forms.CheckBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPeriodo
            // 
            this.gbPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.gbPeriodo.Controls.Add(this.dtpFechaModi);
            this.gbPeriodo.Controls.Add(this.dtca);
            this.gbPeriodo.Controls.Add(this.txtcnueva);
            this.gbPeriodo.Controls.Add(this.txtmodi);
            this.gbPeriodo.Controls.Add(this.dgvPeriodo);
            this.gbPeriodo.Controls.Add(this.btnRegresar);
            this.gbPeriodo.Controls.Add(this.btnconsulta);
            this.gbPeriodo.Controls.Add(this.pictureBox1);
            this.gbPeriodo.Controls.Add(this.btnConsultaPeriodo);
            this.gbPeriodo.Controls.Add(this.label2);
            this.gbPeriodo.Controls.Add(this.cbTodas);
            this.gbPeriodo.Controls.Add(this.txtPeriodo);
            this.gbPeriodo.Controls.Add(this.label1);
            this.gbPeriodo.Controls.Add(this.label6);
            this.gbPeriodo.Location = new System.Drawing.Point(0, 0);
            this.gbPeriodo.Name = "gbPeriodo";
            this.gbPeriodo.Size = new System.Drawing.Size(959, 467);
            this.gbPeriodo.TabIndex = 3;
            this.gbPeriodo.TabStop = false;
            this.gbPeriodo.Enter += new System.EventHandler(this.gbPeriodo_Enter);
            // 
            // dtpFechaModi
            // 
            this.dtpFechaModi.Enabled = false;
            this.dtpFechaModi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaModi.Location = new System.Drawing.Point(678, 309);
            this.dtpFechaModi.Name = "dtpFechaModi";
            this.dtpFechaModi.Size = new System.Drawing.Size(159, 26);
            this.dtpFechaModi.TabIndex = 25;
            this.dtpFechaModi.TabStop = false;
            this.dtpFechaModi.Visible = false;
            // 
            // dtca
            // 
            this.dtca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtca.Location = new System.Drawing.Point(24, 16);
            this.dtca.Name = "dtca";
            this.dtca.Size = new System.Drawing.Size(137, 82);
            this.dtca.TabIndex = 24;
            this.dtca.Visible = false;
            // 
            // txtcnueva
            // 
            this.txtcnueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnueva.Location = new System.Drawing.Point(678, 257);
            this.txtcnueva.MaxLength = 6;
            this.txtcnueva.Name = "txtcnueva";
            this.txtcnueva.Size = new System.Drawing.Size(167, 31);
            this.txtcnueva.TabIndex = 4;
            this.txtcnueva.TextChanged += new System.EventHandler(this.txtcnueva_TextChanged);
            this.txtcnueva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcnueva_KeyPress);
            // 
            // txtmodi
            // 
            this.txtmodi.Enabled = false;
            this.txtmodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodi.Location = new System.Drawing.Point(678, 204);
            this.txtmodi.Name = "txtmodi";
            this.txtmodi.Size = new System.Drawing.Size(167, 31);
            this.txtmodi.TabIndex = 22;
            this.txtmodi.TabStop = false;
            // 
            // dgvPeriodo
            // 
            this.dgvPeriodo.AllowUserToAddRows = false;
            this.dgvPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPeriodo.Location = new System.Drawing.Point(49, 166);
            this.dgvPeriodo.Name = "dgvPeriodo";
            this.dgvPeriodo.Size = new System.Drawing.Size(534, 289);
            this.dgvPeriodo.TabIndex = 19;
            this.dgvPeriodo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPeriodo_CellContentClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(778, 357);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(120, 47);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnconsulta
            // 
            this.btnconsulta.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsulta.Location = new System.Drawing.Point(467, 114);
            this.btnconsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(116, 41);
            this.btnconsulta.TabIndex = 3;
            this.btnconsulta.Text = "Consulta";
            this.btnconsulta.UseVisualStyleBackColor = true;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(699, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 130);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnConsultaPeriodo
            // 
            this.btnConsultaPeriodo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnConsultaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPeriodo.Location = new System.Drawing.Point(639, 357);
            this.btnConsultaPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaPeriodo.Name = "btnConsultaPeriodo";
            this.btnConsultaPeriodo.Size = new System.Drawing.Size(118, 47);
            this.btnConsultaPeriodo.TabIndex = 5;
            this.btnConsultaPeriodo.Text = "Modificar";
            this.btnConsultaPeriodo.UseVisualStyleBackColor = true;
            this.btnConsultaPeriodo.Click += new System.EventHandler(this.btnConsultaPeriodo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(720, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Periodo";
            // 
            // cbTodas
            // 
            this.cbTodas.AutoSize = true;
            this.cbTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbTodas.Location = new System.Drawing.Point(379, 122);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.Size = new System.Drawing.Size(91, 29);
            this.cbTodas.TabIndex = 2;
            this.cbTodas.Text = "Todas";
            this.cbTodas.UseVisualStyleBackColor = true;
            this.cbTodas.CheckedChanged += new System.EventHandler(this.cbTodas_CheckedChanged);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.Location = new System.Drawing.Point(144, 119);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeriodo.MaxLength = 6;
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(223, 31);
            this.txtPeriodo.TabIndex = 1;
            this.txtPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Periodo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(319, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "MODIFICAR PERIODO";
            // 
            // FrmModificaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 467);
            this.Controls.Add(this.gbPeriodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificaPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificaPeriodo";
            this.gbPeriodo.ResumeLayout(false);
            this.gbPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPeriodo;
        private System.Windows.Forms.DataGridView dgvPeriodo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConsultaPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbTodas;
        public System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcnueva;
        private System.Windows.Forms.TextBox txtmodi;
        private System.Windows.Forms.DataGridView dtca;
        private System.Windows.Forms.DateTimePicker dtpFechaModi;
    }
}