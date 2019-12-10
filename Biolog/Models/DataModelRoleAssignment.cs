using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Applies to PowerBIReports. Assignment of data model roles to a user or group.
  /// </summary>
  [DataContract]
  public class DataModelRoleAssignment {
    /// <summary>
    /// A string value that specifies the name of the user or group to which the role assignment applies.
    /// </summary>
    /// <value>A string value that specifies the name of the user or group to which the role assignment applies.</value>
    [DataMember(Name="GroupUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupUserName")]
    public string GroupUserName { get; set; }

    /// <summary>
    /// An array of unique UUID values that specify the identifiers of assigned data model roles.
    /// </summary>
    /// <value>An array of unique UUID values that specify the identifiers of assigned data model roles.</value>
    [DataMember(Name="DataModelRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DataModelRoles")]
    public List<Guid?> DataModelRoles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DataModelRoleAssignment {\n");
      sb.Append("  GroupUserName: ").Append(GroupUserName).Append("\n");
      sb.Append("  DataModelRoles: ").Append(DataModelRoles).Append("\n");
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
