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


