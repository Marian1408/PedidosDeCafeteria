namespace pedidosDeCafeteria
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> preciosComida = new Dictionary<string, double>()//preciosComida
            {
                { "Paleta-Hielo", 15 },
                { "Pastel-Chocolate", 30 },
                { "Camarones", 80 },
                { "Flan de Caramelo", 30 },
                { "Chicharron", 22 },
                { "Pollo ", 30 }
            }; 

        Dictionary<string, double> preciosBebida = new Dictionary<string, double>()//preciosBebida
            {
                
                { "Agua", 15 },
                { "Chocolate", 20 },
                { "Jugo", 28 },
                { "Piña-Colada", 30 },
                { "Jamaica", 12 },
                { "horchata", 22 }
            };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxBebidas.Items.AddRange(preciosBebida.Keys.ToArray());
            comboBoxComida.Items.AddRange(preciosComida.Keys.ToArray());

        }

        private void buttonAgregar_Click(object sender, EventArgs e)/////////////////////////
        {
            if (comboBoxComida.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una Bebida");
                return;
            }


            listBoxCarrito.Items.Add(comboBoxComida.SelectedItem.ToString());


        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double total = 0;

            if (listBoxCarrito.Items.Count == 0)
            {
                MessageBox.Show("El carrito está vacío");
                return;
            }

            foreach (string item in listBoxCarrito.Items)
            {
                if (preciosComida.ContainsKey(item))
                    total += preciosComida[item];
                else if (preciosBebida.ContainsKey(item))
                    total += preciosBebida[item];
            }
            if(codDescuento.Text.Trim().ToUpper() == "DESC89")
    {
                total *= 0.9;
            }

            labelTotal.Text = "Total: $" + total;
        }

        private void buttonVaciar_Click(object sender, EventArgs e)
        {
            listBoxCarrito.Items.Clear();
            labelTotal.Text = "Total: $ 0";
            codDescuento.Clear();
            //comboBoxBebidas.Items.Clear();
            //comboBoxComida.Items.Clear();
            comboBoxBebidas.Text = " ";
            comboBoxComida.Text = " ";


        }

        private void codDescuento_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxBebidas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una Bebida");
                return;
            }


            listBoxCarrito.Items.Add(comboBoxBebidas.SelectedItem.ToString());

        }

        private void comboBoxBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
