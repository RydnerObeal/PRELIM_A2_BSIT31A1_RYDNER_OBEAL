namespace PRELIM_A2_BSIT31A1_RYDNER_OBEAL.Models
{
    // This class is used to represent error information to be displayed in error views
    public class ErrorViewModel
    {
        // Holds the ID of the request that caused the error
        // This helps in tracking specific requests during debugging or logging
        public string? RequestId { get; set; }

        // This read-only property returns true if RequestId is not null or empty
        // It is commonly used in the view to decide whether to show the RequestId
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
