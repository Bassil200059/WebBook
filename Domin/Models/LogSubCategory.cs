using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Models
{
    public class LogSubCategory
    {
        public Guid Id { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }

        public Guid SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public virtual SubCategory? SubCategory { get; set; }
    }
}
