namespace NubankHack.SimuladorAcoes.ViewModels
{
    public class RequestResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public RequestResponse(int code, string message)
        {
            Code = code;
            Message = message;
        }
        protected RequestResponse()
        {

        }
    }

    public class RequestResponse<T> : RequestResponse where T:class
    {
        public T ReturnObject { get; set; }

        public RequestResponse()
            :base()
        {
        }

        public RequestResponse(int code, string message)
            :base(code, message)
        {
        }
    }
}