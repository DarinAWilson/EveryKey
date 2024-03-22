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
        await Expect(Page.GetByRole(AriaRole.Link).GetByText("Home").First).ToHaveAttributeAsync("href", "/enterprise");
        await Expect(Page.GetByRole(AriaRole.Link).GetByText("Product").First).ToHaveAttributeAsync("href", "/enterprise/product");
        await Expect(Page.GetByRole(AriaRole.Link).GetByText("Security").First).ToHaveAttributeAsync("href", "/security");
        await Expect(Page.GetByRole(AriaRole.Link).GetByText("Support").First).ToHaveAttributeAsync("href", "/support");
        await Expect(Page.GetByRole(AriaRole.Link).GetByText("Setup").First).ToHaveAttributeAsync("href", "/setup");
        await Expect(Page.GetByRole(AriaRole.Link).GetByText("Account").First).ToHaveAttributeAsync("href", "/account/login");
        await Expect(Page.GetByRole(AriaRole.Link).GetByText("Shop").First).ToHaveAttributeAsync("href", "https://dashboard.everykey.com/shop");

        // Can access both of these webpages, but they do not have them on the main page in the navbar
        //await Expect(Page.GetByRole(AriaRole.Link).GetByText("Tech Specs").First).ToHaveAttributeAsync("href", "/tech-specs");
        //await Expect(Page.GetByRole(AriaRole.Link).GetByText("Reviews").First).ToHaveAttributeAsync("href", "/reviews");

        // create a locator


    
        // Expects the URL to contain intro.

    }
}