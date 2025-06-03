namespace ManejoDeTareas
{
    
public class Tarea {    
    Tarea value;
 public int TareaID { get; set; }
 public string Descripcion { get; set; }
 public int Duracion { get; set; } // Validar que esté entre
public EstadoTarea Estado { get => estado; set => estado = value; }

        //10 y 100
        // Puedes añadir un constructor y métodos auxiliares si
        //lo consideras necesario
        EstadoTarea estado;
public Tarea(){
    Estado = EstadoTarea.pendiente;
}

public Tarea(int TareaID, string Descripcion, int Duracion, EstadoTarea estado){
    this.TareaID = TareaID;
    this.Descripcion = Descripcion;
    this.Duracion = Duracion;
    this.estado = estado;
}
public string MostrarTarea(){
    return TareaID + " | " + Descripcion + " | " + Duracion + " | " + Estado.ToString();
}

    List<Tarea> tareasPendientes = new List<Tarea>();
    List<Tarea> tareasRealizadas = new List<Tarea>();
    //tareasPendientes.añadir();

}
}
public enum EstadoTarea{
    pendiente = 0,
    completada = 1
}