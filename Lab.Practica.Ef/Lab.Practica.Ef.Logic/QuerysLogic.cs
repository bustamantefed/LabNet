using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Practica.Ef.Entities;



namespace Lab.Practica.Ef.Logic
{
    public class QuerysLogic : BaseLogic
    {
        //query 1 
        public List<Customers> QueryObjectCustomers()
        {
            var query = from C in context.Customers
                        select C;
            return query.ToList();
        }

        // query 2 
        public List<Products> ProducsNullStock()
        {
            var method = context.Products.Where(p => p.UnitsInStock == 0);
            return method.ToList();
        }

        // query 3 

        public List<Products> ProducsWithStocktock()
        {
            var method = context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            return method.ToList();
        }

        // query 4 
        public List<Customers> CustomersRegionWA()
        {
            var query = from C in context.Customers
                        where C.Region.Contains("WA")
                        select C;
            return query.ToList();
        }

        // QUERY 5
        public List<Products> ProductID789()
        {
            var query = from p in context.Products
                        where p.ProductID == 789
                        select p;
            return query.ToList();
        }

        // query 6 
        public List<Customers> NameCustomersUpperAndLower()
        {
            List<string> DTToUpper = new List<string>();
            var query = context.Customers;
            foreach (var item in query)
            {
                DTToUpper.Add(item.CompanyName);
            }
            return query.ToList();
        }

        // query 7
        public List<Orders> JoinCustomersOrders()
        {
            var query = (from o in context.Orders
                         join c in context.Customers on o.CustomerID equals c.CustomerID
                         into union_c_o
                         from c_o in union_c_o.DefaultIfEmpty()
                         where o.OrderDate > new DateTime(1997, 01, 01) && c_o.Region == "WA"
                         select o).ToList();

            return query;
        }
        // query 8
        public List<Customers> Top3WithRegion()
        {
            var query = (from c in context.Customers
                         where c.Region == "WA"
                         select c).Take(3);
            return query.ToList();
        }
        //query 9
        public List<Products> ProductsOrderByName()
        {
            var query = context.Products.OrderBy(p => p.ProductName);
            return query.ToList();
        }
        //query 10
        public List<Products> OrderByPrice()
        {
            var query = context.Products.OrderBy(p => p.UnitsInStock);
            return query.ToList();
        }
        //query 11
        public List<Categories> CategoryAssociatedWithProduct()
        {
            var query = (from c in context.Categories
                         join p in context.Products
                         on c.CategoryID equals p.CategoryID
                         into union_c_p
                         from c_p in union_c_p.DefaultIfEmpty()
                         orderby c.CategoryID ascending
                         select c).ToList();

            return query.ToList();
        }
        //query 12

        //public List<Products> FirstProduct()
        //{
        //    //var query = context.Products.FirstOrDefault();
        //    //return query;
        //}
        //// query 13

        public List<Orders> CustomersWithAssociatedOrders()
        {
            var query = (from o in context.Orders
                         join c in context.Customers
                         on o.CustomerID equals c.CustomerID
                         into union_o_c
                         from o_c in union_o_c.DefaultIfEmpty()

                         select new
                         {
                             Clientes = o_c,
                             Ordenes = o.OrderID
                         }).ToList();

            return query;
        }
    }
}
