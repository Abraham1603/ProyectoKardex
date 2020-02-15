namespace PlayerUI
{
    partial class frmConsultaRelmatalum
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
            this.btnconsultarmc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvrma = new System.Windows.Forms.DataGridView();
            this.txtrma = new System.Windows.Forms.TextBox();
            this.cbTodas = new System.Windows.Forms.CheckBox();
            this.gbConsultaCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrma)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsultaCarrera
            // 
            this.gbConsultaCarrera.Controls.Add(this.button1);
            this.gbConsultaCarrera.Controls.Add(this.label6);
            this.gbConsultaCarrera.Controls.Add(this.btnconsultarmc);
            this.gbConsultaCarrera.Controls.Add(this.label2);
            this.gbConsultaCarrera.Controls.Add(this.dgvrma);
            this.gbConsultaCarrera.Controls.Add(this.txtrma);
            this.gbConsultaCarrera.Controls.Add(this.cbTodas);
            this.gbConsultaCarrera.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaCarrera.Location = new System.Drawing.Point(11, 11);
            this.gbConsultaCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsultaCarrera.Name = "gbConsultaCarrera";
            this.gbConsultaCarrera.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsultaCarrera.Size = new System.Drawing.Size(813, 484);
            this.gbConsultaCarrera.TabIndex = 6;
            this.gbConsultaCarrera.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(696, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(181, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(476, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "CONSULTAR MATERIA - ALUMNO\r\n";
            // 
            // btnconsultarmc
            // 
            this.btnconsultarmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultarmc.Location = new System.Drawing.Point(591, 112);
            this.btnconsultarmc.Margin = new System.Windows.Forms.Padding(2);
            this.btnconsultarmc.Name = "btnconsultarmc";
            this.btnconsultarmc.Size = new System.Drawing.Size(100, 41);
            this.btnconsultarmc.TabIndex = 3;
            this.btnconsultarmc.Text = "Consulta";
            this.btnconsultarmc.UseVisualStyleBackColor = true;
            this.btnconsultarmc.Click += new System.EventHandler(this.btnconsultarmc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Consulta:";
            // 
            // dgvrma
            // 
            this.dgvrma.AllowUserToAddRows = false;
            this.dgvrma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrma.Location = new System.Drawing.Point(19, 161);
            this.dgvrma.Name = "dgvrma";
            this.dgvrma.Size = new System.Drawing.Size(776, 305);
            this.dgvrma.TabIndex = 0;
            this.dgvrma.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrma_CellContentDoubleClick);
            // 
            // txtrma
            // 
            this.txtrma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrma.Location = new System.Drawing.Point(141, 116);
            this.txtrma.Margin = new System.Windows.Forms.Padding(2);
            this.txtrma.Name = "txtrma";
            this.txtrma.Size = new System.Drawing.Size(307, 31);
            this.txtrma.TabIndex = 1;
            this.txtrma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrma_KeyPress);
            // 
            // cbTodas
            // 
            this.cbTodas.AutoSize = true;
            this.cbTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbTodas.Location = new System.Drawing.Point(478, 119);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.Size = new System.Drawing.Size(87, 28);
            this.cbTodas.TabIndex = 4;
            this.cbTodas.Text = "Todas";
            this.cbTodas.UseVisualStyleBackColor = true;
            this.cbTodas.CheckedChanged += new System.EventHandler(this.cbTodas_CheckedChanged);
            // 
            // frmConsultaRelmatalum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(831, 505);
            this.Controls.Add(this.gbConsultaCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaRelmatalum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaRelmatalum";
            this.gbConsultaCarrera.ResumeLayout(false);
            this.gbConsultaCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsultaCarrera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnconsultarmc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvrma;
        public System.Windows.Forms.TextBox txtrma;
        private System.Windows.Forms.CheckBox cbTodas;
    }
}