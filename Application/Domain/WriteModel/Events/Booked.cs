using System;
using Application.EventSourcing;

namespace Application.Domain.WriteModel.Events
{

}

/*
protected bool Equals(Booked other)
{
    return SlotId.Equals(other.SlotId) && SlotId.Equals(other.SlotId) && PatientId == other.PatientId;
}

public override bool Equals(object obj)
{
    if (ReferenceEquals(null, obj)) return false;
    if (ReferenceEquals(this, obj)) return true;
    if (obj.GetType() != this.GetType()) return false;
    return Equals((Booked) obj);
}

public override int GetHashCode()
{
    return HashCode.Combine(SlotId, PatientId);
}
 */
