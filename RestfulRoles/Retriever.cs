using System;

namespace RestfulRoles
{
    public interface Retriever<TInstance>
    {
        RetrievedOrNotModified<TInstance> Retrieve(string id, DateTimeOffset? ifModifiedSince, string ifNoneMatch);
    }
}