﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Auditor.ViewModels.WifiCheck
{
    public class WifiCheckFormVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Не указан адрес"), Display(Name ="Адрес *"), MaxLength(256)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Не указан провайдер"), Display(Name = "Провайдер *"), MaxLength(256)]
        public string Provider { get; set; }
        [Required(ErrorMessage = "Не указан исполнитель"), Display(Name = "Ответственный *")]
        public int AuditorUserId { get; set; }
        [Required(ErrorMessage = "Не указан регион"), Display(Name = "Регион *")]
        public int TerritoryId { get; set; }
        [Required(ErrorMessage = "Не указана дата проверки"), Display(Name = "Дата проверки *"), DataType(DataType.Text)]
        public DateTime CheckDate { get; set; }
        [Required(ErrorMessage = "Не указано кол-во нарушений"), Display(Name = "Кол-во нарушений *")]
        public int ViolationsCount { get; set; }
        [Required(ErrorMessage = "Не указано время проверки"), Display(Name = "Время проверки (мин) *")]
        public int TaskTime { get; set; }
        [Display(Name = "Примечание"), MaxLength(256), DataType(DataType.MultilineText)]
        public string Note { get; set; }
        public List<SelectListItem> AuditorUserList { get; set; }
        public List<SelectListItem> RegionList { get; set; }
    }
}
