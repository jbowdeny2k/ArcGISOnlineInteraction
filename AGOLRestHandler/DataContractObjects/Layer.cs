﻿using System.Runtime.Serialization;

namespace AGOLRestHandler
{
  [DataContract]
  public class Layer
  {
    [DataMember]
    public double currentVersion { get; set; }

    [DataMember]
    public int id { get; set; }

    [DataMember]
    public string name { get; set; }

    [DataMember]
    public string type { get; set; }

    [DataMember]
    public string displayField { get; set; }

    [DataMember]
    public string description { get; set; }

    [DataMember]
    public string copyRightText { get; set; }

    [DataMember]
    public bool defaultVisibility { get; set; }

    [DataMember]
    public object[] relationships { get; set; }

    [DataMember]
    public bool isDataVersioned { get; set; }

    [DataMember]
    public bool supportsRollbackOnFailureParameter { get; set; }

    [DataMember]
    public bool supportsAdvancedQueries { get; set; }

    [DataMember]
    public string geometryType { get; set; }

    [DataMember]
    public int minScale { get; set; }

    [DataMember]
    public int maxScale { get; set; }

    [DataMember]
    public Extent extent { get; set; }

    [DataMember]
    public DrawingInfo drawingInfo { get; set; }

    [DataMember]
    public bool allowGeometryUpdates { get; set; }

    [DataMember]
    public bool hasAttachments { get; set; }

    [DataMember]
    public string htmlPopupType { get; set; }

    [DataMember]
    public bool hasM { get; set; }

    [DataMember]
    public bool hasZ { get; set; }

    [DataMember]
    public string objectIDField { get; set; }

    [DataMember]
    public string globalIDField { get; set; }

    [DataMember]
    public string typeIdField { get; set; }

    [DataMember]
    public object[] fields { get; set; }

    [DataMember]
    public object[] types { get; set; }

    [DataMember]
    public Template[] templates { get; set; }

    [DataMember]
    public string supportedQueryFormats { get; set; }

    [DataMember]
    public bool hasStaticData { get; set; }

    [DataMember]
    public int maxRecordCount { get; set; }

    [DataMember]
    public string capabilities { get; set; }

    [DataMember]
    public int parentLayerId { get; set; }

    [DataMember]
    public object[] subLayerIds { get; set; }

    [DataMember]
    public AdminLayerInfo adminLayerInfo { get; set; }

    [DataMember]
    public string supportedFormats { get; set; }
  }
}
