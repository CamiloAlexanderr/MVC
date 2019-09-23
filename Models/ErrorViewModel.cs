using System;

namespace Metodolgia.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

        public class Coche
    {
        public string Marca { get;set; }
        public string Modelo { get;set; }
        public string Color { get;set; }
}

}