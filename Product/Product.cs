﻿namespace AUTOMAPPPER
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public decimal Precio { get; set; }
    }

    public class ProductDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public decimal Precio { get; set; }
    }
}
