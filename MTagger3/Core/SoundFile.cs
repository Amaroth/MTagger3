using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTagger3.Core
{
    class SoundFile
    {
        public string SubPath { get; set; }

        public string FullPath()
        {
            return SubPath;
        }

        public string Name()
        {
            var split = SubPath.Split('/');
            return split[split.Length - 1];
        }
    }
}
