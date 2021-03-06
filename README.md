# WSOL Ektron CMS content maker
The Ektron CMS content maker is designed to make EPiServer like views from model classes that wrap content types used for strongly typed smart forms which are rendered with the WSOL:ObjectRenderer web control.

## Getting Started
Add WSOL's NuGet feed as a package source in Visual Studio. Below is the feed source:

http://nuget.wsol.com/api/

Instructions for adding package sources can be found at:

https://docs.nuget.org/consume/package-manager-dialog#package-sources

## Build Instructions
Checkout this solution and install the following NuGet packages:
* WSOL.IocContainer - DLL required to run
* WSOL.ObjectRenderer - DLL required to run
* WSOL.MSBuild.AutoVersion.Git - required to build only, development dependency only
* WSOL.ReferencePackages.EktronV87 - required to build only, development dependency only
 
Build and deploy the following files to an Ektron CMS site
* WSOL.EktronCms.ContentMaker\bin\WSOL.IoCContainer.dll
* WSOL.EktronCms.ContentMaker\bin\WSOL.ObjectRenderer.dll
* WSOL.EktronCms.ContentMaker\bin\WSOL.EktronCms.ContentMaker.dll
* WSOL.EktronCms.ContentMaker\Views\*
* WSOL.EktronCms.ContentMaker40\WSOL\* to App_Code folder
 
## Or NuGet Install
Alternatively, obtain the built Nuget package from the WSOL NuGet feed for:

WSOL.EktronCms.ContentMaker

## Code Samples
Usage examples can be found in the WSOL.EktronCms.ContentMaker.Samples project source code.

* [Content Type created by the XSD utility](https://github.com/bmcdavid/ektroncms-content-maker/blob/master/WSOL.EktronCms.ContentMaker.Samples/WSOL/Custom/ContentMaker/Samples/ContentTypes/ArticleContent.designer.cs)
* [Content Model](https://github.com/bmcdavid/ektroncms-content-maker/blob/master/WSOL.EktronCms.ContentMaker.Samples/WSOL/Custom/ContentMaker/Samples/Models/ArticleContent.cs)
* [Content Views](https://github.com/bmcdavid/ektroncms-content-maker/tree/master/WSOL.EktronCms.ContentMaker.Samples/Views/ArticleContent)
* [Content Renderer Web Control](https://github.com/bmcdavid/ektroncms-content-maker/blob/master/WSOL.EktronCms.ContentMaker.Samples/ContentRenderSamples.aspx)
* [Content Renderer Code Behind](https://github.com/bmcdavid/ektroncms-content-maker/blob/master/WSOL.EktronCms.ContentMaker.Samples/ContentRenderSamples.aspx.cs)
* [C# Code Extension Usage](https://github.com/bmcdavid/ektroncms-content-maker/blob/master/WSOL.EktronCms.ContentMaker.Samples/CodeSamples.cs)

## Important Information

* Views for models are found on web site startup, if any changes are made to TemplateDescriptor attributes for views, the web site will need to be restarted, and the quickest approach is to add a white space at the end of the web.config file in the web site root (this only impacts sites running as web sites and not web apps).
* Views currently support web forms only and not MVC.
* Supports Ektron CMS versions 8.7 and up. 8.02 support is possible, but the WSOL.EktronCms.ContentMaker35 project needs built out to create factories and extensions similar to WSOL.EktronCms.ContentMaker40.