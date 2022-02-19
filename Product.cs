namespace LabExam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="This Field is Mandatory")]
        [Display(Name ="Product Id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "This Field is Mandatory")]
        [Display(Name = "Product Name")]

        [StringLength(50)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "This Field is Mandatory")]
        [Display(Name = "Rate")]


        public decimal Rate { get; set; }

        [Required(ErrorMessage = "This Field is Mandatory")]
        [Display(Name = "Description")]

        [StringLength(200)]
        public string Description { get; set; }

        [Required(ErrorMessage = "This Field is Mandatory")]
        [Display(Name = "Category Name")]

        [StringLength(50)]
        public string CategoryName { get; set; }
    }
}
