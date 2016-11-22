Imports WHLClasses
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScanTarget.Focus()
        ScanTarget.Clear()
        Setmode(Modes.View)
    End Sub

    Private Sub Log(Text As String)
        If Text.Length > 27 Then
            History.Text = Text.Remove(27) + vbNewLine + History.Text
        Else
            History.Text = Text + vbNewLine + History.Text
        End If

    End Sub

    Private Function Dialog(Question As String, Optional YesNo As Boolean = False) As DialogResult
        Dim Window As New YesNoDialog
        Window.Instruction.Text = Question
        If YesNo Then
            Window.YesButton.Visible = True
            Window.NoButton.Visible = True
            Window.CancelButton.Visible = True
            Window.OKButton.Visible = False
        Else
            Window.YesButton.Visible = False
            Window.NoButton.Visible = False
            Window.CancelButton.Visible = False
            Window.OKButton.Visible = True
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        End If
        Dim response As DialogResult = Window.ShowDialog
        Return response
    End Function

    Private Sub ProcessScan(Scantext As String)
        If Scantext.StartsWith("qzu") Then
            'Employee Sign in.
            Try
                Dim emp As Employee = Emps.FindEmployeeByID(Convert.ToInt32(Scantext.Replace("qzu", "")))
                If emp.Permissions.SaveChangesToSKU Then
                    Instruct("Scan an item")
                    Authd = emp
                    Log(emp.FullName + " Logged in.")
                Else
                    Authd = Nothing
                    Instruct("User does not have permission to use this utility. Scan a valid user ID.", True)
                End If
            Catch ex As Exception
                Instruct("User not found. Check what you scanned.", True)
            End Try
        ElseIf Scantext.StartsWith("qzm") Then
            Setmode(Convert.ToInt32(Scantext.Replace("qzm", "")))
        Else
            If IsNothing(Authd) Then
                Instruct("You need to scan your ID card before you can continue.", True)
            Else
                Select Case Curmode
                    Case Modes.Pick
                        If Scantext.StartsWith("qlo") And IsNothing(Activeitem) Then
                            Dialog("You must scan an item before scanning a shelf.")
                        ElseIf Scantext.StartsWith("qlo") And Not IsNothing(Activeitem) Then
                            'Change the picking location if the existing one isnt warehouse 2
                            Dim Newloc As Lookupresult = Lookup(Scantext.Replace("qlo", "").TrimStart("0"))
                            If Newloc.type = SKULocation.SKULocationType.Pickable Then
                                Try
                                    'If Activeitem(0).GetLocation(SKULocation.SKULocationType.Pickable).WarehouseID = 2 Then
                                    '    Dialog("This warehouse already contains this item at " + Activeitem(0).GetLocation(SKULocation.SKULocationType.Pickable).LocationText)
                                    'Else
                                    For Each item As WhlSKU In Activeitem
                                        Dim old As SKULocation = item.GetLocation(SKULocation.SKULocationType.Pickable)
                                        item.RemoveLocation(item.GetLocation(SKULocation.SKULocationType.Pickable).LocationID, Authd)
                                        Try
                                            'Remove any additional ones.
                                            item.RemoveLocation(item.GetLocation(SKULocation.SKULocationType.Pickable).LocationID, Authd)
                                            item.RemoveLocation(item.GetLocation(SKULocation.SKULocationType.Pickable).LocationID, Authd)
                                            item.RemoveLocation(item.GetLocation(SKULocation.SKULocationType.Pickable).LocationID, Authd)
                                            item.RemoveLocation(item.GetLocation(SKULocation.SKULocationType.Pickable).LocationID, Authd)
                                        Catch ex As Exception

                                        End Try
                                        item.AddNewLocation(Convert.ToInt32(Newloc.ID), Authd)
                                        If item.PackSize > 0 Then
                                            item.Title.Invoice = item.GetLocation(SKULocation.SKULocationType.Pickable).LocationText + item.Title.Invoice.Substring(6)
                                        End If
                                        item.SaveChanges(Authd, "LocMod (PICK): " + old.LocationText + " To " + Newloc.text)
                                        item.SetGroupStatus("Special", Authd, "LocMod (PICK): " + old.LocationText + " To " + Newloc.text)

                                    Next
                                    Log(Activeitem(0).ShortSku + " Pick:  " = Newloc.text)
                                    ShowItemDetails(Activeitem)
                                    'End If
                                Catch ex As NullReferenceException
                                    For Each item As WhlSKU In Activeitem
                                        item.AddNewLocation(Convert.ToInt32(Newloc.ID), Authd)

                                        If item.PackSize > 0 Then
                                            item.Title.Invoice = item.GetLocation(SKULocation.SKULocationType.Pickable).LocationText + item.Title.Invoice.Substring(6)
                                        End If
                                        item.SaveChanges(Authd, "LocMod (PICK): Added " + Newloc.text)
                                        item.SetGroupStatus("Special", Authd, "LocMod (PICK): " + Newloc.text)

                                    Next
                                    ShowItemDetails(Activeitem)
                                    Log(Activeitem(0).ShortSku + " Pick: " = Newloc.text)
                                End Try

                            Else
                                Dialog("This is not a picking location.")
                            End If
                            'Reset stuff for future.
                            Activeitem = Nothing
                            Instruct("Scan an item")
                        Else
                            Try
                                Dim scanresponse As WhlSKU = skus.SearchSKUS(Scantext, True)(0)
                                Dim kids As SkuCollection = skus.GatherChildren(scanresponse.ShortSku)
                                Activeitem = kids
                                ShowItemDetails(kids)
                                Instruct("Scan a shelf")
                            Catch ex As Exception
                                Dialog("Could not find any items.")
                            End Try
                        End If
                    Case Modes.Store
                        If Scantext.StartsWith("qlo") And IsNothing(Activeitem) Then
                            Dialog("You must scan an item before scanning a shelf.")
                        ElseIf Scantext.StartsWith("qlo") And Not IsNothing(Activeitem) Then
                            'Change the picking location if the existing one isnt warehouse 2
                            Dim Newloc As Lookupresult = Lookup(Scantext.Replace("qlo", "").TrimStart("0"))
                            If Newloc.type = SKULocation.SKULocationType.Storage Then
                                For Each item As WhlSKU In Activeitem
                                    item.AddNewLocation(Convert.ToInt32(Newloc.ID), Authd)
                                    'StoreLocations.Text += Newloc.text
                                    item.RecordChangelog(Authd, "LocMod (STOR): Added " + Newloc.text)
                                Next
                                ShowItemDetails(Activeitem)

                                Log(Activeitem(0).ShortSku + " Store +: " = Newloc.text)

                            Else
                                Dialog("This is not a storage location.")
                            End If
                            'Reset stuff for future.
                            Activeitem = Nothing
                            Instruct("Scan an item")
                        Else
                            Try
                                Dim scanresponse As WhlSKU = skus.SearchSKUS(Scantext, True)(0)
                                Dim kids As SkuCollection = skus.GatherChildren(scanresponse.ShortSku)
                                Activeitem = kids
                                ShowItemDetails(kids)
                                Instruct("Scan a shelf")
                            Catch ex As Exception
                                Dialog("Could not find any items.")
                            End Try
                        End If
                    Case Modes.View
                        If Scantext.StartsWith("qlo") Then
                            Dim Check As Lookupresult = Lookup(Scantext.Replace("qlo", "").TrimStart("0"))
                            If Not IsNothing(Check) Then
                                Instruct("Items stored at " + Check.text + ": ")
                                Dim results As SkuCollection = skus.SearchLocationIDs(Convert.ToInt32(Check.ID)).MakeMixdown
                                Dim ResultString As String = ""
                                For Each result As WhlSKU In results
                                    ResultString += result.ShortSku + ": " + result.Title.Label + vbNewLine
                                Next
                                ItemDetails.Text = ResultString
                            End If
                        Else
                            Dim scanresponse As WhlSKU = skus.SearchSKUS(Scantext, True)(0)
                            Dim kids As SkuCollection = skus.GatherChildren(scanresponse.ShortSku)
                            If kids.Count > 0 Then
                                ShowItemDetails(kids)
                            Else
                                Dialog("Could not find any items with that code.")
                            End If
                        End If
                        Instruct("Scan an item or shelf, or scan a mode switch")
                End Select
                'Main code path.
                'If Scantext.StartsWith("qlo") Then
                '    'It's a location.
                '    If IsNothing(Activeitem) Then
                '        Instruct("You must scan an item.", True)
                '    Else
                '        'Lookup and save location
                '        Dim Check As ArrayList = MySQL.SelectData("SELECT * FROM whldata.locationreference WHERE locID=" + Scantext.Replace("qlo", "").TrimStart("0") + " LIMIT 1;")
                '        If Check.Count = 1 Then
                '            Dim Location As String = Check(0)(1)

                '            Dim Changed As Boolean = False
                '            'Check the item to see if the location is already on there

                '            Dim exists As Boolean = False
                '            For Each loc As SKULocation In Activeitem(0).Locations
                '                If Scantext.Replace("qlo", "").TrimStart("0") = loc.LocationID.ToString Then
                '                    exists = True
                '                End If
                '            Next

                '            If Not exists Then
                '                If Dialog("Do you want to add " + Location + " to item " + Activeitem(0).Title.Label + "?", True) = vbYes Then
                '                    For Each item As WhlSKU In Activeitem
                '                        item.AddNewLocation(Convert.ToInt32(Scantext.Replace("qlo", "").TrimStart("0")), Authd)
                '                        Log(Location + " Added to " + item.SKU)
                '                        If item.PackSize > 0 Then
                '                            item.Title.Invoice = item.GetLocation(SKULocation.SKULocationType.Pickable).LocationText + item.Title.Invoice.Substring(6)
                '                        End If
                '                        item.SaveChanges(Authd, "Title updated for item with Location Modifier")
                '                        Changed = True
                '                    Next
                '                End If
                '            Else
                '                If Dialog("Do you want to remove " + Location + " from item " + Activeitem(0).Title.Label + "?", True) = vbYes Then
                '                    For Each item As WhlSKU In Activeitem
                '                        item.RemoveLocation(Convert.ToInt32(Scantext.Replace("qlo", "").TrimStart("0")), Authd)
                '                        Log(Location + " Removed from " + item.SKU)
                '                        If item.PackSize > 0 Then
                '                            item.Title.Invoice = item.GetLocation(SKULocation.SKULocationType.Pickable).LocationText + item.Title.Invoice.Substring(6)
                '                        End If
                '                        item.SaveChanges(Authd, "Title updated for item with Location Modifier")
                '                        Changed = True
                '                    Next
                '                End If
                '            End If

                '            Activeitem(0).SetGroupStatus("Special", Authd, "Location Modifier modified item")
                '            Instruct("Scan new item or location")
                '        Else
                '            Instruct("Location reference could not be found. Try again.")
                '        End If

                '    End If
                'Else
                '    'It's not a location.
                '    Try
                '        Dim scanresponse As WhlSKU = skus.SearchSKUS(Scantext, True)(0)
                '        Dim kids As SkuCollection = skus.GatherChildren(scanresponse.ShortSku)
                '        Instruct("Scan a location")
                '        Activeitem = kids

                '        Log("Scanned (" + kids.Count.ToString + " rels.) " + scanresponse.Title.Label)
                '        'Update Item details

                '        ItemDetails.Text = "Item: <shortsku> - <rels> Relatives." + vbNewLine + "Label: <label>" + vbNewLine + "Locations: " + vbNewLine
                '        ItemDetails.Text = ItemDetails.Text.Replace("<shortsku>", scanresponse.ShortSku).Replace("<label>", scanresponse.Title.Label).Replace("<rels>", kids.Count.ToString)
                '        Dim Locations As String = ""
                '        For Each child As WhlSKU In kids
                '            Locations += child.SKU + ": "
                '            For Each loc As SKULocation In child.Locations
                '                If loc.LocationType = SKULocation.SKULocationType.Pickable Then
                '                    Locations += loc.LocationText + " "
                '                Else
                '                    Locations += "[" + loc.LocationText + "] "
                '                End If
                '            Next
                '            Locations += vbNewLine
                '        Next
                '        ItemDetails.Text += Locations
                '    Catch ex As Exception
                '        Activeitem = Nothing
                '        Instruct("Unable to detect item. Try another item or restarting the application.")
                '        ItemDetails.Text = ""
                '    End Try
                'End If
            End If
        End If
    End Sub

    Public Sub ShowItemDetails(Items As SkuCollection)
        Dim item As WhlSKU = Items(0)
        ItemDetails.Text = "Item: <shortsku> - <rels> Relatives." + vbNewLine + "Label: <label>" + vbNewLine
        ItemDetails.Text = ItemDetails.Text.Replace("<shortsku>", item.ShortSku).Replace("<label>", item.Title.Label).Replace("<rels>", Items.Count.ToString)
        PickLocation.Text = "Pick: "
        StoreLocations.Text = "Store: "
        'Refersh all the lcoations
        Dim Response As New List(Of String)
        For Each kid As WhlSKU In Items
            Try
                kid.RefreshLocations()
            Catch ex As Exception
                Response.AddRange(kid.SaveChanges(Authd, "Saved so it works with Location Modifier. This hasn\'t been touched since the new system started."))
                kid.FullRefresh()
            End Try

        Next
        If Response.Count > 0 Then
            'MsgBox("This item is so old that it has never been touched by the new system. Here's a log of the save." + vbNewLine + vbNewLine + String.Concat(Response))
        End If
        For Each loc As SKULocation In item.Locations
            If loc.LocationType = SKULocation.SKULocationType.Pickable Then
                PickLocation.Text += loc.LocationText + " "
            Else
                StoreLocations.Text += loc.LocationText + " "
            End If
        Next

    End Sub

    Public Function Lookup(locationID As String) As Lookupresult
        Dim result As ArrayList = MySQL.SelectData("SELECT * FROM whldata.locationreference WHERE locID=" + locationID + " LIMIT 1;")
        If result.Count = 0 Then
            Return Nothing
        Else
            Dim returnable As New Lookupresult
            returnable.ID = result(0)(0)
            returnable.text = result(0)(1).ToString
            If result(0)(3).ToString = "1" Then
                returnable.type = SKULocation.SKULocationType.Pickable
            Else
                returnable.type = SKULocation.SKULocationType.Storage
            End If

            Return returnable
        End If

    End Function

    Public Class Lookupresult
        Public text As String
        Public ID As Integer
        Public type As SKULocation.SKULocationType
    End Class

    Private Sub ResetScan()
        ScanTarget.Clear()
        ScanTarget.Focus()
    End Sub
    Dim Curmode As Modes
    Private Sub Setmode(mode As Modes)
        Curmode = mode
        ModeText.Text = mode.ToString
    End Sub

    Private Sub Instruct(Text As String, Optional nope As Boolean = False)
        Instruction.Text = Text
        If nope Then
            Instruction.ForeColor = Color.FromArgb(255, 200, 200)
        Else
            Instruction.ForeColor = Color.FromArgb(240, 240, 240)
        End If
    End Sub

    Private Sub ScanTarget_KeyUp(sender As Object, e As KeyEventArgs) Handles ScanTarget.KeyUp
        If e.KeyCode = Keys.Enter And ScanTarget.TextLength > 0 Then
            e.SuppressKeyPress = True
            ProcessScan(ScanTarget.Text)
            ResetScan()
        End If
    End Sub

    Dim skus As SkuCollection
    Dim Emps As New EmployeeCollection()
    Dim Authd As Employee
    Dim Activeitem As SkuCollection

    Public Enum Modes
        Pick = 1
        Store = 2
        View = 3
    End Enum


    Private Sub StartTimer_Tick(sender As Object, e As EventArgs) Handles StartTimer.Tick
        StartTimer.Enabled = False
        skus = (New GenericDataController).SmartSkuCollLoad(True)
        ResetScan()
        Instruct("Scan User ID")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        If Dialog("Are you sure you want to quit?", True) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ScanTarget_TextChanged_1(sender As Object, e As EventArgs) Handles ScanTarget.TextChanged

    End Sub
End Class
