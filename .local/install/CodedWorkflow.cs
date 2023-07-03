using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace TugasAkhir
{
    public class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Testing.API.ITestingService), typeof(UiPath.Activities.System.API.ISystemService), typeof(UiPath.UIAutomationNext.API.Contracts.IRuntimeTargetAppSyncFactory)};
        }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>() ; }

        protected UiPath.Activities.System.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Activities.System.API.ISystemService>() ; }

        protected UiPath.UIAutomationNext.API.Contracts.IRuntimeTargetAppSyncFactory uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IRuntimeTargetAppSyncFactory>() ; }
    }
}