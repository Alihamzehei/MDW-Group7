﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MDW_GuessNumberGame
{
    [ServiceContract(Namespace = "MDW_GuessNumberGame")]
    class IPortal
    {
        public bool LogInPlayer(Player player);

        
    }
}