namespace Domain.Enums
{
  using System.Text.Json.Serialization;


  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum Status
  {
    Approved,
    Declined,
    Pending
  }
  }
