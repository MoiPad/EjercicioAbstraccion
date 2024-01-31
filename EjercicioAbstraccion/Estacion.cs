using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal class Estacion : AccesPoint
    { 
        public string Signal { get; set; }
        public string Pais { get; set; }
        public bool EstaActiva { get; set; }
        public string Estacion_ { get; set; }

        public Estacion(string nombre, string direccion_ip, string macaddress, string gateway, string modelo, string subnetmask,
                        string estacion, string signal, string pais,  bool estaactiva)
            : base(nombre, direccion_ip, macaddress, gateway, modelo, subnetmask)
        
        {
            Estacion_ = estacion;
            Signal = signal;
            Pais = pais;
            EstaActiva = estaactiva;
        }

        public override void Imprimir()
        {
            Console.WriteLine(new string('-', 159));
            string fila = "|{0,-15} |{1,-15} |{2,-24} |{3,-15} |{4,-15} |{5,-15} |{6,-10} |{7,-10} |{8,-10} |{9,-10}|";
            Console.WriteLine(String.Format(fila, Nombre, Validacion_IP(Direccion_IP), MacAddress, Gateway, Modelo, SubnetMask, Estacion_, Signal, Pais, Validacion(EstaActiva)));

        }

        public override string Validacion(bool Activa)
        {
            return Activa ? "Si" : "no";
        }

        public override string Validacion_IP(string IP_ingresada )
        {
            string pool = "9.0.0.254";
            if (IP_ingresada == pool)
            {
                return "IP en uso";
            }
            else
            {
                return Direccion_IP;
            }
        }
    }
}
