using UsersApi.Models;

namespace UsersApi.Services;

public class UserService : IUserService
{
    private readonly List<UserModel> _users = new List<UserModel>();
    
    public IEnumerable<UserModel> GetAll()
    {
        return _users;
    }

    public UserModel? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Create(UserModel user)
    {
        throw new NotImplementedException();
    }

    public void Update(UserModel user)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}