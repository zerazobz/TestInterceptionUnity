Imports Microsoft.Practices.Unity.InterceptionExtension

Public Class LoggingInterceptor
    Implements IInterceptionBehavior

    Public ReadOnly Property WillExecute As Boolean Implements IInterceptionBehavior.WillExecute
        Get
            Return True
        End Get
    End Property

    Public Function GetRequiredInterfaces() As IEnumerable(Of Type) Implements IInterceptionBehavior.GetRequiredInterfaces
        Return Enumerable.Empty(Of Type)
    End Function

    Public Function Invoke(input As IMethodInvocation, getNext As GetNextInterceptionBehaviorDelegate) As IMethodReturn Implements IInterceptionBehavior.Invoke
        Dim result As IMethodReturn = getNext()(input, getNext)
        Console.WriteLine("Intercepted")
        Return result
    End Function
End Class
