using System.IO;
using System.Text;
using System.Threading;
//Create a text file
//save basic details like name age address
// read detail and prin them to the console

string line;

try
{
    StreamWriter sw = new StreamWriter("C:\\Users\\willi\\OneDrive\\Desktop\\A2_3_1.txt");
    sw.WriteLine("Name: \t\tChristopher Williams");
    sw.WriteLine("Age: \t\t28");
    sw.WriteLine("Address \t1234 Mockingbird Lane");
    sw.Close();
}
catch(Exception e)
{
    Console.WriteLine("Exception " + e.Message);
}

Console.WriteLine("Waiting...");
Thread.Sleep(2000);

readDoc();
void readDoc()
{
    try
    {
        //using to run garbage collection on the StreamReader from the file.
        using (StreamReader sr = new StreamReader("C:\\Users\\willi\\OneDrive\\Desktop\\A2_3_1.txt"))
        {
            line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to exit.");

            sr.Close();
            Console.ReadLine();
        }
            
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception " + e.Message);
    }
}

