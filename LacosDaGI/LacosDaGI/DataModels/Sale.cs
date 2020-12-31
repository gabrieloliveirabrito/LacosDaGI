using System;
using System.Collections.Generic;
using System.Text;

namespace LacosDaGI.DataModels
{
    public class Sale
    {
        public int Id { get; set; }

        public Client Client { get; set; }
        public List<SaleItem> Items { get; set; }
    }
}
