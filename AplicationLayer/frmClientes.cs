using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinnessLayer;

namespace AplicationLayer
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CargarFechas();
           
        }

        public void guardarBD()
            {
                ClientesEntity cliente = new ClientesEntity();
                cliente.TipoDocumento = txtTipoDocumento.Text;
                cliente.NumeroDocumento = txtdocumento.Text;
                cliente.Primerombre = txtprimernombre.Text;
                cliente.SegundoNombre = txtsegundonombre.Text;
                cliente.PrimerApellido = txtprimerapellido.Text;
                cliente.SegudoApellido = txtsegundoapellido.Text;
                cliente.Telefono = txtnumero.Text;
                cliente.direccion = txtdireccion.Text;
                cliente.FechaNacimiento = Convert.ToDateTime(cbdia.Text + "," + cbmes.Text + "," + cbaño.Text);
    }


        private void txtTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADIOS CRACK");
            Application.Exit();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CargarFechas()
        {
            for (int dia = 1; dia <=31;  dia++)
            {
                cbdia.Items.Add(dia);
            }
            for (int mes = 1; mes <=12 ; mes++)

            {
                cbmes.Items.Add(mes);
                
            }
           
            for (int año = 1900; año <=2060 ; año++)
            {
                cbaño.Items.Add(año);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if (ClientesNegocio.ProbarConexion() == true)
            {
                MessageBox.Show("conexion Exitosa");
            }

        }
    }
}
