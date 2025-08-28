using GrandSumoMcp.Service;
using ModelContextProtocol.Server;
using System.ComponentModel;

namespace GrandSumoMcp.McpTools
{
    [McpServerToolType]
    public class GrandSumo
    {
        private readonly SumoApiClient _sumoApiClient;

        public GrandSumo(SumoApiClient sumoApiClient)
        {
            _sumoApiClient = sumoApiClient;
        }

        [McpServerTool(Name = "GetRikishi"), Description("The a Rikishi by name to retrieve information for, including their id. E.g., 'Onosato'")]
        public async Task<object> GetRikishi(String name)
        {
            var result = await _sumoApiClient.GetRikishiByNameENAsync(name);
            return result;
        }

        [McpServerTool(Name = "GetRikishiDetails"), Description("Retrieves the details of the Rikishi. E.g., '8850'")]
        public async Task<object> GetRikishiDetails(int rikishiId)
        {
            var result = await _sumoApiClient.GetRikishiDetailsAsync(rikishiId);
            return result;
        }

        [McpServerTool(Name = "GetRikishiStats"), Description("Retrieves the stats of a Rikishi by id. E.g., '8850'")]
        public async Task<object> GetRikishiStats(int rikishiId)
        {
            var result = await _sumoApiClient.GetRikishiStatsAsync(rikishiId);
            return result;
        }
    }
}
