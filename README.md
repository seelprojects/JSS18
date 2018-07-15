# TSE18
This tool implements our hybrid approach presented in our currently-under-review research paper.  

![ScreenShot](https://github.com/seelprojects/TSE18/blob/master/src/image.png)

### Getting Started
TSE18's main window provides following options:

#### Dataset
User can choose one of the 5 bug localization datasets available: AspectJ, Eclipse, JodaTime, SWT, and ZXing.

#### Method i
This method will be treated as the base method.

#### Method j
This method will be combined with method i.

#### Metric
Available performance measures are TR<sub>1</sub>, TR<sub>5</sub>, TR<sub>10</sub>, MAP, and MRR.

### Development Environment
In order to open and modify the C# source project you will need:
- Visual Studio 2015 [Free Community Edition](https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx)
- [.Net 4.5.2](https://support.microsoft.com/en-us/kb/2901907)

Once available, open BugLocalizationHybridApproach.sln in [src](src/) directory in Visual Studio.

### Resources
The performance metric for all projects and method combinations are provided as an XML format. Users can find the XMLs in [src/BugLocalizationHybridApproach/Resources](src/BugLocalizationHybridApproach/Resources/). The full dataset can be downloaded from: [http://seel.cse.lsu.edu/data/tse18.zip](http://seel.cse.lsu.edu/data/tse18.zip).