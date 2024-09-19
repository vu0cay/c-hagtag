using Microsoft.VisualBasic;
using MyApp.Models;

namespace MyApp;
class Query
{
    public void getProducts()
    {
        NorthwindContext northwindContext = new NorthwindContext();
        var res = from product in northwindContext.Products
                  select product;
        foreach (var product in res)
        {
            System.Console.WriteLine("ID: {0}, Name: {1}, Price: {2}", product.ProductId, product.ProductName, product.Price);
        }
    }
    public void getProductByFields()
    {
        NorthwindContext northwindContext = new NorthwindContext();
        var res = from product in northwindContext.Products
                  select new
                  {
                      id = product.ProductId,
                      name = product.ProductName,
                      price = product.Price
                  };
        foreach (var product in res)
        {
            System.Console.WriteLine("ID: {0}, Name: {1}, Price: {2}", product.id, product.name, product.price);
        }
    }
    public void getProductByJoin()
    {
        NorthwindContext northwindContext = new NorthwindContext();
        var res = from product in northwindContext.Products
                  join supplier in northwindContext.Suppliers on product.SupplierId equals supplier.SupplierId
                  select product;
        foreach (var product in res)
        {

            System.Console.WriteLine("ID: {0}, Name: {1}, Price: {2}, Supplier name: {3}, Contact: {4}",
                                product.ProductId, product.ProductName, product.Price);

        }
    }
    public void getGroups(int price)
    {
        NorthwindContext northwindContext = new NorthwindContext();
        var res = from product in northwindContext.Products
                  where product.Price <= price
                  group product by product.Price;
        foreach (var group in res)
        {
            System.Console.WriteLine(group.Key);
            foreach (var product in group)
            {
                System.Console.WriteLine("ID: {0}, Name: {1}, Price: {2}",
                                    product.ProductId, product.ProductName, product.Price);
            }
        }
    }
    public void getGroupsCount(int price)
    {
        NorthwindContext northwindContext = new NorthwindContext();
        var res = from product in northwindContext.Products
                  where product.Price <= price
                  group product by product.Price;
        foreach (var group in res)
        {
            System.Console.WriteLine(group.Key + " have: " + group.Count());
        }
    }
    public void insertLinq()
    {
        NorthwindContext northwindContext = new NorthwindContext();
        Product product = new Product();
        product.ProductId = 78;
        product.ProductName = "Desk";
        product.Price = 30;
        northwindContext.Products.Add(product);
        northwindContext.SaveChanges();
        System.Console.WriteLine("inserted successfully");
    }
    public void updateLinq()
    {
        NorthwindContext northwindContext = new NorthwindContext();
        var product = northwindContext.Products.Single(product => product.ProductId == 78);
        product.ProductName = "Table";
        northwindContext.SaveChanges();
        System.Console.WriteLine("Updated successfully");
    }
    public void deleteLinq()
    {
        NorthwindContext northwindContext = new NorthwindContext();
        var product = northwindContext.Products.Single(product => product.ProductId == 78);
        northwindContext.Remove(product);
        northwindContext.SaveChanges();
        System.Console.WriteLine("deleted successfully");
    }
}