<Query Kind="VBProgram">
  <Namespace>Microsoft.VisualBasic</Namespace>
</Query>

Sub Main
	Console.WriteLine(TimeStringFromSeconds(1620))
End Sub

Function TimeStringFromSeconds(TimeInSecond As Integer) As String
	Dim Hours, Minutes, Seconds As Integer
	
	Hours = TimeInSecond \ 3600
	Minutes = (TimeInSecond Mod 3600) \ 60
	Seconds = TimeInSecond Mod 60
	
	Return IIf(Hours = 0, "", Format(Hours, "00") & " ч. ") _
		 & IIf(Hours = 0 And Minutes = 0, "", Format(Minutes, "00") & " мин. ") _
		 & Format(Seconds, "00") & " с."
End Function