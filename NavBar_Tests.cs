using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace NewEveryKey;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class NavBarTests : PageTest
{
    [Test]
    public async Task Homepage()
    {
        await Page.GotoAsync("https://everykey.com");

        // Expect a title "to contain" a substring.
        Page.Locator(".nav-link").GetByText("Home");
        await Expect(Page.GetByRole(AriaRole.Link).GetByText("Home").First).ToHaveAttributeAsync("href", "https://everykey.com/enterprise");
        //await Expect(Page).ToHaveURLAsync("https://everykey.com/enterprise");

        //page.locator(".nav-link").getbytext("Product");
        //await expect(page).toHaveURL("https://everykey.com/enterprise/product");

        //page.locator(".nav-link").getbytext("Security");
        //await expect(page).toHaveURL("https://everykey.com/security");

        //page.locator(".nav-link").getbytext("Support");
        ///await Expect(page).toHaveURL("https://everykey.com/support");

        //page.locator(".nav-link").getbytext("Setup");
        //await expect(page).toHaveURL("https://everykey.com/setup");

        // create a locator
        var getStarted = Page.Locator(".button-CTA").First;
        getStarted.ClickAsync();

    
        // Expects the URL to contain intro.

    }
}