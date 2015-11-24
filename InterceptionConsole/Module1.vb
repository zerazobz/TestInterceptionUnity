Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.InterceptionExtension

Module Module1

    Sub Main()
        Dim myContainer As IUnityContainer = New UnityContainer()
        myContainer.AddNewExtension(Of Interception)()
        myContainer.RegisterType(Of ITask, ATask)(New Interceptor(Of InterfaceInterceptor), New InterceptionBehavior(Of LoggingInterceptor))

        Dim someTask As ITask = myContainer.Resolve(Of ITask)
        someTask.DoSomething()

        Console.ReadKey()
    End Sub

End Module
