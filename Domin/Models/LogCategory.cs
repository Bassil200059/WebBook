using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Models
{
    public class LogCategory
    {
        public Guid Id { get; set; }
        [Required]
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }



        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }

    }
}
