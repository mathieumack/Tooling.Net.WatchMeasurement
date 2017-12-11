# Tooling.Net.WatchMeasurement
This repository contains a simple tool that let you measure some code execution time, and execute an action at the end of the execution.

## Build 

[![Build status](https://ci.appveyor.com/api/projects/status/wgir2qmxpvhmm27n?svg=true)](https://ci.appveyor.com/project/mathieumack/tooling-net-watchmeasurement)

## Nuget

 [![NuGet package](https://buildstats.info/nuget/Tooling.Net.WatchMeasuremen?includePreReleases=true)](https://nuget.org/packages/Tooling.Net.WatchMeasuremen)

### Nuget Installation

Install [WatchMeasurement](https://www.nuget.org/packages/Tooling.Net.WatchMeasurement/) from nuget.

## Please Contribute!

This is an open source project that welcomes contributions/suggestions/bug reports from those who use it. 

If you have any ideas on how to improve the library, please [post an issue here on github](https://github.com/mathieumack/Tooling.Net.WatchMeasuremen/issues).

# Example

## Enable the measurement api

By default, the measurement api is disabled in order to reduce impact of performances in your application.
You can enable or disable by changing the boolean field : MeasurementAction.IsEnabled

```c#
MeasurementAction.IsEnabled = true;
```
## How to use it ?

Using the name of the database and the folder on the client device where to store database files:
```c#

using (var measure = MeasurementAction.StartMeasure(watch =>
{
    // Do your action here.
    // It will be called at the end of the using statement

}, true))
{
    // Do your measurement code statements here
}
```

Enjoy ! 