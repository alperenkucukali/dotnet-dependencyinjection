using WebAPI.Services.Abstract;

namespace WebAPI.Services.Concrete
{
    public class SingletonLifetimeService : ISingletonLifetimeService
    {
        private readonly string _guid;
        public SingletonLifetimeService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetName()
        {
            return $"Singleton, Guid:{_guid}";
        }
    }
}
