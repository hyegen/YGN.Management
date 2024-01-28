﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Extensions
{
    public class Extensions
    {
        [ComplexType]
        public class Client_View
        {
            public int Id { get; set; }
            public string ClientCode { get; set; }
            public string ClientName { get; set; }
            public string ClientSurname { get; set; }
            public string Address { get; set; }
            public string TelNr1 { get; set; }
            public string TelNr2 { get; set; }
            public string FirmDescription { get; set; }
            public string TaxIdentificationNumber { get; set; }
        }
    }
}
