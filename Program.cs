using System.Collections.Generic;

int opcion;

do {
    Console.WriteLine("1 - Cargar Nueva Persona");
    Console.WriteLine("2 - Obtener Estadisticas del Censo");
    Console.WriteLine("3 - Buscar Persona");
    Console.WriteLine("4 - Modificar Mail de Persona");
    Console.WriteLine("5 - Modificar usuario");
    Console.WriteLine("6 - Salir");
    opcion = int.Parse(Console.ReadLine());

    switch(opcion){
        case 1:
            Censo.CargarNuevaPersona();
            break;
        case 2:
            Censo.ObtenerEstadisticas();
            break;
        case 3:
            Censo.BuscarPersona();
            break;
        case 4:
            Censo.ModificarMail();
            break;
        case 5:
            Censo.ModificarUsuario();
            break;
    }
}
while (opcion != 6);