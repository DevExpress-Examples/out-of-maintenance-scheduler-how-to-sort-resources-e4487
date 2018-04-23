# Scheduler - How to sort resources


<p>This example shows how you can sort scheduler resources. Actual sorting is performed via the<strong> SchedulerStorage.Resources.Items.Sort()</strong> method that is called inside the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcSchedulerSettings_ResourceCollectionLoadedtopic"><u>SchedulerSettings.ResourceCollectionLoaded</u></a> delegate.<br />
Note that custom <strong>comparers </strong>are used to compare resource items by the desired criteria (in this example, this is a Resource.Caption Property and a number of appointments, which each resource has).</p><p><strong>Note:</strong> This example shows appointments in the Read-Only mode.<strong> </strong> Refer to the <a href="https://www.devexpress.com/Support/Center/p/E3984">Scheduler - Lesson 2 - Insert-Update-Delete appointment feature</a> example to learn how to implement the appointments modification functionality.</p>

<br/>


