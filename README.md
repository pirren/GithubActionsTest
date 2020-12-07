<h1 align="center">GitHub Workflows</h1>
<h3 align="center"> Actions and Continuous Integration</h3>
  
```yml
name: Continous Integration

on:
  push:
    branches: [ master ]
  pull_request:
    branches: [ master ]

jobs:
  build:

    runs-on: ubuntu-latest

    steps:
    - uses: actions/checkout@v2
    - name: Setup .NET Core
      uses: actions/setup-dotnet@v1
      with:
        dotnet-version: '5.0'
    - name: Install dependencies
      run: dotnet restore
    - name: Build
      run: dotnet build --configuration Release --no-restore
    - name: Test
      run: dotnet test --no-restore --verbosity normal

```

test: 
```
docker-compose -f docker-compose.yml run --rm unittests
```
