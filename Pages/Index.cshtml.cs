using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazor.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
 public List<Language> Languages {get; set; }
    public void OnGet()
    {
  Languages= new List<Language>()
  {
    new Language() { Value = "C#", Text = "C#" },
    new Language() { Value = "Javascript", Text = "Javascript" },
    new Language() { Value = "Ruby", Text = "Ruby"  }
  };
    }
}
