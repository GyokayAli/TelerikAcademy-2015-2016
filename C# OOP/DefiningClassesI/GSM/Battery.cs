namespace GSM
{
    using System;

    public class Battery
    {
        private BatteryType batteryType;
        private int mAh;
        private double idleHours;
        private double talkHours;
        private bool idleSet = false;
        private bool talkSet = false;

        public Battery(BatteryType batteryType, int mAh)
            : base()
        {
            this.BatteryType = batteryType;
            this.Mah = mAh;
        }

        public Battery(BatteryType batteryType, int mAh, double idleHours, double talkHours)
            : this(batteryType, mAh)
        {
            this.IdleHours = idleHours;
            this.TalkHours = talkHours;
            this.idleSet = true;
            this.talkSet = true;
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            private set
            {
                this.batteryType = value;
            }
        }

        public int Mah
        {
            get
            {
                return this.mAh;
            }
            private set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }

                this.mAh = value;
            }
        }

        public double IdleHours
        {
            get
            {
                if (!this.idleSet)
                {
                    throw new NullReferenceException();
                }

                return this.idleHours;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.idleHours = value;
            }
        }

        public double TalkHours
        {
            get
            {
                if (!this.talkSet)
                {
                    throw new NullReferenceException();
                }

                return this.talkHours;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.talkHours = value;
            }
        }

        public override string ToString()
        {
            return String.Format(@"
Battery: {0} {1} mAh
{2}
{3}
", this.BatteryType, this.Mah,
                this.talkSet ? String.Format("Talk time:  {0}h", this.TalkHours) : String.Empty,
                this.idleSet ? String.Format("Stand-by:   {0}h", this.IdleHours) : String.Empty).Trim();
        }
    }


    public enum BatteryType
    {
        Li_Ion,
        NiMH,
        NiCd
    }
}
