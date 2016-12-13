using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrumMashine
{
    public class ChoiceElement
    {
        public bool Choised { get; set; }
        public int Tag { get; set; }
        public ChoiceElement(int tag)
        {
            this.Choised = false;
            this.Tag = tag;
        }
    }
}
