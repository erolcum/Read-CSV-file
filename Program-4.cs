
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
            using (StreamWriter writer = File.CreateText(filePath))
            {
                foreach (var item in programConfigList)
                {
                    writer.WriteLine(item.Key + "," + item.Value);
                }
            }

            programConfigList.Clear(); // dictionary is cleaned
            
            using (StreamReader reader = File.OpenText(filePath))
            {
                string? line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    programConfigList.Add(values[0], values[1]); // key and value
                }
            }

            Console.WriteLine("Printer IP: " + programConfigList["PrinterIp"]);
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
        Console.ReadKey();
    }
}