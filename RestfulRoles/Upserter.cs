namespace RestfulRoles
{
    public interface Upserter<in TInstance>
    {
        UpsertResult Upsert(string id, TInstance instance);
    }
}