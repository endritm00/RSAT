using NovusConsulting.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSAT.Api.Data
{
    public class EtlLayer : NovusConsulting.Etl.SqlServer.EtlLayer
    {
        public EtlLayer(IDataLayer dataLayer) : base(dataLayer) { }
    }
}
