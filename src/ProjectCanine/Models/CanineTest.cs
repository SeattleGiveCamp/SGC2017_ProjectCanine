using System;

namespace ProjectCanine
{
    public class CanineTest
    {
        public string Id { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        // unix timestamp representation
        public string TestVersion_DateTime { get; set; }
        public int LastEditedBy { get; set; }
        // unix timestamp representation
        public int LastEditedDate { get; set; }
    }
}
