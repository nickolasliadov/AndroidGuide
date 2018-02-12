
using Xamarin.Forms;

namespace DroidVersionGuide.Entity
{
    public class DroidVersion
    {
        public string CodeName { get; set; }
        public ImageSource ImagePath { get; set; }
        public string Description { get; set; }

        public DroidVersion(string codeName, string description)
        {
            CodeName = codeName;
            Description = description;
        }
    }
}
