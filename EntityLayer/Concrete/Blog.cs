using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        [StringLength(100)]
        public string BlogTitle { get; set; }

        [StringLength(100)]
        public string BlogImage { get; set; }
        public DateTime BlogDate { get; set; }
        public string BlogContent { get; set; }


        // Category ve blog sınıflarını ilişkili hale getirmek
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        // yazarlarla blogları ilişkilendirme
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        //bloglarla yorumları ilişkilendirme

        public ICollection<Comment> Comments { get; set; }



    }
}
