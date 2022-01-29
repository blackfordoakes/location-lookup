# Location Lookup

This .NET Core Web API shows how to implement an asynchronous workflow to geocode a given location using MassTransit.

## Description

There are three parts to this project:  a .NET Core Web API, a .NET Core worker, and a models project.

## Requirements

.NET Core
[Docker](https://www.docker.com/)
A PC*Miler Web Services API Key ([get one here](https://developer.trimblemaps.com/))

## Running the project

This solution relies on a RabbitMQ instance running inside a Docker container. To launch the container, navigate to the `deployment` directory and run the following command in a command prompt:

```powershell
docker compose up -d
```

Next, open the solution in Visual Studio and launch both the Location.API and Location.Worker projects.

When complete, run the following command in the `deployment` directory to stop the RabbitMQ container:

```powershell
docker compose down
```

## Contributing Guidelines

Thanks for taking the time to contribute! If you want it to do something different than it does, feel free to fork this repo. Just let people know you were inspired by me and we're all good. :)

## Issues

Ensure the bug was not already reported by searching on GitHub under issues. If you're unable to find an open issue addressing the bug, open a new issue.

Please pay attention to the following points while opening an issue.

### Write detailed information

Detailed information is very helpful to understand an issue.

For example:

* How to reproduce the issue, step-by-step.
* The expected behavior (or what is wrong).

## Pull Requests

Pull Requests are always welcome.

Ensure the PR description clearly describes the problem and solution. It should also include the relevant issue number (if applicable).

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

MIT © [blackfordoakes]()