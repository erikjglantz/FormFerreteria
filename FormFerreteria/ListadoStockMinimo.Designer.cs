namespace FormFerreteria
{
    partial class formListadoMinimo
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
            btnCancelar = new Button();
            lstStockMinimo = new ListView();
            CódiCodigogo = new ColumnHeader();
            Nombre = new ColumnHeader();
            StockMinimo = new ColumnHeader();
            StockActual = new ColumnHeader();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(401, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 30);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lstStockMinimo
            // 
            lstStockMinimo.Columns.AddRange(new ColumnHeader[] { CódiCodigogo, Nombre, StockMinimo, StockActual });
            lstStockMinimo.Location = new Point(33, 37);
            lstStockMinimo.Name = "lstStockMinimo";
            lstStockMinimo.Size = new Size(466, 177);
            lstStockMinimo.TabIndex = 12;
            lstStockMinimo.UseCompatibleStateImageBehavior = false;
            lstStockMinimo.SelectedIndexChanged += lstStockMinimo_SelectedIndexChanged;
            // 
            // CódiCodigogo
            // 
            CódiCodigogo.Text = "Código";
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            // 
            // StockMinimo
            // 
            StockMinimo.Text = "Stock mínimo";
            // 
            // StockActual
            // 
            StockActual.Text = "Stock actual";
            // 
            // formListadoMinimo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 298);
            Controls.Add(lstStockMinimo);
            Controls.Add(btnCancelar);
            Name = "formListadoMinimo";
            Text = "Listado stock mínimo";
            ResumeLayout(false);
        }

        #endregion
        private Button btnCancelar;
        private ListView lstStockMinimo;
        private ColumnHeader CódiCodigogo;
        private ColumnHeader Nombre;
        private ColumnHeader StockMinimo;
        private ColumnHeader StockActual;
    }
}