namespace WordCounter.Models
{
  public class CountBL
  {
    private string _word;

    public CountBL()
    {
      
    }

    public CountBL(string word1) 
    {
    _word = word1;
    }

    public string GetWord() 
    {
      return _word;
    }
  }
}
