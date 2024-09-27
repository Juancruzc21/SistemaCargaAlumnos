using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    internal class Cola
    {
        Alumno _inicio;


        public void Encolar(Alumno unAlumno)
        {
            if (_inicio == null)
            {
                _inicio = unAlumno;
            }
            else
            {
                Alumno aux = BuscarUltimo(_inicio);
                aux.Siguiente = unAlumno;
            }
        }

        private Alumno BuscarUltimo(Alumno unAlumno)
        {
            if (unAlumno.Siguiente == null)
            {
                return unAlumno;
            }
            else
            {
                return BuscarUltimo(unAlumno.Siguiente);
            }

        }


        public void Desencolar()
        {
            _inicio = _inicio.Siguiente;
        }

        public Alumno Inicio
        {
            get { return _inicio; }

        }

        public bool Vacia()
        {
            return (_inicio == null);
        }
    }
}
