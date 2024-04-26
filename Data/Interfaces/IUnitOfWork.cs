

namespace Data.Interfaces
{
    public  interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IFanRepository FanRepository { get; }
    }
}
