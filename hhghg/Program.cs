using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhghg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mxm ss = new mxm();
            ss.add(1, "ss", 55);
            ss.print();
            
        }
        
    }
    class mxm
    {
         int id;
         string name;
        int age;

        public void add(int id_, string name_, int age_) 
        {
            this.id = id_;
            this.name = name_;
            this.age = age_;
        }
        public  void  print() 
        {
            
            Console.WriteLine (id);
            Console.WriteLine(name);
            Console.WriteLine(age);
        }

    }

}
