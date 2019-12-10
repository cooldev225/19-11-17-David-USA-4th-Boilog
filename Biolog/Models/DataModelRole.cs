using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Applies to PowerBIReports. A data model role used to control access to row-level data.
  /// </summary>
  [DataContract]
  public class DataModelRole {
    /// <summary>
    /// A unique UUID value that specifies the identifier of the data model role.
    /// </summary>
    /// <value>A unique UUID value that specifies the identifier of the data model role.</value>
    [DataMember(Name="ModelRoleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModelRoleId")]
    public Guid? ModelRoleId { get; set; }

    /// <summary>
    /// A string value that specifies the name for the data model role. This name will typically be displayed in the user interface.
    /// </summary>
    /// <value>A string value that specifies the name for the data model role. This name will typically be displayed in the user interface.</value>
    [DataMember(Name="ModelRoleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModelRoleName")]
    public string ModelRoleName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DataModelRole {\n");
      sb.Append("  ModelRoleId: ").Append(ModelRoleId).Append("\n");
      sb.Append("  ModelRoleName: ").Append(ModelRoleName).Append("\n");
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
