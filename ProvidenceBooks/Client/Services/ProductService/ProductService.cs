
using System;
using System.Collections.Generic;
using ProvidenceBooks.Shared;

namespace ProvidenceBooks.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>
            {
                 new Product
            {
                ProductId = 1,
                CategoryId = 1,
                ProductName = "Do You Believe?",
                Price = 35,
                OriginalPrice = 32,
                Image = "./images/books/book1.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",

            },
             new Product
            {
                ProductId = 2,
                CategoryId = 2,
                ProductName = "Paul and His Letters",
                Price = 39,
                OriginalPrice = 54,
                Image = "./images/books/book2.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",

            },
             new Product
            {
                ProductId =3,
                CategoryId = 2,
                ProductName = "The Holy Spirit in the New Testament",
                Price = 19,
                OriginalPrice = 28,
                Image = "./images/books/book3.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",

            },
             new Product
            {
                ProductId = 4,
                CategoryId = 2,
                ProductName = "The Letters to the Romans: A Short Commentary",
                Price = 19,
                OriginalPrice = 26,
                Image = "./images/books/book4.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",

            },
             new Product
            {
                ProductId = 5,
                CategoryId = 3,
            ProductName = "Basics of Bibilcal Greek Grammar",
                Price = 33,
                OriginalPrice = 59,
                Image = "./images/books/book5.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",

            },
             new Product
            {
                ProductId = 6,
                CategoryId = 3,
                ProductName = "The Old in The New",
                Price = 22,
                OriginalPrice = 25,
                Image = "./images/books/book6.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",

            },



        };
        }
    }


}