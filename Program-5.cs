using System.Collections;
class Program
{
    public static void Main()
    {
        string filePath = @"test.txt";
        Hashtable programConfigList = new Hashtable();
        programConfigList.Add("PrinterPort", "9100");
        programConfigList.Add("PrinterIp", "192.168.1.50");
        programConfigList.Add("PlcPort", "COM2");

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (DictionaryEntry item in programConfigList)
                {
                    writer.WriteLine(item.Key + "," + item.Value);
                }
            }

            Console.WriteLine("PrinterPort: " + programConfigList["PrinterPort"]);
            // if it is not found in hashtable, it returns null
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
        Console.ReadKey();
    }   
}