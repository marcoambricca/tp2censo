public class Persona {
    public int DNI {get;set;}
    
    public string apellido {get;set;}

    public string nombre {get;set;}

    public DateTime fechaNacimiento {get;set;}

    public string email {get;set;}

    public Persona(){

    }
    public Persona(int dni, string ape, string nom, DateTime nacimiento, string mail){
        DNI = dni;
        apellido = ape;
        nombre = nom;
        fechaNacimiento = nacimiento;
        email = mail;
    }

    public bool PuedeVotar(){
        /*int num = DateTime.Now.Year-fechaNacimiento.Year;
        DateTime temp = fechaNacimiento;
        int añosMas = (DateTime.Now.Year-fechaNacimiento.Year);
        temp.AddYears(añosMas);
        if(DateTime.Now < temp){
            num--;
        }

        return num >= 16;*/

        return (DateTime.Now - fechaNacimiento).Days/365 >= 16;
    }

    public int ObtenerEdad(){
        return (DateTime.Now - fechaNacimiento).Days/365;
    }
}