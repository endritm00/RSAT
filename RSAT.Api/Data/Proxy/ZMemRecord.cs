using System;
using System.Collections.Generic;

namespace RSAT.Api.Data.Proxy
{
    public partial class ZMemRecord
    {
        public int Lsh { get; set; }
        public int? Uid { get; set; }
        public string Ucode { get; set; }
        public string Checktime { get; set; }
        public string Udept { get; set; }
        public string Uname { get; set; }
        public int? Utype { get; set; }
        public string Utypename { get; set; }
        public int? Sensorid { get; set; }
        public string Timename { get; set; }
        public string Disposeplan { get; set; }
        public string Errorshow { get; set; }
        public bool Checked { get; set; }
        public int? UattFlag { get; set; }
        public string UattFlagName { get; set; }
        public int? Uworktype { get; set; }
        public string Ulogid { get; set; }
    }
}
