namespace InventoryControl.Models
{
    public class Authentication
    {
        public int ID { get; private set; }
        public int UserID { get; private set; }
        public TimeSpan LoginTime { get; set; }
        public string IPAdress { get; set; }
        public string AuthenticationToken { get; set; }
    }
}
