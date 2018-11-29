
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CDList.Controllers;
using CDList.Models;

namespace Artist.Tests
{
    [TestClass]
    public class ArtistControllerTest
    {

      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResult()
      {
        //Arrange
        ArtistController controller = new ArtistController();

        //Act
        IActionResult view = controller.Create("Walk the dog") as ViewResult;

        //Assert
        Assert.IsInstanceOfType(view, typeof(ActionResult));
      }



    }
}