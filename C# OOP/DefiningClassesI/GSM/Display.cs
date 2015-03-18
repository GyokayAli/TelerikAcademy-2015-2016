namespace GSM
{
    using System;

    public class Display
    {
        private DisplayType displayType;
        private double size;
        private int colors;
        private bool colorsSet = false;

        public Display(DisplayType displayType, double inches)
            : base()
        {
            this.DisplayType = displayType;
            this.Size = inches;
        }

        public Display(DisplayType displayType, double inches, int colors)
            : this(displayType, inches)
        {
            this.Colors = colors;
            this.colorsSet = true;
        }

        public DisplayType DisplayType
        {
            get
            {
                return this.displayType;
            }
            private set
            {
                this.displayType = value;
            }
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }

                this.size = value;
            }
        }

        public int Colors
        {
            get
            {
                if (!this.colorsSet)
                {
                    throw new NullReferenceException();
                }

                return this.colors;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.colors = value;
            }
        }

        public override string ToString()
        {
            return String.Format(@"
Display: {0}, {1} inches
{2}", 
    this.DisplayType, this.Size,
    this.colorsSet ? String.Format("Colors: {0}", this.Colors) : String.Empty).Trim();
        }
    }


    public enum DisplayType
    {
        TFT,
        IPS_LCD,
        HD_Super_AMOLED,
        Super_LCD2,
        TrueHD_IPS_Plus_LCD,
        Other
    }
}
