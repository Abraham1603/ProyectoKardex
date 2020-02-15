namespace PlayerUI
{
    partial class FrmConsultaPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaPeriodo));
            this.gbConsultaPeriodo = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsultaPeriodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtaPeriodo = new System.Windows.Forms.DataGridView();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.cbTodas = new System.Windows.Forms.CheckBox();
            this.gbConsultaPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsultaPeriodo
            // 
            this.gbConsultaPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.gbConsultaPeriodo.Controls.Add(this.btnRegresar);
            this.gbConsultaPeriodo.Controls.Add(this.pictureBox1);
            this.gbConsultaPeriodo.Controls.Add(this.label6);
            this.gbConsultaPeriodo.Controls.Add(this.btnConsultaPeriodo);
            this.gbConsultaPeriodo.Controls.Add(this.label2);
            this.gbConsultaPeriodo.Controls.Add(this.dtaPeriodo);
            this.gbConsultaPeriodo.Controls.Add(this.txtPeriodo);
            this.gbConsultaPeriodo.Controls.Add(this.cbTodas);
            this.gbConsultaPeriodo.Location = new System.Drawing.Point(0, 0);
            this.gbConsultaPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsultaPeriodo.Name = "gbConsultaPeriodo";
            this.gbConsultaPeriodo.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsultaPeriodo.Size = new System.Drawing.Size(934, 511);
            this.gbConsultaPeriodo.TabIndex = 3;
            this.gbConsultaPeriodo.TabStop = false;
            this.gbConsultaPeriodo.Enter += new System.EventHandler(this.gbConsultaPeriodo_Enter);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(779, 403);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(119, 48);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(646, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 180);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(255, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(415, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "CONSULTAR PERIODO";
            // 
            // btnConsultaPeriodo
            // 
            this.btnConsultaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPeriodo.Location = new System.Drawing.Point(635, 403);
            this.btnConsultaPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaPeriodo.Name = "btnConsultaPeriodo";
            this.btnConsultaPeriodo.Size = new System.Drawing.Size(120, 48);
            this.btnConsultaPeriodo.TabIndex = 3;
            this.btnConsultaPeriodo.Text = "Consulta";
            this.btnConsultaPeriodo.UseVisualStyleBackColor = true;
            this.btnConsultaPeriodo.Click += new System.EventHandler(this.btnConsultaPeriodo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(108, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Periodo:";
            // 
            // dtaPeriodo
            // 
            this.dtaPeriodo.AllowUserToAddRows = false;
            this.dtaPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaPeriodo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtaPeriodo.Location = new System.Drawing.Point(29, 111);
            this.dtaPeriodo.Name = "dtaPeriodo";
            this.dtaPeriodo.Size = new System.Drawing.Size(562, 362);
            this.dtaPeriodo.TabIndex = 0;
            this.dtaPeriodo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaPeriodo_CellContentDoubleClick);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.Location = new System.Drawing.Point(213, 69);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(185, 31);
            this.txtPeriodo.TabIndex = 1;
            this.txtPeriodo.TextChanged += new System.EventHandler(this.txtPeriodo_TextChanged);
            this.txtPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodo_KeyPress);
            // 
            // cbTodas
            // 
            this.cbTodas.AutoSize = true;
            this.cbTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbTodas.Location = new System.Drawing.Point(437, 71);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.Size = new System.Drawing.Size(91, 29);
            this.cbTodas.TabIndex = 2;
            this.cbTodas.Text = "Todas";
            this.cbTodas.UseVisualStyleBackColor = true;
            this.cbTodas.CheckedChanged += new System.EventHandler(this.cbTodas_CheckedChanged);
            // 
            // FrmConsultaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 510);
            this.Controls.Add(this.gbConsultaPeriodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaPeriodo";
            this.gbConsultaPeriodo.ResumeLayout(false);
            this.gbConsultaPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaPeriodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsultaPeriodo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsultaPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtaPeriodo;
        public System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.CheckBox cbTodas;
    }
}