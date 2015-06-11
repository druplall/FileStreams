using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter(@"C:\Users\Deodat\Documents\Visual Studio 2013\Projects\secret_plan.txt");
            sw.WriteLine("How I'll defeat Captain Amzaing");
            sw.WriteLine("Another genius secret plan by The Swindler");
            sw.Write("I'll create an army og clones and ");
            sw.WriteLine("unleash them upon the citizens of Objectville.");

            String location = "the mall";

            for (int numbers = 0; numbers <= 6; numbers++) {
                sw.WriteLine("Clone #{0} attack {1}", numbers, location); // Here the #{0}.. are being overwritten by the parameters
                if (location == "the mall") { location = "downtown";}
                else{location = "the mall";}
            }
            
            sw.Close();
        }

    }
}
