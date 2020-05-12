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
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=28320293733348826	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=20411759370751096	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=9536587154100457	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=25244329144808274	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=51617145873056483	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=23441366113375722	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=18027801615184692	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=17059960254855208	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=20626178773287666	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=57100097091423436	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=24018878640527909	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=20946530370469828	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=65004959184388996	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=35425587644337450	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=38437201078089290	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=58931793851445922	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=46348559193224090	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=25514780181345713	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=11773403764702778	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=15472396110662150	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=63499217872110599	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=33293588228706998	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=55959112038778737	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=65883838195688438	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=59486059679335017	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=22667016906590506	
        //http://www.tsetmc.com/Loader.aspx?ParTree=151311&i=58741071099161284

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
