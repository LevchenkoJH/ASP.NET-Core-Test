using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    // Тебе это не нужно
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage ="Заполните название услуги")]
        [Display(Name = "Название услуги")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание услуги")]
        public override string Subtitle { get; set; }

        [Display(Name = "полное описание услуги")]
        public override string Text { get; set; }
    }
}
