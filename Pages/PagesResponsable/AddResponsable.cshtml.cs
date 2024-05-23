using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using obligatorio.clases;
using obligatorio.persistencia;

namespace obligatorio.Pages.PagesResponsable
{
    public class AddResponsableModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPostAddMaquina()
        {
            try
            {
                Responsable r = new Responsable(Convert.ToInt32(Request.Form["idRespon"]), Request.Form["nombre"], Request.Form["telefono"]);
                PResponsable.AddResponsable(r);
                return RedirectToPage("/PagesResponsable/AddResponsable");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return RedirectToPage("/PagesResponsable/AddResponsable");

            }

        }
    }
}
