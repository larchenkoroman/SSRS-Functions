<Query Kind="VBProgram">
  <Namespace>Microsoft.VisualBasic</Namespace>
</Query>

Sub Main
  Dim TimeInSeconds As Integer = 3659
  Console.WriteLine(TimeStringFromSeconds(TimeInSeconds))
  Console.WriteLine(TimeStringFromSeconds(TimeInSeconds, ":", ":", ""))
  
  Console.WriteLine()
  Console.WriteLine(Now)
  Console.WriteLine(SetTimeToDate(Now))
End Sub

Function TimeStringFromSeconds(TimeInSecond As Integer, _
                               Optional HoursSymbol As String = " ч. ", _
                               Optional MinutesSymbol As String = " мин. ", _
                               Optional SecondsSymbol As String = " с." _
                              ) As String
  Dim Hours, Minutes, Seconds As Integer

  Hours = TimeInSecond \ 3600
  Minutes = (TimeInSecond Mod 3600) \ 60
  Seconds = TimeInSecond Mod 60

  Return IIf(Hours = 0, "", Format(Hours, "00") & HoursSymbol) _
       & IIf(Hours = 0 And Minutes = 0, "", Format(Minutes, "00") & MinutesSymbol) _
       & Format(Seconds, "00") & SecondsSymbol
End Function

Function SetTimeToDate(dt As DateTime, _
                       Optional hours As Integer = 23, _
                       Optional minutes As Integer = 59, _
                       Optional seconds As Integer = 59) As DateTime
  Dim year As Integer = dt.Year
  Dim month As Integer = dt.Month
  Dim day As Integer = dt.Day
  
  Return New DateTime(year, month, day, hours, minutes, seconds)
End Function
