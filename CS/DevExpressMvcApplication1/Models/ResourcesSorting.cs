using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ResourceSortType {
    public int ID { get; set; }
    public string Type { get; set; }
}

public enum ResourcesSortOrder {
    None = 0,
    Ascending = 1,
    Descending = 2,
    NOfAppointments = 3
}

public class ResourcesSortingHelper {
    public static IEnumerable GetItems() {
        return new List<ResourceSortType>() {
            new ResourceSortType() { ID = (int)ResourcesSortOrder.None, Type = "None"},
            new ResourceSortType() { ID = (int)ResourcesSortOrder.Ascending, Type = "A-Z Order"},
            new ResourceSortType() { ID = (int)ResourcesSortOrder.Descending, Type = "Z-A Order"},
            new ResourceSortType() { ID = (int)ResourcesSortOrder.NOfAppointments, Type = "N-Appointments"},
        } as IEnumerable;
    }
}