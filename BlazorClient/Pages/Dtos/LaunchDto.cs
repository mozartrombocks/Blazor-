using System.Text.Json.Serialization;

namespace BlazorAPIClient.Dtos
{
    public partial class LaunchDto
    {
	    [JsonPropertyName("id")]
	    public string Id { get; set; }

	    [JsonPropertyName("is_tentative")]
	    public bool IsTentative { get; set; }

	    [JsonPropertyName("launch_data_local")]
	    public System.DateTimeOffset LaunchDataLocal { get; set; }

	    [JsonPropertyName("mission_name")]
	    public string MissionName { get; set; }
    } 
}