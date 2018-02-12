using System;
using Prism.Ioc;
using System.Text;
using Xamarin.Forms;
using DroidVersionGuide.Entity;
using System.Collections.Generic;
using DroidVersionGuide.Repository;

namespace DroidVersionGuide.Service
{
    public class Service : IService
    {
        private readonly List<DroidVersion> _versions;

        public Service(IVersionRepository repository)
        {
            _versions = repository.GetVersions();
        }

        public List<DroidVersion> GetVersionsAndroid()
        {
            return _versions;
        }
    }
}
