

class Program
{
    public static void Main()
    {
        string filePath =
        @"test.txt";
        StreamReader reader = null;
        if (File.Exists(filePath))
        {
            reader = new StreamReader(File.OpenRead(filePath));
            List<string> listA = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                foreach (var item in values)
                {
                    listA.Add(item);
                }
                foreach (var coloumn1 in listA)
                {
                    Console.WriteLine(coloumn1);
                }
                listA.Clear();
            }
        }
        else
        {
            Console.WriteLine("File doesn't exist");
        }
        Console.ReadLine();
    }
}