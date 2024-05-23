using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using obligatorio.clases;
using obligatorio.persistencia;

namespace obligatorio.Pages.PagesSocios
{
    public class AddSocioModel : PageModel
    {
        public List<Local> locales = new List<Local>();
        
        public void OnGet()
        {
            locales = PLocal.Getlocales();
        }


        public IActionResult OnPostAddPrestamo()
        {
            Console.WriteLine(Request.Form["locales"].ToString());
            locales l = new Local(Convert.ToInt32(row["idLocal"]), row["name"].ToString(), row["city"].ToString(), row["phone"].ToString(), PResponsable.GetResponsable(Convert.ToInt32(row["id"])));
            return Redirect("./ListLocales");
        }
    }
}
