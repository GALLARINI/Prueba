using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Alumno
    {
        public int Legajo { get; set; } //public int Legajo { get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public DateTime FechaDeNacimiento { get; set; }
        public string DirrecionPersonal { get; set; }
        public string DirrecionLaboral { get; set; }

        public List<Materia> CursadaActual { get; set; }

        public List<MateriaAprobada> Aprobadas { get; set; }

        public void AnotarseA(Materia materiaEnLaqueAnotarse)
        {

        }
        public int CalcularEdadEnAños()
        {
            var años = DateTime.Now.Year - FechaDeNacimiento.Year;

            return años;
        }
      //  public int CalcularEdadEnAños() => var años = DateTime.Now.Year - FechaDeNacimiento.Year;
    }
}
