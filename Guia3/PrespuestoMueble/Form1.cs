using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrespuestoMueble
{
    public partial class Form1 : Form
    {
        VerPresupuesto verPresupuesto = new VerPresupuesto();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnIniciarPresupuesto_Click(object sender, EventArgs e)
        {
            DatosCliente datosCliente = new DatosCliente();            
            if (datosCliente.ShowDialog() == DialogResult.OK)
            {
                string nombre = datosCliente.tbNombre.Text;
                string direccion = datosCliente.tbDireccion.Text;
                lblNombreAsignado.Text = nombre;
                lblDireccionAsignado.Text = direccion;
                verPresupuesto.lbResultados.Items.Add($"Cliente: {nombre}");
                verPresupuesto.lbResultados.Items.Add($"Direccion: {direccion}");
            }
            datosCliente.Dispose();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            DatosProducto datosProducto = new DatosProducto();         
            if (datosProducto.ShowDialog() == DialogResult.OK)
            {
                int tipoProducto = Convert.ToInt32(datosProducto.cbTipoProducto.SelectedIndex);
                int tipoMaterial = Convert.ToInt32(datosProducto.cbMaterial.SelectedIndex);
                double largo = Convert.ToDouble(datosProducto.tbLargo.Text);
                string descripcion = datosProducto.tbDescripcion.Text;
                double precio = Convert.ToDouble(datosProducto.tbPrecio.Text);
                if (tipoProducto == 0) 
                {
                    Producto silla = new Silla(descripcion, precio, tipoMaterial);
                    silla.CalcularPrecio();
                    verPresupuesto.lbResultados.Items.Add(silla.VerDetalle());
                }
                else if (tipoProducto == 1)
                {
                    Producto mesa = new Mesa(descripcion, precio, tipoMaterial, largo);
                    mesa.CalcularPrecio();
                    verPresupuesto.lbResultados.Items.Add(mesa.VerDetalle());
                }
            }
            datosProducto.Dispose();
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            verPresupuesto.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
