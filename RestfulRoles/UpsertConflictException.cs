using System;

namespace RestfulRoles
{
    public class UpsertConflictException : ConflictException
    {
        public UpsertConflictException()
        {
        }

        public UpsertConflictException(string message)
            : base(message)
        {
        }

        public UpsertConflictException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
