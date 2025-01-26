<Query Kind="VBProgram">
  <Namespace>Microsoft.VisualBasic</Namespace>
</Query>

Sub Main
  Dim TimeInSeconds As Integer = 3659
  Console.WriteLine(TimeStringFromSeconds(TimeInSeconds))
  Console.WriteLine(TimeStringFromSeconds(TimeInSeconds, ":", ":", ""))
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