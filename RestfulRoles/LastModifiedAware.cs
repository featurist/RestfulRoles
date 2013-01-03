using System;

namespace RestfulRoles
{
    public interface LastModifiedAware
    {
        DateTimeOffset? LastModified { get; }
    }
}
