﻿using System.Runtime.Serialization;

namespace AGORestCallTestFS
{
  [DataContract]
  public class FieldString
  {
    [DataMember]
    public string name { get; set; }

    [DataMember]
    public string type { get; set; }

    [DataMember]
    public string alias { get; set; }

    [DataMember]
    public string sqlType { get; set; }

    [DataMember]
    public int length { get; set; }

    [DataMember]
    public bool nullable { get; set; }

    [DataMember]
    public bool editable { get; set; }

    [DataMember]
    public object domain { get; set; }

    [DataMember]
    public object defaultValue { get; set; }
  }
}
