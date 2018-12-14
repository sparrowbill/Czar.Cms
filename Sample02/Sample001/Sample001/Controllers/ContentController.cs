﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample001.Models;

namespace Sample001.Controllers
{
    /// <summary>
    /// 2018.12.13
    /// chenxr
    /// Content控制器
    /// </summary>
    public class ContentController : Controller
    {
        private readonly Content contents;

        public ContentController(IOptions<Content> options)
        {
            contents = options.Value;
        }

        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //var contents = new List<Content>();
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i)});
            //}
            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }
    }
}