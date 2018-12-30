using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Flowsharp.Results;
using Microsoft.Extensions.Localization;

namespace Flowsharp.Models
{
    public class ActivityDescriptor
    {
        public bool IsBrowsable { get; set; }
        public bool IsTrigger { get; set; }
        public string Name { get; set; }
        public LocalizedString Category { get; set; }
        public Type ActivityType { get; set; }
        public LocalizedString DisplayText { get; set; }
        public LocalizedString Description { get; set; }
        public Func<IEnumerable<LocalizedString>> GetEndpoints { get; set; }
        public Func<ActivityExecutionContext, WorkflowExecutionContext, CancellationToken, Task<bool>> CanExecuteAsync { get; set; }
        public Func<ActivityExecutionContext, WorkflowExecutionContext, CancellationToken, Task<ActivityExecutionResult>> ExecuteAsync { get; set; }
        public Func<ActivityExecutionContext, WorkflowExecutionContext, CancellationToken, Task<ActivityExecutionResult>> ResumeAsync { get; set; }
    }
}