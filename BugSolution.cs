public class ExampleClass
{
    public int? MyProperty { get; set; } //Use Nullable<int> (int?) for handling nulls

    public void MyMethod()
    {
        //Check for null before accessing property
        int value = MyProperty.HasValue ? MyProperty.Value.GetHashCode() : 0;  
        //Alternatively:
        //int value = MyProperty ?? 0; //Null-coalescing operator.  Returns 0 if MyProperty is null.
        //Then you can use value.GetHashCode()
    }
}