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

        }
    }
}