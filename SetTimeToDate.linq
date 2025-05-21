<Query Kind="VBProgram">
  <Namespace>Microsoft.VisualBasic</Namespace>
</Query>

Sub Main
  Console.WriteLine(SetTimeToDate(Now))
  Console.WriteLine(DateStrip(Now))
End Sub

Function SetTimeToDate(dt As DateTime, _
                       Optional hours As Integer = 23, _
                       Optional minutes As Integer = 59, _
                       Optional seconds As Integer = 59) As DateTime

  Return New DateTime(dt.Year, dt.Month, dt.Day, hours, minutes, seconds)
End Function


Function DateStrip(dt As DateTime) As DateTime
  Return New DateTime(dt.Year, dt.Month, dt.Day)
End Function
