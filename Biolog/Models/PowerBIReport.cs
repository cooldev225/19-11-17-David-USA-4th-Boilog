using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PowerBIReport : CatalogItem {
    /// <summary>
    /// A boolean value that indicates whether the PowerBIReport has DataSources.
    /// </summary>
    /// <value>A boolean value that indicates whether the PowerBIReport has DataSources.</value>
    [DataMember(Name="HasDataSources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasDataSources")]
    public bool? HasDataSources { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PowerBIReport {\n");
      sb.Append("  HasDataSources: ").Append(HasDataSources).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
