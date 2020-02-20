namespace PlayerUI
{
    partial class frmmodificacalificacion
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtal = new System.Windows.Forms.TextBox();
            this.dtcali = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModificarCarrera = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtcali)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCarrera
            // 
            this.gbCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.gbCarrera.Controls.Add(this.button1);
            this.gbCarrera.Controls.Add(this.cf);
            this.gbCarrera.Controls.Add(this.label7);
            this.gbCarrera.Controls.Add(this.p3);
            this.gbCarrera.Controls.Add(this.label5);
            this.gbCarrera.Controls.Add(this.p2);
            this.gbCarrera.Controls.Add(this.label4);
            this.gbCarrera.Controls.Add(this.p1);
            this.gbCarrera.Controls.Add(this.label3);
            this.gbCarrera.Controls.Add(this.txtid);
            this.gbCarrera.Controls.Add(this.label2);
            this.gbCarrera.Controls.Add(this.label1);
            this.gbCarrera.Controls.Add(this.txtal);
            this.gbCarrera.Controls.Add(this.dtcali);
            this.gbCarrera.Controls.Add(this.button2);
            this.gbCarrera.Controls.Add(this.btnModificarCarrera);
            this.gbCarrera.Controls.Add(this.label6);
            this.gbCarrera.Location = new System.Drawing.Point(12, 12);
            this.gbCarrera.Name = "gbCarrera";
            this.gbCarrera.Size = new System.Drawing.Size(1086, 601);
            this.gbCarrera.TabIndex = 5;
            this.gbCarrera.TabStop = false;
            this.gbCarrera.Text = " ";
            this.gbCarrera.Enter += new System.EventHandler(this.gbCarrera_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(628, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "ID";
            this.label3.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(678, 86);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(91, 31);
            this.txtid.TabIndex = 22;
            this.txtid.TabStop = false;
            this.txtid.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(590, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Parcial 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(590, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Alumno:";
            // 
            // txtal
            // 
            this.txtal.Enabled = false;
            this.txtal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtal.Location = new System.Drawing.Point(678, 132);
            this.txtal.Name = "txtal";
            this.txtal.Size = new System.Drawing.Size(402, 31);
            this.txtal.TabIndex = 0;
            this.txtal.TabStop = false;
            this.txtal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcali_KeyPress);
            // 
            // dtcali
            // 
            this.dtcali.AllowUserToAddRows = false;
            this.dtcali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcali.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtcali.Location = new System.Drawing.Point(16, 65);
            this.dtcali.Name = "dtcali";
            this.dtcali.Size = new System.Drawing.Size(522, 338);
            this.dtcali.TabIndex = 19;
            this.dtcali.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtcali_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(950, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificarCarrera
            // 
            this.btnModificarCarrera.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnModificarCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCarrera.Location = new System.Drawing.Point(632, 422);
            this.btnModificarCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCarrera.Name = "btnModificarCarrera";
            this.btnModificarCarrera.Size = new System.Drawing.Size(128, 44);
            this.btnModificarCarrera.TabIndex = 5;
            this.btnModificarCarrera.Text = "Modificar";
            this.btnModificarCarrera.UseVisualStyleBackColor = true;
            this.btnModificarCarrera.Click += new System.EventHandler(this.btnModificarCarrera_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(56, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "MODIFICAR CALIFICACION";
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(678, 214);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(306, 20);
            this.p1.TabIndex = 24;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(678, 261);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(306, 20);
            this.p2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(590, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Parcial 2:";
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(678, 306);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(306, 20);
            this.p3.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(590, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Parcial 3:";
            // 
            // cf
            // 
            this.cf.Enabled = false;
            this.cf.Location = new System.Drawing.Point(594, 370);
            this.cf.Name = "cf";
            this.cf.Size = new System.Drawing.Size(306, 20);
            this.cf.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(590, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Calificacion FInal:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 31;
            this.button1.Text = "Calcular Promedio FInal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmmodificacalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1120, 625);
            this.Controls.Add(this.gbCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmmodificacalificacion";
            this.Text = "frmmodificacalificacion";
            this.Load += new System.EventHandler(this.frmmodificacalificacion_Load);
            this.gbCarrera.ResumeLayout(false);
            this.gbCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtcali)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtal;
        private System.Windows.Forms.DataGridView dtcali;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificarCarrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox p3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox p1;
    }
}