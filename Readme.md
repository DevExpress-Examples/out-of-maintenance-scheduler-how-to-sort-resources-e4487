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


<p>This example shows how you can sort scheduler resources. Actual sorting is performed via the<strong> SchedulerStorage.Resources.Items.Sort()</strong> method that is called inside the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcSchedulerSettings_ResourceCollectionLoadedtopic"><u>SchedulerSettings.ResourceCollectionLoaded</u></a> delegate.<br />
Note that custom <strong>comparers </strong>are used to compare resource items by the desired criteria (in this example, this is a Resource.Caption Property and a number of appointments, which each resource has).</p><p><strong>Note:</strong> This example shows appointments in the Read-Only mode.<strong> </strong> Refer to the <a href="https://www.devexpress.com/Support/Center/p/E3984">Scheduler - Lesson 2 - Insert-Update-Delete appointment feature</a> example to learn how to implement the appointments modification functionality.</p>

<br/>


