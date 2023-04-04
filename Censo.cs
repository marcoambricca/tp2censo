public static class Censo {
public static List<Persona> listaPersonas = new List<Persona>();

    public static void ObtenerEstadisticas(){
    Console.WriteLine("Estadisticas del censo: ");
    Console.WriteLine($"Cantidad de personas: {listaPersonas.Count}");
    int cnt = 0;
    int total = 0;
    for (int i = 0; i < listaPersonas.Count; i++){
        if (listaPersonas[i].PuedeVotar()){
            cnt++;
            total += listaPersonas[i].ObtenerEdad();
        }
    }
    double promedio = total/listaPersonas.Count;
    Console.WriteLine($"Cantidad de personas habilitadas para votar: {cnt}");
    Console.WriteLine($"Promedio de edad: {promedio}");
}

public static void BuscarPersona(){
    Console.WriteLine("Ingrese el DNI de la persona que busca: ");
    int busq = int.Parse(Console.ReadLine());
    foreach (Persona persona in listaPersonas){
        if (persona.DNI == busq){
            Console.WriteLine($"Nombre: {persona.nombre}\nApellido: {persona.apellido}\nFecha de nacimiento: {persona.fechaNacimiento}\nEmail: {persona.email}");
        }
    }
}

public static void ModificarMail(){
    Console.WriteLine("Ingrese el DNI de la persona que busca: ");
    int busq = int.Parse(Console.ReadLine());
    foreach (Persona persona in listaPersonas){
        if (persona.DNI == busq){
            Console.WriteLine("Escriba el nuevo email: ");
            persona.email = Console.ReadLine();
        }
    }
}

public static void ModificarUsuario(){
    Console.WriteLine("Ingrese el DNI de la persona que busca: ");
    int busq = int.Parse(Console.ReadLine());
    foreach (Persona persona in listaPersonas){
        if (persona.DNI == busq){
            Console.WriteLine("Ingrese el nuevo nombre:");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo apellido:");
            persona.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva fecha de nacimiento:");
            persona.fechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo email:");
            persona.email = Console.ReadLine();
        }
    }
}

public static bool dniValido(int dni){
    int i = 0;
    bool esvalido = true;

    while(i<listaPersonas.Count){
        if(dni == listaPersonas[i].DNI){
            esvalido = false;
        }
        i++;
    }
    return esvalido;
}

public static void CargarNuevaPersona(){
    Persona nueva = new Persona();

    Console.WriteLine("Escriba su DNI: ");
    nueva.DNI = int.Parse(Console.ReadLine());
    while(!dniValido(nueva.DNI)){
        Console.WriteLine("Escriba un DNI no ingresado previamente: ");
        nueva.DNI = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Escriba su apellido: ");
    nueva.apellido = Console.ReadLine();
    Console.WriteLine("Escriba su nombre: ");
    nueva.nombre = Console.ReadLine();
    Console.WriteLine("Escriba su fecha de nacimiento: (DD/MM/YYYY)");
    nueva.fechaNacimiento = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Escriba su email: ");
    nueva.email = Console.ReadLine();

    listaPersonas.Add(nueva);
}
}