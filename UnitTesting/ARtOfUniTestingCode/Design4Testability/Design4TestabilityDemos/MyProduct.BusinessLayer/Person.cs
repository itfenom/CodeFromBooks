using MyProduct.BusinessLayer.Interfaces;

namespace MyProduct.BusinessLayer
{
    public class Person
    {

        public Person()
        {
//            MyStaticHelper.LogPersonCreate(this);
        }

        private string ssid;

        public string SSID
        {
            get { return ssid; }
            set { ssid = value; }
        }


        private int creditOnFile;

        public int CreditOnFile
        {
            get { return creditOnFile; }
            set { creditOnFile = value; }
        }

        private ISubscriptionType subType;

        public ISubscriptionType SubscriptionType
        {
            get { return subType; }
            set { subType = value; }
        }


    }
}
