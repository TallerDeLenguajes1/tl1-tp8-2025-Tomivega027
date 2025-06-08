namespace Tareas
{
    public enum EstadoTarea
    {
        pendientes = 0,
        realizadas = 1
    }
    public class Tarea // mi clase tarea tiene 4 objetos 
    {
        public int TareaID { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }
        public EstadoTarea Estado { get; set; }

        public Tarea()
        {
            Estado = EstadoTarea.pendientes; // las tareas que se creen tendran por defect. pendientes 
        }

        //obtenemos los valores 
        public Tarea(int TareaID, string Descripcion, int Duracion, EstadoTarea estado)
        {
            this.TareaID = TareaID;
            this.Descripcion = Descripcion;
            this.Duracion = Duracion;
            Estado = estado;
        }

        public string mostrar()
        {
            return TareaID + " | " + Descripcion + " | " + Duracion + " | " + Estado.ToString();
        }


        

        // Validar que esté entre10 y 100
        // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario
    }
}