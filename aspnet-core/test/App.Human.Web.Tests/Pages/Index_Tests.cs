using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace App.Human.Pages;

public class Index_Tests : HumanWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
