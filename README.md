# Fal

[![NuGet](https://img.shields.io/nuget/v/tryAGI.Fal.svg)](https://www.nuget.org/packages/tryAGI.Fal/)
[![Downloads](https://img.shields.io/nuget/dt/tryAGI.Fal.svg)](https://www.nuget.org/packages/tryAGI.Fal/)

Generated C# SDK for the [Fal.ai](https://fal.ai/) Platform API — fast inference for generative media models (image, video, voice, 3D).

## Features
- Application management and deployment
- Secret and token management
- Fully generated from the official Fal.ai OpenAPI specification
- NativeAOT/trimming compatible
- Strong-named assembly

## Usage

```csharp
using Fal;

var client = new FalClient("your-api-key");
```

## License

MIT
