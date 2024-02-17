using MyTaller01.Models;

namespace MyTaller01.Bll
{
    public class ServicesBll
    {
        List<CategoriesModel> ListCategories = new List<CategoriesModel>
        {
            new CategoriesModel
            {
                Id = 1,
                Nombre = "Tecnologia",
                FechaCreacion = DateTime.Today
            },
             new CategoriesModel
            {
                Id = 2,
                Nombre = "Hogar",
                FechaCreacion = DateTime.Today
            },
             new CategoriesModel
            {
                Id = 3,
                Nombre = "Ropa",
                FechaCreacion = DateTime.Today
            },

        };

        List<ProductsModel> ListProducts = new List<ProductsModel>
        {
            new ProductsModel 
            { 
                Id = 1, 
                Nombre = "Laptop", 
                Cantidad = 10, 
                FechaCreacion = DateTime.Today, 
                IdCategoria = 1 
            },
             new ProductsModel
            { 
                Id = 2, 
                Nombre = "Lavadora 19 Kgs", 
                Cantidad = 115, 
                FechaCreacion = DateTime.Today, 
                IdCategoria = 2 
            },
             new ProductsModel 
            { 
                Id = 3, 
                Nombre = "Camisa", 
                Cantidad = 80, 
                FechaCreacion = DateTime.Today, 
                IdCategoria = 3 
            },
             new ProductsModel
            { 
                Id = 4, 
                Nombre = "Impresora Laser HP", 
                Cantidad = 22, 
                FechaCreacion = DateTime.Today, 
                IdCategoria = 1 
            },
             new ProductsModel 
            { 
                Id = 5, 
                Nombre = "Televisor", 
                Cantidad = 75, 
                FechaCreacion = DateTime.Today, 
                IdCategoria = 2 
            }           
        };
               
        public List<CategoriesModel> GetCategories()
        {
            return ListCategories;
        } 

        public List<ProductsModel> GetProductsByCategory(int categoryId)
        {
            return ListProducts.Where(p => p.IdCategoria == categoryId).ToList();
        }

        public List<ProductsModel> GetProductsByQuantity(int number)
        {
            return ListProducts.Where(product => product.Cantidad >= number ).ToList();
        }

        public List<string> GetProductNames()
        {
            return ListProducts.Select(p => p.Nombre).ToList();
           
        }                       
       
    }
}

