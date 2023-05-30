using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Instancia del objeto que maneja la BD.
        SqlDBHelper sqlDBHelper;

        // Variable que indica en qué registro estamos situados
        private int pos;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Creamos el objeto BD
            sqlDBHelper = new SqlDBHelper();

            // Situamos la primera posición
            // y mostramos el registro
            pos = 0;
            mostrarRegistro(pos);
        }


        private void mostrarRegistro(int pos)
        {
            JuegoDeMesa juegoDeMesa;

            juegoDeMesa = sqlDBHelper.devuelveJuegoDeMesa(pos);
            
            if(juegoDeMesa == null)
            {
                txtID.Text = "Sin datos";
                txtNombre.Text = "Sin datos";
                txtMinJugadores.Text = "Sin datos";
                txtMaxJugadores.Text = "Sin datos";
                txtTiempo.Text = "Sin datos";
            }
            else
            {
                //Cogemos el valor de cada una de las columnas del registro y lo ponemos en el txtBox correspondiente
                txtID.Text = juegoDeMesa.ID.ToString();
                txtNombre.Text = juegoDeMesa.Nombre;
                txtMinJugadores.Text = juegoDeMesa.MinJugadores.ToString();
                txtMaxJugadores.Text = juegoDeMesa.MaxJugadores.ToString();
                txtTiempo.Text = juegoDeMesa.Tiempo.ToString();
            }

            HabilitarDeshabilitarBotones(pos);

            this.lblRegistros.Text = "Registro " + (pos + 1) + " de " + sqlDBHelper.NumJuegosDeMesa;
        }

        private void HabilitarDeshabilitarBotones(int pos)
        {
            if(pos == 0 && sqlDBHelper.NumJuegosDeMesa == 0)
            { // Si no hay ningún registro se deshabilitan todos
                this.bPrimero.Enabled = false;
                this.bAnterior.Enabled = false;
                this.bUltimo.Enabled = false;
                this.bSiguiente.Enabled = false;
                // También deshabilitar botón Eliminar
                this.bEliminar.Enabled = false;
            }
            else if (pos <= 0)
            { // En la primera posición se deshabilitan los botones Primero y Anterior
                this.bPrimero.Enabled = false;
                this.bAnterior.Enabled = false;
                this.bUltimo.Enabled = true;
                this.bSiguiente.Enabled = true;
            }
            else if (pos >= sqlDBHelper.NumJuegosDeMesa - 1)
            { // En la última posición se deshabilitan los botones Último y Siguiente
                this.bPrimero.Enabled = true;
                this.bAnterior.Enabled = true;
                this.bUltimo.Enabled = false;
                this.bSiguiente.Enabled = false;
            }
        }


        private void bPrimero_Click(object sender, EventArgs e)
        {
            // Si no hay cambios se pasa a mostrar el primer registro
            if (SePuedeCambiarDeRegistro())
            {
                //Para saber qué tipo de objetco es sender
                Console.WriteLine(sender.GetType().Name);

                //He cambiado el tipo del objeto sender a botón (castear)
                Button btn = sender as Button;

                // Ponemos la primera posición
                pos = 0;
                mostrarRegistro(pos);
            }
        }

        private void bAnterior_Click(object sender, EventArgs e)
        {
            // Si no hay cambios se pasa a mostrar el anterior registro
            if (SePuedeCambiarDeRegistro())
            {
                //He cambiado el tipo del objeto sender a botón (castear)
                Button btn = sender as Button;

                // Vamos a la posición anterior.
                pos--;

                //activamos el botón
                this.bSiguiente.Enabled = true;
                this.bUltimo.Enabled = true;
                mostrarRegistro(pos);
            }
        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            // Si no hay cambios se pasa a mostrar el siguiente registro
            if (SePuedeCambiarDeRegistro())
            {
                //He cambiado el tipo del objeto sender a botón (castear)
                Button btn = sender as Button;

                // Vamos a la posición siguiente
                pos++;
                Console.WriteLine(pos.ToString());

                this.bAnterior.Enabled = true;
                this.bPrimero.Enabled = true;
                mostrarRegistro(pos);
            }
        }

        private void bUltimo_Click(object sender, EventArgs e)
        {
            // Si no hay cambios se pasa a mostrar el último registro
            if (SePuedeCambiarDeRegistro())
            {
                Button btn = sender as Button;
                // Vamos a la última posición.
                // Los registros van del 0 al numero de registros - 1
                pos = sqlDBHelper.NumJuegosDeMesa - 1;
                mostrarRegistro(pos);
            }
        }

        private bool SonTodoLetras(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            foreach (char c in input)
            {
                if (!Char.IsLetter(c) && c != ' ')
                {
                    Console.WriteLine(c + " apesta");
                    return false;
                }
            }
            return true;
        }

        private bool SonTodoNumeros(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            foreach (char c in input)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool EsEmailValido(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            return email.Contains("@") && email.Contains(".");
        }

        private bool SePuedeGuardar()
        {
            return SonTodoNumeros(txtID.Text)
                // El ID es clave primaria. No puede estar repetido, o lanza excepción.
                && !sqlDBHelper.IDRepetido(Int32.Parse(txtID.Text))
                && SonTodoLetras(txtNombre.Text)
                && SonTodoNumeros(txtMinJugadores.Text)
                && SonTodoNumeros(txtMaxJugadores.Text)
                && SonTodoNumeros(txtTiempo.Text);
        }
        
        private bool HayCambiosEnRegistroActual()
        {
            JuegoDeMesa juegoDeMesa = this.sqlDBHelper.devuelveJuegoDeMesa(pos);

            bool hayCambios =
                juegoDeMesa.ID.ToString() != txtID.Text
                || juegoDeMesa.Nombre != txtNombre.Text
                || juegoDeMesa.MinJugadores.ToString() != txtMinJugadores.Text
                || juegoDeMesa.MaxJugadores.ToString() != txtMaxJugadores.Text
                || juegoDeMesa.Tiempo.ToString() != txtTiempo.Text;

            return hayCambios;
        }

        private bool SePuedeCambiarDeRegistro()
        {
            bool sePuedeCambiar = true;
            // Si hay cambios en los textbox se pregunta al usuario si está seguro de querer continuar
            if (HayCambiosEnRegistroActual())
            {
                DialogResult result = MessageBox.Show("Hay cambios en el registro actual. Los datos no guardados se perderán.", "¿Desea continuar? ", MessageBoxButtons.YesNo);

                sePuedeCambiar = result.Equals(DialogResult.Yes);
            }

            return sePuedeCambiar;
        }

        private void bAnyadir_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            txtMinJugadores.Clear();
            txtMaxJugadores.Clear();
            txtTiempo.Clear();
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            if(SePuedeGuardar())
            {
                //Creamos el juegoDeMesa con los datos del formulario
                JuegoDeMesa juegoDeMesa = new JuegoDeMesa(txtID.Text, txtNombre.Text,
                    txtMinJugadores.Text, txtMaxJugadores.Text, txtTiempo.Text);

                sqlDBHelper.anyadirJuegoDeMesa(juegoDeMesa);

                //Actualizamos la posición en la tabla.
                pos = sqlDBHelper.NumJuegosDeMesa - 1;
            }
            else
            {
                MessageBox.Show(
                    "Hay campos con datos no válidos." +
                    "\nO el ID ya figura en la base de datos." +
                    "\nRevise los datos introducidos."
                );
            }
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            //Creamos el juegoDeMesa con los datos del formulario
            JuegoDeMesa juegoDeMesa = new JuegoDeMesa(txtID.Text, txtNombre.Text,
                txtMinJugadores.Text, txtMaxJugadores.Text, txtTiempo.Text);

            sqlDBHelper.actualizarJuegoDeMesa(juegoDeMesa, pos);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            // Mostramos cuadro de diálogo para pedir confirmación de eliminación al usuario.
            DialogResult result = MessageBox.Show(
                    "Si confirma se eliminará el registro actual. ¿Desea eliminarlo?",
                    "¿Desea eliminar el registro actual? ",
                    MessageBoxButtons.YesNo
                );

            // Respuesta del usuario a eliminar o no el registro.
            bool eliminar = result.Equals(DialogResult.Yes);

            // Se elimina el registro si el usuario ha respondido que Sí.
            if (eliminar)
            {
                sqlDBHelper.eliminarJuegoDeMesa(pos);

                // Nos vamos al primer registro y lo mostramos
                pos = 0;
                mostrarRegistro(pos);
            }
        }


        private void txtID_TextChanged(object sender, EventArgs e)
        {
            TextBox txtID = sender as TextBox;
            if (!SonTodoNumeros(txtID.Text))
            {
                this.lblValidacionID.Text = "ID inválido. El ID solo debe contener números.";
                this.lblValidacionID.Visible = true;
            }
            else
            {
                this.lblValidacionID.Visible = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox txtNombre = sender as TextBox;
            if (!SonTodoLetras(txtNombre.Text))
            {
                this.lblValidacionNombre.Text = "Nombre inválido.\nSolo puede contener letras y espacios.";
                this.lblValidacionNombre.Visible = true;
            }
            else
            {
                this.lblValidacionNombre.Visible = false;
            }
        }

        private void txtMinJugadores_TextChanged(object sender, EventArgs e)
        {
            TextBox txtMinJugadores = sender as TextBox;
            if (!SonTodoNumeros(txtMinJugadores.Text))
            {
                this.lblValidacionMinJugadores.Text = "Mínimo de jugadores inválido.\nSolo puede contener números.";
                this.lblValidacionMinJugadores.Visible = true;
            }
            else
            {
                this.lblValidacionMinJugadores.Visible = false;
            }
        }

        private void txtMaxJugadores_TextChanged(object sender, EventArgs e)
        {
            TextBox txtMaxJugadores = sender as TextBox;
            if (!SonTodoNumeros(txtMaxJugadores.Text))
            {
                this.lblValidacionMaxJugadores.Text = "Máximo de jugadores inválido.\nSolo puede contener números.";
                this.lblValidacionMaxJugadores.Visible = true;
            }
            else
            {
                this.lblValidacionMaxJugadores.Visible = false;
            }
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {
            TextBox txtTiempo = sender as TextBox;
            if (!SonTodoNumeros(txtTiempo.Text))
            {
                this.lblValidacionTiempo.Text = "Tiempo inválido.\nSolo puede contener números.";
                this.lblValidacionTiempo.Visible = true;
            }
            else
            {
                this.lblValidacionTiempo.Visible = false;
            }
        }
    }
}
