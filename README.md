# .NETCore_ChuckleAPI

This was a .NET Core example project with unit test originally created for full stack friday.  The API is built to serve jokes.  The currently implemented routing structure is listed in the table below.

| Endpoint | Request Type | Description |
|----------|:-------------:|-------------|
| /jokes/ | GET | Returns all available jokes from the API |
| /jokes/{id} | GET | Returns a specific joke by ID |
| /jokes/random | GET | Returns a random joke from the collection |


### Future additions might include:


- Adding a database connection
- Adding more request types such as POST and PUT for input of data
- Adding security access to the api end points
