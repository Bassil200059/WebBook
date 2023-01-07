using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Models
{
    public class Book
    {
        public Guid Id  { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = ("BookName"))]
        [MaxLength(20, ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = ("MaxLength"))]
        [MinLength(20, ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = ("MinLength"))]
        public string Name { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = ("AutherName"))]
        [MaxLength(20, ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = ("MaxLength"))]
        [MinLength(20, ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = ("MinLength"))]
        public string Auther { get; set; }
        public string  ImageName { get; set; }
        public string FileName { get; set; }
        public string Desctiption { get; set; }
        public bool Publish { get; set; }

        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public  virtual Category? Category { get; set; }


        public Guid SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public virtual SubCategory? SubCatrgory { get; set; }


        public int CurrenStaut { get; set; }
    }
}
