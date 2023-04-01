using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryControl.Models
{
    [Table ("Users")]
    public class User
    {
        public int ID { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
    }
}
