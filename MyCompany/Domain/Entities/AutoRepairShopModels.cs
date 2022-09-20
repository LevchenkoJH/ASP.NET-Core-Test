using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class WorkShop
    {
        [Required]
        public Guid Id { get; set; }
    }

    public class WorkName
    {
        [Required]
        public Guid Id { get; set; }
    }

    public class OrderStruct
    {
        [Required]
        public Guid Id { get; set; }
    }

    public class Order
    {
        [Required]
        public Guid Id { get; set; }
    }

    public class Cost
    {
        [Required]
        public Guid Id { get; set; }
    }

    public class Brand
    {
        [Required]
        public Guid Id { get; set; }
    }

    public class Car
    {
        [Required]
        public Guid Id { get; set; }
    }
}
