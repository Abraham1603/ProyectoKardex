namespace PlayerUI
{
    partial class FrmConsultaMaestro
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
            this.gbConsultaMaestro = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsultaPeriodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtaMaestro = new System.Windows.Forms.DataGridView();
            this.txtmaestro = new System.Windows.Forms.TextBox();
            this.cbTodas = new System.Windows.Forms.CheckBox();
            this.gbConsultaMaestro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaMaestro)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsultaMaestro
            // 
            this.gbConsultaMaestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.gbConsultaMaestro.Controls.Add(this.btnRegresar);
            this.gbConsultaMaestro.Controls.Add(this.label6);
            this.gbConsultaMaestro.Controls.Add(this.btnConsultaPeriodo);
            this.gbConsultaMaestro.Controls.Add(this.label2);
            this.gbConsultaMaestro.Controls.Add(this.dtaMaestro);
            this.gbConsultaMaestro.Controls.Add(this.txtmaestro);
            this.gbConsultaMaestro.Controls.Add(this.cbTodas);
            this.gbConsultaMaestro.Location = new System.Drawing.Point(1, 1);
            this.gbConsultaMaestro.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsultaMaestro.Name = "gbConsultaMaestro";
            this.gbConsultaMaestro.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsultaMaestro.Size = new System.Drawing.Size(805, 425);
            this.gbConsultaMaestro.TabIndex = 4;
            this.gbConsultaMaestro.TabStop = false;
            this.gbConsultaMaestro.Enter += new System.EventHandler(this.gbConsultaMaestro_Enter);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(627, 54);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 40);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(231, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "CONSULTAR MAESTRO";
            // 
            // btnConsultaPeriodo
            // 
            this.btnConsultaPeriodo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPeriodo.Location = new System.Drawing.Point(490, 54);
            this.btnConsultaPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaPeriodo.Name = "btnConsultaPeriodo";
            this.btnConsultaPeriodo.Size = new System.Drawing.Size(117, 40);
            this.btnConsultaPeriodo.TabIndex = 3;
            this.btnConsultaPeriodo.Text = "Consulta";
            this.btnConsultaPeriodo.UseVisualStyleBackColor = true;
            this.btnConsultaPeriodo.Click += new System.EventHandler(this.btnConsultaPeriodo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "MAESTRO:";
            // 
            // dtaMaestro
            // 
            this.dtaMaestro.AllowUserToAddRows = false;
            this.dtaMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaMaestro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtaMaestro.Location = new System.Drawing.Point(29, 111);
            this.dtaMaestro.Name = "dtaMaestro";
            this.dtaMaestro.Size = new System.Drawing.Size(714, 289);
            this.dtaMaestro.TabIndex = 0;
            this.dtaMaestro.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaMaestro_CellContentDoubleClick);
            // 
            // txtmaestro
            // 
            this.txtmaestro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaestro.Location = new System.Drawing.Point(144, 60);
            this.txtmaestro.Margin = new System.Windows.Forms.Padding(2);
            this.txtmaestro.Name = "txtmaestro";
            this.txtmaestro.Size = new System.Drawing.Size(236, 33);
            this.txtmaestro.TabIndex = 1;
            this.txtmaestro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodo_KeyPress);
            // 
            // cbTodas
            // 
            this.cbTodas.AutoSize = true;
            this.cbTodas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbTodas.Location = new System.Drawing.Point(393, 65);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.Size = new System.Drawing.Size(90, 29);
            this.cbTodas.TabIndex = 4;
            this.cbTodas.Text = "Todas";
            this.cbTodas.UseVisualStyleBackColor = true;
            this.cbTodas.CheckedChanged += new System.EventHandler(this.cbTodas_CheckedChanged);
            // 
            // FrmConsultaMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 413);
            this.Controls.Add(this.gbConsultaMaestro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaMaestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaMaestro";
            this.gbConsultaMaestro.ResumeLayout(false);
            this.gbConsultaMaestro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaMaestro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsultaMaestro;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsultaPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtaMaestro;
        public System.Windows.Forms.TextBox txtmaestro;
        private System.Windows.Forms.CheckBox cbTodas;
    }
}