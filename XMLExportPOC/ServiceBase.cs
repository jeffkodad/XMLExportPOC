using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLExportPOC
{
    public class ServiceBase
    {
        public void PrintHeading(string text)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine(text);
            Console.WriteLine("===========================================");
        }

        public void PrintSectionBreak()
        {
            Console.WriteLine("===========================================");
        }

        public string GetInput()
        {
            Console.WriteLine("Enter your input and press enter.");
            var input = Console.ReadLine();
            Console.WriteLine();
            return input;
        }

        public void WaitForAnyKey()
        {
            Console.ReadKey();
        }

        public string GetNumberInput(double maxNumber)
        {
            string _val = "";
            Console.Write("Enter your value: ");
            ConsoleKeyInfo key;
            bool read = true;

            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                    if (_x && val <= maxNumber && val != 0)
                    {
                        _val += key.KeyChar;
                        Console.Write(key.KeyChar);
                        Console.Write("\n\n");
                        read = false;
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _val.Length > 0)
                    {
                        _val = _val.Substring(0, (_val.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            // Stops Receving Keys Once Enter is Pressed
            while (read);

            return _val;
        }

        public void ResetApp()
        {
            Console.Clear();
            var program = new Program();
        }
        

        public void DisplayMessageAndWait(string message, Action action)
        {
            Console.WriteLine(message);
            WaitForAnyKey();
            action.Invoke();
        }

        public void CloseAppNow()
        {
            Environment.Exit(0);
        }
    }
}
