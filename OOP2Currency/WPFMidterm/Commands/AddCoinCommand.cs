using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMidterm.Commands
{
    public class AddCoinCommand : BasicCommand
    {
        public AddCoinCommand(Action action) : base(action)
        {

        }
    }
}
