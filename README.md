# Simple.Extension

![twitter_header_photo_2](https://user-images.githubusercontent.com/67638928/191241272-550df522-215c-4af6-b41d-daa84de90763.png)

[![forthebadge](https://img.shields.io/nuget/v/Simple.Extension)](https://www.nuget.org/packages/Simple.Extension/)
[![forthebadge](https://img.shields.io/nuget/dt/Simple.Extension)](https://www.nuget.org/packages/Simple.Extension/)

## Installation 💿

You can install the latest version of the package with the command ```dotnet add package Simple.Extension```.
You can also install it manualy in your IDE with the nuget package manager by searching Simple.Extension.

## Getting started 🚀

Simple Extension provides different methods to help you in your developments.

After this you can use the library by adding differents namespaces :

```C#
using Simple.Extension.String;
using Simple.Extension.Enumerable;
using Simple.Extension.Date;

```
### Simple.Extension.String

Here are the different methods added by Simple.Extension.String :

```C#
string myString = "myString";
bool isNullOrEmpty = myString.IsNullOrEmpty(); // return false
bool isNullOrEmpty = myString.IsNotNullOrEmpty(); // return true
````

### Simple.Extension.Enumerable

Here are the different methods added by Simple.Extension.String :

```C#
string myEnumerable = new List<int>(){ 0, 1, 2, 3 };
bool isNull = myEnumerable.IsNullOrEmpty(); // return false
bool isNotNull = myEnumerable.IsNotNullOrEmpty(); // return true
````

## That's all ! ⭐

If you want to help the project, you can put a star on Github. If you have any problems, please let me know by creating an issue on Github or by asking for a pull request.
  
