# Xamarin Binding for Stetho

A Xamarin.Android binding library for [Stetho](https://github.com/facebook/stetho).

## Status

| VSTS | NuGet |
|------|-------|
| ![Build status](https://uno-platform.visualstudio.com/_apis/public/build/definitions/1dd81cbd-cb35-41de-a570-b0df3571a196/10/badge) | ![NuGet](https://buildstats.info/nuget/nventive.Stetho.Xamarin?includePreReleases=false) |

## Usage

```C#
public class MyApplication : Application
{
  public void OnCreate()
  {
    base.OnCreate();

    StethoLibrary.Stetho.Initialize(
      StethoLibrary.Stetho
        .NewInitializerBuilder(this)
        .EnableDumpapp(StethoLibrary.Stetho.DefaultDumperPluginsProvider(this))
        .EnableWebKitInspector(StethoLibrary.Stetho.DefaultInspectorModulesProvider(this))
        .Build()
    );
  }
}
```