# EdiFabric C# .NET Examples for EDIFACT

**EdiFabric 11.0.0** is a .NET SDK that parses, generates, validates, acknowledges, and splits EDI files. These examples cover **EDIFACT**, **EANCOM**, **IATA PADIS**, and **EDIGAS**.

EdiFabric does not include communication components (AS2 or SFTP), a dashboard, or a UI. It is a library you call from your own application.

The .NET 6 projects compile the same sources as the .NET Framework 4.8 projects. Both solutions reference [EdiFabric 11.0.0](https://www.nuget.org/packages/EdiFabric) and the template packages from NuGet. The examples target .NET 6 for backward compatibility. EdiFabric 11.0.0 also ships targets for .NET 8, .NET 9, and .NET 10. To evaluate one of those, change `TargetFramework` in the project file and rebuild.

| Path | Purpose |
| --- | --- |
| `NET 6/EdiFabric.Examples.EDIFACT.sln` | .NET 6 solution |
| `NET Framework 4.8/EdiFabric.Examples.EDIFACT.sln` | .NET Framework 4.8 solution |
| `NET Framework 4.8/EdiFabric.Examples.EDIFACT.Common/Config.cs` | Serial key shared by every example |
| `NET Framework 4.8/EdiFabric.Examples.EDIFACT.Demo/Program.cs` | Runnable walkthrough: read, then validate |
| `Files/` | Sample EDIFACT, EANCOM, and EDIGAS interchanges |

## Requirements

- Visual Studio 2022, or the .NET SDK. [Download Visual Studio](https://visualstudio.microsoft.com/downloads/).
- .NET 6 for `NET 6/EdiFabric.Examples.EDIFACT.sln`. The projects set `<TargetFramework>net6.0</TargetFramework>` so they stay compatible with existing .NET 6 apps. EdiFabric 11.0.0 also provides `net8.0`, `net9.0`, and `net10.0`. To evaluate a later version, change that property (for example to `net8.0`) and rebuild.
- .NET Framework 4.8 for `NET Framework 4.8/EdiFabric.Examples.EDIFACT.sln`.

1. [Sign up free for **Community**](https://www.edifabric.com/pricing.html) to get an evaluation serial key. Community never expires, requires no credit card, and is limited to 250 operations per day for non-production use. After signup, retrieve your serial from [Your Account](https://support.edifabric.com/hc/en-us/articles/360007159031-Your-Account-API-key).
2. Paste that serial into `TrialSerialKey` in `NET Framework 4.8/EdiFabric.Examples.EDIFACT.Common/Config.cs`. The .NET 6 projects link this file, so one edit covers both solutions.

NuGet restore pulls **EdiFabric 11.0.0**, **EdiFabric.Templates.Edifact 3.0.0**, and, where a project needs them, **EdiFabric.Templates.Padis** and **EdiFabric.Templates.Edigas**.

## Getting started

**Sign up free for Community** at [edifabric.com/pricing](https://www.edifabric.com/pricing.html) and put your serial in `Config.TrialSerialKey`. Then open a solution, set **EdiFabric.Examples.EDIFACT.Demo** as the startup project, and run it.

From the command line:

```bash
cd "NET 6/EdiFabric.Examples.EDIFACT.Demo"
dotnet run
```

The demo reads `Files/Edifact/PurchaseOrders.txt`, parses every message with `EdifactReader`, and validates each one with `IsValid`. Set a breakpoint at the end of `Main` and inspect `ediItems`.

To translate your own file, change the path in `EdiFabric.Examples.EDIFACT.Demo/Program.cs`.

## Usage

Every example calls `License.SetSerial` before it reads or writes. On Community that is the call to use. See [Licensing](#licensing) for Developer and Enterprise.

```csharp
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;

License.SetSerial(serial);   // from your Community or paid plan

var ediStream = File.OpenRead(@"Files\Edifact\PurchaseOrders.txt");

List<IEdiItem> ediItems;
using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
    ediItems = ediReader.ReadToEnd().ToList();

var purchaseOrders = ediItems.OfType<TSORDERS>();
```

`EdifactReader` takes the stream and the template assembly name. `ReadToEnd` loads the interchange into memory. For large files, use the streaming samples in **ReadEDI**.

### Validation and acknowledgments

After a message parses, `IsValid` checks it against the template. **ValidateEDI** shows custom codes, data types, and control segments. **AcknowledgeEDI** builds a CONTRL for a valid group, an invalid group, and duplicates.

```csharp
foreach (var message in ediItems.OfType<EdiMessage>())
{
    if (message.HasErrors)
        continue;

    MessageErrorContext mec;
    if (!message.IsValid(out mec))
    {
        var validationIssues = mec.Flatten();
    }
}
```

### Writing EDI

**WriteEDI** builds an interchange with `EdifactWriter`: UNB, then the message. The same project covers custom delimiters, a postfix after each segment, batches, and empty data elements.

```csharp
using (var stream = new MemoryStream())
{
    using (var writer = new EdifactWriter(stream))
    {
        writer.Write(SegmentBuilders.BuildUnb("1"));
        writer.Write(invoice);
    }
}
```

## Examples by feature

| Project | What it shows |
| --- | --- |
| `EdiFabric.Examples.EDIFACT.Demo` | Read a file and validate each message |
| `EdiFabric.Examples.EDIFACT.ReadEDI` | Read to end, stream, batch, split on a repeating loop, corrupt files, partner templates, custom UNB/UNG |
| `EdiFabric.Examples.EDIFACT.WriteEDI` | Write to a stream or file, delimiters, new lines, batches, empty elements, no auto trailers |
| `EdiFabric.Examples.EDIFACT.ValidateEDI` | Validate after read and before write, custom codes, UNOA/UNOB, UNB and UNG |
| `EdiFabric.Examples.EDIFACT.AcknowledgeEDI` | Generate and read CONTRL |
| `EdiFabric.Examples.EDIFACT.JSON` | Serialize and deserialize JSON |
| `EdiFabric.Examples.EDIFACT.XML` | `XmlSerializer` and `DataContractSerializer` |
| `EdiFabric.Examples.EDIFACT.CSV` | Import and export CSV |
| `EdiFabric.Examples.EDIFACT.DB` | Save and reload an ORDERS message with EF Core (create the database before you run it) |
| `EdiFabric.Examples.EDIFACT.MapEDI` | Map with AutoMapper and XSLT |
| `EdiFabric.Examples.EDIFACT.ModifyTemplates` | Parse a partner-specific ORDERS template |
| `EdiFabric.Examples.EDIFACT.Templates` | Example EDI templates |

## Examples by message type

Each project reads a sample file and writes the same message back out.

| Project | Message |
| --- | --- |
| `EdiFabric.Examples.EANCOM.INVOIC.Syntax3` | EANCOM INVOIC, syntax 3 |
| `EdiFabric.Examples.EDIFACT.BAPLIE` | SMDG BAPLIE bayplan |
| `EdiFabric.Examples.EDIFACT.CUSCAR` | US Customs CUSCAR |
| `EdiFabric.Examples.EDIFACT.PAXLST` | US Customs PAXLST |
| `EdiFabric.Examples.EDIFACT.PNRGOV` | IATA PADIS PNRGOV |
| `EdiFabric.Examples.EDIGAS.NOMINT` | EDIGAS NOMINT |
| `EdiFabric.Examples.EDIFACT.DESADV` | EDIFACT DESADV |
| `EdiFabric.Examples.EDIFACT.IFTMIN` | EDIFACT IFTMIN |
| `EdiFabric.Examples.EDIFACT.IFTSTA` | EDIFACT IFTSTA |
| `EdiFabric.Examples.EDIFACT.INVOIC` | EDIFACT INVOIC |
| `EdiFabric.Examples.EDIFACT.ORDERS` | EDIFACT ORDERS |
| `EdiFabric.Examples.EDIFACT.ORDRSP` | EDIFACT ORDRSP |
| `EdiFabric.Examples.EDIFACT.PRICAT` | EDIFACT PRICAT |

For another version on a paid plan, add that model as C# files. See [EDI templates](#edi-templates).

## Licensing

> [!NOTE]
> Sign up free for the [Community plan](https://www.edifabric.com/pricing.html)
> to get an evaluation serial key. Community never expires, requires no credit
> card, and is for non-production evaluation, learning, and prototyping
> (250 operations per day). After signup, copy your serial from
> [Your Account](https://support.edifabric.com/hc/en-us/articles/360007159031-Your-Account-API-key)
> into `Config.TrialSerialKey`.
>
> One operation is one parse, generate, validate, or acknowledge call. The 250-a-day
> quota is shared across ediFabric .NET, Native, and Cloud. If you hit it, further
> calls fail until the next day. Upgrade at
> [edifabric.com/pricing](https://www.edifabric.com/pricing.html) to continue.
>
> Use of the product is subject to the [EULA](https://www.edifabric.com/files/eula.pdf).

| Plan | What works | Recommended |
| --- | --- | --- |
| Community | `License.SetSerial` only. Online check. 250 operations per day. Non-production. | `License.SetSerial` |
| Developer | `License.SetSerial` and `License.EnsureToken` (`EnsureToken` caches the result for 1 day) | `License.EnsureToken` |
| Enterprise | `License.SetSerial`, `License.GetToken` / `License.SetToken` | `License.SetToken` (offline tokens) |

```csharp
// Community: authorize against the license server
License.SetSerial(serial);

// Developer (recommended): 1-day built-in cache; refreshes if the token expires within N seconds
License.EnsureToken(serial, seconds: 3600);

// Enterprise: set an offline token
License.SetToken(token);
```

The examples call `License.SetSerial(Config.TrialSerialKey)`. On Developer, call `License.EnsureToken` instead. `TokenFileCache.Set()` in `EdiFabric.Examples.EDIFACT.Common` is the manual `GetToken` / `SetToken` cache, for when you want to store the token yourself.

## EDI templates

The models published on NuGet, such as **EdiFabric.Templates.Edifact**, **EdiFabric.Templates.Padis**, **EdiFabric.Templates.Edigas**, and **EdiFabric.Templates.X12**, are for evaluation only. They are a Community plan limitation. These examples reference them so you can run the samples on Community.

Paid plans provide every template as plain C# files. Add them to the solution by following [How to create EDI template projects](https://support.edifabric.com/hc/en-us/articles/360016750838-How-to-create-EDI-Template-projects). For evaluation and the Community plan, you can still download the templates in compiled form by following the same article.

The same classes validate as well as parse. EdiFabric supports the EDIFACT, EANCOM, and IATA versions. If a transaction is missing, [ask for it](https://support.edifabric.com/hc/en-us/requests/new).

- [EDIFACT](https://support.edifabric.com/hc/en-us/articles/360000353611-EDIFACT-1911-to-D97A)
- [EANCOM D93A, D96A, and D01B](https://support.edifabric.com/hc/en-us/articles/360000349012-EANCOM-D93A-D96A-and-D01B-)
- [IATA PADIS](https://support.edifabric.com/hc/en-us/articles/360000349592-PNRGOV-Templates)
- [EDIGAS 4.0](https://support.edifabric.com/hc/en-us/articles/4406831178001-EDIGAS-4-0)
- [EdiNation spec library](https://edination.edifabric.com/edi-spec-library.html) (no registration)

## Warranty

The source code in these example projects is strictly for demonstrational purposes and is provided "AS IS" without warranty of any kind, whether expressed or implied, including but not limited to the implied warranties of merchantability and/or fitness for a particular purpose.

## Links

- [Install EdiFabric](https://support.edifabric.com/hc/en-us/articles/360016808578-Install-EdiFabric)
- [Tutorial](https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics)
- [EDI to database](https://support.edifabric.com/hc/en-us/articles/360029265372-EDI-to-DB)
- [Knowledge base](https://support.edifabric.com)
- [Community plan (free signup)](https://www.edifabric.com/pricing.html)
- [Your Account](https://support.edifabric.com/hc/en-us/articles/360007159031-Your-Account-API-key)
- [Support](https://support.edifabric.com/hc/en-us/requests/new)
- Support: support@edifabric.com

### 2026 © EdiFabric
