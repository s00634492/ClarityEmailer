using System;
using System.ComponentModel.DataAnnotations;

namespace ClarityEmailer.Models
{
    public class EmailModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Missing recipient email address.")]
        [RegularExpression(@"([a-zA-Z0-9\.\-])+\@([a-zA-Z0-9\-])+\.([a-zA-Z0-9\.\-])+", ErrorMessage ="Invalid recipient email address.")]
        public string Recipient { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public DateTime Timestamp { get; set; }

        public string Status { get; set; }
    }
}
