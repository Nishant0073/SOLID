using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class MacBook
    {
        //This will solve problem we can create macbooks with wired or wireless mouse or keyboard
        IKeyboard keyboard;
        IMouse mouse;
        public MacBook(IMouse mouse, IKeyboard keyboard)
        {
            this.mouse = mouse;
            this.keyboard = keyboard;
        }

    }
}
