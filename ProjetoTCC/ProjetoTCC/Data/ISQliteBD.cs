﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCC.Data
{
    public interface ISQliteBD
    {
        string SQLiteLocalPath(string bancoDados);
    }
}
