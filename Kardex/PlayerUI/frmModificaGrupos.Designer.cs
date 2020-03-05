namespace PlayerUI
{
    partial class frmModificaGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificaGrupos));
            this.gbCarrera = new System.Windows.Forms.GroupBox();
            this.dtpFechaModi = new System.Windows.Forms.DateTimePicker();
            this.dtca = new System.Windows.Forms.DataGridView();
            this.txtcnueva = new System.Windows.Forms.TextBox();
            this.txtmodi = new System.Windows.Forms.TextBox();
            this.dgvCarrera = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarCarrera = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTodas = new System.Windows.Forms.CheckBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCarrera
            // 
            this.gbCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.gbCarrera.Controls.Add(this.dtpFechaModi);
            this.gbCarrera.Controls.Add(this.dtca);
            this.gbCarrera.Controls.Add(this.txtcnueva);
            this.gbCarrera.Controls.Add(this.txtmodi);
            this.gbCarrera.Controls.Add(this.dgvCarrera);
            this.gbCarrera.Controls.Add(this.button2);
            this.gbCarrera.Controls.Add(this.button1);
            this.gbCarrera.Controls.Add(this.pictureBox1);
            this.gbCarrera.Controls.Add(this.btnModificarCarrera);
            this.gbCarrera.Controls.Add(this.label2);
            this.gbCarrera.Controls.Add(this.cbTodas);
            this.gbCarrera.Controls.Add(this.txtCarrera);
            this.gbCarrera.Controls.Add(this.label1);
            this.gbCarrera.Controls.Add(this.label6);
            this.gbCarrera.Location = new System.Drawing.Point(0, 0);
            this.gbCarrera.Name = "gbCarrera";
            this.gbCarrera.Size = new System.Drawing.Size(1044, 484);
            this.gbCarrera.TabIndex = 5;
            this.gbCarrera.TabStop = false;
            this.gbCarrera.Text = " ";
            // 
            // dtpFechaModi
            // 
            this.dtpFechaModi.Enabled = false;
            this.dtpFechaModi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaModi.Location = new System.Drawing.Point(78, 440);
            this.dtpFechaModi.Name = "dtpFechaModi";
            this.dtpFechaModi.Size = new System.Drawing.Size(66, 31);
            this.dtpFechaModi.TabIndex = 23;
            this.dtpFechaModi.Visible = false;
            // 
            // dtca
            // 
            this.dtca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtca.Location = new System.Drawing.Point(49, 16);
            this.dtca.Name = "dtca";
            this.dtca.Size = new System.Drawing.Size(137, 82);
            this.dtca.TabIndex = 22;
            this.dtca.Visible = false;
            // 
            // txtcnueva
            // 
            this.txtcnueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnueva.Location = new System.Drawing.Point(786, 322);
            this.txtcnueva.Name = "txtcnueva";
            this.txtcnueva.Size = new System.Drawing.Size(181, 31);
            this.txtcnueva.TabIndex = 4;
            // 
            // txtmodi
            // 
            this.txtmodi.Enabled = false;
            this.txtmodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodi.Location = new System.Drawing.Point(786, 269);
            this.txtmodi.Name = "txtmodi";
            this.txtmodi.Size = new System.Drawing.Size(181, 31);
            this.txtmodi.TabIndex = 0;
            this.txtmodi.TabStop = false;
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.AllowUserToAddRows = false;
            this.dgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrera.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarrera.Location = new System.Drawing.Point(49, 123);
            this.dgvCarrera.Name = "dgvCarrera";
            this.dgvCarrera.Size = new System.Drawing.Size(661, 338);
            this.dgvCarrera.TabIndex = 19;
            this.dgvCarrera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrera_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(885, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(539, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(811, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 130);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnModificarCarrera
            // 
            this.btnModificarCarrera.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnModificarCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCarrera.Location = new System.Drawing.Point(743, 407);
            this.btnModificarCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCarrera.Name = "btnModificarCarrera";
            this.btnModificarCarrera.Size = new System.Drawing.Size(128, 44);
            this.btnModificarCarrera.TabIndex = 5;
            this.btnModificarCarrera.Text = "Modificar";
            this.btnModificarCarrera.UseVisualStyleBackColor = true;
            this.btnModificarCarrera.Click += new System.EventHandler(this.btnModificarCarrera_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(825, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Grupos";
            // 
            // cbTodas
            // 
            this.cbTodas.AutoSize = true;
            this.cbTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbTodas.Location = new System.Drawing.Point(442, 82);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.Size = new System.Drawing.Size(91, 29);
            this.cbTodas.TabIndex = 2;
            this.cbTodas.Text = "Todas";
            this.cbTodas.UseVisualStyleBackColor = true;
            this.cbTodas.CheckedChanged += new System.EventHandler(this.cbTodas_CheckedChanged);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.Location = new System.Drawing.Point(214, 79);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(223, 31);
            this.txtCarrera.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grupos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(351, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "MODIFICAR GRUPOS";
            // 
            // frmModificaGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 483);
            this.Controls.Add(this.gbCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificaGrupos";
            this.Text = "frmModificaGrupos";
            this.gbCarrera.ResumeLayout(false);
            this.gbCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCarrera;
        private System.Windows.Forms.DateTimePicker dtpFechaModi;
        private System.Windows.Forms.DataGridView dtca;
        private System.Windows.Forms.TextBox txtcnueva;
        private System.Windows.Forms.TextBox txtmodi;
        private System.Windows.Forms.DataGridView dgvCarrera;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModificarCarrera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbTodas;
        public System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}