namespace FormFerreteria
{
    partial class FormAltaBajaStock
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
            rbtIngreso = new RadioButton();
            rbtSalida = new RadioButton();
            grbIngresoSalida = new GroupBox();
            comboBox1 = new ComboBox();
            lblProducto = new Label();
            lblCantidad = new Label();
            textBox1 = new TextBox();
            btnAgregar = new Button();
            lstArticulos = new ListBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            grbIngresoSalida.SuspendLayout();
            SuspendLayout();
            // 
            // rbtIngreso
            // 
            rbtIngreso.AutoSize = true;
            rbtIngreso.Location = new Point(20, 25);
            rbtIngreso.Name = "rbtIngreso";
            rbtIngreso.Size = new Size(79, 24);
            rbtIngreso.TabIndex = 0;
            rbtIngreso.TabStop = true;
            rbtIngreso.Text = "Ingreso";
            rbtIngreso.UseVisualStyleBackColor = true;
            // 
            // rbtSalida
            // 
            rbtSalida.AutoSize = true;
            rbtSalida.Location = new Point(117, 25);
            rbtSalida.Name = "rbtSalida";
            rbtSalida.Size = new Size(71, 24);
            rbtSalida.TabIndex = 1;
            rbtSalida.TabStop = true;
            rbtSalida.Text = "Salida";
            rbtSalida.UseVisualStyleBackColor = true;
            // 
            // grbIngresoSalida
            // 
            grbIngresoSalida.Controls.Add(rbtSalida);
            grbIngresoSalida.Controls.Add(rbtIngreso);
            grbIngresoSalida.Location = new Point(123, 17);
            grbIngresoSalida.Name = "grbIngresoSalida";
            grbIngresoSalida.Size = new Size(203, 65);
            grbIngresoSalida.TabIndex = 2;
            grbIngresoSalida.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 28);
            comboBox1.TabIndex = 3;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(37, 97);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(72, 20);
            lblProducto.TabIndex = 4;
            lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(300, 98);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 27);
            textBox1.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(37, 164);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 30);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lstArticulos
            // 
            lstArticulos.FormattingEnabled = true;
            lstArticulos.Location = new Point(37, 212);
            lstArticulos.Name = "lstArticulos";
            lstArticulos.Size = new Size(372, 144);
            lstArticulos.TabIndex = 8;
            lstArticulos.SelectedIndexChanged += lstArticulos_SelectedIndexChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(190, 384);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(98, 30);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(311, 384);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 30);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormAltaBajaStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 435);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lstArticulos);
            Controls.Add(btnAgregar);
            Controls.Add(textBox1);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(comboBox1);
            Controls.Add(grbIngresoSalida);
            Name = "FormAltaBajaStock";
            Text = "Movimiento de stock";
            Load += FormAltaBajaStock_Load;
            grbIngresoSalida.ResumeLayout(false);
            grbIngresoSalida.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtIngreso;
        private RadioButton rbtSalida;
        private GroupBox grbIngresoSalida;
        private ComboBox comboBox1;
        private Label lblProducto;
        private Label lblCantidad;
        private TextBox textBox1;
        private Button btnAgregar;
        private ListBox lstArticulos;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}