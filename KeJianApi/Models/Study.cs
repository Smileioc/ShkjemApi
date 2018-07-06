﻿using System;
using System.ComponentModel.DataAnnotations;

namespace KeJianApi.Models
{
    public class Study
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 学习标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 学习内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
