﻿namespace MaelstromPlatform.UI.Components.Services.Issue
{
    public class IssueModel
    {
        public Guid SysId { get; set; }
        public string? Identifier { get; set; }
        public string? Slug { get; set; }
        public string? SummaryBrief { get; set; }
        public string? SummaryLong { get; set; }
        public DateTime? Origin { get; set; }
        public bool? Approved { get; set; }
        public Guid? IssueStateSysId { get; set; }
        public Guid? IssueStatusSysId { get; set; }
        public bool? Resolved { get; set; }
        public Guid? IssueSeveritySysId { get; set; }
        public Guid? IssuePrioritySysId { get; set; }
        public Guid? IssueKindSysId { get; set; }
        public string? ProblemStatement { get; set; }
        public string? WorkAround { get; set; }
        public string? StepsToReproduce { get; set; }
        public Guid? PrimaryOwnerSysId { get; set; }
        public Guid? PrimaryOwnerTeamSysId { get; set; }
        public Guid? PrimaryFoundByTeamSysId { get; set; }
        public Guid? PrimaryReportedByTeamSysId { get; set; }
        public Guid? PrimaryChampionSysId { get; set; }
        public Guid? FoundByPrimaryPersonSysId { get; set; }
        public Guid? ReportedByPrimaryPersonSysId { get; set; }
        public DateTime? FoundOn { get; set; }
        public DateTime? ReportedOn { get; set; }
    }
}