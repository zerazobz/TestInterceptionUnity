Imports InterceptionConsole

Public Class ATask
    Implements ITask
    Public Function DoSomething() As String Implements ITask.DoSomething
        Dim message As String = "Do Something from A Task"
        Console.WriteLine("Do Something from A Task")
        Throw New ArgumentException("ja ja ja")
        Return message
    End Function
End Class
