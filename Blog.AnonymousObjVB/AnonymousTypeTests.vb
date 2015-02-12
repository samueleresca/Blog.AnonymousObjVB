Imports NUnit
Imports NUnit.Framework

<TestClass>
Public Class AnonymousTypeTests

    <TestMethod()>
    <TestCase(Description:="Compare two anonymous obj with the same values", _
        ExpectedMessage:="The two objects are NOT EQUAL")>
    Public Sub Compare_Anonymous_Objects()
        Assert.AreEqual(New With {.Value = 0, .Description = "Male"}, _
                        New With {.Value = 0, .Description = "Male"})
    End Sub

    <TestMethod()>
    <TestCase(Description:="Compare the type of two anonymous obj", _
        ExpectedMessage:="The two types are EQUAL")>
    Public Sub Compare_Anonymous_Objects_Type()
        Assert.AreEqual(New With {.Value = 0, .Description = "Male"}.GetType(), _
                        New With {.Value = 0, .Description = "Male"}.GetType())
    End Sub


    <TestMethod()>
    <TestCase(Description:="Compare two anonymous obj with  same values using KEY property", _
        ExpectedMessage:="The two objects are EQUAL equal")>
    Public Sub Compare_Anonymous_Objects_Using_Key_On_Value()
        Assert.AreEqual(New With {Key .Value = 0, .Description = "Male"}, _
                        New With {Key .Value = 0, .Description = "Male"})
    End Sub


    <TestMethod()>
    <TestCase(Description:="Compare two anonymous obj with different values using KEY property", _
        ExpectedMessage:="The two objects are EQUAL")>
    Public Sub Compare_Anonymous_Objects_With_Different_Descriptions_Values_Using_Key_On_Value()
        Assert.AreEqual(New With {Key .Value = 0, .Description = "Male"}, _
                        New With {Key .Value = 0, .Description = "Female"})
    End Sub

    <TestMethod()>
    <TestCase(Description:="Compare two anonymous object with  different values using KEY property on both attributes", _
        ExpectedMessage:="The two objects are NOT EQUAL")>
    Public Sub Compare_Anonymous_Objects_With_Different_Values_Using_Key_On_Value_And_Description()
        Assert.AreEqual(New With {Key .Value = 0, Key .Description = "Male"}, _
                        New With {Key .Value = 0, Key .Description = "Female"})
    End Sub

End Class
