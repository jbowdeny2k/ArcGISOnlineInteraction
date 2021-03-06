﻿using System.Runtime.Serialization;

namespace AGORestCallTestFS
{
  [DataContract]
  class Authentication
  {
    [DataMember]
    public string token { get; set; }

    [DataMember]
    public object expires { get; set; }

    [DataMember]
    public bool ssl { get; set; }
  }
}
