<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128553779/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4487)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DevExpressMvcApplication1/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DevExpressMvcApplication1/Controllers/HomeController.vb))
* [Global.asax](./CS/DevExpressMvcApplication1/Global.asax) (VB: [Global.asax](./VB/DevExpressMvcApplication1/Global.asax))
* [Global.asax.cs](./CS/DevExpressMvcApplication1/Global.asax.cs) (VB: [Global.asax.vb](./VB/DevExpressMvcApplication1/Global.asax.vb))
* [ResourceComparer.cs](./CS/DevExpressMvcApplication1/Helpers/ResourceComparer.cs) (VB: [ResourceComparer.vb](./VB/DevExpressMvcApplication1/Helpers/ResourceComparer.vb))
* [ResourcesSorting.cs](./CS/DevExpressMvcApplication1/Models/ResourcesSorting.cs) (VB: [ResourcesSorting.vb](./VB/DevExpressMvcApplication1/Models/ResourcesSorting.vb))
* [Scheduling.cs](./CS/DevExpressMvcApplication1/Models/Scheduling.cs) (VB: [Scheduling.vb](./VB/DevExpressMvcApplication1/Models/Scheduling.vb))
<!-- default file list end -->
# Scheduler - How to sort resources
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4487/)**
<!-- run online end -->


<p>This example shows how you can sort scheduler resources. Actual sorting is performed via the<strong> SchedulerStorage.Resources.Items.Sort()</strong> method that is called inside the <a href="https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.SchedulerSettings.ResourceCollectionLoaded"><u>SchedulerSettings.ResourceCollectionLoaded</u></a> delegate.<br />
Note that custom <strong>comparers </strong>are used to compare resource items by the desired criteria (in this example, this is a Resource.Caption Property and a number of appointments, which each resource has).</p><p><strong>Note:</strong> This example shows appointments in the Read-Only mode.<strong> </strong> Refer to the <a href="https://www.devexpress.com/Support/Center/p/E3984">Scheduler - Lesson 2 - Insert-Update-Delete appointment feature</a> example to learn how to implement the appointments modification functionality.</p>

<br/>


