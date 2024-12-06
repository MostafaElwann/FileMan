using System;
using System.Text;
using System.IO;
using System.Linq;

class main 
{
    public static void Main(string[] args)
    {
        bool ToExit = false;
        Program program = new Program();
        
        program.Ui();

        while(ToExit != true)
        {
            program.Run();
        }
        
        Console.ReadLine();
        
    }

}
