using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaelstromPlatform.UI.Components.Services.Activity
{
    public class ActivityModel
    {
        public Guid SysId { get; set; }
        public string? Identifier { get; set; }
        public string? Slug { get; set; }
        public string? SummaryBrief { get; set; }
        public string? SummaryLong { get; set; }
        public string? Description { get; set; }
        public string? ErrorCode { get; set; }
        public string? ErrorDescription { get; set; }
        public string? StackTrace { get; set; }
        public Guid? ServiceSysId { get; set; }
    }
}