﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtbSomalia.Models
{
    public class DrugTransferDetails
    {
        public long Id { get; set; }
        public DrugTransfer drugTransfer { get; set; }

        public DrugBatches drugBatches { get; set; }

        public long Quantity { get; set; }

        public string Comments { get; set; }

    }
}