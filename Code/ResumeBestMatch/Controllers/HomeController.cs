using Microsoft.AspNetCore.Mvc;
using GroupDocs.Search.Examples.CSharp.BasicUsage;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace ResumeBestMatch.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class HomeController : ControllerBase
	{
		[HttpGet(Name = "GetResumeBestMatch")]
		public string GetResumeBestMatch(string seachWord, string path)
		{
			WorkWithSearchResults workWithSearchResults = new WorkWithSearchResults();
			var res= workWithSearchResults.ObtainSearchResultInformation(seachWord,path);
			return JsonSerializer.Serialize(res);
		}
	}
}
