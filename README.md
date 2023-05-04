## Pre-Requisites

- Dotnet SDK Version 7
  - Note: due to version 3.1 support ending years ago, we are using an up to date version
- NodeJS
- (Recommend)Visual Studio Code

## Setup

- Open the first command prompt in directory you want to download this project and execute the following commands(assuming windows):

```
git clone https://github.com/jamespagedev/WMI-React-App.git
git checkout solution
cd WMI-React-App
```

- create a .env file in the base project directory with the following contents:

```
REACT_APP_DEV_API=http://localhost:5163/api
REACT_APP_TEST_API=http://localhost:5163/api
REACT_APP_PROD_API=http://localhost:5163/api
```

- Open a 2nd command prompt and execute the commands in order:

```
cd backend/API
dotnet restore
dotnet ef database update
dotnet run
```

- Back in the first command prompt, ensure you are in the project base directory and execute the commands in the following order:

```
npm install
npm start
```

### (Optional)`npm test`

Runs a set of basic tests for the app.

## Tasks (MVP Complete)

- [x] Move `honda_wmi.json` file's content to a backend API written in C# & ASP.NET Core 3.1
  - Data must be retrieved from the API and rendered instead of from the local browser
  - A spinner or a `Loading...` text must appear while the request is in flight
- [x] Style `table` element that displays WMI table
- [x] Render data sorted by `CreatedOn` and then by `WMI`
- [x] Introduce a search box to accept user input, filter and render data
- [x] Introduce a `Select` control to group by country
  - By default `View All` option must be selected, rendering all records
  - Distinct countries must be available for user selection
  - On selecting a country, data must be filtered down to just the country
  - Search and Country selection must work together
