using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class Prototype
    {
        public string Value { get; set; }
        public abstract Prototype Clone();
    }

    public class ConcretePrototype : Prototype
    {
        public ConcretePrototype()
        {
            Console.WriteLine("ConcretePrototype has been created.");
            Value = "A";
        }

        public ConcretePrototype(ConcretePrototype other)
        {
            Console.WriteLine("ConcretePrototype has been created.");
            Value = other.Value;
        }
        
        public void print()
        {
            Console.WriteLine($"Value: {Value}");
        }

        public override Prototype Clone()
        {
            return new ConcretePrototype(this);
        }
    }
}
