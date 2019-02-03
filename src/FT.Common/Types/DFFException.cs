using System;

namespace FT.Common.Types
{
    public class FTException : Exception
    {
        public string Code { get; }

        public FTException()
        {
        }

        public FTException(string code)
        {
            Code = code;
        }

        public FTException(string message, params object[] args)
            : this(string.Empty, message, args)
        {
        }

        public FTException(string code, string message, params object[] args)
            : this(null, code, message, args)
        {
        }

        public FTException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        public FTException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }
    }
}