using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;

namespace ThePusnissLayer.People
{
    public class ClassPersonInformation
    {
        enum EnumMode { Add=1, Update=2}
        EnumMode Mode=EnumMode.Add;
       public string ImagePath        {get;set;}
       public int NationalityCountryID{get;set;}
       public string Email           {get;set;}
       public string Phone          {get;set;}
       public string Address         {get;set;}
       public int Gendor         {get;set;}
       public DateTime DateOfBirth   {get;set;}
       public string LastName        {get;set;}
       public string ThirdName       {get;set;}
       public string SecondName      {get;set;}
       public string FirstName       {get;set;}
       public string NationalNo        {get;set;}
       public int PersonID        { get; set; }

        public ClassPersonInformation()
        {
            ImagePath = "";
            NationalityCountryID =0;
            Email = "";
            Phone = "";
            Address = "";
            Gendor = 0;
            DateOfBirth = DateTime.Now;
            LastName = "";
            ThirdName = "";
            SecondName = "";
            FirstName = "";
            NationalNo = "";
            PersonID = -1;


        }
        public ClassPersonInformation(string ImagePath,int NationalityCountryID,string Email,string Phone,
            string Address,int Gendor, DateTime DateOfBirth, string LastName,
            string ThirdName, string SecondName, string FirstName, string NationalNo, int PersonID)
        {
            this.ImagePath = ImagePath;
            this.NationalityCountryID = NationalityCountryID;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.Gendor = Gendor;
            this.LastName = LastName;
            this.ThirdName = ThirdName;
            this.SecondName = SecondName;
            this.FirstName = FirstName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = DateOfBirth;
            this.PersonID = PersonID;
            Mode = EnumMode.Update;





        }




                                                        
        private int AddNewPerson()
        {

            PersonID = ClassDataFromThePeople.AddPerson( FirstName,  SecondName,  ThirdName, LastName,  Email,  Phone,  Address,  DateOfBirth,  ImagePath,  NationalityCountryID,  Gendor,  NationalNo);

            return PersonID;
        }
       
        
        private int UpdatePerson()
        {

            int numberwillupdate = ClassDataFromThePeople.UpdatePersonInfo(
               PersonID,  FirstName,  SecondName,
               ThirdName,  LastName,  Email, 
               Phone,  Address,  DateOfBirth,
               ImagePath, 
               NationalityCountryID, 
               Gendor, 
               NationalNo);

            return PersonID;
        }

        public static bool DeletePerson(int id)
        {
            int number = ClassDataFromThePeople.DeletePersonInfo(id);
            return number != 0;
        }


        public int Save()
        {
            int id = 0;
            switch (Mode)
            {

                case EnumMode.Add:
                     id = AddNewPerson();
                    if (id!=-1)
                    {

                        Mode = EnumMode.Update;
                        
                    }
                    break;
                case EnumMode.Update:
                    
                    id = UpdatePerson();
                    if (id!=-1)
                    {

                        Mode = EnumMode.Update;
                    }
                    break;
                   
            }

            return id;
        }


    }
}