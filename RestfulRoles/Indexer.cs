using System;

namespace RestfulRoles
{
    public interface Indexer<TCollection>
    {
        RetrievedOrNotModified<TCollection> Index(DateTimeOffset? ifModifiedSince, string ifNoneMatch);
    }
}