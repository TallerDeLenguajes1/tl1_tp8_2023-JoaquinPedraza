// See https://aka.ms/new-console-template for more information
using tl1_tp8_2023_JoaquinPedraza;


//ListaTareas tareasPendientes = new ListaTareas();



//ListaTareas tareaRealizadas = new ListaTareas();

//ToDo todo = new ToDo(tareasPendientes, tareaRealizadas);


//char opcion = '0';
//do
//{

//    Console.Clear();
//    Console.WriteLine("/********menu*********/");
//    Console.WriteLine("1-Añadir tareas pendientes");
//    Console.WriteLine("2-Listar tareas");
//    Console.WriteLine("3-Mover tareas de una pendientes a realizadas");
//    Console.WriteLine("4-Buscar tareas por descripcion en pendientes");
//    //Console.WriteLine("5-Buscar tareas por id");
//    Console.WriteLine("6-Salir");
//    opcion = Convert.ToChar(Console.ReadLine());

//    switch (opcion)
//    {
//        case '1':
//            Console.Clear();
//            todo.añadirTareasEnA();
//            Console.ReadLine();
//            break;
//        case '2':
//            Console.Clear();
//            Console.WriteLine("/******Tareas Pendientes*****/");
//            todo.listarTareasDeA();
//            Console.ReadLine();
//            Console.ReadLine();
//            Console.WriteLine("/******Tareas Realizadas*****/");
//            todo.listarTareasDeB();
//            Console.ReadLine();
//            break;
//        case '3':
//            Console.Clear();
//            Console.WriteLine("Cual es el id de la tarea que desea mover: ");
//            int idTarea = Convert.ToInt32(Console.ReadLine());
//            todo.MoverDeAaB(idTarea);
//            Console.ReadLine();
//            break;
//        case '4':
//            Console.Clear();
//            Console.WriteLine("Cual es la descripcion de la tarea que esta buscando.");
//            string desc = Console.ReadLine();
//            todo.buscarPorDescEnA(desc);
//            Console.ReadLine();
//            break;
//        case '5':
//            break;
//        default:
//            break;
//    }
//} while (opcion != '6');



//todo.MoverDeAaB(2);

//Tarea tareaBuscadaPorDesc = tareasPendientes.buscarTareaPorDesc("tp1");

//if (tareaBuscadaPorDesc.TareaId != -9999)
//{
//    Console.WriteLine("La tarea con desc: " + tareaBuscadaPorDesc.Descripcion + ". existe en la lista dad");
//} else
//{
//    Console.WriteLine("La tarea con desc: tp1. no existe en la lista");
//}

//todo.añadirNTareasEnA(2);

//todo.MoverDeAaB(2);

string path = Directory.GetCurrentDirectory();


DirectoryInfo[] cDirectorios = new DirectoryInfo(@"c:\").GetDirectories();


using (StreamWriter sw = new StreamWriter("../../../direccionesC.txt"))
{
    foreach (DirectoryInfo directorio in cDirectorios)
    {
        sw.WriteLine(directorio.Name);
    }
}

string line = "";
using (StreamReader sr = new StreamReader("../../../direccionesC.txt"))
{
    while ((line = sr.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

Console.WriteLine("Hello, World!");