namespace Tarea_5_JorgeMadrid.Formularios
{
    partial class FrmNota_de_Estudiante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtExamen1 = new System.Windows.Forms.TextBox();
            this.TxtExamen2 = new System.Windows.Forms.TextBox();
            this.TxtExamen3 = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAcumulativo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LsbNombreE = new System.Windows.Forms.ListBox();
            this.LsbNot1 = new System.Windows.Forms.ListBox();
            this.LsbNot2 = new System.Windows.Forms.ListBox();
            this.LsbNot3 = new System.Windows.Forms.ListBox();
            this.LsbAcumulativo = new System.Windows.Forms.ListBox();
            this.LsbCondicion = new System.Windows.Forms.ListBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESAR LOS DATOS DEL ESTUDIANTE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar la Nota del Primer Examen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar el Nombre del Estudiante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresar la Nota del Segundo Examen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingresar la Nota del Tercer Examen:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(417, 106);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(294, 27);
            this.TxtNombre.TabIndex = 5;
            // 
            // TxtExamen1
            // 
            this.TxtExamen1.Location = new System.Drawing.Point(417, 147);
            this.TxtExamen1.Name = "TxtExamen1";
            this.TxtExamen1.Size = new System.Drawing.Size(148, 27);
            this.TxtExamen1.TabIndex = 6;
            this.TxtExamen1.TextChanged += new System.EventHandler(this.TxtExamen1_TextChanged);
            // 
            // TxtExamen2
            // 
            this.TxtExamen2.Location = new System.Drawing.Point(417, 187);
            this.TxtExamen2.Name = "TxtExamen2";
            this.TxtExamen2.Size = new System.Drawing.Size(148, 27);
            this.TxtExamen2.TabIndex = 7;
            // 
            // TxtExamen3
            // 
            this.TxtExamen3.Location = new System.Drawing.Point(417, 232);
            this.TxtExamen3.Name = "TxtExamen3";
            this.TxtExamen3.Size = new System.Drawing.Size(148, 27);
            this.TxtExamen3.TabIndex = 8;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.LightGray;
            this.BtnCalcular.Location = new System.Drawing.Point(593, 170);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(137, 44);
            this.BtnCalcular.TabIndex = 9;
            this.BtnCalcular.Text = "AGREGAR";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(16, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "NOMBRE DEL ESTUDIANTE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(278, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 35);
            this.label7.TabIndex = 11;
            this.label7.Text = "NOTA 1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtAcumulativo
            // 
            this.TxtAcumulativo.Location = new System.Drawing.Point(418, 269);
            this.TxtAcumulativo.Name = "TxtAcumulativo";
            this.TxtAcumulativo.Size = new System.Drawing.Size(148, 27);
            this.TxtAcumulativo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ingresar la Nota Acumulativa:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(358, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 35);
            this.label9.TabIndex = 15;
            this.label9.Text = "NOTA 2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(438, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 35);
            this.label10.TabIndex = 16;
            this.label10.Text = "NOTA 3";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(518, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 35);
            this.label11.TabIndex = 17;
            this.label11.Text = "ACUMULATIVO";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(667, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 35);
            this.label12.TabIndex = 18;
            this.label12.Text = "OBSERVACION";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LsbNombreE
            // 
            this.LsbNombreE.FormattingEnabled = true;
            this.LsbNombreE.ItemHeight = 19;
            this.LsbNombreE.Location = new System.Drawing.Point(16, 371);
            this.LsbNombreE.Name = "LsbNombreE";
            this.LsbNombreE.Size = new System.Drawing.Size(259, 156);
            this.LsbNombreE.TabIndex = 19;
            // 
            // LsbNot1
            // 
            this.LsbNot1.FormattingEnabled = true;
            this.LsbNot1.ItemHeight = 19;
            this.LsbNot1.Location = new System.Drawing.Point(278, 371);
            this.LsbNot1.Name = "LsbNot1";
            this.LsbNot1.Size = new System.Drawing.Size(77, 156);
            this.LsbNot1.TabIndex = 20;
            // 
            // LsbNot2
            // 
            this.LsbNot2.FormattingEnabled = true;
            this.LsbNot2.ItemHeight = 19;
            this.LsbNot2.Location = new System.Drawing.Point(358, 371);
            this.LsbNot2.Name = "LsbNot2";
            this.LsbNot2.Size = new System.Drawing.Size(77, 156);
            this.LsbNot2.TabIndex = 21;
            // 
            // LsbNot3
            // 
            this.LsbNot3.FormattingEnabled = true;
            this.LsbNot3.ItemHeight = 19;
            this.LsbNot3.Location = new System.Drawing.Point(438, 371);
            this.LsbNot3.Name = "LsbNot3";
            this.LsbNot3.Size = new System.Drawing.Size(77, 156);
            this.LsbNot3.TabIndex = 22;
            // 
            // LsbAcumulativo
            // 
            this.LsbAcumulativo.FormattingEnabled = true;
            this.LsbAcumulativo.ItemHeight = 19;
            this.LsbAcumulativo.Location = new System.Drawing.Point(518, 371);
            this.LsbAcumulativo.Name = "LsbAcumulativo";
            this.LsbAcumulativo.Size = new System.Drawing.Size(146, 156);
            this.LsbAcumulativo.TabIndex = 23;
            // 
            // LsbCondicion
            // 
            this.LsbCondicion.FormattingEnabled = true;
            this.LsbCondicion.ItemHeight = 19;
            this.LsbCondicion.Location = new System.Drawing.Point(667, 371);
            this.LsbCondicion.Name = "LsbCondicion";
            this.LsbCondicion.Size = new System.Drawing.Size(146, 156);
            this.LsbCondicion.TabIndex = 24;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(593, 235);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(137, 44);
            this.BtnLimpiar.TabIndex = 25;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmNota_de_Estudiante
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(818, 539);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.LsbCondicion);
            this.Controls.Add(this.LsbAcumulativo);
            this.Controls.Add(this.LsbNot3);
            this.Controls.Add(this.LsbNot2);
            this.Controls.Add(this.LsbNot1);
            this.Controls.Add(this.LsbNombreE);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtAcumulativo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtExamen3);
            this.Controls.Add(this.TxtExamen2);
            this.Controls.Add(this.TxtExamen1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNota_de_Estudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota de Estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtExamen1;
        private System.Windows.Forms.TextBox TxtExamen2;
        private System.Windows.Forms.TextBox TxtExamen3;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAcumulativo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox LsbNombreE;
        private System.Windows.Forms.ListBox LsbNot1;
        private System.Windows.Forms.ListBox LsbNot2;
        private System.Windows.Forms.ListBox LsbNot3;
        private System.Windows.Forms.ListBox LsbAcumulativo;
        private System.Windows.Forms.ListBox LsbCondicion;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}