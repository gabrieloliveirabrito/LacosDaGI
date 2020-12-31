using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LacosDaGI.DataModels
{
    public class SaleItem
    {
        public int Id { get; set; }

        public Tie Tie { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        [NotMapped]
        public decimal TotalPrice
        {
            get => Price * Quantity;
        }
    }
}
