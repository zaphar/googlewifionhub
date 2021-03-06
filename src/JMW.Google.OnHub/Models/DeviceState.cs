﻿using System.Collections.Generic;

namespace JMW.Google.OnHub.Models
{
    public class DeviceState
    {
        public List<Arp> ArpCache { get; set; }
        public List<Mac> CamTable { get; set; }
        public List<Interface> Interfaces { get; set; }
        public string StateSeqNo { get; set; }
        public string Version { get; set; }
        public string TimeStampSeconds { get; set; }
        public InfraState InfraState { get; set; }
        public NetworkServiceState NetworkServiceState { get; set; }
    }
}