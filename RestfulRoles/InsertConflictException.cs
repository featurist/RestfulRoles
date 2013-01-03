using System;

namespace RestfulRoles
{
    public class InsertConflictException : ConflictException
    {
        public InsertConflictException()
        {
        }

        public InsertConflictException(string message)
            : base(message)
        {
        }

        public InsertConflictException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}