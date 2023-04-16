using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_ALFRED_W
{
    public class Time
    {
        public string time { get; set; }
        public List<Button> seats;

        public Time(string time)
        {
            this.time = time;
            this.seats = new List<Button>();
        }
    }
}
