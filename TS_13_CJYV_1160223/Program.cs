public class Persona
{
    public string? Nombre { get; set; }
    public string? Apelidos { get; set; }
    public int Edad { get; set; }

    public int Altura { get; set; }

    
}

public class Ejercicio
{

    
    public string nombre(Persona[] personas)
    {
        Persona[] resultado = new Persona[1];

        string nombre;
        string apellido;
        string nombrecompleto;
        for (int i = 0; i < resultado.Length; i++)
        {

            nombrecompleto = nombre;

        }
        promedio = Suma / personas.Length;

        return promedio;
    }
    public double altura(Persona[] personas)
    {
        Persona[] resultado = new Persona[1];

        double Suma = 0;
        double promedio = 0;
        for (int i = 0; i < resultado.Length; i++)
        {

            Suma = Suma + personas[i].Edad;

        }
        promedio = Suma / personas.Length;

        return promedio;
    }

    static void Main()
    {

        string menu = "";
        while (!menu.Equals("4"))
        {

            Console.Clear();
            Console.WriteLine("Trabajo Supervisado - Christopher Javier Yuman Valdez - 1160223");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Salir del programa");
            Console.WriteLine("Ingrese una opcion");
            string opcion = (Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Imprimir("Christopher Javier Yuman Valdez ");
                    Console.WriteLine("Ejercicio 1");
               
                    Persona[] arreglo6 = new Persona[1];
                    Persona Persona1 = new Persona();
                    string nombre;
                    string apellidos;
                    int edad;
                    double altura;

                    Console.WriteLine("Ingresa el nombre persona 1");
                    Persona1.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa el apellido de la persona 1");
                    Persona1.Apelidos = Console.ReadLine();
                    Console.WriteLine("Ingresa el Edad");
                    Persona1.Edad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa su altura");
                    Persona1.Altura = Convert.ToInt32(Console.ReadLine());



                    arreglo6[0] = Persona1;
                    


                    Ejercicio miejercio6 = new Ejercicio();
                    double resultado6 = 0;
                    resultado6 = miejercio6.Ejercicio6(arreglo6);
                    Console.WriteLine("El promedio es: " + resultado6);

                    Console.ReadKey();


                    Console.ReadKey();
                    break;




                case "2":
                    Console.Clear();

                    Imprimir("Christopher Javier Yuman Valdez ");
                    Console.WriteLine("Ejercicio 2");
                    
                    Console.ReadKey();

                    break;
         
                    
                case "3":
                    menu = "4";
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion del 1 al 3");
                    Console.ReadKey();
                    break;
            }
        }
        Console.ReadKey();
        static void Imprimir(string nombre)
        {
            Console.WriteLine("Trabajo supervisado - " + nombre + "- 1160223");
        }


    }

}