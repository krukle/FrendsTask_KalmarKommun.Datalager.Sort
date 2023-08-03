# FrendsTask_KalmarKommun.Datalager.Sort

frends Community Task for Sort

[![Actions Status](https://github.com/krukle/FrendsTask_KalmarKommun.Datalager.Sort/workflows/PackAndPushAfterMerge/badge.svg)](https://github.com/krukle/FrendsTask_KalmarKommun.Datalager.Sort/actions) ![MyGet](https://img.shields.io/myget/frends-community/v/FrendsTask_KalmarKommun.Datalager.Sort) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) 

- [Installing](#installing)
- [Tasks](#tasks)
     - [Sort](#Sort)
- [Building](#building)
- [Contributing](#contributing)
- [Change Log](#change-log)

# Installing

You can install the Task via frends UI Task View or you can find the NuGet package from the following NuGet feed
https://www.myget.org/F/frends-community/api/v3/index.json and in Gallery view in MyGet https://www.myget.org/feed/frends-community/package/nuget/FrendsTask_KalmarKommun.Datalager.Sort

# Tasks

## Sort

Task for sorting a List of Dicitionaries, based on the values of a key from the Dictionaries.

### Properties

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| ListToSort | `List<Dictionary<string, string>>` | List of dictionaries to sort. | `new List<Dictionary<string, string>> { new Dictionary<string, string> { { "season", "autum-2023" }, { "month", "october" } } };` |
| Key | `string` | Key of values in dictionaries to sort by. | `"season"` |

### Returns

A result object with parameters.

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| SortedList | `List<Dictionary<string, string>>` | Sorted list of dictionaries. | `new List<Dictionary<string, string>> { new Dictionary<string, string> { { "season", "autum-2023" }, { "month", "october" } } };` |

Usage:
To fetch result use syntax:

`#result.SortedList`

# Building

Clone a copy of the repository

`git clone https://github.com/krukle/FrendsTask_KalmarKommun.Datalager.Sort`

Rebuild the project

`dotnet build`

Run tests

`dotnet test`

Create a NuGet package

`dotnet pack --configuration Release`

# Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repository on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!
