using WebAPI.Services.Abstract;

namespace WebAPI.Services.Concrete
{
    public class TransientLifetimeService : ITransientLifetimeService
    {
        private readonly string _guid;
        public TransientLifetimeService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetName()
        {
            return $"Transient, Guid:{_guid}";
        }
    }
}
