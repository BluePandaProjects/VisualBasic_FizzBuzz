Public Class frmFizzBuzz
    Private FIZZ As String = "fizz"
    Private BUZZ As String = "buzz"

    Dim inputValue As Integer = 0
    Private Sub frmFizzBuzz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With listviewResults

            .View = View.Details
            .Columns.Add("FizzBuzz", 100)
        End With
        'listviewResults.Columns.Add("FizzBuzz", 100)
        'listviewResults.Columns.Add("TestABC", 100)
    End Sub

    Private Function CheckIsInteger(value As Object)
        Dim resultValue As Integer = -1

        If Integer.TryParse(value, resultValue) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub buttonFizzBuzz_Click(sender As Object, e As EventArgs) Handles buttonFizzBuzz.Click
        Dim rawString As String = textboxInputVale.Text
        Dim outputText As String = ""

        If CheckIsInteger(rawString) Then
            Dim targetNumber As Integer = CInt(rawString)

            For currentNumber As Integer = 1 To targetNumber
                Dim listViewItem As New ListViewItem

                listViewItem.Text = FizzBuzz(currentNumber)

                listviewResults.Items.Add(listViewItem)
            Next
        Else
            MsgBox("Input Value must be a whole number")
        End If
    End Sub

    Private Function FizzBuzz(targetNumber As Integer) As String
        Dim result As String = ""

        If targetNumber Mod 3 = 0 And targetNumber Mod 5 = 0 Then
            result = FIZZ.ToUpper & BUZZ.ToUpper
        ElseIf targetNumber Mod 3 = 0 Then
            result = FIZZ
        ElseIf targetNumber Mod 5 = 0 Then
            result = BUZZ
        Else
            result = targetNumber.ToString
        End If

        Return result
    End Function
End Class
