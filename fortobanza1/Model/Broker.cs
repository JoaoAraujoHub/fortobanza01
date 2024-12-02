namespace fortobanza1
{
    internal class Broker
    {
        private int id;

        public int Id { get; set; }
            public string BrokerName { get; private set; }
            public string BrokerCode { get; private set; }
            public int BrokerPreco { get; private set; }
            public int BrokerQuantidade { get; private set; }
            public string Password { get; private set; }

        public Broker(string brokerCode, string password)
            {
                BrokerCode = brokerCode;
                Password = password;
            }

       

        public Broker(int id, string brokerName, string brokerCode, int brokerPreco, int brokerQuantidade, string password)
        {
            
            Id = id;
            BrokerName = brokerName;
            BrokerCode = brokerCode;
            BrokerPreco = brokerPreco;
            BrokerQuantidade = brokerQuantidade;
            Password = password;
        }

        public Broker(int id, string brokerName, string brokerCode, int brokerPreco, int brokerQuantidade,
            string password)
            {
                
               
                BrokerCode = brokerCode;
                BrokerPreco = brokerPreco;
                BrokerQuantidade = brokerQuantidade;
                
            }

        public Broker(int v1, string v2, string v3, string v4, int v5)
        {
        }
    }
    }
