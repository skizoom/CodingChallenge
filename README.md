# Heidi Engineer Recruitment Task

Thank you for taking the time to do our technical task. It consists of two parts:

- [A coding task](#coding-scenario)
- [A few technical questions](#questions)

Please submit your code as a zip file sent back to us.

# Coding Scenario

Our tech at Heidi relies on many different supplier APIs and data feeds.

In this scenario you have inherited a .NET core API that returns hotel data from two downstream API endpoints.

Please complete the below refactoring task, using it as an example to demonstrate how you build modular, testable and well performing code when having to use unpredictable dependencies.

## Task

Your task is to refactor `HotelsController.cs` so that all hotels are returned from the `/api/hotels` endpoint instead of the two current endpoints.
The endpoint should return a list of hotels, including their name and star rating.

## Questions

Please answer the following questions in a markdown file called `Answers.md`.

1. How did you improve the quality of the existing code?
2. The downstream endpoints can be quite slow. How can we speed up our API?
   - Feel free to demonstrate an example in the code.
3. If you added any tests to the code, which approach did you use and why?
4. How would you add any new data sources to the `/api/hotels/` endpoint in the future?
5. Can your solution easily scale with new providers of hotel data being added?
6. If you have clients using the current version of the API, how would you approach this refactoring task?
7. If you had to host this API in a production environment, describe the steps you would take to do this.

## Running Instructions

The sample application uses the following frameworks:

1. .NET Core 9.0, which can be downloaded [here](https://dotnet.microsoft.com/en-us/download/dotnet/7.0).

The application can be run using the `dotnet run` command from the `./CodingChallenge/API` directory.

The application has a swagger openAPI endpoint at `/swagger/index.html` for testing the API, or you can use a tool like Postman.

#### Thanks for your time, we look forward to hearing from you!
