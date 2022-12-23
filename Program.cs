//Ejercicio 1
//Crea una estructura de datos para un cliente con estos campos:

//Desarrollo

Console.WriteLine("*********FORMAULARIO**************");
Empresa datosCliente = new Empresa();

Console.WriteLine("Nombre del Cliente: ");
string cliente = datosCliente.cliente = Console.ReadLine();
Console.WriteLine("Telefono: ");
string tel = datosCliente.telefono = Console.ReadLine();
Console.WriteLine("Direccion: ");
string direccion = datosCliente.direccion = Console.ReadLine();
Console.WriteLine("Correo Electronico: ");
string correo = datosCliente.correo = Console.ReadLine();
Console.WriteLine("Tipo de Cliente: ");
string estado = datosCliente.estado = Console.ReadLine();

Console.WriteLine("***********INFORMACION DEL CLIENTE****************");
Console.WriteLine(
    "\n Cliente: " + cliente
    + "\n Telefono: " + tel
    + "\n Direccion: " + direccion
    + "\n Correo Electronico: " + correo
    + "\n Tipo de Cliente: " + estado
    );
Console.ReadLine();


//Estructura
public struct Empresa
{
    public Empresa (string client, string tel, string direc, string email, string status)
    {
        cliente = client;
        telefono = tel;
        direccion = direc;
        correo = email;
        estado = status;
    }

    public string cliente { get; set; }
    public string telefono { get; set; }
    public string direccion { get; set; }
    public string correo { get; set; }
    public string estado { get; set; }

}

