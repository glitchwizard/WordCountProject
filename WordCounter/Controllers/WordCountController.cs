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
        [Produces("text/html")]
        [HttpGet("/wordcounter")]
        public ActionResult Index()
        {
            //WordCount newWordToFind = new WordCount();
            return View();
        }

        [Produces("text/html")]
        [HttpGet("/wordcounter/new")]
        public ActionResult New()
        {
            return View();
        }

        [Produces("text/html")]
        [HttpPost("/wordcounter")]
        public ActionResult New(string userInputWord, string userInputSentance)
        {
            WordCount newWordCountObj = new WordCount(userInputWord, userInputSentance);
            return View("Index", newWordCountObj);
        }

    }
}
