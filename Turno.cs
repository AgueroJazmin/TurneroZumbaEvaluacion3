using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurneroZumbaEvaluacion3
{
    public class Turno
    {
        //definir una propiedad dentro de una clase. Va a ser publica y de tipo string
        //Si borro Set, queda get lo que significa que va a ser un codigo de lectura. Es decir que
        //la clase codigo solamente es de lectura. En cambio, si borro Get va a ser un codigo 
        //solamente de actualizar, es decir no vere el codigo solo lo podre actualizar. Prop
        public string Nombre { get; set; }
        public string Dia { get; set; }
        public string TurnoDelDia { get; set; }
        public string Horario { get; set; }

        public Turno(string nombre, string dia, string turnoDelDia, string horario)
        {
            Nombre = nombre;
            Dia = dia;
            TurnoDelDia = turnoDelDia;
            Horario = horario;
        }
    }
}
