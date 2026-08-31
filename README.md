[![](https://img.shields.io/nuget/v/soenneker.monday.graphqlclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.monday.graphqlclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.monday.graphqlclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.monday.graphqlclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.monday.graphqlclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.monday.graphqlclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.monday.graphqlclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.monday.graphqlclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Monday.GraphQlClient

Typed queries, mutations, variables, and response models for Monday's GraphQL API.

## Installation

```bash
dotnet add package Soenneker.Monday.GraphQlClient
```

## Usage

Wrap an authenticated `HttpClient` with the included GraphQL transport, then pass that transport to the generated client:

```csharp
using Soenneker.Monday.GraphQlClient;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.monday.com/v2")
};
httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", apiKey);

var transport = new GraphQlHttpClient(httpClient);
var monday = new MondayGraphQlClient(transport);

var boards = await monday.GetBoards.GetValue(
    new GetBoardsVariables { Limit = 25 },
    cancellationToken);
```

`Execute(...)` returns the full GraphQL response envelope, including GraphQL errors. `GetValue(...)` returns only the operation's data field.

For configuration-based authentication and managed client reuse, use [`Soenneker.Monday.GraphQlClientUtil`](https://github.com/soenneker/soenneker.monday.graphqlclientutil).
