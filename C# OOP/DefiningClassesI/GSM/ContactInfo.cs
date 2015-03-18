using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public class ContactInfo
    {
        private string name;
        private string phoneNum;

        public ContactInfo(string name, string phoneNumber)
            : base()
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }

        public string Name
        {
            get
            {
                if (this.name.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.name;
            }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("contact name");
                }

                this.name = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                if (this.phoneNum.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.phoneNum;
            }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("phone number");
                }

                this.phoneNum = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", this.Name, this.PhoneNumber);
        }
        


    }
}

