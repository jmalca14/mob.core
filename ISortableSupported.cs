﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mob.Core
{
    public interface ISortableSupported
    {
        int DisplayOrder { get; set; }
    }

}
