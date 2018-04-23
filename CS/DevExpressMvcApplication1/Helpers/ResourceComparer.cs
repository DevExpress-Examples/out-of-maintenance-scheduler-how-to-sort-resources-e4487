using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Web.Mvc;
using DevExpress.XtraScheduler;

public abstract class ResourceBaseComparer : IComparer<Resource>, IComparer {
    #region IComparer Members
    int IComparer.Compare(object x, object y) {
        return CompareCore(x, y);
    }
    public int Compare(Resource x, Resource y) {
        return CompareCore(x, y);
    }
    #endregion

    protected virtual int CompareCore(object x, object y) {
        Resource xRes = (Resource)x;
        Resource yRes = (Resource)y;

        if (xRes == null || yRes == null)
            return 0;
        if (Resource.Empty.Equals(xRes) || Resource.Empty.Equals(yRes))
            return 0;

        return CompareResources(xRes, yRes);
    }

    protected abstract int CompareResources(Resource xRes, Resource yRes);
}

public class ResourceCaptionComparer : ResourceBaseComparer {
    protected override int CompareResources(Resource xRes, Resource yRes) {
        return String.Compare(xRes.Caption, yRes.Caption);
    }
}

public class ResourceCaptionReverseComparer : ResourceBaseComparer {
    protected override int CompareResources(Resource xRes, Resource yRes) {
        return String.Compare(yRes.Caption, xRes.Caption);
    }
}

public class ResourceNOfAppointmentsComparer : ResourceBaseComparer {
    private MVCxSchedulerStorage schedulerStorage;

    public ResourceNOfAppointmentsComparer(MVCxSchedulerStorage schedulerStorage) {
        this.schedulerStorage = schedulerStorage;
    }

    protected override int CompareResources(Resource xRes, Resource yRes) {
        int order = schedulerStorage.Appointments.Items.FindAll(e => e.ResourceId.Equals(yRes.Id)).Count -
            schedulerStorage.Appointments.Items.FindAll(e => e.ResourceId.Equals(xRes.Id)).Count;

        return (order != 0) ?  order : schedulerStorage.Resources.Items.IndexOf(xRes) - schedulerStorage.Resources.Items.IndexOf(yRes) ;
    }
}