using System.Collections.Generic;

namespace CDList.Models
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    private string _name;
    private int _id;
    private List<MusicCD> _allCD;

    public Artist(string artistName)
    {
      _name = artistName;
      _instances.Add(this);
      _id = _instances.Count;
      _allCD = new List<MusicCD>{};
    }

    public string GetName()
    {
      return _name;
    }

    public int GetId()
    {
      return _id;
    }

    public void AddCD(MusicCD album)
    {
      _allCD.Add(album);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Artist> GetAll()
    {
      return _instances;
    }

    public static Artist Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public List<MusicCD> GetMusicCD()
    {
      return _allCD;
    }

  }
}