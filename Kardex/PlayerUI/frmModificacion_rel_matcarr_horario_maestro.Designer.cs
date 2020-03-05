namespace PlayerUI
{
    partial class frmModificacion_rel_matcarr_horario_maestro
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
            this.btnConsultaCarrera = new System.Windows.Forms.Button();
            this.dgvCarrera = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtMaestro = new System.Windows.Forms.DataGridView();
            this.dtmatcarrMa = new System.Windows.Forms.DataGridView();
            this.cbMaestro = new System.Windows.Forms.ComboBox();
            this.cbmatcarrDo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmatcarrMa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultaCarrera
            // 
            this.btnConsultaCarrera.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCarrera.Location = new System.Drawing.Point(802, 87);
            this.btnConsultaCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaCarrera.Name = "btnConsultaCarrera";
            this.btnConsultaCarrera.Size = new System.Drawing.Size(117, 46);
            this.btnConsultaCarrera.TabIndex = 5;
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
            this.dgvCarrera.Location = new System.Drawing.Point(12, 78);
            this.dgvCarrera.Name = "dgvCarrera";
            this.dgvCarrera.Size = new System.Drawing.Size(772, 347);
            this.dgvCarrera.TabIndex = 4;
            this.dgvCarrera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrera_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(71, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1139, 41);
            this.label6.TabIndex = 8;
            this.label6.Text = "MODIFICACION RELACION MATERIA-CARRERA-HORARIO-MAESTRO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1085, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(877, 382);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 46);
            this.button2.TabIndex = 62;
            this.button2.Text = "Modificacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtMaestro
            // 
            this.dtMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMaestro.Location = new System.Drawing.Point(1136, 126);
            this.dtMaestro.Name = "dtMaestro";
            this.dtMaestro.Size = new System.Drawing.Size(10, 16);
            this.dtMaestro.TabIndex = 81;
            this.dtMaestro.Visible = false;
            // 
            // dtmatcarrMa
            // 
            this.dtmatcarrMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtmatcarrMa.Location = new System.Drawing.Point(1120, 126);
            this.dtmatcarrMa.Name = "dtmatcarrMa";
            this.dtmatcarrMa.Size = new System.Drawing.Size(10, 16);
            this.dtmatcarrMa.TabIndex = 80;
            this.dtmatcarrMa.Visible = false;
            // 
            // cbMaestro
            // 
            this.cbMaestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbMaestro.FormattingEnabled = true;
            this.cbMaestro.Location = new System.Drawing.Point(986, 273);
            this.cbMaestro.Name = "cbMaestro";
            this.cbMaestro.Size = new System.Drawing.Size(288, 33);
            this.cbMaestro.TabIndex = 77;
            // 
            // cbmatcarrDo
            // 
            this.cbmatcarrDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmatcarrDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbmatcarrDo.FormattingEnabled = true;
            this.cbmatcarrDo.Location = new System.Drawing.Point(986, 197);
            this.cbmatcarrDo.Name = "cbmatcarrDo";
            this.cbmatcarrDo.Size = new System.Drawing.Size(288, 33);
            this.cbmatcarrDo.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(872, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "Maestro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(802, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Materia-Carrera";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1152, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 82;
            this.textBox1.Visible = false;
            // 
            // frmModificacion_rel_matcarr_horario_maestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1286, 585);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtMaestro);
            this.Controls.Add(this.dtmatcarrMa);
            this.Controls.Add(this.cbMaestro);
            this.Controls.Add(this.cbmatcarrDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConsultaCarrera);
            this.Controls.Add(this.dgvCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificacion_rel_matcarr_horario_maestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificacion_rel_matcarr_horario_maestro";
            this.Load += new System.EventHandler(this.frmModificacion_rel_matcarr_horario_maestro_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmatcarrMa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaCarrera;
        private System.Windows.Forms.DataGridView dgvCarrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtMaestro;
        private System.Windows.Forms.DataGridView dtmatcarrMa;
        private System.Windows.Forms.ComboBox cbMaestro;
        private System.Windows.Forms.ComboBox cbmatcarrDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}