using asp_hw_2.Interfaces;

namespace asp_hw_2.Models
{
    public class Dog : IAnimal
    {
        public string GetName()
        {
            return "Dog";
        }

        public string MakeSound()
        {
            return "Woof";
        }
    }
}
