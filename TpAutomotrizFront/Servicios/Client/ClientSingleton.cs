using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizFront.Servicios.Client
{
    public class ClientSingleton
    {
        private static ClientSingleton instance;
        private HttpClient client;
        private ClientSingleton()
        {
            client = new HttpClient();
        }
        public static ClientSingleton GetInstance()
        {
            if (instance == null)
                instance = new ClientSingleton();
            return instance;
        }

        // CRUD


    }
}
