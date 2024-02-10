using asp_hw_2.Interfaces;

namespace asp_hw_2.Services
{
    public class AnimalService
    {
        private readonly IAnimal _animal;

        public AnimalService(IAnimal animal)
        {
            _animal = animal;
        }

        public string GetAnimalInfo()
        {
            return $"Name: {_animal.GetName()}, Sound: {_animal.MakeSound()}";
        }
    }
}
