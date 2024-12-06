using System;
using System.Text;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using Aspose.Imaging.ImageOptions;

public class Program 
{
    // path bug needs to be fixed
    public void CreateFiles()
    {

        string fileExtension = "txt";
        string DefaultPath = "./";
        Console.WriteLine("Enter Files Path Or Leave Empty For Current Path");
        string temp = Console.ReadLine();

        if(temp == "Abort")
        {
            Console.WriteLine("");
            return;
        }

        string PathTemp = temp;
        string FilesPath = "";
        int num = 0;
        if (PathTemp == "" || PathTemp == null)
        {
            FilesPath = DefaultPath;
        }
        Console.WriteLine("Enter Number Of Files To Be Created: ");
        string numtemp = Console.ReadLine();

        if(numtemp == "Abort")
        {
            Console.WriteLine("");
            return;
        }

        if(numtemp == null || int.TryParse(numtemp, out num) == false)
        {
            Console.WriteLine("Invalid Input\n");
            return;

        }
        else
        {
            num = int.Parse(numtemp);

        }
        
        

        Console.WriteLine("Enter first name of file:\n");
        string fileName = Console.ReadLine();

        if(fileName == "Abort")
        {
            Console.WriteLine("");
            return;
        }

        Console.WriteLine("enter file content:");
        string fileContent = Console.ReadLine();

        if(fileContent == "Abort")
        {
            Console.WriteLine("");
            return;
        }    
        if(fileContent == "" || fileContent == null)
        {
            fileContent = " ";
        }
        for(int i = 1; i <= num; i++) 
        {
            FileStream s = File.Create(DefaultPath + fileName + '_' + i + "." + fileExtension);
            string buffer = "";
        

                buffer = buffer + fileContent + " ";
                
                    
                byte[] bytes = new UTF8Encoding(true).GetBytes(fileContent);
                s.Write(bytes, 0, bytes.Length);
                Console.WriteLine(s.Name);

            s.Close();
        }
        Console.WriteLine("Files Created Successfully\n");
        return;
        
    }
  
    public void CreateFolder()
    {
        string DefaultPath = Directory.GetCurrentDirectory();
        Console.WriteLine("Enter Folder Path Or Leave Empty For Current Path");
        string Path = Console.ReadLine();
        if(Path == "Abort")
        {
            Console.WriteLine("");
            return;
        }
        if(Directory.Exists(Path))
        {
            DefaultPath = Path;
        }
        Console.WriteLine("Enter Folder Name:");
        string FolderName = Console.ReadLine();
        if(FolderName == "Abort")
        {
            Console.WriteLine("");
            return;
        }
        Directory.CreateDirectory(DefaultPath + "\\" + FolderName);
        
        Console.WriteLine("Folder Created Successfully\n");

    }

    public void DeleteFolder()

    {
        string DefaultPath = Directory.GetCurrentDirectory();
        Console.WriteLine("Enter Folder Path Or Leave Empty For Current Path");
        string Path = Console.ReadLine();
        if(Path == "Abort")
        {
            Console.WriteLine("");
            return;
        }
        if(Directory.Exists(Path))
        {
            DefaultPath = Path;
        }else 
        {
            Console.WriteLine("Folder Does Not Exist\n");
            return;
        }
        Console.WriteLine("Enter Folder Name:");
        string FolderName = Console.ReadLine();
        if(FolderName == "Abort")
        {
            Console.WriteLine("");
            return;
        }
        Directory.Delete(DefaultPath + "\\" + FolderName);
    }
    public void DeleteAllFiles()
    {   
        string DefaultPath = "./";

        Console.WriteLine("Enter Files Path OR Press Enter Use Current Path: ");
    string UserPath = Console.ReadLine();
        if(UserPath == "Abort")
        {
            Console.WriteLine("");
            return;
        }

        if(UserPath == "" || UserPath == null)
        {
            Console.WriteLine("Are You Sure You Want To Delete All Files In This Directory " + DefaultPath + " Press Y/N \n");
            string UserInput = Console.ReadLine();
            if(UserInput == "Y" || UserInput == "y")
            {
                UserPath = DefaultPath;

            }
            else
            {
                Console.WriteLine("");
                return;
            }
        }
        if(UserPath != "" && Directory.Exists(UserPath))
        {
            string[] files = Directory.GetFiles(UserPath);
            
            foreach(string file in files)
            {
                File.Delete(file);
                Console.WriteLine(file);
            }
        }
        Console.WriteLine("Files Were Deleted Successfully \n");
        return;


    }
    
