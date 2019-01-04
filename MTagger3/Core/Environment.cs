using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTagger3.Core
{
    class Environment
    {
        public string Name { get; set; }
        public Dictionary<string, SoundGroup> SingleSounds = new Dictionary<string, SoundGroup>();
        public Dictionary<string, SoundGroup> RepeatableSounds = new Dictionary<string, SoundGroup>();
        public Dictionary<string, Preset> Presets = new Dictionary<string, Preset>();
    }
}
