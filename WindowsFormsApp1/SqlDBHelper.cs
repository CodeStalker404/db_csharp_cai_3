using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class SqlDBHelper
    {
        // Miembros para guardar el dataSet y el dataAdapter de juegoDeMesaes.
        private DataSet dsJuegosDeMesa;
        private SqlDataAdapter daJuegosDeMesa;

        // Miembro para guardar el número de juegoDeMesaes.
        private int numJuegosDeMesa;
        // Propiedad de solo lectura.
        public int NumJuegosDeMesa
        {
            get => numJuegosDeMesa;
        }

        // Constructor del objeto.
        // En el mismo hacemos la conexión y creamos dataSet y dataAdapter
        public SqlDBHelper()
        {
            //string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\JRJ_1\\Projects\\db_csharp_cai\\Instituto.mdf;Integrated Security=True;Connect Timeout=30";
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=\"C:\\Users\\Cai\\OneDrive\\Escritorio\\DAW\\" +
                "PROGRAMACIÓN\\tema 9\\ejercicios\\db_csharp_cai_3_old\\juegos_de_mesa.mdf\"" +
                ";Integrated Security=True;Connect Timeout=30";

            SqlConnection con = new SqlConnection(cadenaConexion);

            // Abrimos la conexión.
            con.Open();

            string cadenaSQL = "SELECT * From JuegosDeMesa";
            daJuegosDeMesa = new SqlDataAdapter(cadenaSQL, con);

            dsJuegosDeMesa = new DataSet();

            daJuegosDeMesa.Fill(dsJuegosDeMesa, "JuegosDeMesa");

            // Obtenemos el número de juegoDeMesaes
            numJuegosDeMesa = dsJuegosDeMesa.Tables["JuegosDeMesa"].Rows.Count;

            // Cerramos la conexión.
            con.Close();
        }


        // Método que a partir de una posición en la BD
        // Devuelve un objeto juegoDeMesa.
        // Devuelve null si pos está fuera de los límites
        public JuegoDeMesa devuelveJuegoDeMesa(int pos)
        {
            JuegoDeMesa juegoDeMesa = null;

            if (pos >= 0 && pos < numJuegosDeMesa)
            {
                // Objeto que nos permite recoger un registro de la tabla.
                DataRow dRegistro;

                // Cogemos el registro de la posición pos en la tabla Profesores
                dRegistro = dsJuegosDeMesa.Tables["JuegosDeMesa"].Rows[pos];

                // Cogemos el valor de cada una de las columnas del registro
                // y lo creamos el objeto JuegoDeMesa con esos datos.
                juegoDeMesa = new JuegoDeMesa(
                    dRegistro[0].ToString(), dRegistro[1].ToString(),
                    dRegistro[2].ToString(), dRegistro[3].ToString(),
                    dRegistro[4].ToString()
                );
            }
            return juegoDeMesa;
        }

        // Metodos CRUD

        // Método que añade un JuegoDeMesa a nuestra BD
        public void anyadirJuegoDeMesa(JuegoDeMesa juegoDeMesa)
        {
            // Creamos un nuevo registro.
            DataRow dRegistro = dsJuegosDeMesa.Tables["JuegosDeMesa"].NewRow();

            // Metemos los datos en el nuevo registro
            dRegistro[0] = juegoDeMesa.ID;
            dRegistro[1] = juegoDeMesa.Nombre;
            dRegistro[2] = juegoDeMesa.MinJugadores;
            dRegistro[3] = juegoDeMesa.MaxJugadores;
            dRegistro[4] = juegoDeMesa.Tiempo;

            // Si quisieramos hacerlo por nombre de columna en vez de posición
            // dRegistro["ID"] = juegoDeMesa.ID;

            // Añadimos el registro al Dataset
            dsJuegosDeMesa.Tables["JuegosDeMesa"].Rows.Add(dRegistro);

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daJuegosDeMesa);
            daJuegosDeMesa.Update(dsJuegosDeMesa, "JuegosDeMesa");

            // Actualizamos el número de juegoDeMesaes
            numJuegosDeMesa++;
        }

        // Actualizamos los datos del juegoDeMesa
        // situado en la posición pos
        public void actualizarJuegoDeMesa(JuegoDeMesa juegoDeMesa, int pos)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dsJuegosDeMesa.Tables["JuegosDeMesa"].Rows[pos];

            // Metemos los datos en el registro
            dRegistro[0] = juegoDeMesa.ID;
            dRegistro[1] = juegoDeMesa.Nombre;
            dRegistro[2] = juegoDeMesa.MinJugadores;
            dRegistro[3] = juegoDeMesa.MaxJugadores;
            dRegistro[4] = juegoDeMesa.Tiempo;

            // Si quisieramos hacerlo por nombre de columna en vez de posición
            // dRegistro["ID"] = juegoDeMesa.ID;

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daJuegosDeMesa);
            daJuegosDeMesa.Update(dsJuegosDeMesa, "JuegosDeMesa");
        }

        public void eliminarJuegoDeMesa(int pos)
        {
            if(numJuegosDeMesa > 0)
            {
                // Eliminamos el registro situado en la posición actual.
                dsJuegosDeMesa.Tables["JuegosDeMesa"].Rows[pos].Delete();

                // Tenemos un JuegoDeMesa menos
                numJuegosDeMesa--;

                // Reconectamos con el dataAdapter y actualizamos la BD
                SqlCommandBuilder cb = new SqlCommandBuilder(daJuegosDeMesa);
                daJuegosDeMesa.Update(dsJuegosDeMesa, "JuegosDeMesa");
            }
        }

        public bool IDRepetido(int id)
        {
            bool idRepetido = false;

            for (int i = 0; i < NumJuegosDeMesa; i++)
            {
                JuegoDeMesa juegoDeMesa = devuelveJuegoDeMesa(i);
                if (juegoDeMesa != null && juegoDeMesa.ID == id)
                {
                    idRepetido = true;
                }
            }

            return idRepetido;
        }
    }
}
