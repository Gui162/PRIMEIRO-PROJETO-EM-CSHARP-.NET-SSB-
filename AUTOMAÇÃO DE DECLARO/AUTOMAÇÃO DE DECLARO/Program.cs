using System;
using System.Threading;
using WindowsInput;


namespace AutomacaoTeclado
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(5000);
            Console.WriteLine("o programa vai começar");

            InputSimulator inputSimulator = new InputSimulator();
            var cont = 0;
            while (true)
            {
                inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.DOWN);
                Thread.Sleep(200);
                var msg = "1";
                inputSimulator.Keyboard.TextEntry(msg);
                Thread.Sleep(200);
                cont += 1;
                if (cont >= 10)
                {
                    break;
                };
            };
        }
    };
};