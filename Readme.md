<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128657803/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T556239)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ChildNodesPathDemo/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ChildNodesPathDemo/MainWindow.xaml))
* [ViewModel.cs](./CS/ChildNodesPathDemo/ViewModel.cs) (VB: [ViewModel.vb](./VB/ChildNodesPathDemo/ViewModel.vb))
<!-- default file list end -->
# How to: Implement ChildNodesPath


<p>You can use the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.ChildNodesPath.property">TreeListView.ChildNodesPath</a> to bind the <a href="https://documentation.devexpress.com/WPF/9759/Controls-and-Libraries/Tree-List">TreeListControl </a>to a collection if all the business objects have the same child field. To bind a collection to the <strong>TreeListControl, </strong>you should assign the child field name to the TreeListView's <strong>TreeListView.ChildNodesPath</strong> property and set the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.TreeDerivationMode.property">TreeListView.TreeDerivationMode</a> property to <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.ChildNodesSelector.property">TreeDerivationMode.ChildNodesSelector</a>. In the example below the <em>Task </em>field is the child field.</p>

<br/>


