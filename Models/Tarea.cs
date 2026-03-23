namespace ListaDeTareas.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Tarea(int Id, string Titulo, string Descripcion, DateTime FechaCreacion) {

                this.Id = Id;
                this.Titulo = Titulo;
                this.Descripcion = Descripcion;
                this.FechaCreacion = FechaCreacion;


        }

    }
}
