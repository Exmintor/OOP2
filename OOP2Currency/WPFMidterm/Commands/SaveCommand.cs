using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMidterm.Commands
{
    class SaveCommand : BasicCommand
    {
        public SaveCommand(Action action) : base(action)
        {

        }
    }
}
