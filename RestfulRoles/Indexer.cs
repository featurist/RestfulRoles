using System;

namespace RestfulRoles
{
    public interface Indexer<TCollection>
    {
        RetrieveResult<TCollection> Index(DateTimeOffset? ifModifiedSince, string ifNoneMatch);
    }
}