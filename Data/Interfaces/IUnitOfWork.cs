

namespace Data.Interfaces
{
    public  interface IUnitOfWork
    {
        IUserRepository User { get; }
        IFanRepository Fan{ get; }
    }
}
