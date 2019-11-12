using FutCoach.Models;
using FutData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutCoach.Repositories
{
    public class NationRepository : INationRepository
    {
        private readonly FutcoachContext context;

        public NationRepository(FutcoachContext context)
        {
            this.context = context;
        }

        public List<NationViewModel> GetNations()
        {
            return context.Nations.Select(n => new NationViewModel
            {
                Id = n.NationId,
                Name = n.NationName
            }).ToList();
        }
    }
}
