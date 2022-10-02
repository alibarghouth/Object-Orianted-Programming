using Acme.Common;
using System.Xml.Linq;

namespace ACMBL
{
    public  class Customer : EntityBase,ILoggable
    {
        public Customer(int CustomerId)
        {
            this.CustomerId = CustomerId;
            AddressList = new List<Address>();
        }
        //وضعنا ال (this(0)) 
        //يعتبر ال customerid = 0 auto 
        //عشان لما نستدعي الكونستركر الافتراضي ما يعطي اكسبشن لنو ما عملنا انيشييلايز للأري
        public Customer():this(0)
        {

        }
        //public Address HomeAddress { get; set; }
        //public Address WorkAddress { get; set; }
        //OR
        //علاقة بين العميل و العنوان
        public List<Address> AddressList { get; set; }
        //Type Of Customer In Inheritance
        public string CustomerType { get; set; }
        public int CustomerId { get; private set; }

        public string EmailAddress { get; set; }

        //public string Log()
        //{
        //    var LogString = CustomerId + ":" +
        //                    FullName + " " +
        //                    "Email" + ":" + EmailAddress +
        //                    "Status" + ":" + EntityState.ToString();
        //    return LogString;
        //}

        public string Log() => $"{CustomerId} : {FullName}  Email : {EmailAddress}  status : {EntityState.ToString()}";


        public override string ToString() => FullName;

        public string? FullName {

            get {
                string FullName = LastName;
                if (!String.IsNullOrWhiteSpace(FullName))
                {
                    FullName += " ";
                    if (!String.IsNullOrWhiteSpace(FirstName))
                    {
                        FullName+=FirstName;
                    }
                }
               
                return FullName;
            
            }
        
        }

        public string FirstName { get; set; }

        private string _LastName;

        public string LastName { 
            get { return _LastName!; } 
            set { _LastName = value!; } 
        }

        public static int InstancCount { get; set; }



        //validation
        public override bool Validatin()
        {
            bool isValid = true;
            if(String.IsNullOrWhiteSpace(LastName)) isValid = false;    
            if(String.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }


    }
}