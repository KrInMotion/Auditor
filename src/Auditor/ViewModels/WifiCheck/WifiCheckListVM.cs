using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Auditor.ViewModels.WifiCheck
{
    public class WifiCheckListVM
    {
        public int Id { get; set; }
        [Display(Name ="Адрес")]
        public string Address { get; set; }
        [Display(Name = "Провайдер")]
        public string Provider { get; set; }
        [Display(Name = "Ответственный")]
        public string AuditorUser { get; set; }
        [Display(Name = "Регион")]
        public string Territory { get; set; }
        [Display(Name = "Дата проверки *")]
        public DateTime CheckDate { get; set; }
        [Display(Name = "Кол-во нарушений")]
        public int ViolationsCount { get; set; }
        [Display(Name = "Время проверки (мин)")]
        public int TaskTime { get; set; }
        [Display(Name = "Примечания")]
        public string Note { get; set; }
    }
}
