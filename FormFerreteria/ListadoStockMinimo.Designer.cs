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
            listBox1 = new ListBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(33, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(466, 184);
            listBox1.TabIndex = 0;
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
            // formListadoMinimo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 298);
            Controls.Add(btnCancelar);
            Controls.Add(listBox1);
            Name = "formListadoMinimo";
            Text = "Listado stock mínimo";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnCancelar;
    }
}