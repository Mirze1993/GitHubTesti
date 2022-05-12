using System;

namespace WebApplication2.Models
{
    public class ErrorViewModel
    {
        public string RequestId2 { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
