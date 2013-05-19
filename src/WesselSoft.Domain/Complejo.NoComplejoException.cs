using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WesselSoft.Domain
{
    public class NoComplejoException : Exception
    {
        public NoComplejoException(String msg) : base(msg)
        {
        }
    }
}
