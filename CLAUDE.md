# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Fal.ai](https://fal.ai/) Platform API, auto-generated from the Fal.ai OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Fal.slnx

# Build for release (also produces NuGet package)
dotnet build Fal.slnx -c Release

# Run integration tests (requires FAL_API_KEY env var)
dotnet test src/tests/Fal.IntegrationTests/Fal.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Fal && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Fal/Generated/`.

1. `src/libs/Fal/openapi.json` -- the Fal.ai OpenAPI spec (fetched from `https://api.fal.ai/v1/openapi.json`)
3. `src/libs/Fal/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Fal/` | Main SDK library (`FalClient`) |
| `src/tests/Fal.IntegrationTests/` | Integration tests against real Fal.ai API |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
