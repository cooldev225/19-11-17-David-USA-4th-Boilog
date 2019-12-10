using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Applies to PowerBIReports. Ignored when used with DataSets, LinkedReports, and Reports.
  /// </summary>
  [DataContract]
  public class DataModelDataSource {
    /// <summary>
    /// Gets or Sets AuthType
    /// </summary>
    [DataMember(Name="AuthType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthType")]
    public DataModelDataSourceAuthType AuthType { get; set; }

    /// <summary>
    /// Gets or Sets SupportedAuthTypes
    /// </summary>
    [DataMember(Name="SupportedAuthTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportedAuthTypes")]
    public List<DataModelDataSourceAuthType> SupportedAuthTypes { get; set; }

    /// <summary>
    /// Gets or Sets Kind
    /// </summary>
    [DataMember(Name="Kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Kind")]
    public DataModelDataSourceKind Kind { get; set; }

    /// <summary>
    /// The name of the model connection.
    /// </summary>
    /// <value>The name of the model connection.</value>
    [DataMember(Name="ModelConnectionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModelConnectionName")]
    public string ModelConnectionName { get; set; }

    /// <summary>
    /// The value of the credential secret.
    /// </summary>
    /// <value>The value of the credential secret.</value>
    [DataMember(Name="Secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Secret")]
    public string Secret { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public DataModelDataSourceType Type { get; set; }

    /// <summary>
    /// The name of the parameter.
    /// </summary>
    /// <value>The name of the parameter.</value>
    [DataMember(Name="Username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DataModelDataSource {\n");
      sb.Append("  AuthType: ").Append(AuthType).Append("\n");
      sb.Append("  SupportedAuthTypes: ").Append(SupportedAuthTypes).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  ModelConnectionName: ").Append(ModelConnectionName).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
