using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult adt = new Adult();
            Child chd = new Child();
            adt.FirstName = "Jame";
            adt.LastName = "Shaw";
            chd.FirstName = "Janny";
            chd.LastName = "murphy";
            demo[] demos = new demo[] { new Adult(), new Child()};
            foreach (demo d in demos)
            {
                d.FirstName = "Gurjot";
                d.LastName = "Kaur";
                Console.WriteLine("array First Name: {0} \n Last Name: {1}", d.FirstName, d.LastName);
            }
           
        }
    }

    class demo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Adult:demo
    {
      
    }
    class Child:demo
    {
       
    }
}
