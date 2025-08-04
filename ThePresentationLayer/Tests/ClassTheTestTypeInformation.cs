using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;
using ThePusnissLayer.Applications;

namespace ThePusnissLayer.Tests
{
    public class ClassTheTestTypeInformation: TheApplicationTypeInformation
    {
        public string Description { get; set; }
        enum EnumMode { Add = 1, Update = 2 }
        EnumMode Mode = EnumMode.Add;
        public ClassTheTestTypeInformation()
        {
            Title = "";
            ID = 0;
            Fees = 0;
            Description = "";


        }
        public ClassTheTestTypeInformation(int ID, string Title,string Description, decimal Fees):base(ID,Title,Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
            this.Description = Description;
            Mode = EnumMode.Update;


        }



        public int UpdateTest()
        {

            ClassDataFromTheTestsType.UpdateTestInfo(ID, Title,Description, Fees);

            return ID;
        }
    }
}
