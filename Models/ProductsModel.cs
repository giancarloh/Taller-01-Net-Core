namespace MyTaller01.Models
{
    public class ProductsModel
    {
        public int Id {get; set;}
        public string? Nombre {get; set;}
        public int Cantidad {get; set;}         
        public DateTime FechaCreacion {get; set;}
        public int IdCategoria {get; set;}
    }
}