using System.Collections.Generic;
namespace WorkingWithVisualStudio.Models
{
    public class SimpleRepository : IRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository(); // private object that can't be used outside the class
        private Dictionary<string, Product> products
        = new Dictionary<string, Product>();
        public static SimpleRepository SharedRepository => sharedRepository; // Expression body method: same as below. SharedRepository is a property
        //public static SimpleRepository SharedRepository()
        //{
        //    return sharedRepository;
        //}
        public SimpleRepository()
        {
            var initialItems = new[] // object initializer syntax
            {
                new Product { Name = "Kayak", Price = 275M }, // This is an anonymous object
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M },
                new Product { Name = "Corner flag", Price = 34.95M }
            };
            foreach (var p in initialItems)
                AddProduct(p);
            products.Add("Error", null);
        }
        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product p) => products.Add(p.Name, p); // same as below
        //public void AddProduct(Product p)
        //{
        //   products.Add(p.Name, p);  This is an adapter pattern.
        //}
    }
}
