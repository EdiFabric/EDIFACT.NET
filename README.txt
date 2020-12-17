Thank you for downloading EdiFabric's EDIFACT examples

Go to https://support.edifabric.com/hc/en-us/articles/360000280532-Quickstart-Translate-EDI-file for the web version of this README.

1. Overview
The examples are organized into different projects in two logical categories: by product feature and by message type.

2. Requirements
- Visual Studio, compatible with the supported .NET versions
- .NET Framework 4.5 or .NET Core 3.1. All projects target .NET Framework 4.5, however, the Target Framework from each project's properties can be changed to .NET Core 3.1.
- EdiFabric trial NuGet packages and serial number.

3. Download
The trial NuGet packages and the trial serial number can be downloaded from https://sowl.co/oApEt. 

4. Install
Unzip the downloaded file in the previous step. The following folders should be available at the same level:

edifabric-examples-edifact
edifabric-examples-flatfile
edifabric-examples-x12
edifabric-trial

Ensure that the following packages are present in folder edifabric-trial:

EdiFabric.Core.9.8.7.5.nupkg
EdiFabric.Framework.9.8.7.5.nupkg
EdiFabric.Plugins.Ack.Edifact.9.8.7.5.nupkg
EdiFabric.Plugins.Ack.X12.9.8.7.5.nupkg
EdiFabric.Templates.Edifact.1.5.1.nupkg
EdiFabric.Templates.Hipaa.1.5.1.nupkg
EdiFabric.Templates.Padis.1.5.1.nupkg
EdiFabric.Templates.Vda.1.5.1.nupkg
EdiFabric.Templates.X12.1.5.1.nupkg

5. Setup
Add folder edifabric-trial as a package source in Visual Studio:
- From the top menu in Visual Studio go to Tools -> NuGet Package Manager -> Package Manager Settings -> Package Sources
- Add a new package source (by clicking the green plus button), then name it "EdiFabric Trial" and browse to select the edifabric-trial folder as the Source.
- Click the Update button to apply the changes and then click OK to close the dialog.

Rebuild the solution to install the rest of the dependencies. If there are any build errors, contact us at https://support.edifabric.com/hc/en-us/requests/new for assistance.

NOTE: it is possible to also reference DLLs instead of NuGet packages. Change the .nupkg extension of the packages to .zip, unzip them, and extract the DLL files. 
Then uninstall the NuGet packages from each project and replace them with DLL references.

6. Serial Number
All main operations, like read, write, and validate require a valid serial number. The serial number is included in the file serial.key in folder edifabric-trial. Ensure it is there and that the file is not empty.
The serial number is used in the file License.cs in project EdiFabric.Examples.EDIFACT.Common. Open the file and ensure that the serialKeyPath is correct.
If the serial number is invalid or the file is missing, contact us at https://support.edifabric.com/hc/en-us/requests/new for assistance.

7. Gettings started
To get started, set project EdiFabric.Examples.EDIFACT.Demo as the startup project, open Program.cs and follow the instructions there. This project allows you to quickly translate your own EDI files.

8. Examples by feature
Explore the different features of EdiFabric, such as translating from EDI file (ReadEDI), generating EDI file (WriteEDI), validating EDI transactions (ValidateEDI), 
import/export from/to JSON , XML, CSV, create/save/query database (DB), generate CONTRL acknowledgments (AcknowledgeEDI) and how to map to/from an EDI template using Automapper and XSLT (MapEDI).

9. Examples by message type
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

10. Validation
None of the trial templates in EdiFabric.Templates.Edifact and EdiFabric.Templates.Padis can be used for validation. They are cutdown versions of the full templates and can only be used for reading and writing.
To evaluate the validation and acknowledgment functionalities, the full templates for ORDERS and INVOIC are provided in project EdiFabric.Examples.EDIFACT.Templates.D96A. All validation and acknowledgment examples
refer to this project instead of EdiFabric.Templates.Edifact. If you need to test with a different template, please contact us.

11. Trial use
The trial assemblies are valid for 14 days and are subject to EdiFabric's license terms available at https://www.edifabric.com/files/eula.pdf. Please contact us if you need the trial period extended.

12. Warranty
The source code in these example projects is strictly for demonstrational purposes and is provided "AS IS" without warranty of any kind, whether expressed or implied, including but not limited to the
implied warranties of merchantability and/or fitness for a particular purpose.

13. Additional information

EdiFabric tutorial
https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics

Knowledge Base
https://support.edifabric.com

Support
https://support.edifabric.com/hc/en-us/requests/new

Last updated on December 16, 2020
2020 © EdiFabric