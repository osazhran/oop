
namespace C43_G05_OOP03.Part2
{
    internal class Duration
    {
        #region 1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion
        #region 2.Override All System. Object Members [To String(), Equals(),GetHashCode() ] .
        public override string ToString()
        {
            return $"Hours={Hours},Minutes={Minutes},Seconds={Seconds}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        #endregion
        #region 3-Define All Required Constructors to Produce this output:
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            Minutes = ((seconds % 3600) / 60);
            Seconds = ((seconds % 3600) % 60);

        }
        #endregion
        #region 4-Implement All required Operators overloading to enable this Code:
        //D3=D1+D2
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration((d1.Hours + d2.Hours), (d1.Minutes + d2.Minutes), (d1.Seconds + d2.Seconds));

        }
        //D3=D1+4850
        public static Duration operator +(Duration d1, int s)
        {
            return new Duration((d1.Hours + s / 3600), (d1.Minutes + (s % 3600) / 60), (d1.Seconds + (s % 3600) % 60));

        }

        //D3 = 666 + D3;
        public static Duration operator +(int s, Duration d3)
        {
            return new Duration((d3.Hours + s / 3600), (d3.Minutes + (s % 3600) / 60), (d3.Seconds + (s % 3600) % 60));

        }

        //D3= ++D1 (Increase One Minute)
        public static Duration operator ++(Duration du3)
        {
            if (du3.Minutes != 59)
            {
                return new Duration((du3.Hours), (du3.Minutes + 1), (du3.Seconds));
            }
            else
            {
                return new Duration((du3.Hours + 1), (0), (0));
            }

        }
        //D3 = --D2 (Decrease One Minute)
        public static Duration operator --(Duration du3)
        {
            if (du3.Minutes != 0)
            {
                return new Duration((du3.Hours), (du3.Minutes - 1), (du3.Seconds));
            }
            else
            {
                return new Duration((du3.Hours - 1), (59), (0));
            }

        }

        // D1 = D1 - D2;
        public static Duration operator -(Duration dur1, Duration dur2)
        {
            return new Duration((dur1.Hours - dur2.Hours), (dur1.Minutes - dur2.Minutes), (dur1.Seconds - dur2.Seconds));

        }

        //If (D1>D2)
        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) > (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);

        }
        //If (D1<D2)

        public static bool operator <(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) < (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);


        }
        //If (D1<=D2)
        public static bool operator <=(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) <= (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);


        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) >= (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);


        }
        //D1 is true

        public static implicit operator bool(Duration d)
        {
            return d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0;

        }
        // DateTime
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
        #endregion
    }


}
