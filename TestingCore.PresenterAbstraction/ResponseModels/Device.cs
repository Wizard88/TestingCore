namespace TestingCore.PresenterAbstraction.ResponseModel
{
    public class Device
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public Device(string name, string id)
        {
            Name = name;
            ID = id;
        }
    }
}
