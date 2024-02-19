![Logo](.images/Logo.png)

![Dot-Net-Standard-Version](https://img.shields.io/badge/.NET%20Standard-%3E%3D2.0-blue)
![C-Sharp-Version](https://img.shields.io/badge/C%23-Preview-blue.svg)
[![IDE-Version](https://img.shields.io/badge/IDE-VS2022-blue.svg)](https://visualstudio.microsoft.com/downloads)
[![NuGet-Version](https://img.shields.io/nuget/v/Skylark.svg?label=NuGet)](https://www.nuget.org/packages/Skylark)
[![FuGet-Version](https://www.fuget.org/packages/Skylark/badge.svg?label=FuGet)](https://www.fuget.org/packages/Skylark)
[![NuGet-Download](https://img.shields.io/nuget/dt/Skylark?label=Download)](https://www.nuget.org/api/v2/package/Skylark)
[![Stack Overflow](https://img.shields.io/badge/Stack%20Overflow-Skylark-orange.svg)](https://stackoverflow.com/questions/tagged/skylark)

[![.NET](https://github.com/Taiizor/Skylark/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Taiizor/Skylark/actions/workflows/dotnet.yml)
[![CodeQL](https://github.com/Taiizor/Skylark/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/Taiizor/Skylark/actions/workflows/codeql-analysis.yml)
[![.NET Desktop](https://github.com/Taiizor/Skylark/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/Taiizor/Skylark/actions/workflows/dotnet-desktop.yml)

[![Discord-Server](https://img.shields.io/discord/932386235538878534?label=Discord)](https://discord.gg/nxG977byXb)

# Welcome to Skylark
Skylark is a collection of tools and resources that can help with developing .NET projects. It is designed to be lightweight, easy to use, and not too complicated or resource-intensive. It can be useful for developers who are new to .NET or who want to quickly set up a new project without having to spend a lot of time configuring everything from scratch.

## Contributors

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<table>
  <tr>
    <td align="center">
		<a href="https://github.com/Taiizor">
			<img src="https://avatars3.githubusercontent.com/u/41683699?s=460&v=4" width="80px;" alt="Taiizor"/>
			<br/>
			<sub>
				<b>Taiizor</b>
			</sub>
		</a>
		<br/>
		<a href="https://github.com/Taiizor/Skylark/commits?author=Taiizor" title="Code">💻</a>
		<a href="https://www.vegalya.com" title="Ideas & Planning, Feedback">🤔</a>
	</td>
    <td align="center">
		<a href="https://github.com/Grovre">
			<img src="https://avatars3.githubusercontent.com/u/50428844?s=460&v=4" width="80px;" alt="Grovre"/>
			<br/>
			<sub>
				<b>Grovre</b>
			</sub>
		</a>
		<br/>
		<a href="https://github.com/Taiizor/Skylark/commits?author=Grovre" title="Code">💻</a>
	</td>
  </tr>
</table>

This project follows the [all contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!

## Backers

<table>
  <tr>
    <td align="center">
		<a href="https://github.com/Vegalya">
			<img src="https://avatars3.githubusercontent.com/u/98421771?s=200&v=4" width="80px;" alt="Vegalya"/>
			<br/>
			<sub>
				<b>Vegalya</b>
			</sub>
		</a>
		<br/>
		<a href="https://github.com/Vegalya" target="_blank" title="Content">🖋</a>
	</td>
    <td align="center">
		<a href="https://github.com/Soferity">
			<img src="https://avatars3.githubusercontent.com/u/63516515?s=200&v=4" width="80px;" alt="Soferity"/>
			<br/>
			<sub>
				<b>Soferity</b>
			</sub>
		</a>
		<br/>
		<a href="https://github.com/Soferity" target="_blank" title="Content">🖋</a>
	</td>
  </tr>
</table>

## Platform support

Skylark works on .NET Framework, .NET Standard, .NET Core and .NET.

<table>
   <thead>
      <tr>
         <th>.NET implementation</th>
         <th>Version support</th>
      </tr>
   </thead>
   <tbody>
      <tr>
         <td>.NET and .NET Core</td>
         <td>2.0, 2.1, 2.2, 3.0, 3.1, 5.0, 6.0, 7.0, 8.0, 9.0</td>
      </tr>
      <tr>
         <td>.NET Framework</td>
         <td>4.6.1, 4.6.2, 4.7, 4.7.1, 4.7.2, 4.8, 4.8.1</td>
      </tr>
      <tr>
         <td>Mono</td>
         <td>5.4, 6.4</td>
      </tr>
      <tr>
         <td>Xamarin.iOS</td>
         <td>10.14, 12.16</td>
      </tr>
      <tr>
         <td>Xamarin.Mac</td>
         <td>3.8, 5.16</td>
      </tr>
      <tr>
         <td>Xamarin.Android</td>
         <td>8.0, 10.0</td>
      </tr>
      <tr>
         <td>Universal Windows Platform</td>
         <td>10.0.16299, TBD</td>
      </tr>
      <tr>
         <td>Unity</td>
         <td>2018.1</td>
      </tr>
   </tbody>
</table>

Binaries for all platforms are built from a single Visual Studio Project. You will need the latset [Visual Studio](https://visualstudio.microsoft.com/downloads) to build or contribute to Skylark.

## Getting started

Skylark is distributed via Microsofts package manager [NuGet](https://www.nuget.org). We refer to [this page](https://docs.microsoft.com/en-gb/nuget) for detailed descriptions on how to get started/use NuGet. Here is a link to the [Skylark NuGet package](https://www.nuget.org/packages/Skylark).
You can grab a copy of the library on NuGet by running:

By Package Manager (PM): 
```sh 
Install-Package Skylark
```

By .NET CLI: 
```sh 
dotnet add package Skylark
```

Find more, including a runnable example application, under the [Getting Started](https://github.com/Taiizor/Skylark/wiki/Getting-Started) topic in the [documentation](https://github.com/Taiizor/Skylark/wiki/).

## Documentation and FAQ

To learn more about Skylark, check out the [documentation](https://github.com/Taiizor/Skylark/wiki) - you'll find information there on the most common scenarios. If Skylark isn't working the way you expect, you may find the [troubleshooting guide](https://github.com/Taiizor/Skylark/wiki/Debugging-and-Diagnostics) useful.

Skylark has an active and helpful community who are happy to help point you in the right direction or work through any issues you might encounter. You can get in touch via:

 * [Stack Overflow](http://stackoverflow.com/questions/tagged/skylark)
 * [Discord](https://discord.gg/nxG977byXb) &mdash; this is the best place to start if you have a question

We welcome bug reports and suggestions through our [issue tracker](https://github.com/Taiizor/Skylark/issues) here on GitHub.

## Contributing

Would you like to help make Skylark even better? We keep a list of issues that are approachable for newcomers under the [solved](https://github.com/Taiizor/Skylark/issues?q=is%3Aissue+label%3Asolved) label (accessible only when logged into GitHub). Before starting work on a pull request, we suggest commenting on, or raising, an issue on the issue tracker so that we can help and coordinate efforts.

When contributing please keep in mind our [Code of Conduct](CODE_OF_CONDUCT.md).

_Skylark is copyright &copy; 2022-2023 Skylark Contributors - Provided under the [Apache License, Version 2.0](https://apache.org/licenses/LICENSE-2.0.html)._