using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTagger3.Core
{
    class Library
    {
        public string FullPath { get; set; }
        public string LibraryRootPath { get; set; }
        public Dictionary<string, Environment> Environments = new Dictionary<string, Environment>();
        public Dictionary<string, SoundGroup> GlobalSingleSounds = new Dictionary<string, SoundGroup>();
    }
}
