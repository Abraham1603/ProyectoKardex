namespace PlayerUI
{
    partial class frmmodificarmc
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
            this.gbCarrera = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtcarrera = new System.Windows.Forms.DataGridView();
            this.dtmateria = new System.Windows.Forms.DataGridView();
            this.cbmateria = new System.Windows.Forms.ComboBox();
            this.cbcarreras = new System.Windows.Forms.ComboBox();
            this.dtllenadoma = new System.Windows.Forms.DataGridView();
            this.dtllenadoca = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtcar = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.dtca = new System.Windows.Forms.DataGridView();
            this.dgvrmc = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.cbTodas = new System.Windows.Forms.CheckBox();
            this.txtrmc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtcarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtllenadoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtllenadoca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrmc)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCarrera
            // 
            this.gbCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.gbCarrera.Controls.Add(this.label4);
            this.gbCarrera.Controls.Add(this.label3);
            this.gbCarrera.Controls.Add(this.label2);
            this.gbCarrera.Controls.Add(this.dtcarrera);
            this.gbCarrera.Controls.Add(this.dtmateria);
            this.gbCarrera.Controls.Add(this.cbmateria);
            this.gbCarrera.Controls.Add(this.cbcarreras);
            this.gbCarrera.Controls.Add(this.dtllenadoma);
            this.gbCarrera.Controls.Add(this.dtllenadoca);
            this.gbCarrera.Controls.Add(this.txtid);
            this.gbCarrera.Controls.Add(this.txtcar);
            this.gbCarrera.Controls.Add(this.txtma);
            this.gbCarrera.Controls.Add(this.dtca);
            this.gbCarrera.Controls.Add(this.dgvrmc);
            this.gbCarrera.Controls.Add(this.button2);
            this.gbCarrera.Controls.Add(this.button1);
            this.gbCarrera.Controls.Add(this.btnmodificar);
            this.gbCarrera.Controls.Add(this.cbTodas);
            this.gbCarrera.Controls.Add(this.txtrmc);
            this.gbCarrera.Controls.Add(this.label1);
            this.gbCarrera.Controls.Add(this.label6);
            this.gbCarrera.Location = new System.Drawing.Point(12, 12);
            this.gbCarrera.Name = "gbCarrera";
            this.gbCarrera.Size = new System.Drawing.Size(954, 484);
            this.gbCarrera.TabIndex = 5;
            this.gbCarrera.TabStop = false;
            this.gbCarrera.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(791, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nuevas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(662, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Carrera:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(662, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Materia:";
            // 
            // dtcarrera
            // 
            this.dtcarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcarrera.Location = new System.Drawing.Point(64, 468);
            this.dtcarrera.Name = "dtcarrera";
            this.dtcarrera.Size = new System.Drawing.Size(10, 10);
            this.dtcarrera.TabIndex = 32;
            this.dtcarrera.Visible = false;
            // 
            // dtmateria
            // 
            this.dtmateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtmateria.Location = new System.Drawing.Point(48, 468);
            this.dtmateria.Name = "dtmateria";
            this.dtmateria.Size = new System.Drawing.Size(10, 10);
            this.dtmateria.TabIndex = 31;
            this.dtmateria.Visible = false;
            // 
            // cbmateria
            // 
            this.cbmateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmateria.FormattingEnabled = true;
            this.cbmateria.Location = new System.Drawing.Point(751, 351);
            this.cbmateria.Name = "cbmateria";
            this.cbmateria.Size = new System.Drawing.Size(173, 33);
            this.cbmateria.TabIndex = 30;
            // 
            // cbcarreras
            // 
            this.cbcarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcarreras.FormattingEnabled = true;
            this.cbcarreras.Location = new System.Drawing.Point(751, 312);
            this.cbcarreras.Name = "cbcarreras";
            this.cbcarreras.Size = new System.Drawing.Size(173, 33);
            this.cbcarreras.TabIndex = 29;
            // 
            // dtllenadoma
            // 
            this.dtllenadoma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtllenadoma.Location = new System.Drawing.Point(32, 468);
            this.dtllenadoma.Name = "dtllenadoma";
            this.dtllenadoma.Size = new System.Drawing.Size(10, 10);
            this.dtllenadoma.TabIndex = 28;
            this.dtllenadoma.Visible = false;
            // 
            // dtllenadoca
            // 
            this.dtllenadoca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtllenadoca.Location = new System.Drawing.Point(16, 468);
            this.dtllenadoca.Name = "dtllenadoca";
            this.dtllenadoca.Size = new System.Drawing.Size(10, 10);
            this.dtllenadoca.TabIndex = 26;
            this.dtllenadoca.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(725, 158);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 31);
            this.txtid.TabIndex = 25;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtid.Visible = false;
            // 
            // txtcar
            // 
            this.txtcar.Enabled = false;
            this.txtcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcar.Location = new System.Drawing.Point(751, 241);
            this.txtcar.Name = "txtcar";
            this.txtcar.Size = new System.Drawing.Size(173, 31);
            this.txtcar.TabIndex = 24;
            this.txtcar.TextChanged += new System.EventHandler(this.txtcar_TextChanged);
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(751, 204);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(173, 31);
            this.txtma.TabIndex = 23;
            // 
            // dtca
            // 
            this.dtca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtca.Location = new System.Drawing.Point(98, 468);
            this.dtca.Name = "dtca";
            this.dtca.Size = new System.Drawing.Size(10, 10);
            this.dtca.TabIndex = 22;
            this.dtca.Visible = false;
            // 
            // dgvrmc
            // 
            this.dgvrmc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrmc.Location = new System.Drawing.Point(16, 144);
            this.dgvrmc.Name = "dgvrmc";
            this.dgvrmc.Size = new System.Drawing.Size(641, 318);
            this.dgvrmc.TabIndex = 19;
            this.dgvrmc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrmc_CellContentDoubleClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(808, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(577, 93);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(689, 401);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(114, 31);
            this.btnmodificar.TabIndex = 13;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // cbTodas
            // 
            this.cbTodas.AutoSize = true;
            this.cbTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbTodas.Location = new System.Drawing.Point(471, 93);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.Size = new System.Drawing.Size(101, 33);
            this.cbTodas.TabIndex = 9;
            this.cbTodas.Text = "Todas";
            this.cbTodas.UseVisualStyleBackColor = true;
            this.cbTodas.CheckedChanged += new System.EventHandler(this.cbTodas_CheckedChanged);
            // 
            // txtrmc
            // 
            this.txtrmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrmc.Location = new System.Drawing.Point(228, 91);
            this.txtrmc.Margin = new System.Windows.Forms.Padding(2);
            this.txtrmc.Name = "txtrmc";
            this.txtrmc.Size = new System.Drawing.Size(223, 35);
            this.txtrmc.TabIndex = 8;
            this.txtrmc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrmc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Materia o Carrera:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(136, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(636, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "MODIFICAR RELACION MATERIA - CARRERA";
            // 
            // frmmodificarmc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(990, 507);
            this.Controls.Add(this.gbCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmmodificarmc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmodificarmc";
            this.Load += new System.EventHandler(this.frmmodificarmc_Load);
            this.gbCarrera.ResumeLayout(false);
            this.gbCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtcarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtllenadoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtllenadoca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrmc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCarrera;
        private System.Windows.Forms.DataGridView dtcarrera;
        private System.Windows.Forms.DataGridView dtmateria;
        private System.Windows.Forms.ComboBox cbmateria;
        private System.Windows.Forms.ComboBox cbcarreras;
        private System.Windows.Forms.DataGridView dtllenadoma;
        private System.Windows.Forms.DataGridView dtllenadoca;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtcar;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.DataGridView dtca;
        private System.Windows.Forms.DataGridView dgvrmc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.CheckBox cbTodas;
        public System.Windows.Forms.TextBox txtrmc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}