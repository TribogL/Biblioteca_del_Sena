//A program that simulates the management of the Sena's library.
using Biblioteca_del_sena.Models;

List<Libro> biblioteca = new List<Libro> { };

var open = true;
while (open)
{
    Console.Clear();
    Console.WriteLine(@"/////////////// Biblioteca del Sena \\\\\\\\\\\\\");
    Console.WriteLine(@"///////// menu principal \\\\\\\\\\\\
1)Agregar un libro.
2)Buscar un libro.
3)Eliminar un libro.
4)Ver listado de libros.
5)Salir");
    int selection = int.Parse(Console.ReadLine());
    switch (selection)
    {
        case 1:
            Console.Clear();
            AddBook();
            Continue();
            break;
        case 2:
            bool inSearchMenu = true;
            while (inSearchMenu)
            {
                Console.Clear();
                Console.WriteLine(@"//////// menu de busqueda \\\\\\\\\\\");
                Console.WriteLine(@"
1)Buscar un libro por género.
2)Buscar un libro por autor.
3)Buscar un libro por rango de año.
4)Salir al menu principal.");
                int filterSelector = int.Parse(Console.ReadLine());
                switch (filterSelector)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine(@"///////// Buscar libro por género \\\\\\\\\");
                        // Aquí iría el código para buscar por género
                        Continue();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(@"///////// Buscar libro por autor \\\\\\\\\\\\");
                        // Aquí iría el código para buscar por autor
                        Continue();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(@"////// Buscar libro por rango de año de lanzamiento \\\\\\");
                        // Aquí iría el código para buscar por rango de año
                        Continue();
                        break;
                    case 4:
                        inSearchMenu = false;
                        break;
                }
            }
            break;
        case 3:
            Console.Clear();
            Console.WriteLine(@"///////////// Eliminar libros \\\\\\\\\\\\\\\\\");
            // Aquí iría el código para eliminar un libro
            Continue();
            break;
        case 4:
            bool inListMenu = true;
            while (inListMenu)
            {
                Console.Clear();
                Console.WriteLine(@"///////// submenu de listas \\\\\\\\\\\\");
                Console.WriteLine(@"
1)Ver listado de libros por orden alfabético.
2)Ver listado de libros por año de publicación.
3)Salir al menu principal.");
                int listSelection = int.Parse(Console.ReadLine());
                switch (listSelection)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(@"//////// Listado en orden alfabético \\\\\\\\\\");
                        // Aquí iría el código para listar por orden alfabético
                        Continue();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(@"////////// Listado por año de publicación \\\\\\\\\\\");
                        // Aquí iría el código para listar por año de publicación
                        Continue();
                        break;
                    case 3:
                        inListMenu = false;
                        break;
                }
            }
            break;
        case 5:
            Console.Clear();
            Console.WriteLine(@"/////////// Salida del programa \\\\\\\\\\\\");
            Console.WriteLine("¿Está seguro que desea salir del programa?");
            Console.WriteLine(@"
1)Sí
2)No");
            int programExit = int.Parse(Console.ReadLine());
            if (programExit == 1)
            {
                open = false;
            }
            else
            {
                Continue();
            }
            break;
    }
}

void Continue()
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
}

void AddBook()
{

    Console.WriteLine(@"////////////// Agregar un libro a la Biblioteca \\\\\\\\\\\\\\\\");
    Console.Write("Escriba el nombre del libro: ");

    Console.Write("Ingrese el nombre del autor del libro: ");
    Console.Write("Ingrese el ISBN: ");
    Console.Write("Digite la fecha de publicacion de manera AAAA-MM-DD: ");
    Console.Write("Escriba el genero del libro: ");
    Console.Write("Ingrese el precio del libro: ");
}