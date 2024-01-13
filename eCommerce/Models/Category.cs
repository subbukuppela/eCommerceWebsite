using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    /// <summary>
    /// Category Model.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Property : Id.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Property : Name.
        /// </summary>
        [Required]
        [DisplayName("Category Name")]
        public string? Name { get; set; }
        /// <summary>
        /// Property : DisplayOrder.
        /// </summary>
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
