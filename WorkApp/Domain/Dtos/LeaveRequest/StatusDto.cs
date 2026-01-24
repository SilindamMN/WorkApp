namespace Domain.Dtos.LeaveRequest
{
  using Domain.Enums;
  using System.Text.Json.Serialization;

  public class StatusDto
  {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status status { get; set; }
  }
}