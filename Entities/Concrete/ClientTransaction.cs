using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ClientTransaction : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime ProcessDate { get; set; }
        public virtual Client Client { get; set; }
    }
}
