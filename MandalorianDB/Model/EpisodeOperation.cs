using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandalorianDB.BusinessLayer;

namespace MandalorianDB.Model
{
    class EpisodeOperation
    {
        public enum OperationStatus { OKAY, CANCEL }
        public OperationStatus Status { get; set; }
        public Episode episode { get; set; }
    }
}
