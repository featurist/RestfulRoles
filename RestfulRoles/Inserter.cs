namespace RestfulRoles
{
    public interface Inserter<in TInstance>
    {
        string Insert(TInstance instance);
    }
}