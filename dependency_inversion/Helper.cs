using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public interface IKeyboard
    {
        void Typing();
    }

    public class WiredKeyboard : IKeyboard
    {
        public void Typing()
        {
            Console.WriteLine("Typing using Wired KeyBoard");
        }
    }
    class  WireLessKeyBoard: IKeyboard { 
    public void Typing()
        {
            Console.WriteLine("Typing using Wireless KeyBoard");
        }
    }


    public interface IMouse
    {
        void MovingCursor();
    }

    public class  WiredMouse : IKeyboard
    {
        public void Typing()
        {
            Console.WriteLine("Moving cursor using Wired Mouse");
        }
    }
    public class WireLessMouse : IKeyboard
    {
        public void Typing()
        {
            Console.WriteLine("Moving cursor using Wireless Mouse");
        }
    }
}
