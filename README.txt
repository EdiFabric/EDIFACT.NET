Thank you for downloading EdiFabric's EDIFACT examples

1. Overview
The examples are organized into different projects in two logical categories: by product feature and by message type. All examples are provided for both .NET Framework 4.8 and .NET 6 in separate Visual Studio solutions.

2. Requirements
- Visual Studio, compatible with the supported .NET versions
- Minimum .NET Framework 4.8 or .NET 6. 
- EdiFabric DLLs and a trial serial number.

3. Serial Key and EdiFabric DLLs
Download the serial key and EdiFabric trial DLLs from https://sowl.co/oApEt. 
The serial key is included in the file serial.key in folder edifabric. Ensure it is there and that the file is not empty. The serial key is loaded in the file SerialKey.cs in project EdiFabric.Examples.X12.Common. 
Open the file and ensure that the serialKeyPath is correct. If the serial key is invalid or the file is missing, contact us at https://support.edifabric.com/hc/en-us/requests/new for assistance.
The trial DLLs are in folders net48 (for .NET Framework 4.8+) and net6.0 (for .NET 6+).

4. Setup
Rebuild the solution. If there are any build errors, contact us at https://support.edifabric.com/hc/en-us/requests/new for assistance.

5. Getting started
To get started, set project EdiFabric.Examples.EDIFACT.Demo as the startup project, open Program.cs and follow the instructions there. This project allows you to quickly translate your own EDI files.

6. Examples by feature
Explore the different features of EdiFabric, such as translating from EDI file (ReadEDI), generating EDI file (WriteEDI), validating EDI transactions (ValidateEDI), 
import/export from/to JSON , XML, CSV, create/save/query database (DB), generate CONTRL acknowledgments (AcknowledgeEDI) and how to map to/from an EDI template using Automapper and XSLT (MapEDI).

7. Examples by message type
Explore how to translate from and generate several of the most popular EDIFACT transactions. The following examples are included; please let us know if you need a different one:

EANCOM INVOIC Syntax 3
SMDG BAPLIE
US Customs CUSCAR
US Customs PAXLST
IATA PNRGOV
EDIGAS NOMINT
EDIFACT UN DESADV
EDIFACT UN IFTMIN
EDIFACT UN IFTSTA
EDIFACT UN INVOIC
EDIFACT UN ORDERS
EDIFACT UN ORDRSP
EDIFACT UN PRICAT

8. Validation
All templates in EdiFabric.Templates.Edifact and EdiFabric.Templates.Padis can be used for validation. 

9. EDI Templates
The trial comes with the following prebuilt template assemblies:

EdiFabric.Templates.Edifact.dll - EDIFACT D96A, EANCOM INVOIC D01B Syntax 3, SMDG BAPLIE D13B, USC CUSCAR and PAXLST D03B
EdiFabric.Templates.Edigas.dll - EDIGAS 4.0
EdiFabric.Templates.Padis.dll - IATA PADIS 12.1

EdiFabric supports all EDIFACT/EANCOM/IATA/EDIGAS versions and message types. We have an extensive library of EDI templates, however, if you can't find a particular transaction, please let us know. 
The following templates are available out-of-the-box:

EDIFACT
https://support.edifabric.com/hc/en-us/articles/360000353611-EDIFACT-1911-to-D97A

EANCOM
https://support.edifabric.com/hc/en-us/articles/360000349012-EANCOM-D93A-D96A-and-D01B-

IATA PADIS
https://support.edifabric.com/hc/en-us/articles/360000349592-PNRGOV-Templates

EDIGAS
https://support.edifabric.com/hc/en-us/articles/4406831178001-EDIGAS-4-0

For an interactive view of all templates go to EdiNation (no registration is required):
https://edination.com/edi-formats.html

10. Trial use
The trial serial key is valid for 14 days, and using the product with a trial license is subject to EdiFabric's license terms available at https://www.edifabric.com/files/eula.pdf. Upon expiry, the product will begin throwing exceptions. 
To continue using the trial and the examples, you'll need to request a trial extension.

11. Warranty
The source code in these example projects is strictly for demonstrational purposes and is provided "AS IS" without warranty of any kind, whether expressed or implied, including but not limited to the
implied warranties of merchantability and/or fitness for a particular purpose.

12. Additional information

Install EdiFabric
https://support.edifabric.com/hc/en-us/articles/360016808578-Install-EdiFabric

Trial and examples
https://support.edifabric.com/hc/en-us/articles/360000280532-Trial-and-Examples

EdiFabric tutorial
https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics

Knowledge Base
https://support.edifabric.com

Support
https://support.edifabric.com/hc/en-us/requests/new

Last updated on April 20, 2023
2023 © EdiFabric