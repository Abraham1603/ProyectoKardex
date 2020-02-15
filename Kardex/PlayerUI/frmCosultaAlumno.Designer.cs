namespace PlayerUI
{
    partial class frmCosultaAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCosultaAlumno));
            this.gbConsultaAlumno = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsultaPeriodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtaAlumnos = new System.Windows.Forms.DataGridView();
            this.txtAlumnos = new System.Windows.Forms.TextBox();
            this.cbTodos = new System.Windows.Forms.CheckBox();
            this.gbConsultaAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsultaAlumno
            // 
            this.gbConsultaAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.gbConsultaAlumno.Controls.Add(this.btnRegresar);
            this.gbConsultaAlumno.Controls.Add(this.pictureBox1);
            this.gbConsultaAlumno.Controls.Add(this.label6);
            this.gbConsultaAlumno.Controls.Add(this.btnConsultaPeriodo);
            this.gbConsultaAlumno.Controls.Add(this.label2);
            this.gbConsultaAlumno.Controls.Add(this.dtaAlumnos);
            this.gbConsultaAlumno.Controls.Add(this.txtAlumnos);
            this.gbConsultaAlumno.Controls.Add(this.cbTodos);
            this.gbConsultaAlumno.Location = new System.Drawing.Point(1, 1);
            this.gbConsultaAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsultaAlumno.Name = "gbConsultaAlumno";
            this.gbConsultaAlumno.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsultaAlumno.Size = new System.Drawing.Size(934, 510);
            this.gbConsultaAlumno.TabIndex = 5;
            this.gbConsultaAlumno.TabStop = false;
            this.gbConsultaAlumno.Enter += new System.EventHandler(this.gbConsultaAlumno_Enter);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(750, 363);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(111, 43);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(599, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 185);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(272, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 41);
            this.label6.TabIndex = 7;
            this.label6.Text = "CONSULTAR ALUMNOS";
            // 
            // btnConsultaPeriodo
            // 
            this.btnConsultaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPeriodo.Location = new System.Drawing.Point(621, 363);
            this.btnConsultaPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaPeriodo.Name = "btnConsultaPeriodo";
            this.btnConsultaPeriodo.Size = new System.Drawing.Size(112, 43);
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
            this.label2.Location = new System.Drawing.Point(57, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alumnos:";
            // 
            // dtaAlumnos
            // 
            this.dtaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaAlumnos.Location = new System.Drawing.Point(29, 153);
            this.dtaAlumnos.Name = "dtaAlumnos";
            this.dtaAlumnos.Size = new System.Drawing.Size(529, 344);
            this.dtaAlumnos.TabIndex = 0;
            // 
            // txtAlumnos
            // 
            this.txtAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlumnos.Location = new System.Drawing.Point(163, 108);
            this.txtAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlumnos.Name = "txtAlumnos";
            this.txtAlumnos.Size = new System.Drawing.Size(236, 31);
            this.txtAlumnos.TabIndex = 1;
            // 
            // cbTodos
            // 
            this.cbTodos.AutoSize = true;
            this.cbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbTodos.Location = new System.Drawing.Point(415, 111);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(91, 29);
            this.cbTodos.TabIndex = 4;
            this.cbTodos.Text = "Todas";
            this.cbTodos.UseVisualStyleBackColor = true;
            // 
            // frmCosultaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 510);
            this.Controls.Add(this.gbConsultaAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCosultaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCosultaAlumno";
            this.gbConsultaAlumno.ResumeLayout(false);
            this.gbConsultaAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsultaAlumno;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsultaPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtaAlumnos;
        public System.Windows.Forms.TextBox txtAlumnos;
        private System.Windows.Forms.CheckBox cbTodos;
    }
}