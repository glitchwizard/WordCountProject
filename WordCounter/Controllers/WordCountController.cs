using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordCounter.Controllers
{
    public class WordCountController : Controller
    {
        [HttpGet("/wordcounter")]
        public ActionResult Index()
        {
            return View("Index");
        }

        //[HttpGet("/wordcounter/new")]
        //public ActionResult New()
        //{
        //    return View();
        //}

        //[HttpPost("/wordcounter")]
        //public ActionResult New(string userInputWord, string userInputSentance)
        //{
        //    WordCount newWordToFind = new WordCount(userInputWord, userInputSentance);
        //    return View("Index", newWordToFind);
        //}

    }
}
