using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCohort
{
    public class Student
    {

        int id = 7869; //field
        int bp = 6342;
        int tf = 6356;
        int hf = 6473;
        double li = 67.9;
        int fg = 43523;
        string ty = "1010";
        decimal tt = (8983);
        long rr = (535);
        float bb = (64863664644646466);
        byte nn = (2);
        public void MyMethod() //method
        {
            Console.WriteLine(id);
            Console.WriteLine(li);
            Console.WriteLine(fg);
            Console.WriteLine(ty);
            Console.WriteLine(tt);
            Console.WriteLine(nn);
        }

        private void access()
        {
            Console.WriteLine(tf);
            Console.WriteLine(li);

        }

        public void scope()
        {
            Console.WriteLine(hf);
        }

        public void alert()
        {
            Console.WriteLine(bp);

        }




    }
}
