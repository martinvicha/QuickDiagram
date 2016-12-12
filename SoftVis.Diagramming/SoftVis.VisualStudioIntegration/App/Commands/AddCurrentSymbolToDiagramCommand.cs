﻿using System.Threading.Tasks;
using Codartis.SoftVis.Util;

namespace Codartis.SoftVis.VisualStudioIntegration.App.Commands
{
    /// <summary>
    /// Adds the current symbol (the one at the caret) to the diagram.
    /// Shows the diagram if it was not visible.
    /// </summary>
    internal sealed class AddCurrentSymbolToDiagramCommand : AsyncCommandBase
    {
        public AddCurrentSymbolToDiagramCommand(IAppServices appServices)
            :base(appServices)
        {
        }

        public override async Task ExecuteAsync()
        {
            var modelEntity = await ModelServices.AddCurrentSymbolAsync();
            if (modelEntity == null)
                return;

            var diagramNode = DiagramServices.ShowEntity(modelEntity);
            UiServices.ShowDiagramWindow();
            UiServices.FollowDiagramNodes(diagramNode.ToEnumerable());
        }
    }
}