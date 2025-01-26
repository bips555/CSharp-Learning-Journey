using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Ticket:IEquatable<Ticket>
    {
        public int DurationHours { get; set; }

        public Ticket(int durationHours) 
        {
        this.DurationHours = durationHours;
        }
        public bool Equals(Ticket other)
        {
            return this.DurationHours == other.DurationHours;
        }
        public void UpdateTicket(int durationHours)
        {
            this.DurationHours = durationHours;
        }

    }
}
