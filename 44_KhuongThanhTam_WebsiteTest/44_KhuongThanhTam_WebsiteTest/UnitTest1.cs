using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.Threading;

namespace _44_KhuongThanhTam_WebsiteTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC1_LoginSuccess_44_Tam() //Dang nhap thanh cong
        {
            WebDriver driver_44_Tam = new ChromeDriver();
            string url = "https://account.cellphones.com.vn/";
            driver_44_Tam.Navigate().GoToUrl(url);
            Thread.Sleep(3000);
            string username = "khuongthanhtam712@gmail.com"; //Sai tai khoan dang nhap
            string pass = "Admin@123";
            //Nhap tai khoan dang nhap 
            IWebElement mail_44_Tam = driver_44_Tam.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div:nth - child(1) > div > input")); 
            mail_44_Tam.SendKeys(username);

            //Nhap mat khau dang nhap 
            IWebElement pass_44_Tam =
            driver_44_Tam.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div.mt - 4 > div > input")); 
            pass_44_Tam.SendKeys(pass);

            //Nut danh nhap 
            IWebElement clickDN_44_Tam = driver_44_Tam.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[2]/div/div[2]/ div[3] / form / button")); 
            clickDN_44_Tam.Click();

            Thread.Sleep(3000);
            driver_44_Tam.Close();
        }

        [TestMethod]
        public void TC2_LoginFail_1_44_Tam()//Sai tai khoan dang nhap 
        {
            WebDriver driver_44_Tam = new ChromeDriver();
            string url = "https://account.cellphones.com.vn/";
            driver_44_Tam.Navigate().GoToUrl(url);

            Thread.Sleep(3000);
            string username = "KhuongthanhTam"; //Sai tai khoan dang nhap 
            string pass = "Admin@123";

            //Nhap tai khoan dang nhap 
            IWebElement mail_44_Tam = driver_44_Tam.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div:nth - child(1) > div > input")); 
            mail_44_Tam.SendKeys(username);

            //Nhap mat khau dang nhap 
            IWebElement pass_44_Tam = driver_44_Tam.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div.mt - 4 > div > input")); 
            pass_44_Tam.SendKeys(pass);

            //Nut danh nhap 
            IWebElement clickDN_44_Tam = driver_44_Tam.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[2]/div/div[2]/ div[3] / form / button")); 
            clickDN_44_Tam.Click();
            
            Thread.Sleep(3000);
            try
            {
                IWebElement err_44_Tam =
                driver_44_Tam.FindElement(By.XPath("/html/body/div[2]"));
                string error = err_44_Tam.Text;
                Assert.AreEqual(" Vui lòng nhập đúng định dạng email.", error);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Không tìm thấy thông báo lỗi.");
            }
            Thread.Sleep(2000);
            driver_44_Tam.Quit();
        }

        [TestMethod]
        public void TC3_LoginFail_2_44_Tam() 
        {
            WebDriver driver_44_Tam = new ChromeDriver();
            string url = "https://account.cellphones.com.vn/";
            driver_44_Tam.Navigate().GoToUrl(url);
            Thread.Sleep(3000);
            
            string username = "khuongthanhtam712@gmail.com";
            string pass = "admin123"; //Sai mat khau dang nhap 

            //Nhap tai khoan dang nhap 
            IWebElement mail_44_Tam = driver_44_Tam.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div:nth - child(1) > div > input")); 
            mail_44_Tam.SendKeys(username);

            //Nhap mat khau dang nhap 
            IWebElement pass_44_Tam = driver_44_Tam.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div.mt - 4 > div > input")); 
            pass_44_Tam.SendKeys(pass);

            //Nut danh nhap 
            IWebElement clickDN_44_Tam = driver_44_Tam.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[2]/div/div[2]/ div[3] / form / button")); 
            clickDN_44_Tam.Click();
            Thread.Sleep(3000);

            try
            {
                IWebElement err_44_Tam = driver_44_Tam.FindElement(By.XPath("/html/body/div[2]"));
                string error = err_44_Tam.Text;
                Assert.AreEqual(" Thông tin đăng nhập không đúng. Vui lòng kiểm tra và thử lại.", error); 
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Không tìm thấy thông báo lỗi.");
            }

            Thread.Sleep(2000);
            driver_44_Tam.Quit();

        }

        [TestMethod]
        public void TC4_delSPfail_44_Tam() //giam so luong san pham trong gio hang < 1
        {
            WebDriver driver_44_Tam = new ChromeDriver();
            string url = "https://cellphones.com.vn/cart/";
            driver_44_Tam.Navigate().GoToUrl(url);
            Thread.Sleep(6000);
            string username = "khuongthanhtam712@gmail.com";
            string pass = "Admin@123";
            IWebElement DN_click_44_Tam = driver_44_Tam.FindElement(By.CssSelector("#cps-modal-login___BV_modal_body_ > div > div.group - login - btn > div.login - btn.modal__button")); 
            DN_click_44_Tam.Click();
            
            //Nhap tai khoan dang nhap 
            IWebElement mail_44_Tam = driver_44_Tam.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[2]/div/div[2] / div[3] / form / div / div[1] / div / input")); 
            mail_44_Tam.SendKeys(username);

            //Nhap mat khau dang nhap 
            IWebElement pass_44_Tam = driver_44_Tam.FindElement(By.CssSelector("input[type='password']"));
            pass_44_Tam.SendKeys(pass);

            //Nut danh nhap 
            IWebElement clickDN_44_Tam = driver_44_Tam.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > button")); 
            clickDN_44_Tam.Click();
            Thread.Sleep(6000);

            //Nut giam san pham 
            IWebElement click_sl_44_Tam = driver_44_Tam.FindElement(By.CssSelector("#listItemSuperCart > div.block__product - item__outer > div.block__product - item > div.product - info > div.d - flex.justify - content - between.align - items - end > div.action.d - flex > span.minus.d - flex.justify - content - center.align - items - center")); 
            click_sl_44_Tam.Click();

            try
            {
                driver_44_Tam.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                IWebElement error = driver_44_Tam.FindElement(By.XPath("//div[@class='flash-notification']"));
                Assert.AreEqual("Số lượng sản phẩm đã giảm đến mức tối thiểu",error);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Không tìm thấy thông báo lỗi.");
            }

            Thread.Sleep(3000);
            driver_44_Tam.Close();
        }

        [TestMethod]
        public void TC5_addslSPsuccess_44_Tam() //them so luong san pham thanh cong 
        {
            WebDriver driver_44_Tam = new ChromeDriver();
            string url = "https://cellphones.com.vn/cart/";
            driver_44_Tam.Navigate().GoToUrl(url);
            Thread.Sleep(6000);
            string username = "khuongthanhtam712@gmail.com";
            string pass = "Admin@123";
            IWebElement DN_click_44_Tam = driver_44_Tam.FindElement(By.CssSelector("#cps-modal-login___BV_modal_body_ > div > div.group - login - btn > div.login - btn.modal__button")); 
            DN_click_44_Tam.Click();
            //Nhap tai khoan dang nhap 
            IWebElement mail_44_Tam =
            driver_44_Tam.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[2]/div/div[2] / div[3] / form / div / div[1] / div / input")); 
            mail_44_Tam.SendKeys(username);
            //Nhap mat khau dang nhap 
            IWebElement pass_44_Tam =
            driver_44_Tam.FindElement(By.CssSelector("input[type='password']"));
            pass_44_Tam.SendKeys(pass);
            
            //Nut danh nhap 
            IWebElement clickDN_44_Tam = driver_44_Tam.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > button")); 
            clickDN_44_Tam.Click();
            Thread.Sleep(6000);

            //Nut tang san pham 
            IWebElement click_slplus_44_Tam = driver_44_Tam.FindElement(By.CssSelector("#listItemSuperCart > div.block__product - item__outer > div.block__product - item > div.product - info >div.d - flex.justify - content - between.align - items - end > div.action.d - flex >span.plus.d - flex.justify - content - center.align - items - center")); 
            click_slplus_44_Tam.Click();
            Thread.Sleep(2000);

            try
            {
                IWebElement error_44_Tam =driver_44_Tam.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div[2] / div[1] / div[2] / div[2] / div[2] / input")); 
                string actualValue_44_Tam = error_44_Tam.GetAttribute("value");
                Assert.AreEqual("2", actualValue_44_Tam);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Không tìm thấy thông báo lỗi.");
            }

            Thread.Sleep(3000);
            driver_44_Tam.Close();
        }

        [TestMethod]
        public void TC6_searchSuccess_44_Tam() //Tim kiem thanh cong
        {
            WebDriver driver_44_Tam = new ChromeDriver();
            string url = "https://cellphones.com.vn/";
            driver_44_Tam.Navigate().GoToUrl(url);
            Thread.Sleep(6000);

            string search_44_Tam = "Iphone";
            IWebElement searchText_44_Tam = driver_44_Tam.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/header/div[2]/nav / div[3] / form / div / input")); 
            searchText_44_Tam.SendKeys(search_44_Tam);
            IWebElement searchClick_44_Tam = driver_44_Tam.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/header/div[2]/nav / div[3] / form / div / div[1]")); 
            searchClick_44_Tam.Click();

            Thread.Sleep(3000);
            IWebElement searchResult_44_Tam = driver_44_Tam.FindElement(By.CssSelector(".product-item"));
            Assert.IsTrue(searchResult_44_Tam.Displayed); // Kiểm tra xem kết quả tìm kiếm có được hiển thị trên trang hay không

            Thread.Sleep(3000);
            driver_44_Tam.Close();
        }

        [TestMethod]
        public void TC7_searchFail_44_Tam() //Tim kiem that bai
        {
            WebDriver driver_44_Tam = new ChromeDriver();
            string url = "https://cellphones.com.vn/";
            driver_44_Tam.Navigate().GoToUrl(url);
            Thread.Sleep(3000);

            string search_44_Tam = "aaaaa";
            IWebElement searchText_44_Tam = driver_44_Tam.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/header/div[2]/ nav / div[3] / form / div / input")); 
            searchText_44_Tam.SendKeys(search_44_Tam);

            IWebElement searchClick_44_Tam =driver_44_Tam.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/header/div[2]/ nav / div[3] / form / div / div[1]")); 
            searchClick_44_Tam.Click();
            Thread.Sleep(500);

            IWebElement searchResult_44_Tam = driver_44_Tam.FindElement(By.CssSelector("#search-catalog-page > div.no-result > p")); 
            string searchResult = searchResult_44_Tam.Text;

            Assert.AreEqual("Không có kết quả bạn cần tìm", searchResult, "Unexpected results!"); // Kiểm tra xem kết quả tìm kiếm có được hiển thị trên trang hay không

            Thread.Sleep(1000);
            driver_44_Tam.Quit();

        }

    }
}
