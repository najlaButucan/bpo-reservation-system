Public Class overall_sched_form

    Private Sub b_reservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        reservation_form.Show()
    End Sub

    Private Sub close_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        reservation_form.Close()
        reserved_materials_form.Close()
        student_event_form.Close()
        edit_reservation_form.Close()
        home_form.Close()
    End Sub

    Private Sub b_edit_reservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        edit_reservation_form.Show()
    End Sub

    Private Sub b_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        home_form.Show()
    End Sub

    Private Sub b_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        about_form.Show()
    End Sub

    Private Sub b_ovaerall_sched_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub overall_sched_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Dim DisplayedMonth As Integer = Now.Month
    Dim DisplayedYear As Integer = Now.Year
    Dim i As Integer = Now.Month
    Dim Incremental_i As Integer = Now.Month
    Dim Decremental_i As Integer = Now.Month
    Dim yearNr As Integer = Now.Year
    Dim ArrowRight As Boolean = False
    Dim ArrowLeft As Boolean = False
    Dim PastYear As Integer = 0

    Function YearDecrement() As Integer
        PastYear = PastYear - 1
        Return PastYear
    End Function

    Function YearIncrement() As Integer
        PastYear = PastYear + 1
        Return PastYear
    End Function

    Public Function increment() As Integer
        If i = 12 Then
            i = 1
        Else
            i = i + 1
        End If
        Return i
    End Function

    Public Function decrement() As Integer
        If i = 1 Then
            i = 12
        Else
            i = i - 1
        End If
        Return i
    End Function

    Function getlabel(ByVal day As DayOfWeek, ByVal row As Integer) As Button
        Select Case day
            Case DayOfWeek.Sunday
                Select Case row
                    Case 1
                        Return Sunday1
                    Case 2
                        Return Sunday2
                    Case 3
                        Return Sunday3
                    Case 4
                        Return Sunday4
                    Case 5
                        Return Sunday5
                    Case 6
                        Return Sunday6
                End Select
            Case DayOfWeek.Monday
                Select Case row
                    Case 1
                        Return Monday1
                    Case 2
                        Return Monday2
                    Case 3
                        Return Monday3
                    Case 4
                        Return Monday4
                    Case 5
                        Return Monday5
                    Case 6
                        Return Monday6
                End Select
            Case DayOfWeek.Tuesday
                Select Case row
                    Case 1
                        Return Tuesday1
                    Case 2
                        Return Tuesday2
                    Case 3
                        Return Tuesday3
                    Case 4
                        Return Tuesday4
                    Case 5
                        Return Tuesday5
                    Case 6
                        Return Tuesday6
                End Select
            Case DayOfWeek.Wednesday
                Select Case row
                    Case 1
                        Return Wednesday1
                    Case 2
                        Return Wednesday2
                    Case 3
                        Return Wednesday3
                    Case 4
                        Return Wednesday4
                    Case 5
                        Return Wednesday5
                    Case 6
                        Return Wednesday6
                End Select
            Case DayOfWeek.Thursday
                Select Case row
                    Case 1
                        Return Thursday1
                    Case 2
                        Return Thursday2
                    Case 3
                        Return Thursday3
                    Case 4
                        Return Thursday4
                    Case 5
                        Return Thursday5
                    Case 6
                        Return Thursday6
                End Select
            Case DayOfWeek.Friday
                Select Case row
                    Case 1
                        Return Friday1
                    Case 2
                        Return Friday2
                    Case 3
                        Return Friday3
                    Case 4
                        Return Friday4
                    Case 5
                        Return Friday5
                    Case 6
                        Return Friday6
                End Select
            Case DayOfWeek.Saturday
                Select Case row
                    Case 1
                        Return Saturday1
                    Case 2
                        Return Saturday2
                    Case 3
                        Return Saturday3
                    Case 4
                        Return Saturday4
                    Case 5
                        Return Saturday5
                    Case 6
                        Return Saturday6
                End Select
        End Select
    End Function

    Private Sub HideEmptyButtons()
        Sunday1.Visible = Sunday1.Text <> ""
        Sunday2.Visible = Sunday2.Text <> ""
        Sunday3.Visible = Sunday3.Text <> ""
        Sunday4.Visible = Sunday4.Text <> ""
        Sunday5.Visible = Sunday5.Text <> ""
        Sunday6.Visible = Sunday6.Text <> ""
        Monday1.Visible = Monday1.Text <> ""
        Monday2.Visible = Monday2.Text <> ""
        Monday3.Visible = Monday3.Text <> ""
        Monday4.Visible = Monday4.Text <> ""
        Monday5.Visible = Monday5.Text <> ""
        Monday6.Visible = Monday6.Text <> ""
        Tuesday1.Visible = Tuesday1.Text <> ""
        Tuesday2.Visible = Tuesday2.Text <> ""
        Tuesday3.Visible = Tuesday3.Text <> ""
        Tuesday4.Visible = Tuesday4.Text <> ""
        Tuesday5.Visible = Tuesday5.Text <> ""
        Tuesday6.Visible = Tuesday6.Text <> ""
        Wednesday1.Visible = Wednesday1.Text <> ""
        Wednesday2.Visible = Wednesday2.Text <> ""
        Wednesday3.Visible = Wednesday3.Text <> ""
        Wednesday4.Visible = Wednesday4.Text <> ""
        Wednesday5.Visible = Wednesday5.Text <> ""
        Wednesday6.Visible = Wednesday6.Text <> ""
        Thursday1.Visible = Thursday1.Text <> ""
        Thursday2.Visible = Thursday2.Text <> ""
        Thursday3.Visible = Thursday3.Text <> ""
        Thursday4.Visible = Thursday4.Text <> ""
        Thursday5.Visible = Thursday5.Text <> ""
        Thursday6.Visible = Thursday6.Text <> ""
        Friday1.Visible = Friday1.Text <> ""
        Friday2.Visible = Friday2.Text <> ""
        Friday3.Visible = Friday3.Text <> ""
        Friday4.Visible = Friday4.Text <> ""
        Friday5.Visible = Friday5.Text <> ""
        Friday6.Visible = Friday6.Text <> ""
        Saturday1.Visible = Saturday1.Text <> ""
        Saturday2.Visible = Saturday2.Text <> ""
        Saturday3.Visible = Saturday3.Text <> ""
        Saturday4.Visible = Saturday4.Text <> ""
        Saturday5.Visible = Saturday5.Text <> ""
        Saturday6.Visible = Saturday6.Text <> ""
    End Sub

    Function MonthNameText(ByRef MonthToDisplay As Integer) As String
        Dim GetDisplayedMonth As String
        GetDisplayedMonth = Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(MonthToDisplay)
        Return GetDisplayedMonth
    End Function

    Sub clearall()
        Sunday1.Text = ""
        Sunday2.Text = ""
        Sunday3.Text = ""
        Sunday4.Text = ""
        Sunday5.Text = ""
        Sunday6.Text = ""
        Monday1.Text = ""
        Monday2.Text = ""
        Monday3.Text = ""
        Monday4.Text = ""
        Monday5.Text = ""
        Monday6.Text = ""
        Tuesday1.Text = ""
        Tuesday2.Text = ""
        Tuesday3.Text = ""
        Tuesday4.Text = ""
        Tuesday5.Text = ""
        Tuesday6.Text = ""
        Wednesday1.Text = ""
        Wednesday2.Text = ""
        Wednesday3.Text = ""
        Wednesday4.Text = ""
        Wednesday5.Text = ""
        Wednesday6.Text = ""
        Thursday1.Text = ""
        Thursday2.Text = ""
        Thursday3.Text = ""
        Thursday4.Text = ""
        Thursday5.Text = ""
        Thursday6.Text = ""
        Friday1.Text = ""
        Friday2.Text = ""
        Friday3.Text = ""
        Friday4.Text = ""
        Friday5.Text = ""
        Friday6.Text = ""
        Saturday1.Text = ""
        Saturday2.Text = ""
        Saturday3.Text = ""
        Saturday4.Text = ""
        Saturday5.Text = ""
        Saturday6.Text = ""
    End Sub

    Private Function GetFirstOfMonthDay(ByVal ThisDay As Date) As DayOfWeek
        Dim tday As DayOfWeek = ThisDay.DayOfWeek
        Dim tint As Integer = ThisDay.Day
        If tint = 1 Then
            Return tday
            Exit Function
        End If
        Do
            tint -= 1
            tday = ydate(tday)
            If tint = 1 Then Exit Do
        Loop
        Return tday
    End Function

    Private Function ydate(ByVal tday As DayOfWeek) As DayOfWeek
        Dim rday As DayOfWeek
        Select Case tday
            Case DayOfWeek.Sunday
                rday = DayOfWeek.Saturday
            Case DayOfWeek.Monday
                rday = DayOfWeek.Sunday
            Case DayOfWeek.Tuesday
                rday = DayOfWeek.Monday
            Case DayOfWeek.Wednesday
                rday = DayOfWeek.Tuesday
            Case DayOfWeek.Thursday
                rday = DayOfWeek.Wednesday
            Case DayOfWeek.Friday
                rday = DayOfWeek.Thursday
            Case DayOfWeek.Saturday
                rday = DayOfWeek.Friday
        End Select
        Return rday
    End Function

    Private Function tdate(ByVal tday As DayOfWeek) As DayOfWeek
        Dim rday As DayOfWeek
        Select Case tday
            Case DayOfWeek.Sunday
                rday = DayOfWeek.Monday
            Case DayOfWeek.Monday
                rday = DayOfWeek.Tuesday
            Case DayOfWeek.Tuesday
                rday = DayOfWeek.Wednesday
            Case DayOfWeek.Wednesday
                rday = DayOfWeek.Thursday
            Case DayOfWeek.Thursday
                rday = DayOfWeek.Friday
            Case DayOfWeek.Friday
                rday = DayOfWeek.Saturday
            Case DayOfWeek.Saturday
                rday = DayOfWeek.Sunday
        End Select
        Return rday
    End Function


    Private Sub MonthForward_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MonthForward.Click
        DisplayedMonth = increment()
        ArrowRight = True
        Dim IncrementMonth As Date = Now.AddDays((Now.Day - 1) * -1).AddMonths(i - Now.Month)
        If (DisplayedMonth = 12) And (ArrowRight = True) Then
            YearIncrement()
            IncrementMonth = Now.AddDays((Now.Day - 1) * -1).AddMonths(i - Now.Month).AddYears(PastYear)
        End If
        If PastYear <> 0 Then
            IncrementMonth = Now.AddDays((Now.Day - 1) * -1).AddMonths(i - Now.Month).AddYears(PastYear)
        End If
        ReloadCal(IncrementMonth, 0)
        If (DisplayedMonth = 1) And (ArrowRight = True) Then
            yearNr = yearNr + 1
        End If
        ArrowRight = False
        MonthName.Text = MonthNameText(DisplayedMonth)
        HideEmptyButtons()
        YearNumber.Text = yearNr
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MonthBackward.Click
        DisplayedMonth = decrement()
        ArrowLeft = True
        Dim DecrementMonth As Date = Now.AddDays((Now.Day - 1) * -1).AddMonths(i - Now.Month)
        If (DisplayedMonth = 12) And (ArrowLeft = True) Then
            YearDecrement()
            DecrementMonth = Now.AddDays((Now.Day - 1) * -1).AddMonths(i - Now.Month).AddYears(PastYear)
        End If
        If PastYear <> 0 Then
            DecrementMonth = Now.AddDays((Now.Day - 1) * -1).AddMonths(i - Now.Month).AddYears(PastYear)
        End If
        ReloadCal(DecrementMonth, 0)
        If (DisplayedMonth = 12) And (ArrowLeft = True) Then
            yearNr = yearNr - 1
        End If
        ArrowLeft = False
        MonthName.Text = MonthNameText(DisplayedMonth)
        HideEmptyButtons()
        YearNumber.Text = yearNr
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles YearBackward.Click
        yearNr = yearNr - 1
        YearDecrement()
        Dim DecrementMonth As Date = Now.AddDays((Now.Day - 1) * -1).AddMonths(i - Now.Month).AddYears(PastYear)
        ReloadCal(DecrementMonth, 0)
        MonthName.Text = MonthNameText(DisplayedMonth)
        YearNumber.Text = yearNr
        HideEmptyButtons()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles YearForward.Click
        yearNr = yearNr + 1
        YearIncrement()
        Dim IncrementMonth As Date = Now.AddDays((Now.Day - 1) * -1).AddMonths(i - Now.Month).AddYears(PastYear)
        ReloadCal(IncrementMonth, 0)
        MonthName.Text = MonthNameText(DisplayedMonth)
        YearNumber.Text = yearNr
        HideEmptyButtons()
    End Sub
    Public Sub ReloadCal(ByVal ldate As Date, ByVal Selected As Integer)
        On Error Resume Next
        Me.clearall()
        Dim fdate As DayOfWeek = GetFirstOfMonthDay(ldate)
        Dim idate As Integer = 1
        Dim row As Integer = 1
        Do
            getlabel(fdate, row).Text = idate
            If idate = Selected Then
                getlabel(fdate, row).BackColor = Color.Goldenrod
            End If
            If fdate = DayOfWeek.Saturday Then
                row += 1
            End If
            fdate = tdate(fdate)
            idate += 1
            If idate = Date.DaysInMonth((ldate).Year, (ldate).Month) + 1 Then
                Exit Do
            End If
        Loop
        MonthName.Text = MonthNameText(ldate.Month)
    End Sub

    Private Sub CalendarControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReloadCal(Date.Today, Date.Today.Day)
        YearNumber.Text = Now.Year
        HideEmptyButtons()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
