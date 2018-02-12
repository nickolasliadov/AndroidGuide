using System;
using Newtonsoft.Json;
using DroidVersionGuide.Entity;
using System.Collections.Generic;

namespace DroidVersionGuide.Repository
{
    public class DroidVersionRepository : IVersionRepository
    {
        //public string Versions { get { return _versions; } }

        private readonly Dictionary<string, string> _versionsDict;

        public DroidVersionRepository(string json)
        {
            try
            {
                _versionsDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<DroidVersion> GetVersions()
        {
            var versionList = new List<DroidVersion>();

            foreach (var vers in _versionsDict)
            {
                versionList.Add (new DroidVersion(vers.Key, vers.Value));
            }
            return versionList;
        }
    }
}
