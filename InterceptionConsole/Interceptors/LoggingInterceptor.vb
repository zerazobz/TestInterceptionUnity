Imports System.Reflection
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
        Dim methodResult As IMethodReturn = getNext()(input, getNext)
        If Not methodResult.Exception Is Nothing Then
            If input.MethodBase.MemberType = MemberTypes.Method Then
                Dim method As MethodInfo = CType(input.MethodBase, MethodInfo)
                If method.ReturnType = GetType(System.Void) Then
                    Return Nothing
                Else
                    Dim instance = Activator.CreateInstance(methodResult.ReturnValue)
                    methodResult.ReturnValue = instance
                    'Return
                End If
            End If
        End If
        Console.WriteLine("Everything are Intercepted")
        Return methodResult
    End Function
End Class
