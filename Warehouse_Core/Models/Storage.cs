using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Core.Models
{
   public class Storage:BaseComponent
    {
       
        //Storage properties

        //private WarehouseContext _db = new WarehouseContext();

        //ID
        [Key]
        public int ID { get; set; }
        //Name
        [Required]
        [StringLength(100, ErrorMessage = "Name must be between 3 and 100 characters", MinimumLength = 3)]
        public string Name { get; set; }
        //Description
        [Required]
        [Column(TypeName = "text")]
        [StringLength(100, ErrorMessage = "The Description must be between 3 and 100 characters.", MinimumLength = 3)]
        public virtual string Details { get; set; }
        //Quantity
        [Required]
        public int Quantity { get; set; }
        //Manufacturer
        [StringLength(100, ErrorMessage = "Manufacturer must be between 1 and 100 characters", MinimumLength = 1)]
        public string Manufacturer { get; set; }
        //SN - Serial Number
        [StringLength(50, ErrorMessage = "The SN must be between 1 and 50 characters.", MinimumLength = 1)]
        public string SN { get; set; }
        //OS - Operating System
        [StringLength(50, ErrorMessage = "OS must be between 5 and 50 characters", MinimumLength = 5)]
        public string OS { get; set; }
        //Price
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [Column(TypeName = "money")]
        [Display(Name = "Old price")]
        public decimal? OldPrice { get; set; }
        //UserID
        [NotMapped]
        public int? UserID { get; set; }
        //PlaceID
        [NotMapped]
        public int? PlaceID { get; set; }
        //FullPrice
        [Column(TypeName = "money")]
        [Display(Name = "Full price")]
        public decimal? FullPrice { get; set; }
        //FullPriceWithPDV
        [Column(TypeName = "money")]
        [Display(Name = "Full price with PDV")]
        public decimal? FullPriceWithPDV { get; set; }
        //PDV
        [Column(TypeName = "money")]
        [Display(Name = "PDV")]
        public decimal? PDV { get; set; }
        //Savings
        [Column(TypeName = "money")]
        public decimal? Savings { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        //public IEnumerable<LaptopModels> laptop { get; set; }

        public void AddNewItemToStorage()
        {

            this._mediator.AddNewItem(this,"Storage");

        }


    }
}
