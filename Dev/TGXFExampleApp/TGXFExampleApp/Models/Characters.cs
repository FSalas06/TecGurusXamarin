using System;
using System.Collections.Generic;

namespace TGXFExampleApp.Models
{
    public class Characters
    {
        public List<Character> amiibo { get; set; }
    }

    public class Character
    {
        public string key { get; set; }
        public string name { get; set; }
    }
}
