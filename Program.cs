using System;
using Microsoft.Web.Administration;

namespace IIS_Bindings_Scrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            // http://stackoverflow.com/questions/22458410/credentials-for-servermanager-openremote
            //using (var mgr = ServerManager.OpenRemote("sim-dev-web"))
            using (var mgr = new ServerManager())
            {
                foreach (var site in mgr.Sites)
                {
                    var name = site.Name;
                    var state = site.State;
                    var bindings = site.Bindings;

                    Console.WriteLine("==================");
                    Console.WriteLine("New Site:");
                    Console.WriteLine("   Name:  '{0}'", name);
                    Console.WriteLine("   State: '{0}'", state);
                    Console.WriteLine("   Bindings: ");
                    foreach (var binding in bindings)
                    {
                        //Console.WriteLine("      {0}", binding.EndPoint);
                        //Console.WriteLine("      {0}", binding.Host);
                        //Console.WriteLine("      {0}", binding.Protocol);
                        Console.WriteLine("      {0}", binding.BindingInformation);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
