using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyCompany.Domain.Entities
{
    public class WorkShop
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "???")]
        public string Name { get; set; }
    }

    public class WorkName
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "???")]
        public string Name { get; set; }

        [Display(Name = "???")]
        public decimal StandardTime { get; set; }

        public Guid? WorkShopId { get; set; }
        [ForeignKey("WorkShopId")]
        public virtual WorkShop WorkShop { get; set; }
    }

    public class OrderStruct
    {
        [Required]
        public Guid Id { get; set; }

        public Guid? WorkNameId { get; set; }
        [ForeignKey("WorkNameId")]
        public virtual WorkName WorkName { get; set; }

        public Guid? OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        public Guid MasterId { get; set; }
        [ForeignKey("MasterId")]
        public virtual IdentityUser Master { get; set; }

        [Display(Name = "???")]
        public DateTime DateEnd { get; set; }
    }

    public class Order
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "???")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "???")]
        public DateTime CompletionDate { get; set; }

        [Display(Name = "???")]
        public int OrderNumber { get; set; }

        public Guid CarId { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }

        [Display(Name = "???")]
        public bool Paid { get; set; }
    }

    public class Cost
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "???")]
        public decimal Cost_ { get; set; }

        public Guid BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

        public Guid WorkNameId { get; set; }
        [ForeignKey("WorkNameId")]
        public virtual WorkName WorkName { get; set; }
    }

    public class Brand
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "???")]
        public string Name { get; set; }
    }

    public class Car
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "???")]
        public string Number { get; set; }

        public Guid ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual IdentityUser Client { get; set; }

        public Guid BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }
    }
}
