namespace LitecartTests.PageObjects
{
    class Header
    {
        #region Locators
        private const string LogoIconLocator = "//*[@id='header']/descendant::img[@title='My Store']";
        private const string SignInButtonLocator = "//div[@id='default-menu']/descendant::li[contains(@class, 'account')]";
        private const string LoginInputLocator = "//form[@name='login_form']/descendant::input[@name='email']";
        private const string PasswordInputLocator = "//form[@name='login_form']/descendant::input[@name='password']";
        private const string CartBlockLocator = "//div[@id='cart']";
        private const string CartItemsQtyLocator = "//div[@id='cart']/descendant::span[@class='quantity']";
        private const string CartCumulativeValueLocator = "//div[@id='cart']/descendant::span[@class='formatted_value']";
        #endregion
    }
}
