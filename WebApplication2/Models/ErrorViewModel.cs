using System;

namespace WebApplication2.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string RequestId1 { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
