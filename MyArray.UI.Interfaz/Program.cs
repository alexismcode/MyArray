using MyArray.Logic;

try
{
    // Crear una nueva instancia de la clase Arreglos con capacidad para 10 elementos
    var array = new Arreglos(10);
    bool exit = false;

    while (!exit)
    {
        // Mostrar el menú de opciones
        Console.WriteLine("\n\t----------- Menu: -----------");
        Console.WriteLine("\t| 1. Agregar un numero      |");
        Console.WriteLine("\t| 2. Insertar un numero     |");
        Console.WriteLine("\t| 3. Llenar matriz          |");
        Console.WriteLine("\t| 4. Numeros primos         |");
        Console.WriteLine("\t| 5. Numeros pares          |");
        Console.WriteLine("\t| 6. Numeros no repetidos   |");
        Console.WriteLine("\t| 7. Numeros mas repetidos  |");
        Console.WriteLine("\t| 8. Salir                  |");
        Console.WriteLine("\t-----------------------------\n");
        Console.WriteLine("=============================================\n");

        // Solicitar al usuario que seleccione una opción
        Console.Write("\t> Seleccione una opción: ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("\t\t\tV");

        switch (choice)
        {
            case 1:
                // Agregar un número al arreglo
                Console.Write("\t- Ingrese el número a agregar: ");
                int numToAdd = int.Parse(Console.ReadLine());
                array.Add(numToAdd);
                Console.WriteLine("\n\t¡Número agregado con éxito!");
                Console.WriteLine("\n=============================================\n");
                break;

            case 2:
                // Insertar un número en una posición específica
                Console.Write("\t- Ingrese la posición de inserción: ");
                int position = int.Parse(Console.ReadLine());
                Console.Write("\t- Ingrese el número a insertar: ");
                int numToInsert = int.Parse(Console.ReadLine());
                array.Insert(position, numToInsert);
                Console.WriteLine("\n\t¡Número insertado con éxito!");
                Console.WriteLine("\n=============================================\n");
                break;

            case 3:
                // Llenar la matriz con valores dentro de un rango
                Console.Write("\t- Ingrese el valor mínimo: ");
                int min = int.Parse(Console.ReadLine());
                Console.Write("\t- Ingrese el valor máximo: ");
                int max = int.Parse(Console.ReadLine());
                array.Fill(min, max);
                Console.WriteLine("\n\t¡Matriz llenada con éxito!");
                Console.WriteLine("\n=============================================\n");
                break;

            case 4:
                // Encontrar y mostrar los números primos en el arreglo
                var primeArray = array.Primos();
                Console.WriteLine("\t Números primos:");
                Console.WriteLine($"\t{primeArray}");
                Console.WriteLine("\n=============================================\n");
                break;

            case 5:
                // Encontrar y mostrar los números pares en el arreglo
                var evenArray = array.Pares();
                Console.WriteLine("\t Números pares:");
                Console.WriteLine($"\t{evenArray}");
                Console.WriteLine("\n=============================================\n");
                break;

            case 6:
                // Encontrar y mostrar los números no repetidos en el arreglo
                var nonRepeatArray = array.NotRepetidos();
                Console.WriteLine("\t Números no repetidos:");
                Console.WriteLine($"\t{nonRepeatArray}");
                Console.WriteLine("\n=============================================\n");
                break;

            case 7:
                // Encontrar y mostrar los números más repetidos en el arreglo
                var moreRepeatedArray = array.MoreNumbersRepit();
                Console.WriteLine("\t Números más repetidos:");
                Console.WriteLine($"\t{moreRepeatedArray}");
                Console.WriteLine("\n=============================================\n");
                break;

            case 8:
                // Salir del programa
                exit = true;
                Console.WriteLine("\t Saliendo del programa...");
                Console.WriteLine("\n=============================================\n");
                break;

            default:
                // Manejar opción inválida
                Console.WriteLine("\t Opción no válida. Intente nuevamente.");
                Console.WriteLine("\n=============================================\n");
                break;
        }
    }
}
catch (Exception ex)
{
    // Capturar y mostrar cualquier excepción ocurrida durante la ejecución
    Console.WriteLine(ex.Message);
}