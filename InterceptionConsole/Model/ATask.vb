Imports InterceptionConsole

Public Class ATask
    Implements ITask
    Public Function DoSomething() As String Implements ITask.DoSomething
        Dim message As String = "Do Something from A Task"
        Console.WriteLine("Do Something from A Task")
        Return message
    End Function
End Class
