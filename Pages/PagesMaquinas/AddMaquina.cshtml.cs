using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using obligatorio.persistencia;
using obligatorio.clases;

namespace obligatorio.Pages.PagesMaquinas
{
    public class AddMaquinaModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPostAddMaquina()
        {
            try
            {
                Maquinas m = new Maquinas(Convert.ToInt32(Request.Form["id"]), Request.Form["nombre"], Request.Form["tipo"]);
                PPersona.AddPersona(p);
                return RedirectToPage("/PagesMaquinas/AddMaquina");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return RedirectToPage("/PagesMaquinas/AddMaquina");

            }

        }
    }
}
