using ListaDeTareas.Data;
using ListaDeTareas.Models;

namespace ListaDeTareas.Services
{
    public class TareaService
    {

        private readonly AppDbContext _context;

        public TareaService(AppDbContext context)
        {
            _context = context;
        }


        public bool AgregarTarea(string Titulo, string Descripcion, DateTime FechaCreacion)
        {
            List<Tarea> tareas = new List<Tarea>();

            int i = 0;
            bool existe = false;

            while (i < tareas.Count && !existe)
            {
                Tarea t = tareas[i];

                if (string.Equals(t.Titulo, Titulo, StringComparison.OrdinalIgnoreCase) && string.Equals(t.Descripcion, Descripcion, StringComparison.OrdinalIgnoreCase))
                {
                    existe = true;
                }

                i++;
            }

            if (existe)
            {
                throw new Exception("La tarea ya existe");
            }

            _context.Tareas.Add(new Tarea(0, Titulo, Descripcion, FechaCreacion));
            _context.SaveChanges();

            return true;
        }

        public List<Tarea> ListarTareas()
        {
            List<Tarea> tareas = new List<Tarea>();

            foreach (Tarea t in _context.Tareas)
            {
                tareas.Add(t);
            }

            return tareas;
        }



    }
}
