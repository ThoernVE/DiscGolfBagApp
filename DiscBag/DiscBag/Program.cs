using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DiscBag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiscGolfBag.LoadData();
            DiscGolfBag.GolfBagMenu();
            DiscGolfBag.SaveData();
            //calling the method from DiscGolfBag-class to start menu.
           
        }
    }
}
