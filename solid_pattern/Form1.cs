using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solid_pattern
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region [Combo producto]
            cmbProducto.Items.Add("--");
            cmbProducto.Items.Add("Tecnologia");
            cmbProducto.Items.Add("Accesorio");
            cmbProducto.Items.Add("Componente");
            cmbProducto.SelectedIndex = 0;
            #endregion
            #region [Combo entrega]
            cmbEntrega.Items.Add("--");
            cmbEntrega.Items.Add("Dron");
            cmbEntrega.Items.Add("Moto");
            cmbEntrega.Items.Add("Camion");
            cmbEntrega.Items.Add("Bicicleta");
            cmbEntrega.SelectedIndex = 0;
            #endregion

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = txtCliente.Text;
                string producto = cmbProducto.SelectedItem.ToString();
                bool urgente = chkUrgente.Checked;
                double peso = Convert.ToDouble(nudPeso.Value);
                int distancia = Convert.ToInt32(nudDistancia.Value);
                Pedido pedido = new Pedido(cliente, producto, urgente, peso, distancia);
                Singleton.Instancia.AgregarPedido(pedido);
                string entrega = cmbEntrega.SelectedItem.ToString();
                              
                lblResultado.Text = $"Entrega: {pedido.MetodoEntrega.TipoEntrega()}" + $"  Costo: ${pedido.ObtenerCosto():0.00}";

                var pedidos = Singleton.Instancia.MostrarPedidos()
                    .OrderByDescending(p => p.Peso)
                    .Select((p, Index) => new
                    {
                        Nro = Index + 1,
                        Cliente = p.Cliente,
                        Producto = p.Producto,
                        Urgente = p.Urgente ? "Si" : "No",
                        Peso = p.Peso,
                        Distancia = p.Distancia,
                        Entrega = p.MetodoEntrega.TipoEntrega(),
                        Costo = p.ObtenerCosto()
                    }).ToList();
                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = pedidos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entrega = cmbEntrega.SelectedItem.ToString();
            var pedidos_filtrado = Singleton.Instancia.MostrarPedidos()
                   .Where(p => p.MetodoEntrega.TipoEntrega() == entrega)
                   .OrderByDescending(p => p.Peso)
                   .Select((p, Index) => new
                   {
                       Nro = Index + 1,
                       Cliente = p.Cliente,
                       Producto = p.Producto,
                       Urgente = p.Urgente ? "Si" : "No",
                       Peso = p.Peso,
                       Distancia = p.Distancia,
                       Entrega = p.MetodoEntrega.TipoEntrega(),
                       Costo = p.ObtenerCosto()
                   }).ToList();
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = pedidos_filtrado;
        }
    }
}
