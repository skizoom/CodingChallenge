Ski Zoom Engineer Recruitment Task
==================================

Thank you for taking the time to do our technical task. It consists of two parts:

* [A coding challenge](#coding-test)
* [A few technical questions](#technical-questions)

Please submit your code by emailing a .zip file to your technical contact at Ski Zoom.

Please make sure it contains the following:

1. a single markdown file with the answers to the technical questions
2. one folder containing the technical challenge code

## Coding Scenario

In our task scenario, one of our accommodation suppliers has finally given us access to their hotel API, so that we can list the details of their properties.

We'd like you to build a small web application that satisfies the requirements in the below [user-stories](#user-stories).

The API has a single endpoint [https://skizoominterviewchallenge.azurewebsites.net/api/hotels](https://skizoominterviewchallenge.azurewebsites.net/api/hotels) that requires a `x-functions-key` header as authentication. You will be provided with an authentication key by your contact at Ski Zoom.


The API returns a list of hotel information, including country, resort code and star rating.

The task is to create an application that displays the hotels available in the API, and allows them to be quickly filtered by:

- Country
- Star Rating

### Platform Choice

Our tech stack at ski-zoom is currently a mix of PHP, .NET Core and JavaScript (some jQuery and new React apps).

It would be great to see submissions using our tech stack, but we'd also love to be shown anything new as long as you're happy to provide the reasons that you chose it.

Think about the type of work you would like to do at Ski Zoom and **choose an appropriate application type and platform**.

### Task requirements

Feel free to spend as much or as little time on the exercise as you like as long as the following requirements have been met.  

- Please complete the user story below.
- Your code should compile and run in one step.
- Feel free to use whatever frameworks / libraries / packages you like.
- If you have experience with unit testing, it would be great to see examples of this, as it provides more to talk about and helps us see your style of coding.

### User Stories

As a **user running the application**  
I can **view a list of hotels in a chosen country**  
So that **I know which hotels are available in the country I want to visit**

As a **user running the application**  
I can **view a list of hotels in a chosen country with a particular star rating**  
So that **I know what quality of hotel is available in my chosen country**

#### Acceptance criteria

- 5 star rated hotels in France can be viewed
- The name, star-rating and image of a hotel can be viewed.

# Technical questions

Please answer the following questions in a markdown file called `Answers to technical questions.md`.

1. How long did you spend on the coding test? What would you add to your solution if you had more time? If you didn't spend much time on the coding test then use this as an opportunity to explain what you would add.
2. How would you track down a performance issue in production? Have you ever had to do this?
3. How would you improve the API you had to use?


#### Thanks for your time, we look forward to hearing from you!