using Microsoft.VisualStudio.TestTools.UnitTesting;
using CDList.Models;
using System.Collections.Generic;
using System;

namespace CDList.Tests
{
  [TestClass]
  public class MusicCDTest : IDisposable
  {

    public void Dispose()
    {
      MusicCD.ClearAll();
    }

    [TestMethod]
    public void MusicCDConstructor_CreatesInstanceOfMusicCD_MusicCD()
    {
      MusicCD newMusicCD = new MusicCD("test");
      Assert.AreEqual(typeof(MusicCD), newMusicCD.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Walk the dog.";
      MusicCD newMusicCD = new MusicCD(title);

      //Act
      string result = newMusicCD.GetTitle();

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Walk the dog.";
      MusicCD newMusicCD = new MusicCD(title);

      //Act
      string updatedTitle = "Do the dishes";
      newMusicCD.SetTitle(updatedTitle);
      string result = newMusicCD.GetTitle();

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_MusicCDList()
    {
      //Arrange
      List<MusicCD> newList = new List<MusicCD> { };

      //Act
      List<MusicCD> result = MusicCD.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsMusicCDs_MusicCDList()
    {
      //Arrange
      string title01 = "Walk the dog";
      string title02 = "Wash the dishes";
      MusicCD newMusicCD1 = new MusicCD(title01);
      MusicCD newMusicCD2 = new MusicCD(title02);
      List<MusicCD> newList = new List<MusicCD> { newMusicCD1, newMusicCD2 };

      //Act
      List<MusicCD> result = MusicCD.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_MusicCDsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "Walk the dog.";
      MusicCD newMusicCD = new MusicCD(title);

      //Act
      int result = newMusicCD.GetId();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectMusicCD_MusicCD()
    {
      //Arrange
      string title01 = "Walk the dog";
      string title02 = "Wash the dishes";
      MusicCD newMusicCD1 = new MusicCD(title01);
      MusicCD newMusicCD2 = new MusicCD(title02);

      //Act
      MusicCD result = MusicCD.Find(2);

      //Assert
      Assert.AreEqual(newMusicCD2, result);
    }

  }
}
