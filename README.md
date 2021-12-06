# TakeChallenge

## Description
TakeChallenge is an API that integrates with the [public Github API](https://docs.github.com/en/rest) and returns the 5 oldest C# repositories from [Take](https://github.com/takenet) to be used by a chatbot.

## Running
This project was developed using [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0) with [Octokit](https://github.com/octokit/octokit.net). Install [.net](https://dotnet.microsoft.com/download) if you don't have it, after that execute the following commands:

```bash
git clone https://github.com/MateusFerreiraSilva/TakeChallenge.git
cd TakeChallenge/Api
dotnet run
```

After that, you will be able to access [swagger](https://swagger.io/) on [http://localhost:5233](http://localhost:5233)

![alt text](https://github.com/MateusFerreiraSilva/TakeChallenge/blob/master/image.png?raw=true)

## License
[MIT](https://github.com/MateusFerreiraSilva/TakeChallenge/blob/master/LICENSE)
