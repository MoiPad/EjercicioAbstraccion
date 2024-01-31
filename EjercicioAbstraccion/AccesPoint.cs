using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal abstract class AccesPoint
    {
        public string Nombre { get; set; }
        public string Direccion_IP { get; set;}
        public string MacAddress { get; set; }
        public string Modelo { get; set; }
        public string ModoInalambrico { get; set; }
        public string ModoRed { get; set; }
        public string Gateway { get; set; }
        public string SubnetMask { get; set; }
        public int Estaciones { get; set; } // clientes asociados

        public string pool = "9.0.0.254";// ip default para comparar
        public abstract void Imprimir();
        public abstract string Validacion();// activo o no
        public abstract string Validacion_IP();// validad si la ip esta correcta
    }
}
