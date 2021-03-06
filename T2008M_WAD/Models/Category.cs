using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace T2008M_WAD.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên danh mục")]
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}