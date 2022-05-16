using System;

namespace SSU.Coins.CustomException
{
    public class RoleUndefinedException : Exception
    {
        public RoleUndefinedException() : base() { }
        public RoleUndefinedException(string message) : base(message) { }
        public RoleUndefinedException(string message, Exception innerException) : base(message, innerException) { }
    }
}