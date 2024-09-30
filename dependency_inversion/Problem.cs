using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public class MacBook
    {
        //This is where we are wrong
        //In future if we want to upgrade MacBook to wireless mouse or wireless keyboard we need to modify MacBook class we can solve using interface (loose coupling)
        WiredKeyboard keyboard;
        WiredMouse mouse;
        public MacBook(WiredMouse mouse, WiredKeyboard keyboard)
        {
            this.mouse = mouse;
            this.keyboard = keyboard;
        }

    }
}
