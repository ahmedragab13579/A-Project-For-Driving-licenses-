using DVDL_Business.After.DTOs;
using TheDataLayer_For_Project.Repositories.Users;

namespace DVDL_Business.After.User
{
    public class UserService : IUserService
    {
        private readonly UserRepository _repository;

        public UserService()
        {
            _repository = new UserRepository();
        }
        public int Add(UserDto user)
        {
            return _repository.Add(Map(user));
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public List<UserDto> GetAll()
        {
            List<UserDto> userDtos = new List<UserDto>();
            foreach (var i in _repository.GetAll())
            {
                userDtos.Add(Map(i));

            }
            return userDtos;
        }

        public UserDto GetById(int userId)
        {
            return Map(_repository.GetById(userId));
        }

        public UserDto GetByPersonId(int personId)
        {
            return Map(_repository.GetByPersonId(personId));
        }

        public UserDto GetByUserNameAndPassword(string userName, string password)
        {
            return Map(_repository.GetByUserNameAndPassword(userName, password));
        }

        public bool IsUserExist(string userName, string password)
        {
            return _repository.IsUserExist(userName, password);
        }

        public bool IsUserExist(int personId)
        {
            return _repository.IsUserExist(personId);
        }

        public bool Update(UserDto user)
        {
            return _repository.Update(Map(user));
        }


        private TheDataLayer_For_Project.Models.Users.User Map(UserDto user)
        {
            return new TheDataLayer_For_Project.Models.Users.User
            {
                IsActive = user.IsActive,
                PersonID = user.PersonID,
                UserID = user.UserID,
                Password = user.Password,
                UserName = user.UserName,


            };
        }



        private UserDto Map(TheDataLayer_For_Project.Models.Users.User user)
        {
            if (user == null) { return null; }
            return new UserDto
            {
                IsActive = user.IsActive,
                PersonID = user.PersonID,
                UserID = user.UserID,
                Password = user.Password,
                UserName = user.UserName,

            };

        }
    }
}
