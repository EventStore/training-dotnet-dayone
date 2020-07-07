using System;
using System.Collections.Generic;
using System.Linq;
using Application.Domain.ReadModel;

namespace Application.Infrastructure.InMemory
{
    public class InMemoryAvailableSlotsRepository: IAvailableSlotsRepository
    {
        private List<AvailableSlot> _available = new List<AvailableSlot>();
        private List<AvailableSlot> _booked = new List<AvailableSlot>();
        public void Add(AvailableSlot slot)
        {
            _available.Add(slot);
        }

        public void MarkAsUnavailable(string slotId)
        {
            var slot = _available.First(s => s.ScheduledId == slotId);
            _available.Remove(slot);
            _booked.Add(slot);
        }

        public void MarkAsAvailable(string slotId)
        {
            var slot = _booked.First(s => s.ScheduledId == slotId);
            _booked.Remove(slot);
            _available.Add(slot);
        }

        public List<AvailableSlot> getSlotsAvailableOn(DateTime date)
        {
            return _available.Where(s => s.ScheduledStartTime.Date == date).ToList();
        }
    }
}