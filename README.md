Meerkat Logging
===============

The [Meerkat.Logging](https://www.nuget.org/packages/Meerkat.Logging/) library is a simple logging framework for use internally withing the Meerkat libaries

The rationale is so we don't take a dependency on external logging framework such as Common.Logging, log4net etc and possible introduce dependency conflicts to a client project

[![NuGet](https://img.shields.io/nuget/v/Meerkat.Logging.svg)](https://www.nuget.org/packages/Meerkat.Logging/)
[![Build status](https://ci.appveyor.com/api/projects/status/7ycnghu7s0umys9e/branch/master?svg=true)](https://ci.appveyor.com/project/PaulHatcher/meerkat-logging/branch/master)

You can see the version history [here](RELEASE_NOTES.md).

## Build the project
* Windows: Run *build.cmd*

I have my tools in C:\Tools so I use *build.cmd Default tools=C:\Tools encoding=UTF-8*

## Library License

The library is available under the [MIT License](http://en.wikipedia.org/wiki/MIT_License), for more information see the [License file][1] in the GitHub repository.

 [1]: https://github.com/phatcher/Meerkat.Logging/blob/master/License.md
