using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClocks
{
    class ClockData
    {
        private const int V = 5;

        public String BerlinClock(int hours, int minutes, int seconds)
        {
            return $"{GetSeconds(seconds)}{GetHours(hours).Trim()}{GetMinutes(minutes).Trim()}";
        }

        protected String GetSeconds(int seconds)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(seconds % 2 == 0 ? "Y" : "O");
            sb.Append("\n");
            return sb.ToString();

        }

        protected String GetHours(int hours)
        {
            int numberTopHourLamps = hours / V;
            int numberBottomHourLamps = hours % V;

            StringBuilder sb = new StringBuilder();
            sb.Append(GetLampRow(4, numberTopHourLamps,"R")).Append("\n")
                    .Append(GetLampRow(4, numberBottomHourLamps,"R")).Append("\n");

            return sb.ToString();
        }

        protected String GetMinutes(int minutes)
        {
            int numberTopMinutesLamps = minutes / V;
            int numberBottomMinutesLamps = minutes % V;

            StringBuilder sb = new StringBuilder();
            Enumerable.Range(1, 11).ToList().ForEach( i=>sb.Append(i <= numberTopMinutesLamps ? GetMinuteLampColour(i) : "O"));
            sb.Append("\n");

            sb.Append(GetLampRow(4, numberBottomMinutesLamps, "Y"));

            return sb.ToString();
        }

        private String GetLampRow(int totalNumberLamps, int numberLampsOn, String lampSymbol)
        {
            StringBuilder sb = new StringBuilder();
            Enumerable.Range(1, totalNumberLamps).ToList().ForEach(i => sb.Append(i <= numberLampsOn ? lampSymbol : "O"));
            return sb.ToString().Trim();

        }

        private String GetMinuteLampColour(int index)
        {
            return index % 3 == 0 ? "R" : "Y";
        }
    }
}
