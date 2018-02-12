using System;
using System.Collections.Generic;
using System.Text;
using DroidVersionGuide.Entity;

namespace DroidVersionGuide.Repository
{
    public interface IVersionRepository
    {
        List<DroidVersion> GetVersions();
    }
}
