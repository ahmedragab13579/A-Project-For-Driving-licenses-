using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;
namespace ThePusnissLayer.People
{
    public class ClassDealWithDataFromThePeople
    {
        public static DataTable PassAllDataFromThePeople()
        {
            return ClassDataFromThePeople.GetAllInformationFromThePeople();

        }
        public static ClassPersonInformation FindByID(int ID)
        {
            int NationalityCountryID=0, Gendor=0; string firstName = "",
                SecondName = "", ThirdName = "", lastName = "", NationalNo = "",
                 ImagePath = "", 
                 email = "", phone = "", address = "";
                 DateTime DataOfBirth = DateTime.Now;



            if (ClassDataFromThePeople.GetPersonById(ref ID, ref firstName, ref SecondName, 
                ref ThirdName, ref  lastName, ref email, ref phone, ref address, ref DataOfBirth,
                ref ImagePath, ref NationalityCountryID, ref Gendor, ref NationalNo))
            {
                ClassPersonInformation Person = new ClassPersonInformation( ImagePath,  NationalityCountryID,email, phone,
             address,  Gendor, DataOfBirth, lastName,
             ThirdName,  SecondName, firstName, NationalNo,ID);
                return Person;
            }
            else
            {
                return null;

            }

        }

        public static ClassPersonInformation FindByNationalID(string NationalID)
        {
            int NationalityCountryID=0,ID=0, Gendor=0; string firstName = "",
                SecondName = "", ThirdName = "", lastName = "", 
                 ImagePath = "", 
                 email = "", phone = "", address = "";
                 DateTime DataOfBirth = DateTime.Now;



            if (ClassDataFromThePeople.GetPersonByNationalId(ref ID, ref firstName, ref SecondName, 
                ref ThirdName, ref  lastName, ref email, ref phone, ref address, ref DataOfBirth,
                ref ImagePath, ref NationalityCountryID, ref Gendor, ref NationalID))
            {
                ClassPersonInformation Person = new ClassPersonInformation( ImagePath,  NationalityCountryID,email, phone,
             address,  Gendor, DataOfBirth, lastName,
             ThirdName,  SecondName, firstName, NationalID, ID);
                return Person;
            }
            else
            {
                return null;

            }

        }
        
        public static bool FindByNationalID2(string NationalID)
        {
          
          return ClassDataFromThePeople.IsNationalIDExist(NationalID);

        }
       


        



    }




}
