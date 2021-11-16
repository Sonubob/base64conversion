using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base64conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var userip =  Convert.ToString( Console.ReadLine());


            var arr = Encoding.ASCII.GetBytes(userip);
            var result = Convert.ToBase64String(arr);

            Console.WriteLine(result);


        }
    }
}
