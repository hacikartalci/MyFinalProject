using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle - Yazılıma yeni bir özellik ekleme sırasında mevcutta ki hiçbir koduna dokunamazsın. (Business hariç!)
    class Program
    {
        static void Main(string[] args)
        {
            //DTO - Data Transformation Object
            ProductTest();
            //IoC Container
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
