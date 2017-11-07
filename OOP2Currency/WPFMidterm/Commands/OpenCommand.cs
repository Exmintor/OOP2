using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMidterm.Commands
{
    class OpenCommand : BasicCommand
    {
        public OpenCommand(Action action) : base(action)
        {

        }
    }
}
