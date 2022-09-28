Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Functions
<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim F As New Form1
        AssertEqual(F.trianglearea(2, 5) = 1


    End Sub

End Class