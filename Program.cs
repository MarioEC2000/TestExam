// See https://aka.ms/new-console-template for more information

Menu();

static void Menu()
{
    string opcion = string.Empty;

    do
    {
        Console.WriteLine("Bienvenido!");
        Console.WriteLine("!=======================!");
        Console.WriteLine("Ingresa la opcion que deseas usar:");
        Console.WriteLine("1) Validar numero positivo o negativo");
        Console.WriteLine("2) Imprimir dia");
        Console.WriteLine("3) Suma de los primeros 100 numeros naturales");
        Console.WriteLine("4) Imprimir todos los numeros desde el 1 hasta el ingresado");
        Console.WriteLine("5) Calcular el area de un circulo");
        Console.WriteLine("6) Mostrar elementos de arreglo");
        Console.WriteLine("7) mostrar nombres de personas");
        Console.WriteLine("8) Salir");
        opcion = Console.ReadLine();

      

        switch (opcion)
        {
            case "1":
                ValidarNumero();
                break;
            case "2":
                ImprimirDia();
                //Console.WriteLine("Resultado de resta " + (n1 - n2));
                break;
            case "3":
                Console.WriteLine("La suma de los primeros 100 numeros naturales es : " +SumaNaturales());
                //Console.WriteLine("Resultado de multiplicacion " + (n1 * n2));
                break;
            case "4":
                ImprimirNumeros();
                //Console.WriteLine("Resultado de division " + (n1 / n2));
                break;
            case "5":
                Console.WriteLine($"El área del círculo es: {CalcularAreaCirculo()} m");
                //Console.WriteLine("Resultado de Suma " + (n1 + n2));
                break;
            case "6":
                ImprimirArreglo();
                //Console.WriteLine("Resultado de Suma " + (n1 + n2));
                break;
            case "7":
                ImprimirNombresPersonas();
                //Console.WriteLine("Resultado de Suma " + (n1 + n2));
                break;
            default:
                break;
        }


    } while (!opcion.Equals("8"));

    Console.WriteLine("Adios!");
    Console.WriteLine("!=======================!");

}

static void ValidarNumero()
{
    Console.WriteLine("Ingresar el n1 : ");
    int n1 = int.Parse(Console.ReadLine());

    if (n1 < 0 )
    {
        Console.WriteLine("Es un numero negativo "+ n1);
    }else if (n1 > 0)
    {
        Console.WriteLine("Es un numero positivo " + n1);
    }
    else 
    {
        Console.WriteLine("Es 0");
    }

}

static void ImprimirDia()
{
    Console.WriteLine("Ingresar el numero del dia : ");
    string n1 = Console.ReadLine();

    switch (n1)
    {
        case "1":
            Console.WriteLine("Es lunes!");
            break;
        case "2":
            Console.WriteLine("Es Martes!");
            break;
        case "3":
            Console.WriteLine("Es Miercoles!");
            break;
        case "4":
            Console.WriteLine("Es Jueves!");
            break;
        case "5":
            Console.WriteLine("Es Viernes!");
            break;
        case "6":
            Console.WriteLine("Es Sabado!");
            break;
        case "7":
            Console.WriteLine("Es Domingo!");
            break;
        default:
            Console.WriteLine("Estas fuera del rango de dias , la semana solo tiene 7 dias!");
            break;
    }
}

static int SumaNaturales()
{
    int sumaTotal = 0;

    for (int i = 1; i <= 100; i++)
    {
        sumaTotal +=  i;
    }

    return sumaTotal;
}

static void ImprimirNumeros()
{
    Console.WriteLine("Ingresar el n1 : ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Imprimiendo numeros hasta : "+n1);

    for (int i = 0; i <= n1; i++)
    {
        Console.WriteLine(".-"+i);
    }
}

static double CalcularAreaCirculo()
{
    Console.Write("Ingrese el radio del círculo: ");
    double radio = Convert.ToDouble(Console.ReadLine());

    return Math.Round(Math.PI * Math.Pow(radio, 2),2);

}

static void ImprimirArreglo()
{
    Console.WriteLine("=====Imprimiendo arreglo======");
    int[,] alumnosNotas = new int[2, 2];

    alumnosNotas[0, 0] = 10;
    alumnosNotas[0, 1] = 1;

    alumnosNotas[1, 0] = 20;
    alumnosNotas[1, 1] = 2;


    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"alumno {alumnosNotas[i, 1]} su nota es {alumnosNotas[i, 0]}"); 
    }


}

static void ImprimirNombresPersonas()
{
    Console.WriteLine("=====Imprimiendo lista======");
    List<string> nombres = new();

    nombres.Add("Mariano");
    nombres.Add("Carlos");
    nombres.Add("Jesus");
    nombres.Add("Fer");

    foreach (var nombre in nombres)
    {
        Console.WriteLine("Hola "+nombre);
    }

}

