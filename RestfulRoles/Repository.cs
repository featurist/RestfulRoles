namespace RestfulRoles
{
    public interface Repository<T> : Inserter<T>, Upserter<T>, Retriever<T>, Deleter
    {
    }
}
