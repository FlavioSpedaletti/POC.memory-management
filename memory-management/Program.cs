using System;

namespace memory_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //x should be allocated into the stack memory
            int x = 0;

            //myClass1 should be allocated into the heap memory with a reference into the stack memory
            //the id variable insisde the F1 function would also be allocated into the stack memory
            var myClass1 = new MyClass1();
            myClass1.F1();

            //myClass2 should be allocated into the heap memory with a reference into the stack memory
            //the "private int Id" would be allocated into the heap memory as it is a class first citizen
            var myClass2 = new MyClass2();
        }
    }

    //heap allocation
    public class MyClass1
    {
        public void F1()
        {
            //stack allocation
            int y = 0;
        }
    }

    //heap allocation
    public class MyClass2
    {
        //heap allocation (defined as firsl level of MyClass2)
        private int z = 0;
    }
}
