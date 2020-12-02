using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaf1 = new Leaf("First leaf");
            var leaf2 = new Leaf("Second leaf");
            var leaf3 = new Leaf("Third leaf");
            var leaf4 = new Leaf("Fourth leaf");
            var leaf5 = new Leaf("Fifth leaf");
            var composite1 = new Composite();
            var composite2 = new Composite();

            composite1.Add(leaf1);
            composite1.Add(leaf2);
            composite1.Add(leaf3);
            composite2.Add(leaf4);
            composite2.Add(leaf5);

            //composite 자기 자신도 추가할 수 있습니다.
            composite1.Add(composite2);

            Console.WriteLine("composite1.Operation() - three Leaf and one composite has two leaf");
            composite1.Operation();
            Console.WriteLine("composite2.Operation() - two leaf");
            composite2.Operation();
        }
    }
}
