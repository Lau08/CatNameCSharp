using System;

namespace Model
{
    public abstract class Animal
    {
        public string Name { get; set; } = "";
        public abstract void Eat(string Name);
    }
}

