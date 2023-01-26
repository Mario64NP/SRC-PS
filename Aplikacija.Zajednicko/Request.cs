using System;

namespace Aplikacija.Zajednicko
{
    [Serializable]
    public class Request
    {
        public Operation Operation { get; set; }
        public object Argument { get; set; }
    }
}