

class Program
{
    static void Main()
    {
        string s = Application.StartupPath;
        string filePath = s+ @"\text.txt";
        if (File.Exists(filePath))
        {
            int lineCount = 0;
            StreamReader sr = new StreamReader(filePath); //correct usage in Program-2.cs

            while (sr.Read() > 0) //or check !sr.EndOfStream or check WholeLine=sr.ReadLine())!=null
            {
                var ss = sr.ReadLine().Split(','); //does't work
                lineCount++;
                //Console.WriteLine(ss[0]);  //it prints asan instead of Hasan
            }
            sr.Close();

            //File.ReadLines is another speedy method and returns IEnumerable
            string line = "";
            for (int j = 0; j < lineCount; j++)
            {
                line = File.ReadLines(filePath).Skip(j).First();
                var wordsInLine = line.Split(','); //it works
                foreach (var word in wordsInLine)
                {
                    Console.Write(word + " ");
                }
                Console.Write("\n");
            }
        }
        else 
        { Console.WriteLine("No test.txt file ! Place your file next to .exe file"); }
    }
}
