using System.Collections.Generic;

namespace CDList.Models
{
  public class MusicCD
  {
    private string _title;
    private int _id;
    private static List<MusicCD> _instances = new List<MusicCD> {};

    public MusicCD (string title)
    {
      _title = title;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<MusicCD> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static MusicCD Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
