// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class CarInsuranceQuoteTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void carInsuranceQuote25and3and0Result2500() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04//prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("province")).Click();
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("548-333-5132");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("25");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$2500"));
    }
  }
  [Test]
  public void carInsuranceQuote5and0AgeOmitted() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).Click();
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("548-333-5195");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("5");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      var element = driver.FindElement(By.Id("btnSubmit"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
  }
  [Test]
  public void carInsuranceQuote22and3and2NoInsurance() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.CssSelector(".form-row:nth-child(4)")).Click();
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).SendKeys("548-333-2222");
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).SendKeys("22");
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).SendKeys("3");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
    }
  }
  [Test]
  public void carInsuranceQuote25and0and0Result4000() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).Click();
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("548-444-3333");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("25");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("0");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$4000"));
    }
  }
  [Test]
  public void carInsuranceQuote25and3and0FirstNameOmitted() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("lastName")).Click();
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("province")).Click();
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).SendKeys("548-333-4232");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("25");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      var element = driver.FindElement(By.Id("btnSubmit"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    Assert.That(driver.FindElement(By.Id("firstName-error")).Text, Is.EqualTo("First Name is required"));
  }
  [Test]
  public void carInsuranceQuote26and3and0LastNameOmitted() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("address")).Click();
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).Click();
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("province")).Click();
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("548-333-4332");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("26");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    Assert.That(driver.FindElement(By.Id("lastName-error")).Text, Is.EqualTo("Last Name is required"));
  }
  [Test]
  public void carInsuranceQuote26and10and0Result1800() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).SendKeys("548-333-2222");
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).SendKeys("26");
    driver.FindElement(By.Id("experience")).SendKeys("10");
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    {
      var element = driver.FindElement(By.Id("age"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.Id("age"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.Id("age"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$1800"));
    }
  }
  [Test]
  public void carInsuranceQuote27and3and0InvalidPhoneNo() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).SendKeys("5483335232");
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("27");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      var element = driver.FindElement(By.Id("btnSubmit"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
  }
  [Test]
  public void carInsuranceQuote28and3and0InvalidEmail() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("548-333-5322");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("gajjar");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("28");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      var element = driver.FindElement(By.Id("btnSubmit"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
  }
  [Test]
  public void carInsuranceQuote30and2and0Result1875() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(927, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).Click();
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("548-444-3333");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("30");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("2");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$1875"));
    }
  }
  [Test]
  public void carInsuranceQuote35and17and1InvalidPostalCode() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).Click();
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("NN2 JJ8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("548-333-5195");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("35");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("17");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("1");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      var element = driver.FindElement(By.Id("btnSubmit"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
  }
  [Test]
  public void carInsuranceQuote36and5and0Result1875() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    driver.Manage().Window.Size = new System.Drawing.Size(927, 1032);
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).SendKeys("543-444-3333");
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("36");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("5");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$1875"));
    }
  }
  [Test]
  public void carInsuranceQuote36and10and0Result1350() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("city")).SendKeys(Keys.Enter);
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("548-555-4444");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("26");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("10");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    {
      var element = driver.FindElement(By.Id("age"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.Id("age"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.Id("age"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("36");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$1350"));
    }
  }
  [Test]
  public void carInsuranceQuote37and8NoOfAtFaultOmitted() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("548-333-5195");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("37");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("8");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$1875"));
    }
  }
  [Test]
  public void carInsuranceQuote45and0YearsOfExpOmitted() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).Click();
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("548-333-5343");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("45");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      var element = driver.FindElement(By.Id("btnSubmit"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
  }
  [Test]
  public void carInsuranceQuote50and20and1Result1350() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(927, 1032);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("satyam");
    driver.FindElement(By.Id("lastName")).SendKeys("gajjar");
    driver.FindElement(By.Id("address")).SendKeys("king street north");
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2J 0B8");
    driver.FindElement(By.Id("phone")).SendKeys("548-344-3333");
    driver.FindElement(By.Id("email")).SendKeys("satyamgajjar@gmail.com");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("50");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("20");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("1");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$1350"));
    }
  }
}
