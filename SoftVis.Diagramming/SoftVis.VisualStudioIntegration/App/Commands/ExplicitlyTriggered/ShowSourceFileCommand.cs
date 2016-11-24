﻿using Codartis.SoftVis.Diagramming;

namespace Codartis.SoftVis.VisualStudioIntegration.App.Commands.ExplicitlyTriggered
{
    /// <summary>
    /// Activates the source code editor window for a given Symbol.
    /// </summary>
    internal class ShowSourceFileCommand : ExplicitCommandBase<IDiagramNode>
    {
        public ShowSourceFileCommand(IAppServices appServices)
            : base(appServices)
        {
        }

        public override void Execute(IDiagramNode diagramNode)
        {
            var modelEntity = diagramNode?.ModelEntity;
            if (modelEntity != null)
                ModelServices.ShowSource(modelEntity);
        }
    }
}
