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
        public string? Name { get; set; }
        /// <summary>
        /// Property : DisplayOrder.
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
