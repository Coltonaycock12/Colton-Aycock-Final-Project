using System;

namespace Colton_Aycock_Final_Project.Models 
{
    public class Order
    {
        public int OrderId {get; set;} // Primary Key
        public string Name {get; set;} = string.Empty;
        public string Address {get; set;} = string.Empty;
        public string Phone {get; set;} = string.Empty;
        public string Email {get; set;} = string.Empty; 
        public int ProductId {get; set;} // Foreign Key 
        public Product Product {get; set;} = default!; 
    }
}