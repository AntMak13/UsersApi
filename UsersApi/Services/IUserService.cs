using UsersApi.Models;

namespace UsersApi.Services;

public interface IUserService
{
    IEnumerable<UserModel> GetAll();
    UserModel? GetById(int id);
    void Create(UserModel user);
    void Update(UserModel user);
    void Delete(int id);
}