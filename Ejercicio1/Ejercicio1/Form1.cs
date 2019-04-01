using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Operacion recepcion;

        public Form1()
        {
            InitializeComponent();
        }

        private void BTNEVALUAR_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(TXTD1.Text)) || (string.IsNullOrEmpty(TXTD.Text)))
            {
                MessageBox.Show("NO INGRESO VALORES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            recepcion = new Operacion();
            recepcion.Valor1 = double.Parse(TXTD1.Text);
            recepcion.Valor2 = double.Parse(TXTD.Text);
            if (this.RBSUMA.Checked == true)
            {
                MessageBox.Show("Resultado de la Suma es: " + recepcion.Suma().ToString(),"**",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else if (this.RBRESTA.Checked == true)
            {
                MessageBox.Show("Resultado de la Resta es: " + recepcion.Resta().ToString(), "**", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.RBMULTI.Checked == true)
            {
                if (recepcion.Valor1==0 || recepcion.Valor2 == 0)
                {
                    MessageBox.Show("TODO NUMERO MULTIPLICADO POR CERO ES CERO", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Resultado de la Multiplicacion es: " + recepcion.Multiplicacion().ToString(), "**", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else if (this.RBDIVI.Checked == true)
            {
                if (recepcion.Valor2 == 0)
                {
                    MessageBox.Show("NO SE PUEDE DIVIDIR ENTRE CERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Resultado de la Division es: " + recepcion.Division().ToString(), "**", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Ninguna Opcion Seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
