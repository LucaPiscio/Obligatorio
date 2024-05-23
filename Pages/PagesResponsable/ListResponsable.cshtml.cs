using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using obligatorio.clases;
using obligatorio.persistencia;

namespace obligatorio.Pages.PagesResponsable
{
    public class ListResponsableModel : PageModel
    {
        public List<Responsable> responsables { get; set; }
        public void OnGet()
        {
            responsables =PResponsable.GetResponsable();
        }

        public IActionResult OnPostDeleteResponsable()
        {
            int idRespon = Convert.ToInt32(Request.Form["idRespon"]);
            PResponsable.DeleteResponsable(idRespon);
            return RedirectToPage("./ListResponsable");
        }

    }
}
