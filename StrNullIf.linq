<Query Kind="VBProgram">
  <Namespace>Microsoft.VisualBasic</Namespace>
</Query>

Sub Main
  Console.WriteLine(StrNullIf("<null>,1,2"))
End Sub

Function StrNullIf(source As String, Optional nullString As String = "<null>") As Object
  Return iif(source.Contains(nullString), Nothing, source)
End Function