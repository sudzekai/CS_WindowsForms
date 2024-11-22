using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;

namespace CS_WindowsForms
{
    internal class User
    {
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string country { get; set; }
        public int age { get; set; }
        public Gender gender { get; set; }
        public List<string> about { get; set; }

    }

    public enum Gender
    {
        male,
        female,
    }
}
