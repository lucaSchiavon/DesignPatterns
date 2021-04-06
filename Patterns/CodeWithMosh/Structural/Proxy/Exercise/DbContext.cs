using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Proxy.Exercise
{
    public class DbContext
    {
        private Dictionary<int, IProduct> updatedObjects = new Dictionary<int, IProduct>();

        public IProduct getProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine($"SELECT * FROM products WHERE product_id = {id}");

            // Simulate reading a product object from a database.
            var product = new ProductProxy(id, this);
            product.setName("Product 1");

            return product;
        }

        public void saveChanges()
        {
            // Automatically generate SQL statements
            // to update the database.
            foreach (KeyValuePair<int, IProduct> dict in updatedObjects)
            {
                
                Console.WriteLine($"UPDATE products SET name = '{dict.Value.getName()}' WHERE product_id = {dict.Value.getId()}");
            }
           
            updatedObjects.Clear();
        }

        public void markAsChanged(IProduct product)
        {
            updatedObjects[product.getId()]=product;
        }

    }
}
