using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Colton_Aycock_Final_Project.Models
{
    public class Product
    {
        public int ProductID {get; set;}

        public string Name {get; set;} = string.Empty;

        [Range(1,100)]
        public int Size {get; set;} 

        public string Gender {get; set;} = string.Empty;  

        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price {get; set;}

        public List<Order> Orders {get; set;} = default!; 
    }
}
