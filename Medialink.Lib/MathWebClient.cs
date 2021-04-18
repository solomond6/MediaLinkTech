using RestSharp;
using System;

namespace MediaLink.Lib
{
    public class MathWebClient
    {
        private IRestClient _restClient;
        private ILogger dblogger = new DatabaseLogger();
        public MathWebClient()
        {
            _restClient = new RestClient("http://api.mathweb.com/");
        }

        public int Add(int a, int b)
        {
            string sum = _restClient.Get(new RestRequest($"add?a={a}&b={b}", Method.GET)).Content;

            //log the request

            OperationModel op = new OperationModel
            {
                OperationName = "Sum",
                A = a,
                B = b,
                Result = sum
            };

            dblogger.Log(op);

            return Convert.ToInt32(sum);
        }

        public int Multiply(int a, int b)
        {
            string product = _restClient.Get(new RestRequest($"multiply?a={a}&b={b}", Method.GET)).Content;

            //log the request
            OperationModel op = new OperationModel
            {
                OperationName = "Multiply",
                A = a,
                B = b,
                Result = product
            };

            dblogger.Log(op);

            return Convert.ToInt32(product);
        }

        public int Divide(int a, int b)
        {
            string quotient = _restClient.Get(new RestRequest($"divide?a={a}&b={b}", Method.GET)).Content;

            //log the request
            OperationModel op = new OperationModel
            {
                OperationName = "Divide",
                A = a,
                B = b,
                Result = quotient
            };

            dblogger.Log(op);

            return Convert.ToInt32(quotient);
        }
    }
}
