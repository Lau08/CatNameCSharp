
namespace Model
{
    public class Cat : Animal
    {
        public override void Eat(string Name)
        {
            Console.WriteLine("The cat named {0} is Eating", Name);
        }
    }
}

