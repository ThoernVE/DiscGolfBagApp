using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            Run();
        }


        static void Run()
        {
            LogIn.Start(); //Log-in message that starts the loginprocess to choose user
            DiscGolfBag.GolfBagMenu(); //menu that runs the app
            DiscGolfBag.SaveData(); //method that saves data after app closes
            
        }
    }
}
