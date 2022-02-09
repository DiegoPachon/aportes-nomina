using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recibo_de_nomina
{
    public partial class Form1 : Form
    {

        Empleado miEmpleado = new Empleado();
        NominaTrabajador miNomina = new NominaTrabajador();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtIdentificacion.Clear();
            txtApellidos.Clear();
            txtSalario.Clear();
            txtDias.Clear();
            lblSalarioDiario.Text = "...";
            lblPension.Text = "...";
            lblSalud.Text = "...";
            lblRiesgos.Text = "...";
            lblCCF.Text = "...";
            lblTotal.Text = "...";
        }
        private void btnSalarioD_Click(object sender, EventArgs e)
        {
            miNomina.Salario = Convert.ToDouble(txtSalario.Text);
            miEmpleado.Dias = Convert.ToInt32(txtDias.Text);
            lblSalarioDiario.Text = miNomina.Calcularsalariodiario(Convert.ToInt32(miNomina.Salario),
                Convert.ToInt32(miEmpleado.Dias)).ToString();

            //Sólo dos digitos despues de la coma
            Double x;
            Double.TryParse(lblSalarioDiario.Text, out x);
            lblSalarioDiario.Text = x.ToString(".00");

            // Validación de datos ingresados
            if (txtNombres.Text == "")
            {
                error1.SetError(txtNombres, "Debe ingresar un Nombre");
                txtNombres.Focus();
                return;
            }
            error1.SetError(txtNombres, "");

            if (txtApellidos.Text == "")
            {
                error1.SetError(txtApellidos, "Debe ingresar un Apellido");
                txtNombres.Focus();
                return;
            }
            error1.SetError(txtApellidos, "");

            //Validación de datos numéricos
            decimal AsignacionSalario;
            if (!Decimal.TryParse(txtSalario.Text, out AsignacionSalario))
            {
                error1.SetError(txtSalario, "Debe ingresar un número");
                txtNombres.Focus();
                return;
            }
            error1.SetError(txtSalario, "");

            decimal AsignacionIdentificacion;
            if (!Decimal.TryParse(txtIdentificacion.Text, out AsignacionIdentificacion))
            {
                error1.SetError(txtIdentificacion, "Debe ingresar un número");
                txtNombres.Focus();
                return;
            }
            error1.SetError(txtIdentificacion, "");

            decimal AsignacionDiasLaborados;
            if (!Decimal.TryParse(txtDias.Text, out AsignacionDiasLaborados))
            {
                error1.SetError(txtDias, "Debe ingresar un número");
                txtNombres.Focus();
                return;
            }
            error1.SetError(txtDias, "");

            miEmpleado.Nombres = txtNombres.Text;
            miEmpleado.Apellidos = txtApellidos.Text;
            miEmpleado.Identificacion = Convert.ToInt32(txtIdentificacion.Text);
            miEmpleado.Dias = Convert.ToInt32(txtDias.Text);
            miNomina.Salario = Convert.ToDouble(txtSalario.Text);
        }

       
        private void btnTotalPagado_Click(object sender, EventArgs e)
        {
       
            lblTotal.Text = (Convert.ToDecimal(lblPension.Text) + Convert.ToDecimal(lblRiesgos.Text)+ 
                Convert.ToDecimal(lblSalud.Text) + Convert.ToDecimal(lblCCF.Text)).ToString();
        }

        private void btnAportes_Click(object sender, EventArgs e)
        {
            lblPension.Text = (Convert.ToInt32(txtSalario.Text) * 0.16).ToString();
            lblRiesgos.Text = (Convert.ToInt32(txtSalario.Text) * 0.04350).ToString();
            lblSalud.Text = (Convert.ToInt32(txtSalario.Text) * 0.04).ToString();
            lblCCF.Text = (Convert.ToInt32(txtSalario.Text) * 0.04).ToString();
        }
    }
    }
