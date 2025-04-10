<Query Kind="VBProgram">
  <Namespace>Microsoft.VisualBasic</Namespace>
</Query>

Sub Main
  Dim a As Double = 15.2
  Dim b As Double = 0
  Console.WriteLine(SafeDiv(a, b))
End Sub

Function SafeDiv(a As Double, b As Double) As Double
  If (b = 0) Or IsNothing(b)
    Return 0
  Else
    Return a / b
  End If
End Function