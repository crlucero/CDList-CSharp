using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CDList.Models;

namespace CDList.Controllers
{
  public class ArtistController : Controller
  {

    [HttpGet("/artist")]
    public ActionResult Index()
    {
      List<Artist> allArtists = Artist.GetAll();
      return View(allArtists);
    }

    [HttpGet("/artist/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/artist")]
    public ActionResult Create(string artistName)
    {
      Artist newArtist = new Artist(artistName);
      List<Artist> allArtists = Artist.GetAll();
      return View("Index", allArtists);
    }

    [HttpGet("/artist/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist selectedArtist = Artist.Find(id);
      List<MusicCD> artistCD = selectedArtist.GetMusicCD();
      model.Add("artist", selectedArtist);
      model.Add("musicCD", artistCD);
      return View(model);
    }

    // This one creates new Items within a given Category, not new Categories:
    [HttpPost("/artist/{artistId}/allCD")]
    public ActionResult Create(int artistId, string albumName)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist foundArtist = Artist.Find(artistId);
      MusicCD newMusicCD = new MusicCD(albumName);
      foundArtist.AddCD(newMusicCD);
      List<MusicCD> allArtists = foundArtist.GetMusicCD();
      model.Add("musicCD", allArtists);
      model.Add("artist", foundArtist);
      return View("Show", model);
    }

  }
}