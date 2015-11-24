Module Module1

    Sub Main()
        Dim someTask As ITask = New ATask()
        someTask.DoSomething()

        Console.ReadKey()
    End Sub

End Module
