
using EjercicioAbstraccion;

/*static void Cabecera() 
{
    Console.WriteLine(new string('-', 154));
    string Cabecera = "|{0,-15} |{1,-15} |{2,-10}  |{3,-10} |{4,-10} |{5,-15} |{6,-20} |{7,-25} |{8,-15}|";
    Console.WriteLine(String.Format(Cabecera, "Nombre", "Tipo", "Nivel", "Vida", "Poder", "Ataque Especial", "Ataque Basico", "Ataque Secundario", "Puede Volar"));
}*/
static void Cabecera()
{
    Console.WriteLine(new string('-', 159));
    string Cabecera = "|{0,-15} |{1,-15} |{2,-24} |{3,-15} |{4,-15} |{5,-15} |{6,-10} |{7,-10} |{8,-10} |{9,-10}|";
    Console.WriteLine(String.Format(Cabecera, "Nombre", "Direccion_IP", "MacAddress", "Gateway", "Modelo", "Subnet Mask", "Estacion", "Señal", "Pais", "Activo"));
}
    
    Estacion equipo = new Estacion("Lite Beam","9.0.0.233","00:00:00:00:00:00","9.0.0.1","LBE-5AC","255.255.255.0","PTMP","-47dBm","Licensed", true);
    Cabecera();
    equipo.Imprimir();

    Router router = new Router("Mercusys","192.168.1.100","DC:9F:DB:00:25:2A","192.169.1.1","MW325R","255.255.255.0","Router","-65dBm","Honduras", true);
    router.Imprimir();
    Console.WriteLine(new string('-', 159));