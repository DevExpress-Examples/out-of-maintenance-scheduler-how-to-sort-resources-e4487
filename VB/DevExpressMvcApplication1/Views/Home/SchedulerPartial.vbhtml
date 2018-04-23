@Html.DevExpress().Scheduler( _
    Sub(settings)
            settings.Name = "scheduler"
            settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "SchedulerPartial"}
            settings.Storage.Appointments.Assign(SchedulerDataHelper.DefaultAppointmentStorage)
            settings.Storage.Resources.Assign(SchedulerDataHelper.DefaultResourceStorage)

            settings.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None
            settings.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None
            settings.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None

            settings.ActiveViewType = SchedulerViewType.Timeline
            settings.GroupType = SchedulerGroupType.Resource
            
            settings.ResourceCollectionLoaded =
                Sub(s, e)
                        Dim storage As MVCxSchedulerStorage = CType(s, MVCxSchedulerStorage)
                        Dim comparer As IComparer(Of Resource) = Nothing

                        Dim sortOrder As ResourcesSortOrder = If(ViewBag.ResourcesSortType IsNot Nothing, CType(ViewBag.ResourcesSortType, ResourcesSortOrder), 0)

                        Select Case (sortOrder)
                            Case ResourcesSortOrder.None
                                Return
                            Case ResourcesSortOrder.Ascending
                                comparer = New ResourceCaptionComparer()
                            Case ResourcesSortOrder.Descending
                                comparer = New ResourceCaptionReverseComparer()
                            Case ResourcesSortOrder.NOfAppointments
                                comparer = New ResourceNOfAppointmentsComparer(storage)
                          
                        End Select

                        storage.Resources.Items.Sort(comparer)
                End Sub

            settings.Start = New DateTime(2012, 4, 18)
            settings.ClientSideEvents.BeginCallback = "function(s, e) { e.customArgs['ResourcesSortType'] = ResourcesSortType.GetValue(); }"

    End Sub).Bind(Model.Appointments, Model.Resources).GetHtml()