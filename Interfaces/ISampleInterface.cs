interface ISampleInterface
{
    void SampleMethod();
}

class ImplementationClass : ISampleInterface
{
    
    void ISampleInterface.SampleMethod()
    {

    }

    static void Main()
    {

        ISampleInterface obj = new ImplementationClass();


        obj.SampleMethod();
    }
}