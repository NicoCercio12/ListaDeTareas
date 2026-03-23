namespace ListaDeTareas.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public bool Completada { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Tarea(int Id, string Titulo, string Descripcion, bool Completada, DateTime FechaCreacion) {

                this.Id = Id;
                this.Titulo = Titulo;
                this.Completada = Completada;
                this.Descripcion = Descripcion;
                this.FechaCreacion = FechaCreacion;


        }

    }
}
