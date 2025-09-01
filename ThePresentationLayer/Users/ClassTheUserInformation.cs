using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;

namespace ThePusnissLayer.Users
{
    public class ClassTheUserInformation
    {
        enum EnumMode { Add = 1, Update = 2 }
        EnumMode Mode = EnumMode.Add;
        public string UserName { get; set; }
        public int UserID { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int PersonID { get; set; }


        public ClassTheUserInformation()
        {
            UserID = -1;
            PersonID = -1;
            UserName = string.Empty;
            IsActive = false;
            Password = string.Empty;
        }
        public ClassTheUserInformation(string UserName,string Password,int UserID,int PersonID,bool IsActive)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.IsActive = IsActive;
            Mode = EnumMode.Update;

        }

        private int AddNewUser()
        {

            UserID = ClassDataFromTheUsers.AddUser(UserID,PersonID,UserName,Password,IsActive);

            return UserID;
        }


        private int UpdateUser()
        {

            int numberwillupdate = ClassDataFromTheUsers.UpdateUserInfo(UserID,PersonID,UserName,Password,IsActive);

            return UserID;
        }

        public static bool DeleteUser(int id)
        {
            int number = ClassDataFromTheUsers.DeleteUserInfo(id);
            return number != 0;
        }


        public int Save()
        {
            int id = 0;
            switch (Mode)
            {

                case EnumMode.Add:
                    id = AddNewUser();
                    if (id != -1)
                    {

                        Mode = EnumMode.Update;

                    }
                    break;
                case EnumMode.Update:

                    id = UpdateUser();
                    if (id != -1)
                    {

                        Mode = EnumMode.Update;
                    }
                    break;

            }

            return id;
        }


    }
}
