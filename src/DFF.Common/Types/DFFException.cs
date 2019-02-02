using System;

namespace DFF.Common.Types
{
    public class DFFException : Exception
    {
        public string Code { get; }

        public DFFException()
        {
        }

        public DFFException(string code)
        {
            Code = code;
        }

        public DFFException(string message, params object[] args)
            : this(string.Empty, message, args)
        {
        }

        public DFFException(string code, string message, params object[] args)
            : this(null, code, message, args)
        {
        }

        public DFFException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        public DFFException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }
    }
}