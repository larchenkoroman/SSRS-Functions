<Query Kind="VBProgram">
  <Namespace>Microsoft.VisualBasic</Namespace>
</Query>

Sub Main
  Dim d1 As New Date(2024, 1, 1)
  Dim d2 As New Date(2025, 1, 1)
  Console.WriteLine(YearStringFromTwoDates(d1, d2))
End Sub

Function YearStringFromTwoDates(DateFrom As Date, DateTo As Date) As String
  Dim Year1, Year2 As Integer
  Year1 = Year(DateFrom)
  Year2 = Year(DateTo)

  Return IIf(Year1 = Year2, CStr(Year1), Year1 & " - " & Year2) & " год"
End Function