Imports System.Speech

Public Class Form1
    Shared gram As New Recognition.SrgsGrammar.SrgsDocument

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.firstlaunch = True Then
            MsgBox("Please fill in the Day Type box with 'odd only', 'even only', or 'all' for the program to work properly (you can aldo use individual class join options). Also be sure to open and fill the text boxes in the settings page or else it will not work")
        End If

        If My.Forms.FormHelp.TextBox19.Text = "" Then
            My.Forms.FormHelp.TextBox19.Text = "Please Fill"
        End If

        reco.SetInputToDefaultAudioDevice()

        Dim gRule As New Recognition.SrgsGrammar.SrgsRule("bandon")

        Dim Glist As New Recognition.SrgsGrammar.SrgsOneOf(My.Settings.keyphrase)

        gRule.Add(Glist)

        gram.Rules.Add(gRule)

        gram.Root = gRule

        reco.LoadGrammar(New Recognition.Grammar(gram))

        reco.RecognizeAsync()

        My.Settings.firstlaunch = False

        CheckBox1.Checked = My.Settings.alwaysontop

        CheckBox2.Checked = My.Settings.listen

        My.Settings.firstlaunch = False

        If My.Settings.lagged = True Then
            Button2.Text = "Stop Lagging"
        End If

    End Sub
    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        reco.RecognizeAsync()

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        If CheckBox2.Checked = True Then
            If My.Settings.fakelag = True Then
                If InStr(e.Result.Text, My.Forms.FormHelp.TextBox19.Text) Then
                    If My.Forms.FormHelp.TextBox22.Text IsNot "" Then
                        If e.Result.Confidence > "0." + My.Forms.FormHelp.TextBox22.Text Then
                            Form4.Show()
                            My.Settings.dolag = True
                        End If
                    Else
                        Form4.Show()
                        My.Settings.dolag = True

                    End If

                End If

            Else
                If InStr(e.Result.Text, My.Forms.FormHelp.TextBox19.Text) Then
                    If My.Forms.FormHelp.TextBox22.Text IsNot "" Then
                        If e.Result.Confidence > "0." + My.Forms.FormHelp.TextBox22.Text Then
                            My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                            Threading.Thread.Sleep(500)
                            My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                            Threading.Thread.Sleep(500)
                            My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                            Threading.Thread.Sleep(500)
                            My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                            Threading.Thread.Sleep(500)
                            My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                            Threading.Thread.Sleep(500)
                            My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                            Threading.Thread.Sleep(500)
                            My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                            Threading.Thread.Sleep(500)
                        End If
                    Else
                        My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                        Threading.Thread.Sleep(500)
                        My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                        Threading.Thread.Sleep(500)
                        My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                        Threading.Thread.Sleep(500)
                        My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                        Threading.Thread.Sleep(500)
                        My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                        Threading.Thread.Sleep(500)
                        My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                        Threading.Thread.Sleep(500)
                        My.Computer.Audio.Play("C:\Windows\Media\Windows Hardware Fail.wav")
                        Threading.Thread.Sleep(500)
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If dtype.Text = "odd only" Then
            If TimeOfDay = My.Settings.p1stime Then
                System.Diagnostics.Process.Start(My.Settings.p1link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p1chatcheck()
            ElseIf TimeOfDay = My.Settings.p3stime Then
                System.Diagnostics.Process.Start(My.Settings.p3link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p3chatcheck()
            ElseIf TimeOfDay = My.Settings.p5stime Then
                System.Diagnostics.Process.Start(My.Settings.p5link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p5chatcheck()
            End If
        ElseIf dtype.Text = "even only" Then
            If TimeOfDay = My.Settings.p2stime Then
                System.Diagnostics.Process.Start(My.Settings.p2link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p2chatcheck()
            ElseIf TimeOfDay = My.Settings.p4stime Then
                System.Diagnostics.Process.Start(My.Settings.p4link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p4chatcheck()
            ElseIf TimeOfDay = My.Settings.p6stime Then
                System.Diagnostics.Process.Start(My.Settings.p6link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p6chatcheck()
            End If
        ElseIf dtype.Text = "all" Then
            If TimeOfDay = My.Settings.p1stime Then
                System.Diagnostics.Process.Start(My.Settings.p1link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p1chatcheck()
            ElseIf TimeOfDay = My.Settings.p3stime Then
                System.Diagnostics.Process.Start(My.Settings.p3link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p3chatcheck()
            ElseIf TimeOfDay = My.Settings.p5stime Then
                System.Diagnostics.Process.Start(My.Settings.p5link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p5chatcheck()
            ElseIf TimeOfDay = My.Settings.p2stime Then
                System.Diagnostics.Process.Start(My.Settings.p2link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p2chatcheck()
            ElseIf TimeOfDay = My.Settings.p4stime Then
                System.Diagnostics.Process.Start(My.Settings.p4link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p4chatcheck()
            ElseIf TimeOfDay = My.Settings.p6stime Then
                System.Diagnostics.Process.Start(My.Settings.p6link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p6chatcheck()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If dtype.Text = "odd only" Then
            If TimeOfDay = My.Settings.p1endtime Then
                My.Computer.Keyboard.SendKeys("^+w")
            ElseIf TimeOfDay = My.Settings.p3endtime Then
                My.Computer.Keyboard.SendKeys("^+w")
            ElseIf TimeOfDay = My.Settings.p5endtime Then
                My.Computer.Keyboard.SendKeys("^+w")
            End If
        ElseIf dtype.Text = "even only" Then
            If TimeOfDay = My.Settings.p2endtime Then
                My.Computer.Keyboard.SendKeys("^+w")
            ElseIf TimeOfDay = My.Settings.p4endtime Then
                My.Computer.Keyboard.SendKeys("^+w")
            ElseIf TimeOfDay = My.Settings.p6endtime Then
                My.Computer.Keyboard.SendKeys("^+w")
            End If
        End If
    End Sub

    Private Sub helpbutton_Click(sender As Object, e As EventArgs) Handles helpbutton.Click
        FormHelp.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dtype.Text.ToLower = "even only" Then
            MsgBox("Good job, all should work properly.")
        ElseIf dtype.Text.ToLower = "odd only" Then
            MsgBox("Good job, all should work properly.")
        ElseIf dtype.Text.ToLower = "all" Then
            MsgBox("Good job, all should work properly.")
        Else
            MsgBox("Try again, this configuration will cause the program to not work. please enter 'even only', 'all', or 'odd only'.")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TopMost = True
            FormHelp.TopMost = True
            My.Settings.alwaysontop = True
        Else
            Me.TopMost = False
            FormHelp.TopMost = False
            My.Settings.alwaysontop = False
        End If

    End Sub
    Public Sub cammicjoin()
        Threading.Thread.Sleep(10000)
        My.Computer.Keyboard.SendKeys("^e")
        Threading.Thread.Sleep(1000)
        My.Computer.Keyboard.SendKeys("^d")
        Threading.Thread.Sleep(1000)
        My.Computer.Keyboard.SendKeys("^f")
        Threading.Thread.Sleep(1000)
        My.Computer.Keyboard.SendKeys("join now")
        Threading.Thread.Sleep(1000)
        My.Computer.Keyboard.SendKeys("{esc}")
        Threading.Thread.Sleep(1000)
        My.Computer.Keyboard.SendKeys("{enter}")
    End Sub

#Region "discovery avoidance"

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            My.Settings.listen = True
        Else
            My.Settings.listen = False
        End If
    End Sub
    Public Sub sendattendance()
        My.Computer.Keyboard.SendKeys(My.Settings.chmessage)
        Threading.Thread.Sleep(500)
        My.Computer.Keyboard.SendKeys("{enter}")
    End Sub
    Public Sub p1chatcheck()
        If My.Settings.p1chatattendance = True Then
            Threading.Thread.Sleep(My.Settings.timetowait)
            openchat()
            sendattendance()
        End If
    End Sub

    Public Sub p2chatcheck()
        If My.Settings.p2chatattendance = True Then
            Threading.Thread.Sleep(My.Settings.timetowait)
            openchat()
            sendattendance()
        End If
    End Sub

    Public Sub p3chatcheck()
        If My.Settings.p3chatattendance = True Then
            Threading.Thread.Sleep(My.Settings.timetowait)
            openchat()
            sendattendance()
        End If
    End Sub

    Public Sub p4chatcheck()
        If My.Settings.p4chatattendance = True Then
            Threading.Thread.Sleep(My.Settings.timetowait)
            openchat()
            sendattendance()
        End If
    End Sub

    Public Sub p5chatcheck()
        If My.Settings.p5chatattendance = True Then
            Threading.Thread.Sleep(My.Settings.timetowait)
            openchat()
            sendattendance()
        End If
    End Sub
    Public Sub p6chatcheck()
        If My.Settings.p6chatattendance = True Then
            Threading.Thread.Sleep(My.Settings.timetowait)
            openchat()
            sendattendance()
        End If
    End Sub

    Public Sub openchat()
        My.Computer.Keyboard.SendKeys("^%{c}")
        Threading.Thread.Sleep(1000)
        'lol its really not that complex just didnt want to reuse lines a ton. Edit 2/20/21 8:13 PM: yeah as if I didn't do that already
    End Sub

#End Region

    Private Sub gramadd_Click(sender As Object, e As EventArgs) Handles grammadd.Click
        reco.UnloadAllGrammars()

        Dim Glist As New Recognition.SrgsGrammar.SrgsOneOf(My.Forms.FormHelp.TextBox19.Text)

        reco.LoadGrammar(New Recognition.Grammar(gram))
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If My.Settings.mp1 = True Then
            If TimeOfDay = My.Settings.p1stime Then
                System.Diagnostics.Process.Start(My.Settings.p1link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p1chatcheck()
            End If
        ElseIf My.Settings.mp2 = True Then
            If TimeOfDay = My.Settings.p2stime Then
                System.Diagnostics.Process.Start(My.Settings.p2link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p2chatcheck()
            End If
        ElseIf My.Settings.mp3 = True Then
            If TimeOfDay = My.Settings.p3stime Then
                System.Diagnostics.Process.Start(My.Settings.p3link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p3chatcheck()
            End If
        ElseIf My.Settings.mp4 = True Then
            If TimeOfDay = My.Settings.p4stime Then
                System.Diagnostics.Process.Start(My.Settings.p4link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p4chatcheck()
            End If
        ElseIf My.Settings.mp5 = True Then
            If TimeOfDay = My.Settings.p5stime Then
                System.Diagnostics.Process.Start(My.Settings.p5link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p5chatcheck()
            End If
        ElseIf My.Settings.mp6 = True Then
            If TimeOfDay = My.Settings.p6stime Then
                System.Diagnostics.Process.Start(My.Settings.p6link)
                cammicjoin()
                Threading.Thread.Sleep(1000)
                p6chatcheck()
            End If
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If My.Settings.mp1 = True Then
            If TimeOfDay = My.Settings.p1endtime Then
                My.Computer.Keyboard.SendKeys("^+w")
            End If
        ElseIf My.Settings.mp3 = True Then
            If TimeOfDay = My.Settings.p3endtime Then
                My.Computer.Keyboard.SendKeys("^+w")
            End If
        ElseIf My.Settings.mp5 = True Then
            If TimeOfDay = My.Settings.p5endtime Then
                My.Computer.Keyboard.SendKeys("^+w")
            End If
        ElseIf My.Settings.mp2 = True Then
            If TimeOfDay = My.Settings.p2endtime Then
                My.Computer.Keyboard.SendKeys("^+w")
            End If
        ElseIf My.Settings.mp4 = True Then
            If TimeOfDay = My.Settings.p4endtime Then
                My.Computer.Keyboard.SendKeys("^+w")
            End If
        ElseIf My.Settings.mp6 = True Then
            If TimeOfDay = My.Settings.p6endtime Then
                My.Computer.Keyboard.SendKeys("^+w")
            End If
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If My.Settings.dolag = True Then
            Shell("ipconfig /release")
            Threading.Thread.Sleep(2000)
            If My.Settings.dolag = True Then
                Shell("ipconfig /renew")
                Threading.Thread.Sleep(4000)
            End If
            If My.Settings.dolag = True Then
                Shell("ipconfig /release")
                Threading.Thread.Sleep(2000)
                If My.Settings.dolag = True Then
                    Shell("ipconfig /renew")
                    Threading.Thread.Sleep(4000)
                End If
                If My.Settings.dolag = True Then
                    Shell("ipconfig /release")
                    Threading.Thread.Sleep(2000)
                    If My.Settings.dolag = True Then
                        Shell("ipconfig /renew")
                        Threading.Thread.Sleep(2000)
                    End If
                End If
            End If
        End If
        My.Settings.dolag = False
        Form4.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Settings.lagged = False Then
            My.Settings.lagged = True
            Shell("ipconfig /release")
            Button2.Text = "Stop Lagging"
            'Please do NOT use this as a video game lag switch. If you are looking for that I have an open source one with a built in keybind on my GitHub.
        Else
            My.Settings.lagged = False
            Shell("ipconfig /renew")
            Button2.Text = "Lag"
        End If

    End Sub
End Class