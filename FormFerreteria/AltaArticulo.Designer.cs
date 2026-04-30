namespace FormFerreteria
{
    partial class AltaArticulos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            lblNombre = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblCantidadMinima = new Label();
            txtCantidadMinnima = new TextBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 27);
            textBox1.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(35, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(157, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre del producto:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(35, 26);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(151, 20);
            lblCodigo.TabIndex = 5;
            lblCodigo.Text = "Código del producto:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(35, 58);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(372, 27);
            txtCodigo.TabIndex = 4;
            // 
            // lblCantidadMinima
            // 
            lblCantidadMinima.AutoSize = true;
            lblCantidadMinima.Location = new Point(35, 171);
            lblCantidadMinima.Name = "lblCantidadMinima";
            lblCantidadMinima.Size = new Size(216, 20);
            lblCantidadMinima.TabIndex = 7;
            lblCantidadMinima.Text = "Cantidad mínima del producto:";
            // 
            // txtCantidadMinnima
            // 
            txtCantidadMinnima.Location = new Point(35, 194);
            txtCantidadMinnima.Name = "txtCantidadMinnima";
            txtCantidadMinnima.Size = new Size(372, 27);
            txtCantidadMinnima.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(154, 250);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 28);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(294, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 28);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AltaArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 320);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(lblCantidadMinima);
            Controls.Add(txtCantidadMinnima);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombre);
            Controls.Add(textBox1);
            Name = "AltaArticulos";
            Text = "Alta de artículos";
            Load += AltaArticulos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblNombre;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblCantidadMinima;
        private TextBox txtCantidadMinnima;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}
