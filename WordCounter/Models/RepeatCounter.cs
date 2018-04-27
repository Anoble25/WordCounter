using System.Collections;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _chosenWord;
    private int _wordCount;

    public RepeatCounter (string sentence, string chosenWord)
    {
      _sentence=sentence;
      _chosenWord=chosenWord;
      _wordCount=0;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public string GetChosenWord(){
      return _chosenWord;
    }

    public int GetWordCount(){
      return _wordCount;
    }

    public void SetWordCount(int newWordCount){
      _wordCount=newWordCount;
    }

    public static int PerformWordCount(RepeatCounter newRepeatCounter)
    {
      string sentence=newRepeatCounter.GetSentence();
      string chosenWord=newRepeatCounter.GetChosenWord();

      int wordTotal=0;

      char[] delimiterChars = { ' ', ',', '.', ':', '!', '\t' };
      string[] words=sentence.Split(delimiterChars);

      for(int x=0; x<words.Length; x++)
      {
        if (words[x]==chosenWord){
          wordTotal++;
        } else{}
      }

      Console.WriteLine("word total is: "+wordTotal);
      Console.WriteLine(sentence);
      newRepeatCounter.SetWordCount(wordTotal);
      return wordTotal;
    }
  }
}
