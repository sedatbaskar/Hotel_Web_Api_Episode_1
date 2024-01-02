using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
	public class StaffController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public StaffController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task <IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("");
			return View();
		}
	}
}
