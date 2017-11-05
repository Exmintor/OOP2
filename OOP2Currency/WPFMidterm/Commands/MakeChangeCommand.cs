using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMidterm.Commands
{
    public class MakeChangeCommand : BasicCommand
    {
        public MakeChangeCommand(Action action) : base(action)
        {

        }
    }
}
