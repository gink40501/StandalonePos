using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一盒蛋玩具店.Repository.ProgramToolkit
{
    internal class NoDataFoundException : Exception
    {
        public NoDataFoundException(string message) : base(message) { }
    }
}
