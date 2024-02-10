using asp_hw_2.Interfaces;

namespace asp_hw_2.Models
{
    public class Cat : IAnimal
    {
        public string GetName()
        {
            return "Cat";
        }

        public string MakeSound()
        {
            return "Meow";
        }
    }
}
