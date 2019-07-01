﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Model.Models
{
    /// <summary>
    /// 动作
    /// </summary>
    public class SystemAction : BaseModel
    {

        [Display(Name = "动作名称")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string ActionName { get; set; }

        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        [Display(Name = "方法")]
        public string MethodName { get; set; }

        [Display(Name = "菜单")]
        public Guid? MeunID { get; set; }
        public SystemMenu Meun { get; set; }
        //[Display(Name = "模块")]
        //public Guid? ModuleId { get; set; }

        //[Display(Name = "模块")]
        //public SystemModule Module { get; set; }

        [Display(Name = "参数")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Parameter { get; set; }

        [NotMapped]
        public bool IgnorePrivillege { get; set; }
        [NotMapped]
        private string _url;
       
    }
}