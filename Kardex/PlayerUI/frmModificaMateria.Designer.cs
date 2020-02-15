namespace PlayerUI
{
    partial class frmModificaMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificaMateria));
            this.gbCarrera = new System.Windows.Forms.GroupBox();
            this.dtpFechaModi = new System.Windows.Forms.DateTimePicker();
            this.dtma = new System.Windows.Forms.DataGridView();
            this.txtcnueva = new System.Windows.Forms.TextBox();
            this.txtmodi = new System.Windows.Forms.TextBox();
            this.dgvCarrera = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConsultaMateria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTodas = new System.Windows.Forms.CheckBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCarrera
            // 
            this.gbCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.gbCarrera.Controls.Add(this.dtpFechaModi);
            this.gbCarrera.Controls.Add(this.dtma);
            this.gbCarrera.Controls.Add(this.txtcnueva);
            this.gbCarrera.Controls.Add(this.txtmodi);
            this.gbCarrera.Controls.Add(this.dgvCarrera);
            this.gbCarrera.Controls.Add(this.button2);
            this.gbCarrera.Controls.Add(this.button1);
            this.gbCarrera.Controls.Add(this.pictureBox1);
            this.gbCarrera.Controls.Add(this.btnConsultaMateria);
            this.gbCarrera.Controls.Add(this.label2);
            this.gbCarrera.Controls.Add(this.cbTodas);
            this.gbCarrera.Controls.Add(this.txtMateria);
            this.gbCarrera.Controls.Add(this.label1);
            this.gbCarrera.Controls.Add(this.label6);
            this.gbCarrera.Location = new System.Drawing.Point(12, 12);
            this.gbCarrera.Name = "gbCarrera";
            this.gbCarrera.Size = new System.Drawing.Size(954, 447);
            this.gbCarrera.TabIndex = 2;
            this.gbCarrera.TabStop = false;
            // 
            // dtpFechaModi
            // 
            this.dtpFechaModi.Enabled = false;
            this.dtpFechaModi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaModi.Location = new System.Drawing.Point(682, 311);
            this.dtpFechaModi.Name = "dtpFechaModi";
            this.dtpFechaModi.Size = new System.Drawing.Size(159, 26);
            this.dtpFechaModi.TabIndex = 24;
            this.dtpFechaModi.TabStop = false;
            this.dtpFechaModi.Visible = false;
            // 
            // dtma
            // 
            this.dtma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtma.Location = new System.Drawing.Point(6, 16);
            this.dtma.Name = "dtma";
            this.dtma.Size = new System.Drawing.Size(113, 60);
            this.dtma.TabIndex = 22;
            this.dtma.Visible = false;
            // 
            // txtcnueva
            // 
            this.txtcnueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnueva.Location = new System.Drawing.Point(674, 276);
            this.txtcnueva.Name = "txtcnueva";
            this.txtcnueva.Size = new System.Drawing.Size(167, 31);
            this.txtcnueva.TabIndex = 4;
            this.txtcnueva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcnueva_KeyPress);
            // 
            // txtmodi
            // 
            this.txtmodi.Enabled = false;
            this.txtmodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodi.Location = new System.Drawing.Point(674, 223);
            this.txtmodi.Name = "txtmodi";
            this.txtmodi.Size = new System.Drawing.Size(167, 31);
            this.txtmodi.TabIndex = 20;
            this.txtmodi.TabStop = false;
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.AllowUserToAddRows = false;
            this.dgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrera.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarrera.Location = new System.Drawing.Point(49, 166);
            this.dgvCarrera.Name = "dgvCarrera";
            this.dgvCarrera.Size = new System.Drawing.Size(534, 260);
            this.dgvCarrera.TabIndex = 19;
            this.dgvCarrera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarrera_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(781, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(467, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(691, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 130);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnConsultaMateria
            // 
            this.btnConsultaMateria.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnConsultaMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaMateria.Location = new System.Drawing.Point(633, 356);
            this.btnConsultaMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaMateria.Name = "btnConsultaMateria";
            this.btnConsultaMateria.Size = new System.Drawing.Size(130, 38);
            this.btnConsultaMateria.TabIndex = 5;
            this.btnConsultaMateria.Text = "Modificar";
            this.btnConsultaMateria.UseVisualStyleBackColor = true;
            this.btnConsultaMateria.Click += new System.EventHandler(this.BtnConsultaMateria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(713, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Materia";
            // 
            // cbTodas
            // 
            this.cbTodas.AutoSize = true;
            this.cbTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbTodas.Location = new System.Drawing.Point(371, 122);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.Size = new System.Drawing.Size(91, 29);
            this.cbTodas.TabIndex = 2;
            this.cbTodas.Text = "Todas";
            this.cbTodas.UseVisualStyleBackColor = true;
            this.cbTodas.CheckedChanged += new System.EventHandler(this.CbTodas_CheckedChanged);
            // 
            // txtMateria
            // 
            this.txtMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria.Location = new System.Drawing.Point(139, 119);
            this.txtMateria.Margin = new System.Windows.Forms.Padding(2);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(220, 31);
            this.txtMateria.TabIndex = 1;
            this.txtMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMateria_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Materia: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(319, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "MODIFICAR MATERIA";
            // 
            // frmModificaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(978, 475);
            this.Controls.Add(this.gbCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificaMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificaMateria";
            this.gbCarrera.ResumeLayout(false);
            this.gbCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCarrera;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConsultaMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbTodas;
        public System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcnueva;
        private System.Windows.Forms.TextBox txtmodi;
        private System.Windows.Forms.DataGridView dgvCarrera;
        private System.Windows.Forms.DataGridView dtma;
        private System.Windows.Forms.DateTimePicker dtpFechaModi;
    }
}