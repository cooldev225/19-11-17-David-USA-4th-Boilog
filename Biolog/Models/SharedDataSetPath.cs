using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An object that defines a link to shared dataset object.
  /// </summary>
  [DataContract]
  public class SharedDataSetPath {
    /// <summary>
    /// A string value that specifies the name of the shared dataset.
    /// </summary>
    /// <value>A string value that specifies the name of the shared dataset.</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// A string value that specifies the path to the shared dataset.
    /// </summary>
    /// <value>A string value that specifies the path to the shared dataset.</value>
    [DataMember(Name="Path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Path")]
    public string Path { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SharedDataSetPath {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
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
