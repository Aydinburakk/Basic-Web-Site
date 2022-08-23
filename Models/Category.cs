using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models


{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="1-100 arasında olması gerekiyor")]
        public int DisplayOrder { get; set; }


        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
