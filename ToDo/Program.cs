using Tareas;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Tarea> TareaPendientes = new List<Tarea>();
List<Tarea> TareaRealizadas = new List<Tarea>();

int CantTareas;
Console.WriteLine("Ingrese la cantidad de tareas:");// pedimos que ingrese la cantidad de tarea aagregar
string numero = Console.ReadLine();
int.TryParse(numero, out CantTareas);

string[] descripcion = { "calculo1", "calculo2", " taller", "arquitectura", "algebra" };//colocamos decripciones definidas


for (int i = 0; i < CantTareas; i++)
{
    int duracion;
    Console.WriteLine($"ingrese la duracion de la tarea numero{i + 1} :");
    string buff = Console.ReadLine();
    int.TryParse(buff, out duracion);// hasta aqui pedimos duracion de la tarea 
    Tarea nueva = new Tarea(i , descripcion[i] , duracion , EstadoTarea.pendientes);
    // hacemos un tarea nueva para poder ingresar los datos de tipo tarea y
    //  luego insertarlos en tareas pendientes
    TareaPendientes.Add(nueva);// aqui pasamos los datos a tarea pendientes
}
//aqui recorremos con un foreach para mostrar lo que tiene TareasPendientes 
foreach (Tarea pendientes in TareaPendientes)
{
    Console.WriteLine(pendientes.mostrar());
}
    int cambiar;
do
{
    cambiar = 0;
    Console.WriteLine("si desea pasar tareas pendientes a realizadas (PRESIONE 1):");
    Console.WriteLine("si NO desea pasar tareas pendientes a realizadas (PRESIONE 0)");
    string buff1 = Console.ReadLine();
    int.TryParse(buff1, out cambiar);

    if (cambiar == 1)
    {
        int id;
        Console.WriteLine("ingrese el id de la tarea que quiere pasar a realizadas:");
        string buff2 = Console.ReadLine();
        int.TryParse(buff2, out id);

        foreach (Tarea pendientes in TareaPendientes)// recorremos pendientes para pasar tarea
        {
            if (pendientes.TareaID == id)
            {
                pendientes.Estado = EstadoTarea.realizadas;
                TareaRealizadas.Add(pendientes);

            }
        }
        //removemos afuera , adentro de foreach no funciona
        TareaPendientes.RemoveAt(id);
    }

} while (cambiar == 1);

Console.WriteLine("ingrese una descripcion de tarea pendientes a buscar:");
string buscarDescrip = Console.ReadLine();

foreach (Tarea pendientes in TareaPendientes)
{
    if (pendientes.Descripcion == buscarDescrip)
    {
        Console.WriteLine(pendientes.mostrar());
    }
}

//mostramos realizadas y pendientes
Console.WriteLine("-------REALIZADAS-------");
foreach (Tarea realizadas in TareaRealizadas)
{
    Console.WriteLine(realizadas.mostrar());
}

Console.WriteLine("-------PENDIENTES-------");
foreach (Tarea pendientes in TareaPendientes)
{
    Console.WriteLine(pendientes.mostrar());
}





