﻿namespace APIparcial.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum UniType
    {
        Botella, //0
        Metro, //1
        Litro, //2
        Caja //3
    }

    public enum StatusType
    {
        Activo,
        Inactivo
    }

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }

        [Required]
        public UniType Unit { get; set; }
        public StatusType Status { get; set; }

    }
}