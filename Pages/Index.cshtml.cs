using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace az_app_tim.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IConfiguration _configuration;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
        this._configuration = configuration;
        this._logger = logger;
    }

    public void OnGet()
    {
        ViewData["Greeting"] = _configuration["Greeting"];
    }
}
