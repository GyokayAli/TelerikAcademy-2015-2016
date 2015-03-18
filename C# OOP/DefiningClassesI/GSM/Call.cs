using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public class Call
    {
        private DateTime dateTime;
        private ContactInfo contact;
        private double duration;
        public Call(DateTime dateTime, ContactInfo contact, double duration)
            : base()
        {
            this.Date = dateTime;
            this.Contact = contact;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get
            {
                if (this.dateTime.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.dateTime;
            }
            private set
            {
                this.dateTime = value;
            }
        }

        public ContactInfo Contact
        {
            get
            {
                return this.contact;
            }
            private set
            {
                this.contact = value;
            }
        }

        public double Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return String.Format(@"[{0}, Duration: {1:F1}sec, {2}]",
                this.Contact, this.Duration, this.Date.ToString("dd/MM/yy - HH:mm:ss"));
        }
    }
}

