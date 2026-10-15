using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static LINQ.DataSources.Source;


namespace LINQ

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : Get SeaFood Products

            //var seafoodProducts = ProductList.Where(P => P.Category == "Seafood")
            //                                 .Select(P => new { P.ProductName, P.UnitPrice }); // not executed yet (Deffered)
            //foreach (var product in seafoodProducts)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName}   |   Unit Price: {product.UnitPrice}"); // Executed here
            //}

            #endregion

            #region Q2 : Get Products name only
            //var ProductNames = ProductList.Select(P => P.ProductName);
            //Console.WriteLine("Products Name:\n");
            //foreach (var product in ProductNames)
            //{
            //    Console.WriteLine($"{product}");
            //}
            #endregion

            #region Q3 : Get Price between 10 and 30

            //var ProductPrices = ProductList.Where(P=> P.UnitPrice >=10 && P.UnitPrice <= 30)
            //                        .Select(P => new { P.ProductName, P.UnitPrice });

            //foreach (var product in ProductPrices)
            //{
            //    Console.WriteLine($"{product.ProductName} - ${product.UnitPrice:F2}");
            //}

            #endregion

            #region Q4 : Condiments Peeoducts in Stock

            //var CondimentsInStock = ProductList.Where(P => P.Category == "Spices & Condiments" && P.UnitsInStock > 0)
            //                                   .Select(P => new { P.ProductName, P.UnitsInStock });

            //foreach (var product in CondimentsInStock)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName}  |  Units in Stock: {product.UnitsInStock}");
            //}
            #endregion

            #region Q5 : New Anonymous Type with 3 Properties

            //var Products = ProductList.Select(P=>new { 
            //    P.ProductName,
            //    P.UnitPrice,
            //    StockStatus = P.UnitsInStock > 0 ? "Available" : "Out Of Stock"});

            //foreach (var product in Products)
            //{
            //    Console.WriteLine($"{product.ProductName}  -  ${product.UnitPrice}  -  {product.StockStatus}");
            //}

            #endregion

        }
    } 
}