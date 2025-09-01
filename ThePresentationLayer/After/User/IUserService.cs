using DVDL_Business.After.DTOs;
namespace DVDL_Business.After.User
{
    public interface IUserService
    {
        public List<UserDto> GetAll();
        public UserDto GetById(int userId);
        public UserDto GetByUserNameAndPassword(string userName, string password);
        public UserDto GetByPersonId(int personId);
        public bool IsUserExist(string userName, string password);
        public bool IsUserExist(int personId);
        public int Add(UserDto user);
        public bool Update(UserDto user);
        public bool Delete(int id);
    }
}
