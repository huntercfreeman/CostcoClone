using CostcoClone.Interfaces.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostcoClone.Repository
{
    public class GiftCardsTicketsRepository : IGiftCardsTicketsRepository
    {
        private List<IGiftCardsTickets> _giftCardsTickets = new List<IGiftCardsTickets>();
        public void AddGiftCardsTickets(IGiftCardsTickets giftCardsTickets)
        {
            _giftCardsTickets.Add(giftCardsTickets);
        }
    }
}
