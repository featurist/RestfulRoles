using System;

namespace RestfulRoles
{
    public interface Retriever<TInstance>
    {
        RetrieveResult<TInstance> Retrieve(string id, DateTimeOffset? ifModifiedSince, string ifNoneMatch);
    }
}