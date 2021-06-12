using System.Threading.Tasks;
using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.Pages
{
	public class NewBaseType
	{
		private LaunchDto[] launches; 

		protected override async Task OnInitializedAsynce()
		{
			launches = await Http.GetFromJsonAsync<LaunchDto[]>("https://api.spacex.land/rest/launches")
		}