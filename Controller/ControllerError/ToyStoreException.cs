using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一盒蛋玩具店.Controller.Error
{
    internal class ToyStoreException : Exception
    {
        public Error ErrorCode { get; }

        public ToyStoreException(Error errorCode)
            : base(ErrorMessage.GetErrorMessage(errorCode))
        {
            ErrorCode = errorCode;
        }
    }
}
