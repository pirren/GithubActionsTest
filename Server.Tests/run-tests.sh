#!/bin/bash
set -eu -o pipefail

dotnet restore /v/Server.Tests/BlazorApp.Server.Tests.csproj
dotnet test /v/Server.Tests/BlazorApp.Server.Tests.csproj