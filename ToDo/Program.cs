// See https://aka.ms/new-console-template for more information
using ManejoDeTareas;
Console.WriteLine("Hello, World!");
//Tarea[] Tareas = new Tarea[3];
string [] descripcion = {"Calculo 1, Algebra 2, Labo 5, Taller 4, AED2"};

class GestorDeTareas
{
    List<Tarea> tareasPendientes;
    List<Tarea> tareasRealizadas;
    int contadorId;
    public GestorDeTareas(){
        tareasRealizadas = new List<Tarea>();
        tareasPendientes = [];
        contadorId = 1;
    }
    public void agregarTarea(Tarea nuevaTarea){
        nuevaTarea.TareaID = contadorId++;
        tareasPendientes.Add(nuevaTarea);
    }
    public int CantidadtareasPendientes(){
        return tareasPendientes.Count;
    }
}
/* var Tareas = new List<Tarea>();

for (int i = 0; i < ; i++)
{
    
}

foreach (var tarea in Tareas)
{
    Console.WriteLine(tarea.MostrarTarea());
} */

//Console.WriteLine("Cantidad de tareas:" + Tareas.Count);
/* for (int i = 0; i < TareasDia.Length; i++)
{
    TareasDia[i] = new Tarea();
    TareasDia[i].TareaID = i;
    TareasDia[i].Descripcion = "Calculo3";
    TareasDia[i].Duracion = 11;
    Console.WriteLine(TareasDia[i].MostrarTarea());
}    */
