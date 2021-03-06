using System;
using Application.EventSourcing;

namespace Application.Domain.WriteModel.Events
{
    public class Cancelled : Event
    {
        public string SlotId { get; }

        public string Reason { get; }

        public Cancelled(string slotId, string reason)
        {
            SlotId = slotId;
            Reason = reason;
        }

        protected bool Equals(Cancelled other)
        {
            return SlotId.Equals(other.SlotId) && Reason == other.Reason;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Cancelled) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SlotId, Reason);
        }
    }
}
