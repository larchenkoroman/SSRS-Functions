<Query Kind="VBProgram">
  <Namespace>Microsoft.VisualBasic</Namespace>
</Query>

Sub Main
  Console.WriteLine(SetTimeToDate(Now, 23, 59, 59))
  Console.WriteLine(DateStrip(Now))
  'Console.WriteLine(Weekday(Today, FirstDayOfWeek.Monday))
End Sub

Function SetTimeToDate(dt As DateTime, hours As Integer, minutes As Integer, seconds As Integer) As DateTime
  Return New DateTime(dt.Year, dt.Month, dt.Day, hours, minutes, seconds)
End Function


Function DateStrip(dt As DateTime) As DateTime
  Return New DateTime(dt.Year, dt.Month, dt.Day)
End Function
