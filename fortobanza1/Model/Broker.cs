namespace fortobanza1
{
    internal class Broker
    {
        private int v1;
        private string v2;
        private string v3;
        private string v4;
        private int v5;

        public int Id { get; set; }
        public string BrokerName { get; private set; }
        public string BrokerCode { get; private set; }
        public int brokerPreco { get; private set; }
        public int BrokerQuantidade { get; private set; }
        public string Password { get; private set; }
        public int brokerQuantidade { get; private set; }

        public Broker(string brokerCode, string password)
        {
            BrokerCode = brokerCode;
            Password = password;
        }

        public Broker(int id, string brokerName, string brokerCode,
            string state, int BrokerPreco, string BrokerQuantidade,
            string password) : this(BrokerQuantidade, password)
        {
            Id = id;
        }

        public Broker(string brokerName, string brokerCode,
            string state, int codeArea, string telephone, string email, string password)
        {
            BrokerName = brokerName;
            BrokerCode = brokerCode;
            brokerPreco = brokerPreco;
            BrokerQuantidade = brokerQuantidade;
            Password = password;
        }

        public Broker(int v1, string v2, string v3, string v4, int v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }
    }
}