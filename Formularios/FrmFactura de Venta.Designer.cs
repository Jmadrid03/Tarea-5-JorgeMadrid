namespace Tarea_5_JorgeMadrid.Formularios
{
    partial class FrmFactura_de_Venta
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
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtPrecioU = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.DgvFactura = new System.Windows.Forms.DataGridView();
            this.DcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcPrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSubT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtImpto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTotalP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura del Comercial Madrid";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción del Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Unitario:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(106, 92);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(125, 27);
            this.TxtCodigo.TabIndex = 5;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(237, 133);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(245, 27);
            this.TxtProducto.TabIndex = 6;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(217, 176);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(125, 27);
            this.TxtCantidad.TabIndex = 7;
            this.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCantidad.TextChanged += new System.EventHandler(this.TxtCantidad_TextChanged);
            // 
            // TxtPrecioU
            // 
            this.TxtPrecioU.Location = new System.Drawing.Point(217, 218);
            this.TxtPrecioU.Name = "TxtPrecioU";
            this.TxtPrecioU.Size = new System.Drawing.Size(125, 27);
            this.TxtPrecioU.TabIndex = 8;
            this.TxtPrecioU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPrecioU.TextChanged += new System.EventHandler(this.TxtPrecioU_TextChanged);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.LightGray;
            this.BtnAgregar.Location = new System.Drawing.Point(364, 166);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(118, 40);
            this.BtnAgregar.TabIndex = 9;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightGray;
            this.BtnLimpiar.Location = new System.Drawing.Point(506, 193);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(110, 40);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // DgvFactura
            // 
            this.DgvFactura.AllowUserToAddRows = false;
            this.DgvFactura.AllowUserToDeleteRows = false;
            this.DgvFactura.AllowUserToResizeColumns = false;
            this.DgvFactura.AllowUserToResizeRows = false;
            this.DgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcCodigo,
            this.DcDescripcion,
            this.DcCantidad,
            this.DcPrecioU,
            this.DcMonto});
            this.DgvFactura.Location = new System.Drawing.Point(12, 284);
            this.DgvFactura.Name = "DgvFactura";
            this.DgvFactura.Size = new System.Drawing.Size(606, 150);
            this.DgvFactura.TabIndex = 11;
            // 
            // DcCodigo
            // 
            this.DcCodigo.HeaderText = "Código";
            this.DcCodigo.Name = "DcCodigo";
            this.DcCodigo.Width = 80;
            // 
            // DcDescripcion
            // 
            this.DcDescripcion.HeaderText = "Descripción";
            this.DcDescripcion.Name = "DcDescripcion";
            this.DcDescripcion.Width = 200;
            // 
            // DcCantidad
            // 
            this.DcCantidad.HeaderText = "Cantidad";
            this.DcCantidad.Name = "DcCantidad";
            // 
            // DcPrecioU
            // 
            this.DcPrecioU.HeaderText = "Precio Unitario";
            this.DcPrecioU.Name = "DcPrecioU";
            // 
            // DcMonto
            // 
            this.DcMonto.HeaderText = "Monto";
            this.DcMonto.Name = "DcMonto";
            this.DcMonto.Width = 80;
            // 
            // TxtSubT
            // 
            this.TxtSubT.Location = new System.Drawing.Point(520, 446);
            this.TxtSubT.Name = "TxtSubT";
            this.TxtSubT.Size = new System.Drawing.Size(98, 27);
            this.TxtSubT.TabIndex = 13;
            this.TxtSubT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "El Sub-Total es:";
            // 
            // TxtImpto
            // 
            this.TxtImpto.Location = new System.Drawing.Point(520, 478);
            this.TxtImpto.Name = "TxtImpto";
            this.TxtImpto.Size = new System.Drawing.Size(98, 27);
            this.TxtImpto.TabIndex = 15;
            this.TxtImpto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "El Impuesto S/V es:";
            // 
            // TxtTotalP
            // 
            this.TxtTotalP.Location = new System.Drawing.Point(520, 509);
            this.TxtTotalP.Name = "TxtTotalP";
            this.TxtTotalP.Size = new System.Drawing.Size(98, 27);
            this.TxtTotalP.TabIndex = 17;
            this.TxtTotalP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "El Total A Pagar es:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.LightGray;
            this.BtnCalcular.Location = new System.Drawing.Point(364, 218);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(118, 40);
            this.BtnCalcular.TabIndex = 18;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // FrmFactura_de_Venta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(633, 544);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtTotalP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtImpto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSubT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DgvFactura);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtPrecioU);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFactura_de_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtPrecioU;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridView DgvFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcPrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcMonto;
        private System.Windows.Forms.TextBox TxtSubT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtImpto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTotalP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCalcular;
    }
}