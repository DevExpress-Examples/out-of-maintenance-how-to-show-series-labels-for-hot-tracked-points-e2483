<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575654/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2483)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ShowLabelsOnHotTrack/Form1.cs) (VB: [Form1.vb](./VB/ShowLabelsOnHotTrack/Form1.vb))
* [Program.cs](./CS/ShowLabelsOnHotTrack/Program.cs) (VB: [Program.vb](./VB/ShowLabelsOnHotTrack/Program.vb))
<!-- default file list end -->
# How to show series labels for hot-tracked points


<p>This example demonstrates how to make a chart show a series point label only for the point that has been hot-tracked.</p><p>To do this, in the CustomDrawSeriesPoint event handler, assign an empty string to the LabelText property of each series point, and then assign the point's value to the hot-tracked point, which is obtained in the ObjectHotTracked event handler.</p><p>See also:<br />
- <a href="https://www.devexpress.com/Support/Center/p/E126">How to show a tooltip with a series point's data</a>; <br />
- <a href="https://www.devexpress.com/Support/Center/p/E2188">How to accompany a chart, its pane or series point by text or image annotations</a>.</p>

<br/>


