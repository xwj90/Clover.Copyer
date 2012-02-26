using System;
using Clover.Copyer;

namespace Copyer
{
    // delegate long Square(int input);
    class Program
    {
        static void Main(string[] args1)
        {

            ClassA target = new ClassA();
            ClassB source = new ClassB() { A = "AA", B = 2, C = DateTime.Now };

            //复制代码
            CopyHelper<ClassB, ClassA>.Copy(source, target);

            Console.WriteLine(target.A);
            Console.WriteLine(target.B);
            Console.WriteLine(target.C);
        }
    }

    public sealed class ClassA
    {

        public string A { get; set; }
        public int B { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public DateTime C { get; set; }

    }
    public sealed class ClassB
    {
        public string A { get; set; }
        public int B { get; set; }
        public DateTime C { get; set; }
    }
}
