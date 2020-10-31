namespace Tarea_5_JorgeMadrid.Formularios
{
    partial class FrmCalcular_el_Promedio_de_Estudiante_si_Aprobo_o_Reprobo
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
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtNota2 = new System.Windows.Forms.TextBox();
            this.TxtNota1 = new System.Windows.Forms.TextBox();
            this.TxtNombreE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNota3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNota4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvDatosE = new System.Windows.Forms.DataGridView();
            this.DcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtPromedioE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtAprobado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtReprobado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosE)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(1, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "DATOS REGISTRADOS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Silver;
            this.BtnAgregar.Location = new System.Drawing.Point(389, 254);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(123, 35);
            this.BtnAgregar.TabIndex = 25;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtNota2
            // 
            this.TxtNota2.Location = new System.Drawing.Point(229, 201);
            this.TxtNota2.Name = "TxtNota2";
            this.TxtNota2.Size = new System.Drawing.Size(128, 27);
            this.TxtNota2.TabIndex = 23;
            this.TxtNota2.TextChanged += new System.EventHandler(this.TxtNota2_TextChanged);
            // 
            // TxtNota1
            // 
            this.TxtNota1.Location = new System.Drawing.Point(229, 156);
            this.TxtNota1.Name = "TxtNota1";
            this.TxtNota1.Size = new System.Drawing.Size(128, 27);
            this.TxtNota1.TabIndex = 22;
            this.TxtNota1.TextChanged += new System.EventHandler(this.TxtNota1_TextChanged);
            // 
            // TxtNombreE
            // 
            this.TxtNombreE.Location = new System.Drawing.Point(229, 111);
            this.TxtNombreE.Name = "TxtNombreE";
            this.TxtNombreE.Size = new System.Drawing.Size(283, 27);
            this.TxtNombreE.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ingresar la Nota 2: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ingresar la Nota 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre del Estudiante:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(1, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Calcular Las Ventas de un Vendedor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtNota3
            // 
            this.TxtNota3.Location = new System.Drawing.Point(229, 243);
            this.TxtNota3.Name = "TxtNota3";
            this.TxtNota3.Size = new System.Drawing.Size(128, 27);
            this.TxtNota3.TabIndex = 29;
            this.TxtNota3.TextChanged += new System.EventHandler(this.TxtNota3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ingresar la Nota 3: ";
            // 
            // TxtNota4
            // 
            this.TxtNota4.Location = new System.Drawing.Point(229, 290);
            this.TxtNota4.Name = "TxtNota4";
            this.TxtNota4.Size = new System.Drawing.Size(128, 27);
            this.TxtNota4.TabIndex = 31;
            this.TxtNota4.TextChanged += new System.EventHandler(this.TxtNota4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ingresar la Nota 4: ";
            // 
            // DgvDatosE
            // 
            this.DgvDatosE.AllowUserToAddRows = false;
            this.DgvDatosE.AllowUserToDeleteRows = false;
            this.DgvDatosE.AllowUserToResizeColumns = false;
            this.DgvDatosE.AllowUserToResizeRows = false;
            this.DgvDatosE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvDatosE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatosE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcNombre,
            this.DcNota1,
            this.DcNota2,
            this.DcNota3,
            this.DcNota4,
            this.DcPromedio});
            this.DgvDatosE.Location = new System.Drawing.Point(12, 433);
            this.DgvDatosE.Name = "DgvDatosE";
            this.DgvDatosE.Size = new System.Drawing.Size(735, 158);
            this.DgvDatosE.TabIndex = 32;
            // 
            // DcNombre
            // 
            this.DcNombre.HeaderText = "Nombre Del Estudiante";
            this.DcNombre.Name = "DcNombre";
            this.DcNombre.Width = 230;
            // 
            // DcNota1
            // 
            this.DcNota1.HeaderText = "Nota 1";
            this.DcNota1.Name = "DcNota1";
            this.DcNota1.Width = 90;
            // 
            // DcNota2
            // 
            this.DcNota2.HeaderText = "Nota 2";
            this.DcNota2.Name = "DcNota2";
            this.DcNota2.Width = 90;
            // 
            // DcNota3
            // 
            this.DcNota3.HeaderText = "Nota 3";
            this.DcNota3.Name = "DcNota3";
            this.DcNota3.Width = 90;
            // 
            // DcNota4
            // 
            this.DcNota4.HeaderText = "Nota 4";
            this.DcNota4.Name = "DcNota4";
            this.DcNota4.Width = 90;
            // 
            // DcPromedio
            // 
            this.DcPromedio.HeaderText = "Promedio";
            this.DcPromedio.Name = "DcPromedio";
            // 
            // TxtPromedioE
            // 
            this.TxtPromedioE.Location = new System.Drawing.Point(292, 333);
            this.TxtPromedioE.Name = "TxtPromedioE";
            this.TxtPromedioE.Size = new System.Drawing.Size(128, 27);
            this.TxtPromedioE.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "El Promedio del Estudiante es:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.Silver;
            this.BtnCalcular.Location = new System.Drawing.Point(389, 188);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(123, 35);
            this.BtnCalcular.TabIndex = 35;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtAprobado
            // 
            this.TxtAprobado.Location = new System.Drawing.Point(423, 616);
            this.TxtAprobado.Name = "TxtAprobado";
            this.TxtAprobado.Size = new System.Drawing.Size(128, 27);
            this.TxtAprobado.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 619);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(377, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "La Cantidad de Estudiantes Aprobados son:";
            // 
            // TxtReprobado
            // 
            this.TxtReprobado.Location = new System.Drawing.Point(423, 651);
            this.TxtReprobado.Name = "TxtReprobado";
            this.TxtReprobado.Size = new System.Drawing.Size(128, 27);
            this.TxtReprobado.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 654);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(387, 19);
            this.label10.TabIndex = 38;
            this.label10.Text = "La Cantidad de Estudiantes Reprobados son:";
            // 
            // FrmCalcular_el_Promedio_de_Estudiante_si_Aprobo_o_Reprobo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(763, 728);
            this.Controls.Add(this.TxtReprobado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtAprobado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtPromedioE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DgvDatosE);
            this.Controls.Add(this.TxtNota4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNota3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtNota2);
            this.Controls.Add(this.TxtNota1);
            this.Controls.Add(this.TxtNombreE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_el_Promedio_de_Estudiante_si_Aprobo_o_Reprobo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promedio de Estudiante si Aprobo o Reprobo";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtNota2;
        private System.Windows.Forms.TextBox TxtNota1;
        private System.Windows.Forms.TextBox TxtNombreE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNota3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNota4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvDatosE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcPromedio;
        private System.Windows.Forms.TextBox TxtPromedioE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtAprobado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtReprobado;
        private System.Windows.Forms.Label label10;
    }
}