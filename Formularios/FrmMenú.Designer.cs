namespace Tarea_5_JorgeMadrid.Formularios
{
    partial class FrmMenú
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
            this.BtnPorcentajeGanancia = new System.Windows.Forms.Button();
            this.BtnLitrosTanque = new System.Windows.Forms.Button();
            this.BtnNotaE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-1, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELIJE UNA OPCIÓN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPorcentajeGanancia
            // 
            this.BtnPorcentajeGanancia.BackColor = System.Drawing.Color.LightGray;
            this.BtnPorcentajeGanancia.Location = new System.Drawing.Point(39, 113);
            this.BtnPorcentajeGanancia.Name = "BtnPorcentajeGanancia";
            this.BtnPorcentajeGanancia.Size = new System.Drawing.Size(185, 54);
            this.BtnPorcentajeGanancia.TabIndex = 1;
            this.BtnPorcentajeGanancia.Text = "Calcular Porcentaje de Ganancia";
            this.BtnPorcentajeGanancia.UseVisualStyleBackColor = false;
            this.BtnPorcentajeGanancia.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnLitrosTanque
            // 
            this.BtnLitrosTanque.BackColor = System.Drawing.Color.LightGray;
            this.BtnLitrosTanque.Location = new System.Drawing.Point(39, 189);
            this.BtnLitrosTanque.Name = "BtnLitrosTanque";
            this.BtnLitrosTanque.Size = new System.Drawing.Size(185, 54);
            this.BtnLitrosTanque.TabIndex = 2;
            this.BtnLitrosTanque.Text = "Cantidad de Litros de Agua ";
            this.BtnLitrosTanque.UseVisualStyleBackColor = false;
            this.BtnLitrosTanque.Click += new System.EventHandler(this.BtnLitrosTanque_Click);
            // 
            // BtnNotaE
            // 
            this.BtnNotaE.BackColor = System.Drawing.Color.LightGray;
            this.BtnNotaE.Location = new System.Drawing.Point(281, 113);
            this.BtnNotaE.Name = "BtnNotaE";
            this.BtnNotaE.Size = new System.Drawing.Size(185, 54);
            this.BtnNotaE.TabIndex = 3;
            this.BtnNotaE.Text = "Calcular Nota de Estudiante";
            this.BtnNotaE.UseVisualStyleBackColor = false;
            this.BtnNotaE.Click += new System.EventHandler(this.BtnNotaE_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(281, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Promedio de Estudiantes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(159, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "Factura Comercial";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMenú
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(511, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnNotaE);
            this.Controls.Add(this.BtnLitrosTanque);
            this.Controls.Add(this.BtnPorcentajeGanancia);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPorcentajeGanancia;
        private System.Windows.Forms.Button BtnLitrosTanque;
        private System.Windows.Forms.Button BtnNotaE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}