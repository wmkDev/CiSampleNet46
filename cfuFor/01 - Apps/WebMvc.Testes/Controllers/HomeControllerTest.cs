﻿//using System.Web.Mvc;
//using NUnit.Framework;
//using WebMvc.Controllers;

//namespace WebMvc.Testes.Controllers
//{
//    [TestFixture]
//    public class HomeControllerTest
//    {
//        [Test]
//        public void Index()
//        {
//            // Arrange
//            HomeController controller = new HomeController();

//            // Act
//            ViewResult result = controller.Index() as ViewResult;

//            // Assert
//            Assert.IsNotNull(result);
//        }

//        [Test]
//        public void About()
//        {
//            // Arrange
//            HomeController controller = new HomeController();

//            // Act
//            ViewResult result = controller.About() as ViewResult;

//            // Assert
//            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
//        }

//        [Test]
//        public void Contact()
//        {
//            // Arrange
//            HomeController controller = new HomeController();

//            // Act
//            ViewResult result = controller.Contact() as ViewResult;

//            // Assert
//            Assert.IsNotNull(result);
//        }
//    }
//}
