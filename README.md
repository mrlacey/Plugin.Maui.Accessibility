![nuget.png](https://raw.githubusercontent.com/mrlacey/Plugin.Maui.Accessibility/main/nuget.png)
# Plugin.Maui.Accessibility

`Plugin.Maui.Accessibility` lets you access system/device accessibility settings in your .NET MAUI application.

## Install Plugin

[![NuGet](https://img.shields.io/nuget/v/Plugin.Maui.Accessibility.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.Maui.Accessibility/)

Available on [NuGet](http://www.nuget.org/packages/Plugin.Maui.Accessibility).

Install with the dotnet CLI: `dotnet add package Plugin.Maui.Accessibility`, or through the NuGet Package Manager in Visual Studio.

### Supported Platforms

| Platform | Minimum Version Supported |
|----------|---------------------------|
| iOS      | 14+                       |
| macOS    | 14.0+                     |
| Android  | 5.0 (API 21)              |
| Windows  | 11 and 10 version 1809+   |

## API Usage

`Plugin.Maui.Accessibility` provides the `AccessibilityInfo` class that has a single property `Property` that you can get or set.

You can either use it as a static class, e.g.: `AccessibilityInfo.Default.UseReducedMotion` or with dependency injection: `builder.Services.AddSingleton<IAccessibilityInfo>(AccessibilityInfo.Default);`

### Permissions

No permissions are needed for this plugin.

### Dependency Injection

You will first need to register the `AccessibilityInfo` class with the `MauiAppBuilder` following the same pattern that the .NET MAUI Essentials libraries follow.

```csharp
builder.Services.AddSingleton(AccessibilityInfo.Default);
```

You can then enable your classes to depend on `IAccessibilityInfo` as per the following example.

```csharp
public class FeatureViewModel
{
    readonly IAccessibilityInfo accessibility;

    public FeatureViewModel(IAccessibilityInfo a11yInfo)
    {
        this.accessibility = a11yInfo;
    }

    public void ShowCompletedMessage()
    {
        if (accessibility.UseReducedMotion)
        {
            CompletionAnimation.GoToState(State.Finished);
        }
        else
        {
            CompletionAnimation.Start();
        }
    }
}
```

### Straight usage

Alternatively if you want to skip using the dependency injection approach you can use the `Feature.Default` property.

```csharp
public class FeatureViewModel
{
    public void ShowCompletedMessage()
    {
        if (AccessibilityInfo.Default.UseReducedMotion)
        {
            CompletionAnimation.GoToState(State.Finished);
        }
        else
        {
            CompletionAnimation.Start();
        }
    }
}
```

### IAccessibilityInfo

Once you have created a `AccessibilityInfo` you can interact with it in the following ways:

#### Events

None.

#### Properties

##### `UseReducedMotion`

Gets a value indicating whether the device is configured to use reduced motion or animations have been disabled.

##### `TextScaleFactor`

Gets a double value indicating by what about text should be scaled to match device settings. (Default = 1.0)

#### Methods

None.

# Acknowledgements

This project could not have came to be without these projects and people, thank you! <3

- [Gerald and Plugin.Maui.Feature](https://github.com/jfversluis/Plugin.Maui.Feature)
