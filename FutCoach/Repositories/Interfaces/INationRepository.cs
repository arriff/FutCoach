using System.Collections.Generic;
using FutCoach.Models;

namespace FutCoach.Repositories
{
    public interface INationRepository
    {
        List<NationViewModel> GetNations();
    }
}