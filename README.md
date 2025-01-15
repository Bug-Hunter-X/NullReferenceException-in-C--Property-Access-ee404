# NullReferenceException in C# Property Access

This example demonstrates a common error in C#: a `NullReferenceException` that occurs when accessing a property of a class that might be null.  The code attempts to access the `GetHashCode()` method of the `MyProperty` int, but if `MyProperty` has not been initialized, this results in a runtime exception.

The solution shows how to safely handle this potential null value.