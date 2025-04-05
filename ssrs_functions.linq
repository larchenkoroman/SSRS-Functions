<Query Kind="VBProgram">
  <Namespace>Microsoft.VisualBasic</Namespace>
</Query>

Sub Main
  Console.WriteLine(StrNullIf("<null>,1,2"))
End Sub

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  Dim TimeInSeconds As Integer = 3659
'  TimeStringFromSeconds(TimeInSeconds)
'  TimeStringFromSeconds(TimeInSeconds, ":", ":", "")
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
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

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' SetTimeToDate(Now)
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Function SetTimeToDate(dt As DateTime, _
                       Optional hours As Integer = 23, _
                       Optional minutes As Integer = 59, _
                       Optional seconds As Integer = 59) As DateTime
  
  Return New DateTime(dt.Year, dt.Month, dt.Day, hours, minutes, seconds)
End Function

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' StrNullIf("<null>,1,2")
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Function StrNullIf(source As String, Optional nullString As String = "<null>") As Object
  Return iif(source.Contains(nullString), Nothing, source)
End Function