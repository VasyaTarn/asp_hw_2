using asp_hw_2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_hw_2.Pages
{
    public class AnimalModel : PageModel
    {
        private readonly AnimalService _animalService;
        public AnimalModel(AnimalService animalService)
        {
            _animalService = animalService;
        }

        public string AnimalInfo { get; private set; }
        public void OnGet()
        {
            AnimalInfo = _animalService.GetAnimalInfo();
        }
    }
}
