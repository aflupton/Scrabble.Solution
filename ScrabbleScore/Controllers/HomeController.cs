// using System;
// using System.Collections.Generic;
// using ScrabbleScoreApp.Models;
//
// namespace ScrabbleScoreApp.Controllers
// {
//   public class HomeController : Controllers
//   {
//     [HttpGet("/")]
//     public ActionResult Index()
//     {
//       return View();
//     }
//
//     [HttpPost("/Result")]
//     public ActionResult ScoreResult()
//     {
//       ScrabbleScore userWord = new ScrabbleScore(Request.Form["word"]);
//       int score = userWord.Score();
//       return View("Index", score);
//     }
//   }
// }
