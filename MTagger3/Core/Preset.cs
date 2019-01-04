using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTagger3.Core
{
    class Preset
    {
        public string Name { get; set; }
        public Dictionary<string, Tuple<SoundGroup, int, PlayMode>> SoundGroups = new Dictionary<string, Tuple<SoundGroup, int, PlayMode>>();
    }
}
