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
    }
}