using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibraryNetCore
{
    public class OrderModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public int Value { get; set; }

        [ForeignKey("ClientId")]

        public virtual ClientModel Client { get; set; }


        public OrderModel()
        {

        }
    }
}
