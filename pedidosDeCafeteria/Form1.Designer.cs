namespace pedidosDeCafeteria
{
    partial class Form1
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
            comboBoxBebidas = new ComboBox();
            buttonAgregarComida = new Button();
            buttonCalcular = new Button();
            buttonVaciar = new Button();
            listBoxCarrito = new ListBox();
            codDescuento = new TextBox();
            labelTotal = new Label();
            comboBoxComida = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonAgregarBebidas = new Button();
            label1 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // comboBoxBebidas
            // 
            comboBoxBebidas.FormattingEnabled = true;
            comboBoxBebidas.Location = new Point(158, 115);
            comboBoxBebidas.Name = "comboBoxBebidas";
            comboBoxBebidas.Size = new Size(132, 23);
            comboBoxBebidas.TabIndex = 0;
            comboBoxBebidas.SelectedIndexChanged += comboBoxBebidas_SelectedIndexChanged;
            // 
            // buttonAgregarComida
            // 
            buttonAgregarComida.Location = new Point(56, 211);
            buttonAgregarComida.Name = "buttonAgregarComida";
            buttonAgregarComida.Size = new Size(234, 24);
            buttonAgregarComida.TabIndex = 1;
            buttonAgregarComida.Text = "Agregar Comida";
            buttonAgregarComida.UseVisualStyleBackColor = true;
            buttonAgregarComida.Click += buttonAgregar_Click;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(56, 291);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 24);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonVaciar
            // 
            buttonVaciar.Location = new Point(401, 320);
            buttonVaciar.Name = "buttonVaciar";
            buttonVaciar.Size = new Size(86, 24);
            buttonVaciar.TabIndex = 3;
            buttonVaciar.Text = "Vaciar";
            buttonVaciar.UseVisualStyleBackColor = true;
            buttonVaciar.Click += buttonVaciar_Click;
            // 
            // listBoxCarrito
            // 
            listBoxCarrito.FormattingEnabled = true;
            listBoxCarrito.ItemHeight = 15;
            listBoxCarrito.Location = new Point(309, 115);
            listBoxCarrito.Name = "listBoxCarrito";
            listBoxCarrito.Size = new Size(196, 184);
            listBoxCarrito.TabIndex = 4;
            // 
            // codDescuento
            // 
            codDescuento.BackColor = SystemColors.InactiveBorder;
            codDescuento.Location = new Point(158, 260);
            codDescuento.Name = "codDescuento";
            codDescuento.Size = new Size(132, 23);
            codDescuento.TabIndex = 5;
            codDescuento.TextChanged += codDescuento_TextChanged;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(158, 295);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(44, 15);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "Total: $";
            labelTotal.Click += label1_Click;
            // 
            // comboBoxComida
            // 
            comboBoxComida.FormattingEnabled = true;
            comboBoxComida.Location = new Point(158, 144);
            comboBoxComida.Name = "comboBoxComida";
            comboBoxComida.Size = new Size(132, 23);
            comboBoxComida.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 118);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 8;
            label2.Text = "Elige tu Bebida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 147);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 9;
            label3.Text = "Elige tu Comida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 263);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 10;
            label4.Text = "Cod. Descuento";
            // 
            // buttonAgregarBebidas
            // 
            buttonAgregarBebidas.Location = new Point(56, 182);
            buttonAgregarBebidas.Name = "buttonAgregarBebidas";
            buttonAgregarBebidas.Size = new Size(234, 24);
            buttonAgregarBebidas.TabIndex = 11;
            buttonAgregarBebidas.Text = "Agregar Bebidas";
            buttonAgregarBebidas.UseVisualStyleBackColor = true;
            buttonAgregarBebidas.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 97);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 12;
            label1.Text = "Productos Elegidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Sienna;
            label5.Location = new Point(132, 39);
            label5.Name = "label5";
            label5.Size = new Size(309, 40);
            label5.TabIndex = 13;
            label5.Text = "CAFETERÍA ORIGINAL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(577, 494);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(buttonAgregarBebidas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxComida);
            Controls.Add(labelTotal);
            Controls.Add(codDescuento);
            Controls.Add(listBoxCarrito);
            Controls.Add(buttonVaciar);
            Controls.Add(buttonCalcular);
            Controls.Add(buttonAgregarComida);
            Controls.Add(comboBoxBebidas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.FromArgb(192, 0, 192);
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxBebidas;
        private Button buttonAgregarComida;
        private Button buttonCalcular;
        private Button buttonVaciar;
        private ListBox listBoxCarrito;
        private TextBox codDescuento;
        private Label labelTotal;
        private ComboBox comboBoxComida;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonAgregarBebidas;
        private Label label1;
        private Label label5;
    }

    internal class GestionUsuarios
    {
    }
}
