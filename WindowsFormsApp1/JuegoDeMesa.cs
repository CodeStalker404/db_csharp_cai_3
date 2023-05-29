using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class JuegoDeMesa
    {
        // Miembros
        private string mNombre;
        private int mID, mMinJugadores, mMaxJugadores, mTiempo;

        // Propiedades
        public int ID
        {
            get { return mID; }
            set { mID = value; }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        // Otra posible forma de hacer la propiedad
        public int MinJugadores
        {
            get => mMinJugadores;
            set => mMinJugadores = value;
        }

        public int MaxJugadores
        {
            get => mMaxJugadores;
            set => mMaxJugadores = value;
        }

        public int Tiempo
        {
            get => mTiempo;
            set => mTiempo = value;
        }

        // Constructor
        public JuegoDeMesa(int id, string nombre, int minJugadores, int maxJugadores, int tiempo)
        {
            mID = id;
            mNombre = nombre;
            mMinJugadores = minJugadores;
            mMaxJugadores = maxJugadores;
            mTiempo = tiempo;
        }

        public JuegoDeMesa(string id, string nombre, string minJugadores, string maxJugadores, string tiempo)
        {
            mID = Int32.Parse(id);
            mNombre = nombre;
            mMinJugadores = Int32.Parse(minJugadores);
            mMaxJugadores = Int32.Parse(maxJugadores);
            mTiempo = Int32.Parse(tiempo);
        }
    }
}
