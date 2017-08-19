using System.Collections.Generic;

namespace Jaca.Api.Models.Response
{
    public class ErrorResponse
    {
        public List<ErrorItem> Errors { get; set; }

        public ErrorResponse()
        {
            this.Errors = new List<ErrorItem>();
        }
    }

    public class ErrorItem
    {
        public ErrorItem() { }

        public ErrorItem(string message)
        {
            this.Message = message;
        }

        public ErrorItem(string message, string property)
        {
            this.Message = message;
            this.Property = property;
        }

        public string Message { get; set; }

        public string Property { get; set; }
    }
}
