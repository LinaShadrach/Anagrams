using System;
using System.Collections.Generic;

namespace Anagram.Objects
{
  public class Anagrams
  {
    public string testWord {get; set;}
    private static List<string> _wordList = new List<string> {};
    private static List<string> _trueAnagrams = new List<string> {};

    public Anagrams(string testWord, List<string> words)
    {
      this.testWord = testWord;
      _wordList = words;
    }
    public static List<string> GetAll()
    {
      return _wordList;
    }
    public bool IsAnagram()
    {
      char[] testWordArr = this.testWord.ToCharArray();
      Array.Sort(testWordArr);
      for(int i=0; i<_wordList.Count;i++)
      {
        char[] Word2Arr = _wordList[i].ToCharArray();
        Array.Sort(Word2Arr);
        // Console.WriteLine(Word2Arr);
        this.testWord =  new string(testWordArr);
        string currentWord =  new string(Word2Arr);

        if(this.testWord == currentWord)
        {
          _trueAnagrams.Add(currentWord);
          Console.WriteLine(currentWord);
        }
      }
      if(_trueAnagrams.Count>0){
        return true;
      }
      return false;
    }
    public static void DeleteAll()
    {
      _wordList.Clear();
      _trueAnagrams.Clear();
    }
  }
}
