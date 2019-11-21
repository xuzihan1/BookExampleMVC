using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookExamples.Areas.Chapter03.Models
{
    public class MyUserModel
    {
        [Display(Name = "用户ID")]
        [Required(ErrorMessage = "用户id不能为空")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "用户ID必须为3位")]
        public string UserId { get; set; }

        [Display(Name = "用户名")]
        [Required(ErrorMessage = "用户名不能为空")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "用户名至少需要5个字符")]
        public string UserName { get; set; }

        [Display(Name = "年龄")]
        [Required(ErrorMessage = "年龄不能为空")]
        [Range(18,60,ErrorMessage = "年龄必须在18到60之间")]
        public int Age { get; set; }

        [Display(Name = "出生日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }

        public MyUserModel()
        {
            UserId = "010";
            UserName = "bowqw";
            Age = 20;
            BirthDate = null;
        }
    }
}