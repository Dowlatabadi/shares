using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Text;

namespace share_linux
{
    class Program
    {
        public void fetch()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            sb.AppendLine("http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722");
            IWebDriver driver = new FirefoxDriver();
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            foreach (var line in textBox1.Lines)
            {

                try
                {
                    driver.Navigate().GoToUrl(line);

                    //  wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/div[4]/form/div[2]/div[2]/div[1]/div[2]/div[1]/table/tbody/tr[4]/td[2]/span")));
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='d02']/span|//*[@id='d03']/span")));

                    string title = driver.Title;
                    string status = driver.FindElement(By.XPath("//*[@id='d01']")).Text.Contains("ممنوع") ? "ممنوع" : "";
                    textBox2.AppendText(title + " " + status + "/");
                }
                catch (Exception)
                {


                }
                //
            }
            driver.Close();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
