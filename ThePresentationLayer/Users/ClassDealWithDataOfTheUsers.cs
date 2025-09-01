using System.Data;
using TheDataLayer_For_Project;
namespace ThePusnissLayer.Users
{
    public class ClassDealWithDataOfTheUsers
    {
        public static bool FindUserByNameAndPassWord(string Name ,string Password)
        {
            return ClassDataFromTheUsers.IsUserExist(Name,Password);
        }
        
        public static bool FindUserByPersonID(int PersonID)
        {
            return ClassDataFromTheUsers.IsUserExist(PersonID);
        }


        public static DataTable PassAllDataFromTheUsers()
        {
            return ClassDataFromTheUsers.GetAllInformationFromTheUsers();

        }



        public static ClassTheUserInformation FindByID(int ID)
        {
            int PersonID=-1;string UserName="", Password="";
            bool IsActive=false;

            if (ClassDataFromTheUsers.GetUserById( ref ID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                ClassTheUserInformation User = new ClassTheUserInformation( UserName,  Password, ID, PersonID, IsActive);
                return User;
            }
            else
            {
                return null;

            }

        }
        
        
        public static ClassTheUserInformation FindUserByUserNameAndPassWord(string UserName,string Password )
        {
            int PersonID=-1,ID=-1;
            bool IsActive=false;

            if (ClassDataFromTheUsers.GetUserByNameAndPassword( ref ID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                ClassTheUserInformation User = new ClassTheUserInformation( UserName,  Password, ID, PersonID, IsActive);
                return User;
            }
            else
            {
                return null;

            }

        }
       
        public static ClassTheUserInformation FindByPersonID(int PersonID)
        {
            int ID=-1;string UserName="", Password="";
            bool IsActive=false;

            if (ClassDataFromTheUsers.GetUserByPersonId( ref ID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                ClassTheUserInformation User = new ClassTheUserInformation( UserName,  Password, ID, PersonID, IsActive);
                return User;
            }
            else
            {
                return null;

            }

        }
       
        
        


    }
}
