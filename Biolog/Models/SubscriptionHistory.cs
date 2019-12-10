using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An object that defines a subscription history or execution record.
  /// </summary>
  [DataContract]
  public class SubscriptionHistory {
    /// <summary>
    /// A unique identifier by which this Subscription History record can be referenced in requests or in other defined objects.
    /// </summary>
    /// <value>A unique identifier by which this Subscription History record can be referenced in requests or in other defined objects.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// A unique UUID value that identifies the Subscription that this record is associated with.
    /// </summary>
    /// <value>A unique UUID value that identifies the Subscription that this record is associated with.</value>
    [DataMember(Name="SubscriptionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionID")]
    public Guid? SubscriptionID { get; set; }

    /// <summary>
    /// A string value that specifies the type of subscription execution.
    /// </summary>
    /// <value>A string value that specifies the type of subscription execution.</value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }

    /// <summary>
    /// A string that contains the date-time for when the subscription execution started.
    /// </summary>
    /// <value>A string that contains the date-time for when the subscription execution started.</value>
    [DataMember(Name="StartTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartTime")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// A string that contains the date-time for when the subscription execution ended.
    /// </summary>
    /// <value>A string that contains the date-time for when the subscription execution ended.</value>
    [DataMember(Name="EndTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndTime")]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// A string value that represents the status of the subscription execution.
    /// </summary>
    /// <value>A string value that represents the status of the subscription execution.</value>
    [DataMember(Name="SubscriptionStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionStatus")]
    public string SubscriptionStatus { get; set; }

    /// <summary>
    /// A string value that contains message that describes the status of the subscription execution.
    /// </summary>
    /// <value>A string value that contains message that describes the status of the subscription execution.</value>
    [DataMember(Name="Message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Message")]
    public string Message { get; set; }

    /// <summary>
    /// A JSON string value that contains the session information and error details when a subscription execution fails.
    /// </summary>
    /// <value>A JSON string value that contains the session information and error details when a subscription execution fails.</value>
    [DataMember(Name="Details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Details")]
    public string Details { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionHistory {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  SubscriptionID: ").Append(SubscriptionID).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
      sb.Append("  SubscriptionStatus: ").Append(SubscriptionStatus).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
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
