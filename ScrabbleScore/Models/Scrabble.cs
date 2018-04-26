using System;
using System.Collections.Generic;
using System.Linq;


namespace ScrabbleScoreApp.Models
{
  public class ScrabbleScore
  {
    private string _userWord;
    private int _score=0;

    private static List<string> _one = new List<string>() {"A", "E", "I", "O", "U", "L", "N", "R", "S", "T"};
    private static List<string> _two = new List<string>() {"D", "G"};
    private static List<string> _three = new List<string>() {"B", "C", "M", "P"};
    private static List<string> _four = new List<string>() {"F", "H,", "V", "W", "Y"};
    private static List<string> _five = new List<string>() {"K"};
    private static List<string> _eight = new List<string>() {"J", "K"};
    private static List<string> _ten = new List<string>() {"Q", "Z"};

    private Dictionary<int, List<string>> _chars = new Dictionary<int, List<string>>()
    {
      {1, _one}, {2, _two}, {3, _three}, {4, _four}, {5, _five}, {8, _eight}, {10, _ten}
    };

    public int GetScore()
    {
      return _score;
    }

    public string GetWord()
    {
      return _userWord;
    }

    public ScrabbleScore(string word)
    {
      _userWord = word;
    }



    // public void ClearAll()
    // {
    //   _userWord.Clear();
    // }

    public int Score()
    {
      for (var i=0; i<_userWord.Length; i++)
      {
        foreach(KeyValuePair<int, List<string>> item in _chars)
        {
          foreach(string str in item.Value)
          {
            if (_userWord[i].ToString() == str)
            {
              _score += item.Key;
            }
          }
        }

      }
       return _score;
    }
  }
}
