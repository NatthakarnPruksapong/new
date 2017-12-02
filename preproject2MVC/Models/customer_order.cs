using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace preproject2MVC.Models
{
    public class customer_order
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public int idorder { get; set; }
        public short status { get; set; }
        
    }
}