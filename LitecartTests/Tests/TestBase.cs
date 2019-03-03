using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitecartTests.Tests
{
    public abstract class TestBase
    {
        protected IWebDriver webDriver;
        protected string userName;
        protected string userPassword;

        protected void LogIn()
        {

        }
    }
}