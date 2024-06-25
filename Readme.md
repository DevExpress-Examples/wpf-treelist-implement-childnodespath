<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128657803/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T556239)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Tree List - Implement the Child Nodes Path

This example uses the **Child Nodes Path** to bind the [TreeListView](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView) to a collection whose objects have the same field that contains child items.

1. Set the [TreeListView.ChildNodesPath](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.ChildNodesPath) property to the children field name (**Tasks** in this example).
2. Set the [TreeListView.TreeDerivationMode](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.TreeDerivationMode) property to `ChildNodesSelector`.

![image](https://user-images.githubusercontent.com/65009440/193259437-5c4823f6-bacd-4956-b25a-d59c531e7ee2.png)

## Files to Review

* [MainWindow.xaml](./CS/ChildNodesPath/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ChildNodesPath/MainWindow.xaml))
* [ViewModel.cs](./CS/ChildNodesPath/ViewModel.cs) (VB: [ViewModel.vb](./VB/ChildNodesPath/ViewModel.vb))

## Documentation

* [Child Nodes Path](https://docs.devexpress.com/WPF/10366/controls-and-libraries/data-grid/display-hierarchical-data/bind-to-hierarchical-data-structure#child-nodes-path)
* [Display Hierarchical Data](https://docs.devexpress.com/WPF/9700/controls-and-libraries/data-grid/display-hierarchical-data)
* [TreeListView.ChildNodesPath](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.ChildNodesPath)

## More Examples

* [WPF Tree List - Bind to Self-Referential Data Structure](https://github.com/DevExpress-Examples/wpf-treelist-bind-to-self-referential-data)
* [WPF Tree List - Use the Child Nodes Selector to Create a Hierarchical Data Structure](https://github.com/DevExpress-Examples/how-to-implement-hierarchical-data-binding-via-child-nodes-selector-e3298)
* [WPF Tree List - Use the Hierarchical Data Template to Build a Tree](https://github.com/DevExpress-Examples/how-to-build-a-tree-via-hierarchicaldatatemplate-e3410)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-treelist-implement-childnodespath&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-treelist-implement-childnodespath&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
