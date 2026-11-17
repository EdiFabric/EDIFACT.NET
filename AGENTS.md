# AGENTS.md: EdiFabric C# .NET examples for EDIFACT

Guidance for AI coding assistants (Codex, Cursor, GitHub Copilot, Claude Code and others) that work in this
repository, or that write C# code with EdiFabric based on it. README.md lists every example.

## What this is

Runnable C# examples for **EdiFabric** (ediFabric .NET), the `EdiFabric` NuGet package that reads, writes,
validates and splits EDI as typed C# objects. These examples cover UN/EDIFACT D96A, EANCOM D03B, IATA PADIS and EDIGAS 4.0.

EdiFabric is a library you call from your own code. It has no AS2 or SFTP transport, dashboard or UI.

## Build and run

- `NET 6/EdiFabric.Examples.EDIFACT.sln` targets .NET 6; `NET Framework 4.8/EdiFabric.Examples.EDIFACT.sln` targets .NET Framework 4.8. Both compile the same
  sources. EdiFabric 11.2.0 also targets .NET 8, 9 and 10: change `TargetFramework` to try one.
- `dotnet build "NET 6/EdiFabric.Examples.EDIFACT.sln"`, then run a project, or open the solution in Visual Studio 2022.
- The serial key is `TrialSerialKey` in `NET Framework 4.8/EdiFabric.Examples.EDIFACT.Common/Config.cs`. It's the demo serial
  `bd96a836feca45cb91c86ee65d281f52`, which needs no account and has a small daily quota.

## How the code works

```csharp
License.EnsureToken(serial, seconds: 3600);   // once per process, on every plan

using (var reader = new EdifactReader(ediStream, "EdiFabric.Examples.EDIFACT.Templates"))
{
    var items = reader.ReadToEnd().ToList();
}
```

- License first: `License.EnsureToken(serial, seconds: 3600)` on every plan. Don't write new code with
  `License.SetSerial`: it still works, but checks the serial online on every operation.
- The second argument of the reader is the **assembly name** of the project holding the templates, not a namespace.
- `ReadToEnd` loads everything into memory. For large files, use the streaming examples.
- Template classes are named TS plus the message id, in a namespace per standard and version, such as `EdiFabric.Templates.EdifactD96A`, for example `TSORDERS` ((the ORDERS message)).
- Acknowledgments: the examples generate CONTRL.
- Validate with `IsValid(out MessageErrorContext errorContext)` on a message; the same template classes parse,
  generate and validate.

## Templates

- Get C# templates from the EDI spec library: https://www.edifabric.com/specs/index.html (free sign-in to download). Put one version,
  or one trading partner, in one class library, and reference it.
- For a trading partner's changes, customise the spec in the EDI Spec Builder (https://www.edifabric.com/spec-builder/index.html) and
  download its C#, or edit the template's attributes.
- Don't invent template classes or properties: open the template, or the transaction's page in the spec library.

## Serial keys and errors

- Read the user's own serial from configuration. Never commit a customer's serial.
- When the demo serial's daily quota runs out, don't retry in a loop. Tell the user to sign up free for Community
  or upgrade at https://www.edifabric.com/pricing.html, and put their serial in `Config.cs`.
- The license errors are listed in README.md under Error codes.

## Working in this repository

- Keep the .NET 6 and .NET Framework 4.8 solutions in step: they share the same sources.
- Keep README.md's lists of examples in step when you add or rename a project.

## More

- Docs as markdown: https://www.edifabric.com/docs/edifabric-net/introduction.html.md, https://www.edifabric.com/docs/edifabric-net/licensing.html.md and
  https://www.edifabric.com/docs/edifabric-net/edi-templates.html.md
- Index of all docs for LLMs: https://www.edifabric.com/llms.txt
