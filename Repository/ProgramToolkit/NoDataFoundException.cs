using System;

namespace 一盒蛋玩具店.Repository.ProgramToolkit
{
    internal class NoDataFoundException : Exception
    {
        public NoDataFoundException(string message) : base(message) { }
    }
}
