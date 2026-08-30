[![](https://img.shields.io/nuget/v/soenneker.responses.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.responses.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.responses.entity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.responses.entity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.responses.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.responses.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.responses.entity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.responses.entity/actions/workflows/codeql.yml)

# Soenneker.Responses.Entity

A reusable API response record containing a resource identifier and audit timestamps.

## Installation

```bash
dotnet add package Soenneker.Responses.Entity
```

## Usage

Derive a resource response from `EntityResponse`:

```csharp
using Soenneker.Responses.Entity;

public record WidgetResponse : EntityResponse
{
    public required string Name { get; init; }
}
```

Populate it when mapping a domain entity to an API contract:

```csharp
var response = new WidgetResponse
{
    Id = widget.Id,
    Name = widget.Name,
    CreatedAt = widget.CreatedAt,
    ModifiedAt = widget.ModifiedAt
};
```

The serialized base properties are:

```json
{
  "id": "75f11404-9c6f-4b33-b16c-d3ffea59f8f4",
  "createdAt": "2026-08-30T14:00:00+00:00",
  "modifiedAt": null
}
```

`CreatedAt` and `ModifiedAt` are `DateTimeOffset` values, preserving the supplied UTC offset. `ModifiedAt` is nullable for resources that have not been changed since creation. The properties are virtual so specialized response contracts can override them when necessary.

