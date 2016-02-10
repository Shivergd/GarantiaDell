namespace GarantiasDell
{
    partial class frm_main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_servisetag = new System.Windows.Forms.TextBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.lst_garantias = new System.Windows.Forms.ListView();
            this.Garantia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Termino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Restante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_region = new System.Windows.Forms.Label();
            this.lbl_fecha_compra = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_servisetag
            // 
            this.txt_servisetag.Location = new System.Drawing.Point(106, 6);
            this.txt_servisetag.MaxLength = 7;
            this.txt_servisetag.Name = "txt_servisetag";
            this.txt_servisetag.Size = new System.Drawing.Size(78, 22);
            this.txt_servisetag.TabIndex = 0;
            this.txt_servisetag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_servisetag_KeyPress);
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(489, 12);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(97, 56);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.Text = "Consultar";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst_garantias
            // 
            this.lst_garantias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Garantia,
            this.Estado,
            this.Inicio,
            this.Termino,
            this.Restante});
            this.lst_garantias.FullRowSelect = true;
            this.lst_garantias.GridLines = true;
            this.lst_garantias.Location = new System.Drawing.Point(15, 99);
            this.lst_garantias.Name = "lst_garantias";
            this.lst_garantias.Size = new System.Drawing.Size(579, 181);
            this.lst_garantias.TabIndex = 2;
            this.lst_garantias.TileSize = new System.Drawing.Size(228, 30);
            this.lst_garantias.UseCompatibleStateImageBehavior = false;
            this.lst_garantias.View = System.Windows.Forms.View.Details;
            // 
            // Garantia
            // 
            this.Garantia.Text = "Garantia";
            this.Garantia.Width = 173;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 66;
            // 
            // Inicio
            // 
            this.Inicio.Text = "Inicio";
            // 
            // Termino
            // 
            this.Termino.Text = "Termino";
            this.Termino.Width = 72;
            // 
            // Restante
            // 
            this.Restante.Text = "Restante";
            this.Restante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Restante.Width = 129;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(88, 17);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "Service Tag:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "* Se debe tener acceso a internet para utilizar esta aplicacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modelo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Compra:";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(122, 45);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(0, 17);
            this.lbl_modelo.TabIndex = 10;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(122, 79);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(0, 17);
            this.lbl_tipo.TabIndex = 11;
            // 
            // lbl_region
            // 
            this.lbl_region.AutoSize = true;
            this.lbl_region.Location = new System.Drawing.Point(81, 62);
            this.lbl_region.Name = "lbl_region";
            this.lbl_region.Size = new System.Drawing.Size(0, 17);
            this.lbl_region.TabIndex = 12;
            // 
            // lbl_fecha_compra
            // 
            this.lbl_fecha_compra.AutoSize = true;
            this.lbl_fecha_compra.Location = new System.Drawing.Point(122, 62);
            this.lbl_fecha_compra.Name = "lbl_fecha_compra";
            this.lbl_fecha_compra.Size = new System.Drawing.Size(0, 17);
            this.lbl_fecha_compra.TabIndex = 13;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(191, 10);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 18);
            this.lbl_error.TabIndex = 14;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(604, 310);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_fecha_compra);
            this.Controls.Add(this.lbl_region);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lst_garantias);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.txt_servisetag);
            this.Name = "frm_main";
            this.Text = "Garantia Dell - DTI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_servisetag;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.ListView lst_garantias;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_region;
        private System.Windows.Forms.Label lbl_fecha_compra;
        private System.Windows.Forms.ColumnHeader Garantia;
        private System.Windows.Forms.ColumnHeader Termino;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.ColumnHeader Restante;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.ColumnHeader Inicio;
    }
}

