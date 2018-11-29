using Microsoft.AspNetCore.Mvc;
using CDList.Models;
using System.Collections.Generic;

namespace CDList.Controllers
{
  public class MusicCDController : Controller
  {

    [HttpGet("/artist/{artistId}/allCD/new")]
    public ActionResult New(int artistId)
    {
       Artist artist = Artist.Find(artistId);
       return View(artist);
    }

    [HttpGet("/artist/{artistId}/allCD/{musicCDId}")]
    public ActionResult Show(int artistId, int musicCDId)
    {
      MusicCD musicCD = MusicCD.Find(musicCDId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist artist = Artist.Find(artistId);
      model.Add("musicCD", musicCD);
      model.Add("artist", artist);
      return View(model);
    }

    [HttpPost("/allCD/delete")]
    public ActionResult DeleteAll()
    {
      MusicCD.ClearAll();
      return View();
    }

  }
}