'This Project Was Created By Thompson Vo
'6/16/2017
Public Class censoredincolor
    'this is to exit
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If (MsgBox("Are You Sure?", vbYesNo, "censored.in.color") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub EmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailToolStripMenuItem.Click
        'this is to mail me "Thompson Vo," for any questions or problems
        Process.Start("mailto:tivoisxtothecore@aol.com")
    End Sub
    Dim currentIndex As Integer = 0
    Private Sub Button_Next_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Next.Click
        '"This is a button to listen to the next track
        Dim SIZE = ToolStripComboBox2.Items.Count()
        If (currentIndex = SIZE) Then
            currentIndex = 0
        Else
            currentIndex = currentIndex + 1
        End If
        ChangeSong(currentIndex)
    End Sub
    Private Sub Button_Previous_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Previous.Click
        'This is a button to listen to the previous track
        Dim SIZE = ToolStripComboBox2.Items.Count()
        If (currentIndex = SIZE) Then
            currentIndex = 0
        Else
            currentIndex = currentIndex + 1
        End If
        ChangeSong(currentIndex)
    End Sub

    Private Sub censoredincolor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Whenever this form is opened, it should play this song
        My.Computer.Audio.Play(My.Resources.Creepin, AudioPlayMode.Background)
        PictureBox_AlbumArt.Visible = True
        PictureBox_AlbumArt.Image = My.Resources.Tramadol
        ToolStripComboBox2.Text = "Creepin"
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'This launches my bands reverbnation page
        Process.Start("http://www.reverbnation.com/censoredincolor1")
    End Sub

    Private Sub PictureBox_BandPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_BandPhoto.Click
        'Band Photo
        PictureBox_BandPhoto.Image = My.Resources.BandPhoto2
    End Sub
    Private Sub PictureBox_BandPhoto_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_BandPhoto.DoubleClick
        'Band Photo2 on double click
        PictureBox_BandPhoto.Image = My.Resources.BandPhoto
    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.Click, ToolStripComboBox1.SelectedIndexChanged
        'This will launch the selected band members facebook page
        If ToolStripComboBox1.Text = "Jessica" Then
            Process.Start("https://www.facebook.com/jessica.young.52687506")
        End If
        If ToolStripComboBox1.Text = "Thompson" Then
            Process.Start("https://www.facebook.com/tivoisxtothecore")
        End If
        If ToolStripComboBox1.Text = "Jovan" Then
            Process.Start("https://www.facebook.com/jovan.alvarado.1")
        End If
        If ToolStripComboBox1.Text = "Tice" Then
            Process.Start("https://www.facebook.com/ticey.griffin")
        End If
        If ToolStripComboBox1.Text = ("Marco") Then
            Process.Start("https://www.facebook.com/marco.darko.96")
        End If
    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        'Stops music
        My.Computer.Audio.Stop()
        StopToolStripMenuItem.Visible = False
        PlayMusicToolStripMenuItem.Visible = True
    End Sub
    Private Sub PlayMusicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayMusicToolStripMenuItem.Click
        'Plays Music
        My.Computer.Audio.Play(My.Resources.Creepin, AudioPlayMode.Background)
        PlayMusicToolStripMenuItem.Visible = False
        StopToolStripMenuItem.Visible = True
        ToolStripComboBox2.Text = "Creepin"
        Label_Song.Text = "Creepin"
        Label_Song2.Text = "Creepin"
        Label_Album.Text = "Tramadol"
        PictureBox_AlbumArt.Visible = True
        PictureBox_AlbumArt.Image = My.Resources.Tramadol
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'Launches our facebook page
        Process.Start("https://www.facebook.com/CensoredInColor-141430882626897/")
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'Launches my youtube channel
        Process.Start("https://www.youtube.com/channel/UCHox3NGlWYv6aUDw45HKm-A")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'Launches our soundcloud page
        Process.Start("https://soundcloud.com/cic123")
    End Sub

    Private Sub CheckUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckUpdateToolStripMenuItem.Click
        'will let you know if there is an update to said application
        MsgBox("You're Running The Latest Version", vbOKOnly, "version 2.2beta3")
    End Sub

    Private Sub StoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StoreToolStripMenuItem.Click
        'launches our store at bigcartel
        Process.Start("http://censoredincolor.bigcartel.com/")
    End Sub
    Private Sub ChangeSong(ByVal index As Integer)
        'made possible for track selection
        Select Case (currentIndex)
            Case 0
                ToolStripComboBox2.Text = "Distance"
                Label_Song.Text = "Distance"
                Label_Song2.Text = "Distance"
                Label_Album.Text = "Via Larunda"
                PictureBox_AlbumArt.Visible = True
                PictureBox_AlbumArt.Image = My.Resources.ViaLarunda
                My.Computer.Audio.Play(My.Resources.Distance, AudioPlayMode.Background)
            Case 1
                ToolStripComboBox2.Text = "Reverse This Day"
                Label_Song.Text = "Reverse This Day"
                Label_Song2.Text = "Reverse This Day"
                Label_Album.Text = "Tramadol"
                PictureBox_AlbumArt.Visible = True
                PictureBox_AlbumArt.Image = My.Resources.Tramadol
                My.Computer.Audio.Play(My.Resources.Reverse_This_Day, AudioPlayMode.Background)
            Case 2
                ToolStripComboBox2.Text = "Stage 1"
                Label_Song.Text = "Stage 1"
                Label_Song2.Text = "Stage 1"
                Label_Album.Text = "Self/Titled"
                PictureBox_AlbumArt.Visible = True
                PictureBox_AlbumArt.Image = My.Resources.SelfTitled
                My.Computer.Audio.Play(My.Resources.Stage_1, AudioPlayMode.Background)
            Case 3
                ToolStripComboBox2.Text = "The Start"
                Label_Song.Text = "The Start"
                Label_Song2.Text = "The Start"
                Label_Album.Text = "The Time..."
                PictureBox_AlbumArt.Visible = True
                PictureBox_AlbumArt.Image = My.Resources.TheTime
                My.Computer.Audio.Play(My.Resources.The_Start, AudioPlayMode.Background)
            Case 4
                ToolStripComboBox2.Text = "You're Not Alone"
                Label_Song.Text = "You're Not Alone"
                Label_Song2.Text = "You're Not Alone"
                Label_Album.Text = "Cover"
                PictureBox_AlbumArt.Visible = True
                PictureBox_AlbumArt.Image = My.Resources.cover
                My.Computer.Audio.Play(My.Resources.You_re_not_alone, AudioPlayMode.Background)
            Case 5
                ToolStripComboBox2.Text = "Creepin"
                Label_Song.Text = "Creepin"
                Label_Song2.Text = "Creepin"
                Label_Album.Text = "Tramadol"
                PictureBox_AlbumArt.Visible = True
                PictureBox_AlbumArt.Image = My.Resources.Tramadol
                My.Computer.Audio.Play(My.Resources.Creepin, AudioPlayMode.Background)
            Case 6
                ToolStripComboBox2.Text = "Empire"
                Label_Song.Text = "Empire"
                Label_Song2.Text = "Empire"
                Label_Album.Text = "The Time..."
                PictureBox_AlbumArt.Visible = True
                PictureBox_AlbumArt.Image = My.Resources.TheTime
                My.Computer.Audio.Play(My.Resources.empire, AudioPlayMode.Background)
            Case 7
                ToolStripComboBox2.Text = "Via Invested"
                Label_Song.Text = "Via Invested"
                Label_Song2.Text = "Via Invested"
                Label_Album.Text = "Cover"
                PictureBox_AlbumArt.Visible = True
                PictureBox_AlbumArt.Image = My.Resources.cover
                My.Computer.Audio.Play(My.Resources.Via_Invested, AudioPlayMode.Background)
        End Select
    End Sub

    Private Sub ToolStripComboBox2_selected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox2.Click
        'Shows What song is being played
        Dim SIZE = ToolStripComboBox2.Items.Count()
        If (currentIndex = SIZE) Then
            currentIndex = 0
        Else
            currentIndex = currentIndex + 1
        End If
        ChangeSong(currentIndex)
    End Sub
End Class
