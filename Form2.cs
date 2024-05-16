using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1ClaseProg2
{
    public partial class Form2SumaPar : Form
    {
        public Form2SumaPar()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            ///Paso 1 . Definir variables
            int numero1;
            int numero2;
            // Se cambia texto a numero entero 
            int.TryParse(txtNumero1.Text,out numero1);
            int.TryParse(txtNumero2.Text,out numero2);

            if (numero1 % 2 != 0) // validadcion de si el numero 1 es par 
            {
                MessageBox.Show(" Numero 1 no es par");
                return;
            }
            if(numero2 % 2 != 0)
            {
                MessageBox.Show(" Numero 2 no es par");
                return;
            }

            var suma = numero1 + numero2;
                MessageBox.Show($"La suma de los dos numeroS ingresados es:{suma}") ;
        }
    }
}
