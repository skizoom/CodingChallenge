Heidi Engineer Recruitment Task
==================================

Thank you for taking the time to do our technical task. It consists of two parts:

* [A coding task](#coding-scenario)
* [A few technical questions](#questions)

Please submit your code as a pull request containing your changes on this repository, or a forked version of this repository if you would prefer.

# Coding Scenario
Our tech at Heidi relies on many different supplier APIs and data feeds.

In this scenario you have inherited a .NET core API that returns hotel data from two downstream API endpoints.

Please complete the below refactoring task, using it as an example to demonstrate how you build modular, testable and well performing code when having to use unpredictable dependencies.

## Task

Your task is to refactor `HotelsController.cs` so that all hotels are returned from the `/api/hotels` endpoint instead of the two current endpoints.
The endpoint should return a list of hotels, including their name and star rating.
## Questions

Please answer the following questions in a markdown file called `Answers.md`.

1. How did you make the code more modular and testable? 
    - did you use any [SOLID](https://en.wikipedia.org/wiki/SOLID) design principles? if so, which ones?
2. The downstream endpoints can be quite slow. How can we speed up our API? 
    - Feel free to demonstrate an example in the code.
3. If you added any tests to the code, which approach did you use and why?
4. How would you add any new data sources to the `/api/hotels/` endpoint in the future?


## Running Instructions
The sample application uses the following frameworks:

1. .NET Core 6.0, which can be downloaded [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).

The application can be run using the `dotnet run` command from the `./CodingChallenge/` directory.

The application has a swagger openAPI endpoint at `/swagger/index.html` for testing the API, or you can use a tool like Postman.


#### Thanks for your time, we look forward to hearing from you!

