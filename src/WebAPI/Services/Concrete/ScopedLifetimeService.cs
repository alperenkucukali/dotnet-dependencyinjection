using WebAPI.Services.Abstract;

namespace WebAPI.Services.Concrete
{
    public class ScopedLifetimeService : IScopedLifetimeService
    {
        private readonly string _guid;
        public ScopedLifetimeService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetName()
        {
            return $"Scoped, Guid:{_guid}";
        }
    }
}
