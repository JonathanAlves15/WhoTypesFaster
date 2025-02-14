namespace Modelos
{
    public class PlayerModel(int id)
    {
        public int id = id;
        private string ip;

        public string GetIp() {
            return ip;
        }

        public void SetIp(string ip) {
            this.ip = ip;
        }
    }
}
