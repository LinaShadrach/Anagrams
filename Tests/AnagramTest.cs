using Xunit;
using System;
using System.Collections.Generic;
using Anagram.Objects;

namespace  Anagram
{
  public class AnagramTest : IDisposable
  {
    [Fact]
    public void IsAnagram_OneWordComparison_true()
    {
      // Arrange
      string word1 = "beard";
      List<string> wordList = new List<string> {"bread"};

      Anagrams newAnagram1 = new Anagrams(word1, wordList);

      // Assert
      Assert.Equal(true, newAnagram1.IsAnagram());
    }
    [Fact]
    public void IsAnagram_OneWordComarison_false()
    {
      //Arrange
      string word1 = "golly";
      List<string> wordList = new List<string> {"gee"};
      Anagrams newAnagram1 = new Anagrams(word1, wordList);
      //Assert
      Assert.Equal(false, newAnagram1.IsAnagram());
    }
    [Fact]
    public void IsAnagram_MultipleWordComparison_true()
    {
      //Arrange
      string word1 = "beard";
      List<string> wordList = new List<string> {"bread", "golly", "gee", "beard"};
      //Act
      Anagrams newAnagrams1 = new Anagrams(word1, wordList);

      //Assert
      Assert.Equal(true, newAnagrams1.IsAnagram());
    }
    [Fact]
    public void IsAnagram_MultipleWordComparison_false()
    {
      //Arrange
      string word1 = "golly";
      Console.WriteLine(word1);
      List<string> wordList = new List<string> {"bread", "gee", "beard"};
      //Act
      Anagrams newAnagrams1 = new Anagrams(word1, wordList);

      //Assert
      Assert.Equal(false, newAnagrams1.IsAnagram());
    }

    public void Dispose()
    {
      Anagrams.DeleteAll();
    }
  }
}
