Public Class FormHelp
    Public Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub FormHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.p1link
        TextBox2.Text = My.Settings.p2link
        TextBox3.Text = My.Settings.p3link
        TextBox4.Text = My.Settings.p4link
        TextBox5.Text = My.Settings.p5link
        TextBox6.Text = My.Settings.p6link
        TextBox7.Text = My.Settings.p1stime
        TextBox8.Text = My.Settings.p2stime
        TextBox9.Text = My.Settings.p3stime
        TextBox10.Text = My.Settings.p4stime
        TextBox11.Text = My.Settings.p5stime
        TextBox12.Text = My.Settings.p6stime
        TextBox13.Text = My.Settings.p1endtime
        TextBox14.Text = My.Settings.p2endtime
        TextBox15.Text = My.Settings.p3endtime
        TextBox16.Text = My.Settings.p4endtime
        TextBox17.Text = My.Settings.p5endtime
        TextBox18.Text = My.Settings.p6endtime
        TextBox19.Text = My.Settings.keyphrase
        p1chatattendance.Checked = My.Settings.p1chatattendance
        p2chatattendance.Checked = My.Settings.p2chatattendance
        p3chatattendance.Checked = My.Settings.p3chatattendance
        p4chatattendance.Checked = My.Settings.p4chatattendance
        p5chatattendance.Checked = My.Settings.p5chatattendance
        p6chatattendance.Checked = My.Settings.p6chatattendance
        TextBox20.Text = My.Settings.timetowait
        TextBox21.Text = My.Settings.chmessage
        mpcheck.Checked = My.Settings.mpcheck
        mp1.Checked = My.Settings.mp1
        mp2.Checked = My.Settings.mp2
        mp3.Checked = My.Settings.mp3
        mp4.Checked = My.Settings.mp4
        mp5.Checked = My.Settings.mp5
        mp6.Checked = My.Settings.mp6
        CheckBox1.Checked = My.Settings.fakelag
        My.Settings.Reload()
    End Sub

    Public Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.p1link = TextBox1.Text
        My.Settings.p2link = TextBox2.Text
        My.Settings.p3link = TextBox3.Text
        My.Settings.p4link = TextBox4.Text
        My.Settings.p5link = TextBox5.Text
        My.Settings.p6link = TextBox6.Text
        My.Settings.p1stime = TextBox7.Text
        My.Settings.p2stime = TextBox8.Text
        My.Settings.p3stime = TextBox9.Text
        My.Settings.p4stime = TextBox10.Text
        My.Settings.p5stime = TextBox11.Text
        My.Settings.p6stime = TextBox12.Text
        My.Settings.p1endtime = TextBox13.Text
        My.Settings.p2endtime = TextBox14.Text
        My.Settings.p3endtime = TextBox15.Text
        My.Settings.p4endtime = TextBox16.Text
        My.Settings.p5endtime = TextBox17.Text
        My.Settings.p6endtime = TextBox18.Text
        My.Settings.keyphrase = TextBox19.Text
        My.Settings.p1chatattendance = p1chatattendance.Checked
        My.Settings.p2chatattendance = p2chatattendance.Checked
        My.Settings.p3chatattendance = p3chatattendance.Checked
        My.Settings.p4chatattendance = p4chatattendance.Checked
        My.Settings.p5chatattendance = p5chatattendance.Checked
        My.Settings.p6chatattendance = p6chatattendance.Checked
        My.Forms.Form1.grammadd.PerformClick()
        My.Settings.timetowait = TextBox20.Text
        My.Settings.chmessage = TextBox21.Text
        My.Settings.mpcheck = mpcheck.Checked
        My.Settings.mp1 = mp1.Checked
        My.Settings.mp2 = mp2.Checked
        My.Settings.mp3 = mp3.Checked
        My.Settings.mp4 = mp4.Checked
        My.Settings.mp5 = mp5.Checked
        My.Settings.mp6 = mp6.Checked
        My.Settings.fakelag = CheckBox1.Checked
        My.Settings.Save()
    End Sub

    Private Sub mpcheck_CheckedChanged(sender As Object, e As EventArgs) Handles mpcheck.CheckedChanged
        If mpcheck.Checked = True Then
            My.Forms.Form1.Timer1.Stop()
            My.Forms.Form1.Timer2.Stop()
            My.Forms.Form1.Timer3.Start()
            My.Forms.Form1.Timer4.Start()
        Else
            My.Forms.Form1.Timer1.Start()
            My.Forms.Form1.Timer2.Start()
            My.Forms.Form1.Timer3.Stop()
            My.Forms.Form1.Timer4.Stop()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.p1link = "https://google.com"
        My.Settings.p2link = "https://google.com"
        My.Settings.p3link = "https://google.com"
        My.Settings.p4link = "https://google.com"
        My.Settings.p5link = "https://google.com"
        My.Settings.p6link = "https://google.com"
        My.Settings.p1stime = "12:00:00 AM"
        My.Settings.p2stime = "12:00:00 AM"
        My.Settings.p3stime = "12:00:00 AM"
        My.Settings.p4stime = "12:00:00 AM"
        My.Settings.p5stime = "12:00:00 AM"
        My.Settings.p6stime = "12:00:00 AM"
        My.Settings.p1endtime = "12:00:00 AM"
        My.Settings.p2endtime = "12:00:00 AM"
        My.Settings.p3endtime = "12:00:00 AM"
        My.Settings.p4endtime = "12:00:00 AM"
        My.Settings.p5endtime = "12:00:00 AM"
        My.Settings.p6endtime = "12:00:00 AM"
        My.Settings.keyphrase = "Please Fill"
        My.Settings.p1chatattendance = False
        My.Settings.p2chatattendance = False
        My.Settings.p3chatattendance = False
        My.Settings.p4chatattendance = False
        My.Settings.p5chatattendance = False
        My.Settings.p6chatattendance = False
        My.Settings.timetowait = 300000
        My.Settings.chmessage = "sorry im late my wifi wasnt working"
        My.Settings.mpcheck = False
        My.Settings.mp1 = False
        My.Settings.mp2 = False
        My.Settings.mp3 = False
        My.Settings.mp4 = False
        My.Settings.mp5 = False
        My.Settings.mp6 = False
        My.Settings.alwaysontop = False
        My.Settings.listen = False
        My.Settings.fakelag = False


        TextBox1.Text = My.Settings.p1link
        TextBox2.Text = My.Settings.p2link
        TextBox3.Text = My.Settings.p3link
        TextBox4.Text = My.Settings.p4link
        TextBox5.Text = My.Settings.p5link
        TextBox6.Text = My.Settings.p6link
        TextBox7.Text = My.Settings.p1stime
        TextBox8.Text = My.Settings.p2stime
        TextBox9.Text = My.Settings.p3stime
        TextBox10.Text = My.Settings.p4stime
        TextBox11.Text = My.Settings.p5stime
        TextBox12.Text = My.Settings.p6stime
        TextBox13.Text = My.Settings.p1endtime
        TextBox14.Text = My.Settings.p2endtime
        TextBox15.Text = My.Settings.p3endtime
        TextBox16.Text = My.Settings.p4endtime
        TextBox17.Text = My.Settings.p5endtime
        TextBox18.Text = My.Settings.p6endtime
        TextBox19.Text = My.Settings.keyphrase
        p1chatattendance.Checked = My.Settings.p1chatattendance
        p2chatattendance.Checked = My.Settings.p2chatattendance
        p3chatattendance.Checked = My.Settings.p3chatattendance
        p4chatattendance.Checked = My.Settings.p4chatattendance
        p5chatattendance.Checked = My.Settings.p5chatattendance
        p6chatattendance.Checked = My.Settings.p6chatattendance
        TextBox20.Text = My.Settings.timetowait
        TextBox21.Text = My.Settings.chmessage
        mpcheck.Checked = My.Settings.mpcheck
        mp1.Checked = My.Settings.mp1
        mp2.Checked = My.Settings.mp2
        mp3.Checked = My.Settings.mp3
        mp4.Checked = My.Settings.mp4
        mp5.Checked = My.Settings.mp5
        mp6.Checked = My.Settings.mp6
        My.Forms.Form1.CheckBox1.Checked = False
        My.Forms.Form1.CheckBox2.Checked = False
        My.Forms.Form1.dtype.Text = ""
        CheckBox1.Checked = False
        Button3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button3.Show()
    End Sub

End Class