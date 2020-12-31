using System;
using System.Collections.Generic;
using System.Text;

namespace LacosDaGI.DataModels
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int HomeNumber { get; set; }
        public string PhoneNumber { get; set; }

        public List<Tie> Laces { get; set; }
    }
}
