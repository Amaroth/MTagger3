using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTagger3.Core
{
    class SoundGroup
    {
        public string Name { get; set; }

        public int DefaultVolume { get; set; }
        public int Volume { get; set; }

        public PlayMode DefaultPlayMode { get; set; }
        public PlayMode PlayMode { get; set; }

        public Dictionary<string, SoundFile> SoundFiles = new Dictionary<string, SoundFile>();
    }
}
