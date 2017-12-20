# TestAuth01

### Create a appsettings.json file like this:
```JSON
{
  "Logging": {
    "IncludeScopes": false,
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "MongoDB": {
    "ConnectionString": "mongodb://<username>:<password>@<mongoDBurl>",
    "DatabaseName": "<databaseName>"
  },
  "Authentication": {
    "Facebook": {
      "AppId": "",
      "AppSecret": ""
    }
  }
}
```
