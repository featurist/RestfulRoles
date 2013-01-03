namespace RestfulRoles
{
    public class RetrieveResult<TInstance>
    {
        private static readonly RetrieveResult<TInstance> NotModifiedInstance = new RetrieveResult<TInstance>();

        public static RetrieveResult<TInstance> Retrieved(TInstance instance)
        {
            return new RetrieveResult<TInstance> { WasRetrieved = true, Value = instance };
        }
        
        public static RetrieveResult<TInstance> NotModified
        {
            get { return NotModifiedInstance; }
        }

        public bool WasRetrieved { get; set; }
        public TInstance Value { get; set; }
    }
}