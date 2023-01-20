﻿namespace Testing.Models
{
    public class Product
    {
        public int ProductsID { get; set; }
        public string Name { get; set;}
        public double Price { get; set;}

        public int CategoryID { get; set;}
        public int OnSale { get; set;}
        public int StockLevel { get; set;}
    }
}
