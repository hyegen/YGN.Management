using System;
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
        public class YGN_CLIENTCODECREATOR_VIEW
        {
            [DataMember]
            public string NEWCLIENTCODE { get; set; }
        }
    }
}