    public void DeleteByExtension()

    {   string DefaultPath = "./SUS/";
        Console.WriteLine("Enter Files Path OR Press Enter Use Current Path: ");
        string path = Console.ReadLine();

        if(Console.ReadKey().Key.ToString() == "ctrl")
        {
            Console.WriteLine("lol");
        }

        if(path == "Abort")
        {
            Console.WriteLine("");
            return;
        }

        if(Directory.Exists(path))
        {
            DefaultPath = path;
        }

        Console.WriteLine("Enter File Extension To Be Deleted: ");
        string extension = Console.ReadLine();

        if(extension == "Abort")
        {
            Console.WriteLine("");
            return;
        }
        string[] Files = Directory.GetFiles(DefaultPath);
        foreach(string file in Files)
        {
            if(file.Substring(file.LastIndexOf(".") + 1) == extension)
            {
                File.Delete(file);
                Console.WriteLine(file);
            }
        }
        Console.WriteLine("All Files With " + extension + " Extension Was Deleted \n");
        return;
    }
    public void DeleteByName()
    {
        string DefaultPath = "./SUS/";
        Console.WriteLine("Enter Files Path OR Press Enter Use Current Path: ");
        string path = Console.ReadLine();
        if(path == "Abort")
        {
            Console.WriteLine("");
            return;
        }

        if(path != null && Directory.Exists(path))
        {
            DefaultPath = path;
        } 
            

        Console.WriteLine("Enter Files Name To Be Deleted: ");
        string name = Console.ReadLine();
        if(name == "Abort")
        {
            Console.WriteLine("");
            return;
        }
        if(name == null || name == "")
        {
            Console.WriteLine("Name Cannot Be Empty\n");
            return;
        }
        string[] Files = Directory.GetFiles(DefaultPath);
        foreach(string file in Files)
            {
            if(file.Substring(file.LastIndexOf(@"/")).Contains(name))
            {
                File.Delete(file);
                Console.WriteLine(file);
            }
        }
        Console.WriteLine("All Files With Names Containing " + name + " Were Deleted Successfully \n");
        return;
    }
        
