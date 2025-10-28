using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyLinks.Pages
{
    public class IndexModel : PageModel
    {
        // 1. Data Property: User's name
        public string YourName { get; set; } = "";

        // 2. Data Property: List of links
        public List<LinkItem> Links { get; set; } = new List<LinkItem>();
        public void OnGet()
        {
            YourName = "Yogesh Agrawal.";

            Links = new List<LinkItem>
            {
                new LinkItem { Title = "My GitHub Profile", Url = "https://github.com/YogeshAgrawal-07" },
                new LinkItem { Title = "My LinkedIn", Url = "https://www.linkedin.com/in/yogesh-agrawal-830b8429b" },
                new LinkItem { Title = "My Portfolio Website", Url = "https://linktr.ee/yogeshagrawal" },
            };
        }
    }

    public class LinkItem
    {
        public string Title { get; set; } = "";
        public string Url { get; set; } = "";
    }
}
