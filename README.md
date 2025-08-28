# GrandSumoMcp

A .NET 9 application for interacting with the [sumo-api.com](https://sumo-api.com) service, providing tools and services for sumo data retrieval and manipulation. Built with extensibility in mind, it leverages dependency injection and MCP server tooling.

## Features

- Retrieve rikishi (wrestler) information by English name
- Fetch rikishi details, stats, and match history
- Get basho (tournament) schedules
- Query kimarite (winning technique) details
- Extensible MCP server with stdio transport and custom tools

## Requirements

- .NET 9 SDK
- Visual Studio 2022 (recommended)
- Internet access for API calls

## Getting Started

1. **Clone the repository:**
   git clone https://github.com/yourusername/GrandSumoMcp.git cd GrandSumoMcp


2. **Restore dependencies:**
   dotnet restore

3. **Build the project:**
   dotnet build

## Configuration

### Claude Desktop Integration

To use this MCP server with Claude Desktop, add the following configuration to your Claude Desktop settings:

**Location of config file:**

- **macOS:** `~/Library/Application Support/Claude/claude_desktop_config.json`
- **Windows:** `%APPDATA%\Claude\claude_desktop_config.json`

**Configuration:**

```json
{
  "mcpServers": {
	"grand-sumo-api": {
        "command": "dotnet",
        "args": [
            "run",
            "--project",
            "/path/to/your/grand-sumo-mcp",
            "--no-build"
        ]
     }
  }
}
```

> **Important:** Replace `/path/to/your/grand-sumo-mcp` with the actual absolute path to your cloned repository.

## Contributing

1. Fork the repository
2. Create a feature branch: `git checkout -b feature-name`
3. Make your changes and add tests
4. Commit your changes: `git commit -am 'Add some feature'`
5. Push to the branch: `git push origin feature-name`
6. Submit a pull request
1. 
## License

See the [LICENSE](LICENSE) file for license rights and limitations.

## Support

For issues and questions:

- Open an issue on GitHub
- Check the [MCP documentation](https://spec.modelcontextprotocol.io/)
- Check the [sumo-api.com documentation](https://sumo-api.com/docs)
## Changelog

### [1.0.0-beta] - 08-27-2025

- Initial release
- Basic character and guild lookup functionality
- Integration with Claude Desktop