    public void CreateMigaBytes()
    {
        string DefaultPath = "./SUS/";
        Console.WriteLine("Enter Files Path OR Press Enter Use Current Path: ");
        string path = Console.ReadLine();
        if(path == "Abort")
        {
            Console.WriteLine("");
            return;
        }
        if(path != null && Directory.Exists(path))
        {
            DefaultPath = path;
        }
        Console.WriteLine("Enter Number Of MigaBytes To Be Created: ");
        string MB = Console.ReadLine();
        if(MB == "Abort")
        {
            Console.WriteLine("");
            return;
        }
        if(int.TryParse(MB, out int i) != true)
        {
            Console.WriteLine("Invalid Number");
            return;
        }
        {

        }
        Console.WriteLine("Enter File Extension To Be Used: ");
        string extension = Console.ReadLine();
        if(extension == "Abort")
        {
            Console.WriteLine("");
            return;
        }
        int num = Convert.ToInt32(MB);
        if(extension == "txt")
        {

            FileStream fs = File.Create(DefaultPath + num + "MB." + extension);
            // // string Content = new string(' ', 1048576 * num);
            // byte[] bytes;
            // Random random = new Random();
            // rando
            // //  = new UTF8Encoding(true).GetBytes(Content);
            // fs.Write(bytes, 0, bytes.Length);
            // fs.Close();
            // Console.WriteLine("File" + num + "MB." + extension + " Was Successfully Created \n");
            const string src = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789\n";

            Random random = new Random();
            byte[] bytes = new byte[1048576 * num];
            for(int e = 0; e < bytes.Length; e++)
            {
                bytes[e] = (byte)src[random.Next(0, src.Length)];
            }
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
            Console.WriteLine("File" + num + "MB." + extension + " Was Successfully Created \n");
        }

        else if(extension == "png")
        {
            //creating the image 
            Image image = CreateImage(int.Parse(MB) * 262144);
            image.Save(DefaultPath + MB + "MBs.png");

            using (Aspose.Imaging.Image img = Aspose.Imaging.Image.Load(DefaultPath + MB + "MBs" +".png"))
            {
                PngOptions options = new PngOptions();
                options.CompressionLevel = 9;
                img.Save(DefaultPath + MB + "MBs" +".png", options);
            }
            
            Console.WriteLine("File " + MB + "MBsCompressed.png" + "Was Created Successfully");
            return;
        }

    }

    Bitmap CreateImage(int size)

    {
        int width = Convert.ToInt32(Math.Sqrt(size));
        int height = Convert.ToInt32(Math.Sqrt(size));
        Bitmap bmp = new Bitmap(width, height);
        Random random = new Random();
        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {
                int a = random.Next(256);
                int r = random.Next(256);
                int g = random.Next(256);
                int b = random.Next(256);

                bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
            }
        }
        return bmp;

    }
    public void Ui()
    {
        int ConsoleWidth = Console.WindowWidth;
        string top = new string('_', ConsoleWidth);
        string bottom = new string('_', ConsoleWidth - 27);
        string hash = new string('#', ConsoleWidth - 2);
        // Console.SetWindowSize(ConsoleWidth, 10);
        Console.WriteLine(top + 
"| Command                | Function " + new string(' ', ConsoleWidth - 37) + "|" + 
"|########################|" + new string('#', ConsoleWidth - 27) + "|" +
"| FileCreate             | Creates Files With Specific Path, Quantity, Name, And Extension  " + new string(' ', ConsoleWidth - 93) + "|"+
"| FileDelete             | Deletes All Files In A Specific Path                             " + new string(' ', ConsoleWidth - 93) + "|"+
"| FileDeleteByExtension  | Deletes All Files With Certain Extension                         " + new string(' ', ConsoleWidth - 93) + "|"+
"| FileDeleteByName       | Deletes All Files With Names Containing Certain Word             " + new string(' ', ConsoleWidth - 93) + "|"+
"| FolderCreate           | Creates A Folder With Certain Name And Path                      " + new string(' ', ConsoleWidth - 93) + "|"+
"| FolderDelete           | Deletes A Folder With Certain Name And Path                      " + new string(' ', ConsoleWidth - 93) + "|"+
"| CreateMBs              |                                                                  " + new string(' ', ConsoleWidth - 93) + "|"+
"|________________________|" + bottom + "|");
        
    }

    public void Run()
    {
        switch (Console.ReadLine()) 
        {
            case "FileCreate":
                CreateFiles();
                break;
            case "FileDelete":
                DeleteAllFiles();
                break;
            case "FolderCreate":
                CreateFolder();
                break;
            case "FolderDelete":
                DeleteFolder();
                break;
            case "FileDeleteByExtension":
                DeleteByExtension();
                break;
            case "FileDeleteByName":
                DeleteByName();
                break;
            case "CreateMBs":
                CreateMigaBytes();
                break;
            case "Exit":
                Console.WriteLine("Exiting Program..."); Environment.Exit(0);
                break;
            default :
                Console.WriteLine("Invalid Input!");
                break;
        }
    
    }
}

