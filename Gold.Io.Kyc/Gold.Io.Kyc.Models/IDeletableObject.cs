using System;
using System.Collections.Generic;
using System.Text;

namespace Gold.IO.Kyc.Models
{
    public interface IDeletableObject
    {
        bool Deleted { get; set; }
    }
}
