using Caso1_GestionLibros.Models;

namespace Caso1_GestionLibros.Data
{
    public class LibroRepository
    {
        private static List<Libros> _libros = new List<Libros>();

        public void AgregarLibro(Libros libro)
        {
            _libros.Add(libro);
        }

        public List<Libros> ObtenerLibros()
        {
            return _libros;
        }

        public bool ExisteCodigoInterno(string codigoInterno)
        {
            return _libros.Any(l => l.CodigoInterno.Equals(codigoInterno, StringComparison.OrdinalIgnoreCase));
        }


    } //class
} //end
