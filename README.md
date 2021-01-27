# EdiFabric C# .NET Examples for EDIFACT D96A, EANCOM D03B, and IATA PADIS

## 1. Overview
EdiFabric is a software development kit for .NET Framework and .NET Core, which makes it straightforward to parse, generate, validate, acknowledge, split, customize, or in other words, to programmatically manipulate EDI files. It is written in C# and is distributed as a set of NuGet packages and C# files.  

It currently supports all message types for the X12, EDIFACT, HL7, and NCPDP EDI standards, the German automotive standard VDA, as well as custom formatted flat files (delimited, positional, or a mixture of both).  

> NOTE: EdiFabric does not provide any communication components (AS2 or SFTP, for example), has no dashboard or UI, and is not a full end-to-end EDI solution.
The best option to get the gist of what EdiFabric is, and can do, is to play around with the trial and examples.  

The examples are organized into different projects in two logical categories: by product feature and by message type.   

```C#
var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrder.txt");

List<IEdiItem> ediItems;
using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
    ediItems = ediReader.ReadToEnd().ToList();

var transactions = ediItems.OfType<TSORDERS>();
```

## 2. Requirements
- Visual Studio, compatible with the supported .NET versions.
- Minimum .NET Framework 4.5 or .NET Core 3.1. All projects target .NET Framework 4.5, however, the Target Framework from each project's properties can be changed to .NET Core 3.1.  
- EdiFabric trial NuGet packages and serial key.  

## 3. Setup
Rebuild the solution to install EdiFabric Trial from nuget.org. If there are any build errors, contact us at https://support.edifabric.com/hc/en-us/requests/new for assistance.  

> NOTE: it is possible to also reference DLLs instead of NuGet packages. Change the .nupkg extension of the packages to .zip, unzip them, and extract the DLL files. 
Then uninstall the NuGet packages from each project and replace them with DLL references.  

## 4. Serial Key
[Download the serial key](https://sowl.co/oApEt).
The serial key is included in the file serial.key in folder edifabric-trial. Ensure it is there and that the file is not empty. The serial key is loaded in the file SerialKey.cs in project EdiFabric.Examples.EDIFACT.Common. Open the file and ensure that the serialKeyPath is correct.  
If the serial number is invalid or the file is missing, contact us at https://support.edifabric.com/hc/en-us/requests/new for assistance.  

## 5. Getting started
To get started, set project EdiFabric.Examples.EDIFACT.Demo as the startup project, open Program.cs and follow the instructions there. This project allows you to quickly translate your own EDI files.  

## 6. Examples by feature
Explore the different features of EdiFabric, such as translating from EDI file (ReadEDI), generating EDI file (WriteEDI), validating EDI transactions (ValidateEDI), 
import/export from/to JSON , XML, CSV, create/save/query database (DB), generate CONTRL acknowledgments (AcknowledgeEDI) and how to map to/from an EDI template using Automapper and XSLT (MapEDI).  

## 7. Examples by message type
Explore how to translate from and generate several of the most popular EDIFACT transactions. The following examples are included; please let us know if you need a different one:  

EANCOM INVOIC Syntax 3  
SMDG BAPLIE  
US Customs CUSCAR  
US Customs PAXLST  
IATA PNRGOV  
EDIFACT UN DESADV  
EDIFACT UN IFTMIN  
EDIFACT UN IFTSTA  
EDIFACT UN INVOIC  
EDIFACT UN ORDERS  
EDIFACT UN ORDRSP  
EDIFACT UN PRICAT  

## 8. EDI Validation
All templates in EdiFabric.Templates.Edifact and EdiFabric.Templates.Padis can be used for validation.   

## 9. EDI Templates
EdiFabric supports all EDIFACT/EANCOM/IATA versions and message types. We have an extensive library of EDI templates, however, if you can't find a particular transaction, please let us know.   
The following templates are available out-of-the-box:

[EDIFACT](https://support.edifabric.com/hc/en-us/articles/360000353611-EDIFACT-1911-to-D97A)

[EANCOM](https://support.edifabric.com/hc/en-us/articles/360000349012-EANCOM-D93A-D96A-and-D01B-)

[IATA PADIS](https://support.edifabric.com/hc/en-us/articles/360000349592-PNRGOV-Templates)

For an interactive view of all templates go to EdiNation's EDI Webpad (no registration is required):

[EDIFACT](https://www.edination.com/edi-models-edifact.html)

[EANCOM](https://www.edination.com/edi-models-eancom.html)

[IATA PADIS](https://www.edination.com/edi-models-iata.html)

## 10. Trial use
The trial assemblies are valid for 14 days and are subject to EdiFabric's license terms available at https://www.edifabric.com/files/eula.pdf. Upon expiry, the trial packages will begin throwing exceptions.   
To continue using the trial and the examples, you'll need to either request a trial extension or replace the trial packages, together with all references to the trial packages, with the full version of EdiFabric.  

## 11. Warranty
*The source code in these example projects is strictly for demonstrational purposes and is provided "AS IS" without warranty of any kind, whether expressed or implied, including but not limited to the
implied warranties of merchantability and/or fitness for a particular purpose.*

## 12. Additional information

[Install EdiFabric](https://support.edifabric.com/hc/en-us/articles/360016808578-Install-EdiFabric)

[Trial and Examples](https://support.edifabric.com/hc/en-us/articles/360000280532-Trial-and-Examples)

[EdiFabric Tutorial](https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics)

[Knowledge Base](https://support.edifabric.com)

[Support](https://support.edifabric.com/hc/en-us/requests/new)

Last updated on January 7, 2021
### 2021 © EdiFabric
