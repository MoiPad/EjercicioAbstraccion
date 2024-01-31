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
        public string Gateway { get; set; }
        public string SubnetMask { get; set; }

        protected AccesPoint(string nombre, string direccion_ip, string macaddress, string gateway, string modelo, string subnetmask)
        {
            Nombre = nombre;
            Direccion_IP = direccion_ip;
            MacAddress = macaddress;
            Modelo = modelo;
            Gateway = gateway;
            SubnetMask = subnetmask;
        }

        public abstract void Imprimir();
        public abstract string Validacion(bool Activa);// activo o no
        public abstract string Validacion_IP(string IP_ingresada);
    }
}
