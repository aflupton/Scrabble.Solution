using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScoreApp.Models;
using System;
using System.Collections.Generic;

namespace ScrabbleScoreApp.TestTools
{
  [TestClass]
  public class ScrabbleScoreTest  //IDisposable
  {
    // public void Dispose()
    // {
    //   Dispose(true);
    //   ScrabbleScore.ClearAll();
    // }
    [TestMethod]
    public void GetScore_Esquire()
    {
      ScrabbleScore userWord = new ScrabbleScore("Esquire");
      int score = userWord.Score();
      Assert.AreEqual(15, score);
    }

    [TestMethod]
    public void GetScore_Dog()
    {
      ScrabbleScore userWord = new ScrabbleScore("dog");
      int score = userWord.Score();
      Assert.AreEqual(5, score);
    }
    // [TestMethod]
    // public void GetScore1_ReturnScore_Int()
    // {
    //   string inputWord1 = Request.Form["word"];
    //   ScrabbleScore userWord = new ScrabbleScore(inputWord1);
    //   Assert.AreEqual(1, userWord.Score());
    // }
    //
    // [TestMethod]
    // public void GetScore2()
    // {
    //   string inputWord2 = Request.Form["word"];
    //   ScrabbleScore userWord = new ScrabbleScore(inputWord2);
    //   Assert.AreEqual(2, userWord.Score());
    // }
    //
    // [TestMethod]
    // public void GetScore3()
    // {
    //   string inputWord3 = Request.Form["word"];
    //   ScrabbleScore userWord = new ScrabbleScore(inputWord3);
    //   Assert.AreEqual(3, userWord.Score());
    // }
    //
    // [TestMethod]
    // public void GetScore4()
    // {
    //   string inputWord4 = Request.Form["word"];
    //   ScrabbleScore userWord = new ScrabbleScore(inputWord4);
    //   Assert.AreEqual(4, userWord.Score());
    // }
    //
    // [TestMethod]
    // public void GetScore5()
    // {
    //   string inputWord5 = Request.Form["word"];
    //   ScrabbleScore userWord = new ScrabbleScore(inputWord5);
    //   Assert.AreEqual(5, userWord.Score());
    // }
    //
    // [TestMethod]
    // public void GetScore8()
    // {
    //   string inputWord8 = Request.Form["word"];
    //   ScrabbleScore userWord = new ScrabbleScore(inputWord8);
    //   Assert.AreEqual(8, userWord.Score());
    // }
    //
    // [TestMethod]
    // public void GetScore10()
    // {
    //   string inputWord10 = Request.Form["word"];
    //   ScrabbleScore userWord = new ScrabbleScore(inputWord10);
    //   Assert.AreEqual(10, userWord.Score());
    // }
  }
}
