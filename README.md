[![](https://img.shields.io/nuget/v/soenneker.responses.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.responses.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.responses.entity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.responses.entity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.responses.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.responses.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.responses.entity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.responses.entity/actions/workflows/codeql.yml)

# Soenneker.Responses.Entity

Provides the stable identifier and creation or modification timestamps shared by API resource responses.

## Install

```bash
dotnet add package Soenneker.Responses.Entity
```

## What you get

- `EntityResponse` — Provides the stable identifier and creation or modification timestamps shared by API resource responses.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `EntityResponse.Id` | Stable unique identifier of the resource. | Stable unique identifier of the resource. |
| `EntityResponse.CreatedAt` | UTC timestamp when the resource was created. | UTC timestamp when the resource was created. |
| `EntityResponse.ModifiedAt` | UTC timestamp when the resource was last modified, or `null` when it has not been updated. | UTC timestamp when the resource was last modified, or `null` when it has not been updated. |
