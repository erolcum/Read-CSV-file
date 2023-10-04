
using System.IO;

class Program
{
    public static void Main()
    {
        string filePath = @"test.txt";
        Dictionary<string, string> programConfigList =
            new Dictionary<string, string>();
        programConfigList.Add("PrinterPort", "9100");
        programConfigList.Add("PrinterIp", "192.168.1.50");
        programConfigList.Add("PlcPort", "COM2");

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in programConfigList)
                {     
                    writer.WriteLine( item.Key + "," + item.Value );
                }
            }

            Console.WriteLine("PrinterPort: " + programConfigList["PrinterPort"]);
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
        Console.ReadKey();
    }
}