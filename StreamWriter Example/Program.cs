using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriter_Example
{
    class Program
    {
        static void Main(string[] args)
        {


            StreamWriter writer = new StreamWriter("number.txt");
            using (writer)
            {
                for (int i = 0; i < 100; i++)
                {
                    writer.WriteLine(i);
                }
            }

          



        }
    }
}
