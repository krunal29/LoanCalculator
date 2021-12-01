using LoanCalculator.Business.Enums.General;

namespace LoanCalculator.Business.ViewModels.General
{
    public class DropMessageModel
    {
        public string Message { get; set; }

        public string Description { get; set; }

        public DropMessageType DropMessageType { get; set; }
    }
}