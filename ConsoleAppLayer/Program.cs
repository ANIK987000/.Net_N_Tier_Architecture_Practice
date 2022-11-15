using BusinessLoginLayer_BLL_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = StudentService.Get();
            foreach (var item in data)
            {
                Console.WriteLine("ID : {0}, Name: {1}", item.ID, item.Name);
                //System.Console.Write("ID:"+item.ID+",");
                //System.Console.WriteLine("Name:" + item.Name);
            }
        }
    }
}
