public class HelloWebDriver {
    public static void main(String[] args) throws InterruptedException{
        WebDriver driver = new WebDriver();
        driver.get("https://seleniumhq.org");
        Thread.sleep(2000);
        driver.quit();
    }
}
