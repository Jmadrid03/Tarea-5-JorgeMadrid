namespace Tarea_5_JorgeMadrid.Formularios
{
    partial class FrmCalcular_el_Porcentaje_de_Ganancia_de_un_Producto
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
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.TxtVenta = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtPorcentaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(110, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular el Porcentaje de Ganancia de Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Precio de Costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar Precio de Venta:";
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(285, 117);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(112, 27);
            this.TxtCosto.TabIndex = 3;
            this.TxtCosto.TextChanged += new System.EventHandler(this.TxtCosto_TextChanged);
            // 
            // TxtVenta
            // 
            this.TxtVenta.Location = new System.Drawing.Point(285, 172);
            this.TxtVenta.Name = "TxtVenta";
            this.TxtVenta.Size = new System.Drawing.Size(112, 27);
            this.TxtVenta.TabIndex = 4;
            this.TxtVenta.TextChanged += new System.EventHandler(this.TxtVenta_TextChanged);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(126, 214);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(111, 39);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.BackColor = System.Drawing.Color.White;
            this.TxtPorcentaje.Location = new System.Drawing.Point(310, 271);
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.ReadOnly = true;
            this.TxtPorcentaje.Size = new System.Drawing.Size(112, 27);
            this.TxtPorcentaje.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "El Porcentaje de Ganancias es:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(341, 339);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(111, 39);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmCalcular_el_Porcentaje_de_Ganancia_de_un_Producto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(464, 390);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtPorcentaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtVenta);
            this.Controls.Add(this.TxtCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_el_Porcentaje_de_Ganancia_de_un_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porcentaje de Ganancia de un Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.TextBox TxtVenta;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtPorcentaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}