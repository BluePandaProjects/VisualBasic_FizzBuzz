Public Class frmFizzBuzz
    Private FIZZ As String = "fizz"
    Private BUZZ As String = "buzz"

    Dim inputValue As Integer = 0
    Private Sub frmFizzBuzz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        listviewResults.Columns.Add("FizzBuzzResult")

        If CheckIsInteger(rawString) Then
            Dim targetNumber As Integer = CInt(rawString)

            For currentNumber As Integer = 1 To targetNumber
                listviewResults.Items.Add(FizzBuzz(currentNumber))
            Next
        Else
            MsgBox("Input Value must be a whole number")
        End If
    End Sub

    Private Function FizzBuzz(targetNumber As Integer) As String
        Dim result As String = ""

        If targetNumber Mod 3 = 0 Then
            listviewResults.Items.Add(FIZZ)
        ElseIf targetNumber Mod 5 = 0 Then
            listviewResults.Items.Add(BUZZ)
        Else
            listviewResults.Items.Add(targetNumber.ToString)
        End If

        Return result
    End Function
End Class
