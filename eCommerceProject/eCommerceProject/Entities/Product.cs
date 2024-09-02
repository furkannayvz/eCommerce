using System.ComponentModel.DataAnnotations;

namespace eCommerceProject.Entities
{
    public class Product
    {


        public int Id { get; set; }
       
        public string Name { get; set; } = "";
        
        public string Surname { get; set; } = "";
        
        public string Password { get; set; } = "";




    }
}
