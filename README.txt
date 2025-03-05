# LabTest - Educational Software Testing Project

This public repository is intended to help you learn and practice writing tests (Unit Tests and Integration Tests) in an ASP.NET Core Minimal API project.

## Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Git
- A code editor such as Visual Studio Code or Visual Studio 2022

## Installation

### 1. Clone the Repository

Open your terminal and execute the following commands:

```
   git clone https://github.com/username/LabTest.git
   cd LabTest
```
### 2. Restore Packages and Build the Project
Run the following commands from the repository's root:

```
dotnet restore
dotnet build
```
### 3. Run the Project
To run the project, execute:

```
dotnet run --project LabTest
```
After starting the application, a URL (for example, https://localhost:5001) will be displayed in the terminal. Open this URL in your browser to view the API.

## Running Tests
The project contains two sets of tests:

LabTest.Unit.Tests: Contains unit tests that verify the business logic separately.
LabTest.IntegrationTests: Contains integration tests that check the endpoints using an in-memory test server.
To run all tests, execute the following command from the repository's root:

```
dotnet test
```
This command will build the projects, run all tests, and display the results in the terminal.

## Project Structure
LabTest/: Contains the main API code.
LabTest.Unit.Tests/: Contains the unit tests.
LabTest.IntegrationTests/: Contains the integration tests.

## Contributing
If you have any ideas or improvements:

Open an Issue to discuss your idea.
Alternatively, you can submit a Pull Request with your changes.

## License
This project is licensed under the MIT License.
