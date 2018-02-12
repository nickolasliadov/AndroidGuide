using System;
using System.Collections.Generic;
using System.Text;
using DroidVersionGuide.Entity;

namespace DroidVersionGuide.Service
{
    public interface IService
    {
        List<DroidVersion> GetVersionsAndroid();
    }
}
