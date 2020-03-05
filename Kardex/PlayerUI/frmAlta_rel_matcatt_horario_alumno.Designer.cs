namespace PlayerUI
{
    partial class frmAlta_rel_matcatt_horario_alumno
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
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbalumno = new System.Windows.Forms.ComboBox();
            this.cbmatcarr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtalumno = new System.Windows.Forms.DataGridView();
            this.dtmatcarr = new System.Windows.Forms.DataGridView();
            this.dtvalida2 = new System.Windows.Forms.DataGridView();
            this.dtca2 = new System.Windows.Forms.DataGridView();
            this.dtca = new System.Windows.Forms.DataGridView();
            this.dtcaadmin = new System.Windows.Forms.DataGridView();
            this.dtcgrupo = new System.Windows.Forms.DataGridView();
            this.dtcgrupo2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtalumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmatcarr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvalida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtca2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcaadmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcgrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcgrupo2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(226, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(486, 31);
            this.label7.TabIndex = 49;
            this.label7.Text = "Alta Materia Carrera Horario Alumno";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 218);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(568, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 46);
            this.button2.TabIndex = 47;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(472, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 46);
            this.button1.TabIndex = 46;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbalumno
            // 
            this.cbalumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbalumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbalumno.FormattingEnabled = true;
            this.cbalumno.Location = new System.Drawing.Point(198, 185);
            this.cbalumno.Name = "cbalumno";
            this.cbalumno.Size = new System.Drawing.Size(420, 33);
            this.cbalumno.TabIndex = 43;
            // 
            // cbmatcarr
            // 
            this.cbmatcarr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmatcarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbmatcarr.FormattingEnabled = true;
            this.cbmatcarr.Location = new System.Drawing.Point(198, 118);
            this.cbmatcarr.Name = "cbmatcarr";
            this.cbmatcarr.Size = new System.Drawing.Size(702, 33);
            this.cbmatcarr.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(76, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Alumno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Materia-Carrera";
            // 
            // dtalumno
            // 
            this.dtalumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtalumno.Location = new System.Drawing.Point(50, 370);
            this.dtalumno.Name = "dtalumno";
            this.dtalumno.Size = new System.Drawing.Size(10, 16);
            this.dtalumno.TabIndex = 51;
            this.dtalumno.Visible = false;
            // 
            // dtmatcarr
            // 
            this.dtmatcarr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtmatcarr.Location = new System.Drawing.Point(34, 370);
            this.dtmatcarr.Name = "dtmatcarr";
            this.dtmatcarr.Size = new System.Drawing.Size(10, 16);
            this.dtmatcarr.TabIndex = 50;
            this.dtmatcarr.Visible = false;
            // 
            // dtvalida2
            // 
            this.dtvalida2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvalida2.Location = new System.Drawing.Point(50, 392);
            this.dtvalida2.Name = "dtvalida2";
            this.dtvalida2.Size = new System.Drawing.Size(832, 128);
            this.dtvalida2.TabIndex = 52;
            // 
            // dtca2
            // 
            this.dtca2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtca2.Location = new System.Drawing.Point(581, 358);
            this.dtca2.Name = "dtca2";
            this.dtca2.Size = new System.Drawing.Size(332, 99);
            this.dtca2.TabIndex = 77;
            // 
            // dtca
            // 
            this.dtca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtca.Location = new System.Drawing.Point(682, 325);
            this.dtca.Name = "dtca";
            this.dtca.Size = new System.Drawing.Size(57, 61);
            this.dtca.TabIndex = 76;
            this.dtca.Visible = false;
            // 
            // dtcaadmin
            // 
            this.dtcaadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcaadmin.Location = new System.Drawing.Point(187, 306);
            this.dtcaadmin.Name = "dtcaadmin";
            this.dtcaadmin.Size = new System.Drawing.Size(178, 76);
            this.dtcaadmin.TabIndex = 78;
            this.dtcaadmin.Visible = false;
            // 
            // dtcgrupo
            // 
            this.dtcgrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcgrupo.Location = new System.Drawing.Point(691, 198);
            this.dtcgrupo.Name = "dtcgrupo";
            this.dtcgrupo.Size = new System.Drawing.Size(63, 61);
            this.dtcgrupo.TabIndex = 79;
            this.dtcgrupo.Visible = false;
            // 
            // dtcgrupo2
            // 
            this.dtcgrupo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcgrupo2.Location = new System.Drawing.Point(780, 198);
            this.dtcgrupo2.Name = "dtcgrupo2";
            this.dtcgrupo2.Size = new System.Drawing.Size(63, 61);
            this.dtcgrupo2.TabIndex = 80;
            this.dtcgrupo2.Visible = false;
            // 
            // frmAlta_rel_matcatt_horario_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(925, 566);
            this.Controls.Add(this.dtcgrupo2);
            this.Controls.Add(this.dtcgrupo);
            this.Controls.Add(this.dtcaadmin);
            this.Controls.Add(this.dtca2);
            this.Controls.Add(this.dtca);
            this.Controls.Add(this.dtvalida2);
            this.Controls.Add(this.dtalumno);
            this.Controls.Add(this.dtmatcarr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbalumno);
            this.Controls.Add(this.cbmatcarr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlta_rel_matcatt_horario_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlta_rel_matcatt_horario_alumno";
            this.Load += new System.EventHandler(this.frmAlta_rel_matcatt_horario_alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtalumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmatcarr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvalida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtca2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcaadmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcgrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcgrupo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbalumno;
        private System.Windows.Forms.ComboBox cbmatcarr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtalumno;
        private System.Windows.Forms.DataGridView dtmatcarr;
        private System.Windows.Forms.DataGridView dtvalida2;
        private System.Windows.Forms.DataGridView dtca2;
        private System.Windows.Forms.DataGridView dtca;
        private System.Windows.Forms.DataGridView dtcaadmin;
        private System.Windows.Forms.DataGridView dtcgrupo;
        private System.Windows.Forms.DataGridView dtcgrupo2;
    }
}