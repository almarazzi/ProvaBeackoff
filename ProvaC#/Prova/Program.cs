using System.Net.Sockets;
using TwinCAT.Ads;

using (AdsClient a = new AdsClient())
{
    try
    {
        a.Connect("199.4.42.250.1.1", 851);
        uint h = a.CreateVariableHandle("MAIN.bottone");
        while (true)
        {
            int b = a.ReadAny<int>("MAIN.c");
            //bool c = (bool)a.ReadAny("MAIN.bottone", typeof(bool));
            var c = a.ReadAny<bool>(h);
            a.WriteAny(h, (c == false) ? true : false);
            Console.WriteLine(b);
            Thread.Sleep(1000);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"eccezione {e.Message}");
    }
}
