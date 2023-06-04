Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.Windows.Media.Animation
Public Class Form1
    Dim winnerBotton(3) As Integer
    Dim winner As Boolean = False
    Dim pWinner As Char
    Dim result(9) As Char
    Dim player As Integer = 2
    Dim counter As Integer = 0
    Dim a As Integer
    Dim OorX As Char = "X"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OorXFunc()
        Button1.Text = OorX
        Button1.Enabled = False
        result(0) = OorX
        counter += 1
        winFunction()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OorXFunc()
        Button2.Text = OorX
        Button2.Enabled = False
        result(1) = OorX
        counter += 1
        winFunction()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OorXFunc()
        Button3.Text = OorX
        Button3.Enabled = False
        result(2) = OorX
        counter += 1
        winFunction()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OorXFunc()
        Button4.Text = OorX
        Button4.Enabled = False
        result(3) = OorX
        counter += 1
        winFunction()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OorXFunc()
        Button5.Text = OorX
        Button5.Enabled = False
        result(4) = OorX
        counter += 1
        winFunction()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        OorXFunc()
        Button6.Text = OorX
        Button6.Enabled = False
        result(5) = OorX
        counter += 1
        winFunction()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        OorXFunc()
        Button7.Text = OorX
        Button7.Enabled = False
        result(6) = OorX
        counter += 1
        winFunction()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        OorXFunc()
        Button8.Text = OorX
        Button8.Enabled = False
        result(7) = OorX
        counter += 1
        winFunction()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        OorXFunc()
        Button9.Text = OorX
        Button9.Enabled = False
        result(8) = OorX
        counter += 1
        winFunction()
    End Sub
    Private Sub winFunction()
        If counter > 4 Then
            If result(0) = "X" And result(1) = "X" And result(2) = "X" Then
                pWinner = "X"
                winner = True
                disableButtons()
                Button1.BackColor = Color.DarkCyan
                Button2.BackColor = Color.DarkCyan
                Button3.BackColor = Color.DarkCyan
            ElseIf result(0) = "X" And result(3) = "X" And result(6) = "X" Then
                pWinner = "X"
                winner = True
                disableButtons()
                Button1.BackColor = Color.DarkCyan
                Button4.BackColor = Color.DarkCyan
                Button7.BackColor = Color.DarkCyan
            ElseIf result(0) = "X" And result(4) = "X" And result(8) = "X" Then
                pWinner = "X"
                winner = True
                disableButtons()
                Button1.BackColor = Color.DarkCyan
                Button5.BackColor = Color.DarkCyan
                Button9.BackColor = Color.DarkCyan
            ElseIf result(1) = "X" And result(4) = "X" And result(7) = "X" Then
                pWinner = "X"
                winner = True
                disableButtons()
                Button2.BackColor = Color.DarkCyan
                Button5.BackColor = Color.DarkCyan
                Button8.BackColor = Color.DarkCyan
            ElseIf result(2) = "X" And result(5) = "X" And result(8) = "X" Then
                pWinner = "X"
                winner = True
                disableButtons()
                Button3.BackColor = Color.DarkCyan
                Button6.BackColor = Color.DarkCyan
                Button9.BackColor = Color.DarkCyan
            ElseIf result(3) = "X" And result(4) = "X" And result(5) = "X" Then
                pWinner = "X"
                winner = True
                disableButtons()
                Button4.BackColor = Color.DarkCyan
                Button5.BackColor = Color.DarkCyan
                Button6.BackColor = Color.DarkCyan
            ElseIf result(6) = "X" And result(7) = "X" And result(8) = "X" Then
                pWinner = "X"
                winner = True
                disableButtons()
                Button7.BackColor = Color.DarkCyan
                Button8.BackColor = Color.DarkCyan
                Button9.BackColor = Color.DarkCyan
            ElseIf result(2) = "X" And result(4) = "X" And result(6) = "X" Then
                pWinner = "X"
                winner = True
                disableButtons()
                Button3.BackColor = Color.DarkCyan
                Button5.BackColor = Color.DarkCyan
                Button7.BackColor = Color.DarkCyan
            ElseIf result(0) = "O" And result(1) = "O" And result(2) = "O" Then
                pWinner = "O"
                winner = True
                disableButtons()
                Button1.BackColor = Color.DarkCyan
                Button2.BackColor = Color.DarkCyan
                Button3.BackColor = Color.DarkCyan
            ElseIf result(0) = "O" And result(3) = "O" And result(6) = "O" Then
                pWinner = "O"
                winner = True
                disableButtons()
                Button1.BackColor = Color.DarkCyan
                Button4.BackColor = Color.DarkCyan
                Button7.BackColor = Color.DarkCyan
            ElseIf result(0) = "O" And result(4) = "O" And result(8) = "O" Then
                pWinner = "O"
                winner = True
                disableButtons()
                Button1.BackColor = Color.DarkCyan
                Button5.BackColor = Color.DarkCyan
                Button9.BackColor = Color.DarkCyan
            ElseIf result(1) = "O" And result(4) = "O" And result(7) = "O" Then
                pWinner = "O"
                winner = True
                disableButtons()
                Button2.BackColor = Color.DarkCyan
                Button5.BackColor = Color.DarkCyan
                Button8.BackColor = Color.DarkCyan
            ElseIf result(2) = "O" And result(5) = "O" And result(8) = "O" Then
                pWinner = "O"
                winner = True
                disableButtons()
                Button3.BackColor = Color.DarkCyan
                Button6.BackColor = Color.DarkCyan
                Button9.BackColor = Color.DarkCyan
            ElseIf result(3) = "O" And result(4) = "O" And result(5) = "O" Then
                pWinner = "O"
                winner = True
                disableButtons()
                Button4.BackColor = Color.DarkCyan
                Button5.BackColor = Color.DarkCyan
                Button6.BackColor = Color.DarkCyan
            ElseIf result(6) = "O" And result(7) = "O" And result(8) = "O" Then
                pWinner = "O"
                winner = True
                disableButtons()
                Button7.BackColor = Color.DarkCyan
                Button8.BackColor = Color.DarkCyan
                Button9.BackColor = Color.DarkCyan
            ElseIf result(2) = "O" And result(4) = "O" And result(6) = "O" Then
                pWinner = "O"
                winner = True
                disableButtons()
                Button3.BackColor = Color.DarkCyan
                Button5.BackColor = Color.DarkCyan
                Button7.BackColor = Color.DarkCyan
            ElseIf winner = False And counter = 9 Then
                Label4.Text = "Draw!"
                winner = True
                disableButtons()
            End If
        End If

        If pWinner = "X" Then
            Label4.Text = "X Wins!"
        ElseIf pWinner = "O" Then
            Label4.Text = "O Wins!"
        End If
    End Sub
    Private Sub OorXFunc()
        If OorX = "X" Then
            OorX = "O"
            Label6.Text = " Player O's Turn!"
        ElseIf OorX = "O" Then
            OorX = "X"
            Label6.Text = " Player X's Turn!"
        End If
    End Sub
    Private Sub disableButtons()
        If winner = True Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Application.Restart()
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub
End Class
