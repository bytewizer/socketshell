using TinyOS.Core.Models;

namespace socketshell;

[TestClass]
public class JsonResponseTest
{
    [TestMethod]
    public void OkEquatable()
    {
        var response = JsonResponse.Ok();
        Assert.AreEqual(response, "{}");
    }

    [TestMethod]
    public void ErrorEquatable()
    {
        var response = JsonResponse.Error("error message");
        Assert.AreEqual(response, """{"Err":"error message","Code":""}""");
    }

}