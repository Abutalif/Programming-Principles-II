using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace FarManager_2._0
{
    class Program
    {

        public static void ShowFolders(DirectoryInfo d, int pos)
        {


            FileSystemInfo[] files = d.GetFileSystemInfos();
            for (int i = 0; i < files.Length; ++i)
            {
                if (i == files.Length)
                {
                    break;
                }
                if (i == pos)
                    Console.BackgroundColor = ConsoleColor.Magenta;
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                if (files[i].GetType() == typeof(DirectoryInfo))
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(files[i].Name);

                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.SetCursorPosition(0, pos);
        }
        public static void Down(DirectoryInfo s, int a, int b)
        {
            FileSystemInfo[] UpperFile = s.GetFileSystemInfos();

            Console.SetCursorPosition(0 , a);
            Console.BackgroundColor = ConsoleColor.Magenta;
            if (UpperFile[a].GetType() == typeof(DirectoryInfo))
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(UpperFile[a].Name);
            Console.SetCursorPosition(0, b);
            Console.BackgroundColor = ConsoleColor.Black;
            if (UpperFile[b].GetType() == typeof(DirectoryInfo))
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(UpperFile[b].Name);

            Console.SetCursorPosition(40, b);
        }

        public static void Up(DirectoryInfo ss, int x, int y, int z)
        {
            FileSystemInfo[] LowerFile = ss.GetFileSystemInfos();

            Console.SetCursorPosition(0, x);
            Console.BackgroundColor = ConsoleColor.Magenta;
            if (LowerFile[x].GetType() == typeof(DirectoryInfo))
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(LowerFile[x]);

            Console.SetCursorPosition(0, y);
            Console.BackgroundColor = ConsoleColor.Black;
            if (LowerFile[y].GetType() == typeof(DirectoryInfo))
                Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(LowerFile[y]);

            Console.SetCursorPosition(0, z);
            Console.BackgroundColor = ConsoleColor.Black;
            if (LowerFile[z].GetType() == typeof(DirectoryInfo))
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(LowerFile[z]);
            Console.SetCursorPosition(40, z);
        }
        public static void Main(string[] args)
        {
            Console.SetWindowSize(100, 50);
            Console.CursorVisible = false;
            int pos = 0;

            DirectoryInfo dir = new DirectoryInfo(@"C:\tests");

            ShowFolders(dir, pos);

            bool quit = false;
            while (!quit)
            {
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        pos--;
                        FileSystemInfo[] fa = dir.GetFileSystemInfos();
                        if (pos == 0)
                        {
                            Up(dir, 0, 1, 1);
                        }
                        else
                        if (pos < 0)
                        {

                            pos = dir.GetFileSystemInfos().Length - 1;
                            Up(dir, pos, 0, pos - 1);
                        }
                        else
                        {
                            Up(dir, pos, pos + 1, pos - 1);

                        }

                        break;

                    case ConsoleKey.DownArrow:
                        pos++;
                        FileSystemInfo[] fg = dir.GetFileSystemInfos();
                        if (pos >= fg.Length)
                        {
                            Down(dir, 0, fg.Length - 1);
                        }
                        else
                        {
                            Down(dir, pos, pos - 1);
                        }
                        if (pos > dir.GetFileSystemInfos().Length - 1)
                        {
                            pos = 0;
                        }

                        break;
                    case ConsoleKey.Escape:
                        quit = true;
                        break;
                    case ConsoleKey.Backspace:
                        FileSystemInfo fo = dir.Parent;
                        dir = new DirectoryInfo(fo.FullName);
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        ShowFolders(dir, pos);
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case ConsoleKey.Enter:
                        FileSystemInfo fl = dir.GetFileSystemInfos()[pos];
                        Console.WriteLine(fl);

                        if (fl.GetType() == typeof(DirectoryInfo))
                        {
                            dir = new DirectoryInfo(fl.FullName);

                            Console.Clear();
                            pos = 0;
                            ShowFolders(dir, pos);
                        }
                        else
                        {
                            if (fl.GetType() == typeof(FileInfo))
                            {
                                FileStream fs = new FileStream(fl.FullName, FileMode.Open, FileAccess.ReadWrite);
                                StreamReader str = new StreamReader(fs);
                                Console.Clear();
                                Console.WriteLine(str.ReadToEnd());

                                ConsoleKeyInfo presskey = new ConsoleKeyInfo();
                                do
                                {
                                    presskey = Console.ReadKey();
                                }
                                while (presskey.Key != ConsoleKey.Backspace);
                                Console.Clear();
                                ShowFolders(dir, pos);
                                str.Close();
                                fs.Close();
                            }
                        }
                        break;
                }
            }
            Console.Clear();
        }
    }
}