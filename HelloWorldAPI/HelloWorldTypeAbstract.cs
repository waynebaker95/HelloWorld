namespace HelloWorldAPI
{
    public abstract class HelloWorldTypeAbstract<T> where T : class
    {
        //public IHelloWorldType CreateTypeInstance(string writeToLocation)
        //{

        //}
        public abstract string WriteToLocation(string writeToLocation);
    }
}