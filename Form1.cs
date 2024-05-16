namespace Ejercicio1ClaseProg2
{
    public partial class Form1Notafinal : Form
    {
        public Form1Notafinal()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            var notafinal=txtNotaFinal.Text;
            double nota = 0; // Se le debe asignar un valor, en este caso 0 - el double es para permitir decimales
            double.TryParse(txtNotaFinal.Text, out nota); // tray parse permite cambiar el valor de texto a numero
                                                          // ya que se trata de una not
            //algoritmo
            string mensaje; /// Se hace la validaci�n de la nota si aprob� o no 
            
            if (nota < 0 || nota > 10)    /// Condicion para que no ingrese valores negativos ni mayor a 10
            {
                MessageBox.Show("Nota no valida");
                            return;/// se termina la ejecuci�n 
            }

            if (nota > 5)
            {
                mensaje = "Felicitaciones, has aprobado ";
            }
            else
            {
                mensaje = "Lo siento, has perdido";
            }
            MessageBox.Show(mensaje);// muestra el mensaje final cuando hizo la validaci�n
        }
    }
}