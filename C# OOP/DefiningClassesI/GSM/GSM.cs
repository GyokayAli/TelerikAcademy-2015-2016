namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSM
    {
        private static readonly GSM LG = new GSM(Manufacturer.LG, "G3", 400.00m, "Mike",
            new Battery(BatteryType.Li_Ion, 2700, 40, 15), new Display(DisplayType.TrueHD_IPS_Plus_LCD, 5.5, 3), OS.ANDROID);

        private string owner;
        private decimal price;
        private string model;
        private Manufacturer manufacturer;
        private Display display;
        private Battery battery;
        private OS os;
        private List<Call> calls = new List<Call>();

        public GSM(Manufacturer manufacturer, string model, decimal price)
            : base()
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
        }

        public GSM(Manufacturer manufacturer, string model, decimal price, string owner, Battery battery, Display display, OS os)
            : this(manufacturer, model, price)
        {
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.OS = os;
        }

        public Manufacturer Manufacturer
        {
            get
            {
                if (this.manufacturer.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner cannot be null or empty.");
                }

                this.owner = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be less than 0.00");
                }

                this.price = value;
            }
        }

        public string Model
        {
            get
            {
                if (String.IsNullOrEmpty(this.model))
                {
                    throw new NullReferenceException();
                }

                return this.model;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }

                this.model = value;
            }
        }

        public Display Display
        {
            get
            {
                if (this.display.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.display;
            }
            private set
            {
                this.display = value;

            }
        }

        public Battery Battery
        {
            get
            {
                if (this.battery.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.battery;
            }
            private set
            {
                this.battery = value;

            }
        }

        public OS OS
        {
            get
            {
                if (this.os.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.os;
            }
            private set
            {
                this.os = value;
            }
        }

        public static GSM LG_G3
        {
            get
            {
                return LG;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.calls);
            }
        }

        public void AddCall(Call call)
        {
            this.calls.Add(call);
        }

        public void DeleteCall(int position)
        {
            if ((this.CallHistory.Count <= position - 1) || (position - 1 < 0))
            {
                throw new ArgumentException("Call history log does not exists.");
            }

            this.CallHistory.RemoveAt(position - 1);
        }

        public void DisplayCallHistory()
        {
            var result = new StringBuilder();
            result.AppendLine("\nCurrent call history:");
            int index = 1;
            foreach (var call in this.CallHistory)
            {
                result.Append(index++);
                result.Append(" ---> ");
                result.Append(call);
                result.AppendLine();
            }

            Console.WriteLine(result);
        }

        public void ClearCallHistory(Call call)
        {
            this.calls.Clear();
        }

        public decimal CalculateCallPrice(decimal pricePerMin)
        {
            decimal callSeconds = (decimal)(this.calls.Select(x => x.Duration).Sum()); //calc total call seconds
            return pricePerMin * (callSeconds / 60.0m);  //call seconds converted to minutes and return the total price
        }

        public override string ToString()
        {
            return String.Format(@"
Phone: {0} {1}, Costs: £{2}, Owned by: {3}
OS: {4} 
{5} 
{6}", this.Manufacturer, this.Model, this.Price, this.Owner, this.OS, this.Battery.ToString(), this.Display.ToString());
        }

    }

    public enum Manufacturer
    {
        APPLE,
        MOTOROLA,
        SAMSUNG,
        LG,
        NOKIA,
        SONY,
        ASUS,
        ACER,
        HTC,
        MICROSOFT,
        Other
    }

    public enum OS
    {
        IOS,
        WINDOWS,
        ANDROID,
        Other
    }
}

