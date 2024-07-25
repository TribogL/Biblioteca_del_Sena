//A program that simulates the management of the Sena's library.
using Biblioteca_del_sena.Models;

List<Libro> biblioteca = new List<Libro> { };

var open = true;
while (open)
{
    Console.Clear();
    Console.WriteLine(@"/////////////// Biblioteca del Sena \\\\\\\\\\\\\
    
    ");
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
                        ShowBookByGender();
                        Continue();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(@"///////// Buscar libro por autor \\\\\\\\\\\\");
                        ShowBoockByAuthor();
                        Continue();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(@"////// Buscar libro por rango de año de lanzamiento \\\\\\");
                        ShowBookByDate();
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
            DeleteBook();
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
                Console.WriteLine(@"///////// vuelva pronto \\\\\\\\\\");
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
    Console.Write("Ingrese el titullo del libro: ");
    string? titulo1 = Console.ReadLine();
    Console.Write("Ingrese el nombre del autor del libro: ");
    string? autor1 = Console.ReadLine();
    Console.Write("Ingrese el genero del libro: ");
    string? genero1 = Console.ReadLine();
    Console.Write("Digite la fecha de publicacion de manera AAAA-MM-DD: ");
    int fecha1 = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el precio del libro: ");
    double precio1 = double.Parse(Console.ReadLine());

    Libro newLibro = new Libro(titulo1, autor1, genero1, fecha1, precio1);
    biblioteca.Add(newLibro);
}

void ShowBookByGender()
{
    Console.Write("Ingrese el genero: ");
    string? generoselect = Console.ReadLine();
    var librosFiltrados = biblioteca.Where(libro => libro.Genero.Equals(generoselect, StringComparison.OrdinalIgnoreCase)).ToList();
    if (librosFiltrados.Any())
    {
        foreach (var libro in librosFiltrados)
        {
            Console.WriteLine($@"Titulo: {libro.Titulo}
Genero: {libro.Genero}
Autor: {libro.Autor}
fecha de publicacion: {libro.FechaDePublicacion}
precio: ${libro.Precio}
");
        }
    }
    else
    {
        Console.WriteLine("No tenemos libros de ese género por el momento...");
    }
}

void ShowBoockByAuthor()
{
    Console.Write("Ingrese el nombre del autor: ");
    string? authorselect1 = Console.ReadLine();
    var librosFiltrados1 = biblioteca.Where(libro => libro.Autor.Equals(authorselect1, StringComparison.OrdinalIgnoreCase)).ToList();
    if (librosFiltrados1.Any())
    {
        foreach (var libro in librosFiltrados1)
        {
            Console.WriteLine($@"Titulo: {libro.Titulo}
Genero: {libro.Genero}
Autor: {libro.Autor}
fecha de publicacion: {libro.FechaDePublicacion}
precio: ${libro.Precio}
");
        }
    }
    else
    {
        Console.WriteLine("No tenemos libros de ese autor por el momento...");
    }
}

void ShowBookByDate()
{
    Console.Write("Ingrese la fecha de publicación (AAAA/MM/DD): ");
    DateTime dateselect1;
    if (DateTime.TryParse(Console.ReadLine(), out dateselect1))
    {
        var librosFiltrados1 = biblioteca.Where(libro => libro.FechaDePublicacion.DayOfYear == dateselect1.DayOfYear).ToList();
        if (librosFiltrados1.Any())
        {
            foreach (var libro in librosFiltrados1)
            {
                Console.WriteLine($@"Titulo: {libro.Titulo}
Genero: {libro.Genero}
Autor: {libro.Autor}
Fecha de publicacion: {libro.FechaDePublicacion}
Precio: ${libro.Precio}
");
            }
        }
        else
        {
            Console.WriteLine("No tenemos libros con esa fecha de publicación por el momento...");
        }
    }
    else
    {
        Console.WriteLine("Fecha inválida. Por favor, ingrese la fecha en el formato AAAA/MM/DD.");
    }
}

void DeleteBook()
{
    Console.Write("Digite el título del libro que desea eliminar: ");
    string? bookSelect = Console.ReadLine();
    
    // Encuentra los libros que coinciden con el título
    var booksToErase = biblioteca.Where(libro => libro.Titulo.Equals(bookSelect, StringComparison.OrdinalIgnoreCase)).ToList();
    
    if (booksToErase.Any())
    {
        // Eliminar cada libro que coincida
        foreach (var libro in booksToErase)
        {
            biblioteca.Remove(libro);
        }
        Console.WriteLine("El libro ha sido eliminado exitosamente.");
    }
    else
    {
        Console.WriteLine("No se encontró ningún libro con ese título.");
    }
}

void Discount()
{
    
}