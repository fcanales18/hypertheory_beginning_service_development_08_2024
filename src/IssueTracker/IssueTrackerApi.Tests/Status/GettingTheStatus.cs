using Alba;
using IssueTrackerAPI.Controllers;

namespace IssueTrackerApi.Tests.Status;
public class GettingTheStatus
{
    [Fact]
    public async Task CurrentStatus()
    {
        var host = await AlbaHost.For<global::Program>();

        var httpResponse = await host.Scenario(api =>
        {
            api.Get.Url("/status");
            api.StatusCodeShouldBeOk();
        });

        var representation = await httpResponse.ReadAsJsonAsync<StatusResponseModel>();

        Assert.NotNull(representation);

        Assert.Equal("Looks Good Here, Boss", representation.Message);
    }
}
