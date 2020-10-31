namespace Tarea_5_JorgeMadrid.Formularios
{
    partial class FrmCalcular_la_Cantidad_de_Litros_de_Agua
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
            this.TxtLargo = new System.Windows.Forms.TextBox();
            this.TxtAlto = new System.Windows.Forms.TextBox();
            this.TxtAncho = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(124, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular los Litros de Agua Necesario Para un Tanque:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar el Largo del Tanque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar el Alto del Tanque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresar el Ancho del Tanque:";
            // 
            // TxtLargo
            // 
            this.TxtLargo.Location = new System.Drawing.Point(322, 126);
            this.TxtLargo.Name = "TxtLargo";
            this.TxtLargo.Size = new System.Drawing.Size(115, 27);
            this.TxtLargo.TabIndex = 4;
            this.TxtLargo.TextChanged += new System.EventHandler(this.TxtLargo_TextChanged);
            // 
            // TxtAlto
            // 
            this.TxtAlto.Location = new System.Drawing.Point(322, 177);
            this.TxtAlto.Name = "TxtAlto";
            this.TxtAlto.Size = new System.Drawing.Size(115, 27);
            this.TxtAlto.TabIndex = 5;
            this.TxtAlto.TextChanged += new System.EventHandler(this.TxtAlto_TextChanged);
            // 
            // TxtAncho
            // 
            this.TxtAncho.Location = new System.Drawing.Point(322, 232);
            this.TxtAncho.Name = "TxtAncho";
            this.TxtAncho.Size = new System.Drawing.Size(115, 27);
            this.TxtAncho.TabIndex = 6;
            this.TxtAncho.TextChanged += new System.EventHandler(this.TxtAncho_TextChanged);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.Silver;
            this.BtnCalcular.Location = new System.Drawing.Point(109, 271);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(131, 43);
            this.BtnCalcular.TabIndex = 7;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.Color.White;
            this.TxtResultado.Location = new System.Drawing.Point(384, 332);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(131, 27);
            this.TxtResultado.TabIndex = 9;
            this.TxtResultado.TextChanged += new System.EventHandler(this.TxtResultado_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Los Litros Que Caben en un Tanque son:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.BtnLimpiar.Location = new System.Drawing.Point(384, 377);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(131, 43);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmCalcular_la_Cantidad_de_Litros_de_Agua
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(527, 432);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtAncho);
            this.Controls.Add(this.TxtAlto);
            this.Controls.Add(this.TxtLargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_la_Cantidad_de_Litros_de_Agua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantidad de Litros de Agua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtLargo;
        private System.Windows.Forms.TextBox TxtAlto;
        private System.Windows.Forms.TextBox TxtAncho;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}