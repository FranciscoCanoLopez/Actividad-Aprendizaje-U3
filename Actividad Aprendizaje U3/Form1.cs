namespace Actividad_Aprendizaje_U3
{
    public partial class Form1 : Form
    {
        // Variables para las estructuras
        private int[] pila;
        private int tope;
        private int[] cola;
        private int frente, fondo, capacidad;
        private LinkedList<int> lista;
        public Form1()
        {
            InitializeComponent();
            // Inicializaci�n de Pila
            capacidad = 10;
            pila = new int[capacidad];
            tope = -1;

            // Inicializaci�n de Cola
            cola = new int[capacidad];
            frente = fondo = -1;

            // Inicializaci�n de Lista Enlazada
            lista = new LinkedList<int>();
        }

        // M�todos para Pila
        private void btnApilar_Click(object sender, EventArgs e)
        {
            if (tope == capacidad - 1)
            {
                MessageBox.Show("La pila est� llena.");
                return;
            }

            if (int.TryParse(txtPila.Text, out int valor))
            {
                pila[++tope] = valor;
                MostrarPila();
                txtPila.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un n�mero v�lido.");
            }
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            if (tope == -1)
            {
                MessageBox.Show("La pila est� vac�a.");
                return;
            }

            MessageBox.Show($"Elemento desapilado: {pila[tope--]}");
            MostrarPila();
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            if (tope == -1)
            {
                MessageBox.Show("La pila est� vac�a.");
            }
            else
            {
                MessageBox.Show($"Elemento en la cima: {pila[tope]}");
            }
        }

        private void MostrarPila()
        {
            lstPila.Items.Clear();
            for (int i = tope; i >= 0; i--)
            {
                lstPila.Items.Add(pila[i]);
            }
        }

        // M�todos para Cola
        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if ((fondo + 1) % capacidad == frente)
            {
                MessageBox.Show("La cola est� llena.");
                return;
            }

            if (int.TryParse(txtCola.Text, out int valor))
            {
                if (frente == -1) frente = 0;
                fondo = (fondo + 1) % capacidad;
                cola[fondo] = valor;
                MostrarCola();
                txtCola.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un n�mero v�lido.");
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (frente == -1)
            {
                MessageBox.Show("La cola est� vac�a.");
                return;
            }

            MessageBox.Show($"Elemento desencolado: {cola[frente]}");
            if (frente == fondo)
            {
                frente = fondo = -1;
            }
            else
            {
                frente = (frente + 1) % capacidad;
            }
            MostrarCola();
        }

        private void btnFrente_Click(object sender, EventArgs e)
        {
            if (frente == -1)
            {
                MessageBox.Show("La cola est� vac�a.");
            }
            else
            {
                MessageBox.Show($"Elemento en el frente: {cola[frente]}");
            }
        }

        private void MostrarCola()
        {
            lstCola.Items.Clear();
            if (frente != -1)
            {
                int i = frente;
                do
                {
                    lstCola.Items.Add(cola[i]);
                    i = (i + 1) % capacidad;
                } while (i != (fondo + 1) % capacidad);
            }
        }

        // M�todos para Lista Enlazada
        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLista.Text, out int valor))
            {
                lista.AddFirst(valor);
                MostrarLista();
                txtLista.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un n�mero v�lido.");
            }
        }

        private void btnAgregarFinal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLista.Text, out int valor))
            {
                lista.AddLast(valor);
                MostrarLista();
                txtLista.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un n�mero v�lido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLista.Text, out int valor))
            {
                if (lista.Remove(valor))
                {
                    MessageBox.Show($"Elemento {valor} eliminado.");
                }
                else
                {
                    MessageBox.Show("Elemento no encontrado.");
                }
                MostrarLista();
                txtLista.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un n�mero v�lido.");
            }
        }

        private void MostrarLista()
        {
            lstLista.Items.Clear();
            foreach (int item in lista)
            {
                lstLista.Items.Add(item);
            }
        }
    }
}
