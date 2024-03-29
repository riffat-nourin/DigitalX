//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalX.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Configuration;


    public partial class Product : IValidatableObject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderItems = new HashSet<OrderItem>();
            this.Product_Category = new HashSet<Product_Category>();
            this.Product_Reviews = new HashSet<Product_Reviews>();
        }
    
        public long ProductID { get; set; }

        [Required(ErrorMessage ="Enter Product Name")]
        [StringLength(50, ErrorMessage = "{0} should have maximum {1} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Product Description")]
        [StringLength(1000, ErrorMessage = "{0} should have maximum {1} characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Enter Product {0}")]
        [Range(0,int.MaxValue, ErrorMessage = "{0} must be a number between {1} and {2}")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Enter Product Price")]
        [Range(1, int.MaxValue, ErrorMessage  = "{0} must be a number between {1} and {2}")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Enter Product Discount")]
        public int Discount { get; set; } = 0;
  
        public string Picture { get; set; }

        public bool IsActive { get; set; }
        public long UpdatedBy { get; set; }
        public Nullable<short> BrandID { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Discount <0 || Discount >= Price)
            {
                yield return new ValidationResult(
                    "Discount must be either 0 or a number less than Price", new[] { nameof(Discount)});
            }
        }

        public virtual Brand Brand { get; set; }
        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Category> Product_Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Reviews> Product_Reviews { get; set; }
    }
}
