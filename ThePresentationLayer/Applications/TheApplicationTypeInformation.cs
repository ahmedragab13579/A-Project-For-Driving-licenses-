using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;

namespace ThePusnissLayer.Applications
{
    public class TheApplicationTypeInformation
    {
        enum EnumMode { Add = 1, Update = 2 }
        EnumMode Mode = EnumMode.Add;
        public string Title { get; set; }
        public int ID { get; set; }
        public decimal Fees { get; set; }






        public TheApplicationTypeInformation()
        {
            Title = "";
            ID = 0;
            Fees = 0;

           

        }
        public TheApplicationTypeInformation(int ID,string Title, decimal Feed)
        {
             this.ID = ID;
            this.Title = Title;
            Fees = Feed;
            Mode = EnumMode.Update;


        }



        public int UpdateApplication()
        {

           ClassDataFromApplicationTypes.UpdateApplicationInfo(ID,Title,Fees);

            return ID;
        }



    }
}
