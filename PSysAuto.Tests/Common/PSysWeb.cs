using PSysAuto.Tests.Pages;

namespace PSysAuto.Tests.Common
{
    public class PSysWeb
    {
        public static HomePageObject HomePage => new HomePageObject();
        public static LoginPageObject LoginPage => new LoginPageObject();
    }
}
