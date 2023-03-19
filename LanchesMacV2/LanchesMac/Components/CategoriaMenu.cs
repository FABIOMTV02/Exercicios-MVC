using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NuGet.Protocol.Core.Types;

namespace LanchesMac.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriarRepository;
        public CategoriaMenu(ICategoriaRepository categoriarRepository)
        {
            _categoriarRepository = categoriarRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriarRepository.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categorias);
        }
    }
}
