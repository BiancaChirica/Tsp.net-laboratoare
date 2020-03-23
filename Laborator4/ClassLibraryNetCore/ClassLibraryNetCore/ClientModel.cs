using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibraryNetCore
{
    public partial class ClientModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        // 0 = inregistrare corecta; 1 = inregistrare stearsa
        //public int Deleted { get; set; }
        public virtual ICollection<OrderModel> Orders { get; set; }
        public ClientModel() {
          
        
            Orders = new HashSet<OrderModel>();
        


    }
}
}
