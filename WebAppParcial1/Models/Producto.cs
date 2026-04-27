namespace WebAppParcial1.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CategoriaId { get; set; }
        public double Precio { get; set; }
        public string Marca { get; set; }
        public bool Favorito { get; set; }

        public Categoria? categoria { get; set; }

    }
}
