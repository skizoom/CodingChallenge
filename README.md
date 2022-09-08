Heidi Full-stack Engineer Recruitment Task
==================================

Thank you for taking the time to do our technical task. It consists of two parts:

* [A coding task](#coding-scenario)
* [A few technical questions](#questions)


# Coding Scenario
Our tech at Heidi relies on many different supplier APIs and data feeds.

In this scenario you have inherited a .NET core API that returns hotel data from two downstream API endpoints.

Please complete the below task, using it as an example to demonstrate how you build applications using and improving on existing APIs.

## Task
Your taks is to build a basic web application that displays a list of hotels, including their name and star rating.

The ability to filter by star rating and resort code is required.

The existing API exposes two endpoints of hotel data from `HotelsController.cs`.

- Please refactor HotelsController.cs so that all hotels are returned from the /api/hotels endpoint instead of the two current endpoints. The endpoint should return a list of hotels, including their name and star rating.
- Create a front-end as a subdirectory of the solution, with a README explaining how to build and run it. Our current stack is React/NextJS based, but use anything you like for your submission. Let us know why you choose it.
- Perfect is the enemy of good. Don't worry too much about UX or making things pretty.

Please submit your code as a zip file.

## Questions

Please answer the following questions in a markdown file called `Answers.md`.

1. How long did you spend on the coding test? What would you add to your solution if you had more time? If you didn't spend much time on the coding test then use this as an opportunity to explain what you would add.
2. The downstream endpoints can be quite slow. How can we speed up our API? Feel free to demonstrate an example in the code.
3. How would you improve the API in this project? Did you use any [SOLID](https://en.wikipedia.org/wiki/SOLID) principles?.



## Running Instructions
The sample application uses the following frameworks:

1. .NET Core 6.0, which can be downloaded [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).

The application can be run using the `dotnet run` command from the `./CodingChallenge/` directory.

The application has a swagger openAPI endpoint at `/swagger/index.html` for testing the API, or you can use a tool like Postman.


#### Thanks for your time, we look forward to hearing from you!

