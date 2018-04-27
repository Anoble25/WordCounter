using System.Collections;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _chosenWord;
    //private int _wordTotal;

    public RepeatCounter (string sentence, string chosenWord)
    {
      _sentence=sentence;
      _chosenWord=chosenWord;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public string GetChosenWord(){
      return _chosenWord;
    }

    public void SetSentence(string newSentence)
    {
      _sentence=newSentence;
    }

    public string SetChosenWord(string newChosenWord){
      return _chosenWord=newChosenWord;
    }


    public int PerformWordCount()
    {
      int wordTotal=0;

      char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
      string[] words=_sentence.Split(delimiterChars);

      for(int x=0; x<words.Length; x++)
      {
        if (words[x]==_chosenWord){
          wordTotal++;
        } else{}
      }

      Console.WriteLine("word total is: "+wordTotal);
      Console.WriteLine(_sentence);
      return wordTotal;
    }
  }
}
