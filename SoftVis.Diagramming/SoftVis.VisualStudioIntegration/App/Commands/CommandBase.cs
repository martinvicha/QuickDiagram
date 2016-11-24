using Codartis.SoftVis.VisualStudioIntegration.Diagramming;
using Codartis.SoftVis.VisualStudioIntegration.Modeling;
using Codartis.SoftVis.VisualStudioIntegration.UI;

namespace Codartis.SoftVis.VisualStudioIntegration.App.Commands
{
    /// <summary>
    /// Base class for all commands. Commands are the application logic of the package.
    /// </summary>
    internal abstract class CommandBase
    {
        /// <summary>
        /// The command can consume package services via this interface.
        /// </summary>
        private readonly IAppServices _appServices;

        protected IModelServices ModelServices => _appServices.ModelServices;
        protected IDiagramServices DiagramServices => _appServices.DiagramServices;
        protected IUiServices UiServices => _appServices.UiServices;

        protected CommandBase(IAppServices appServices)
        {
            _appServices = appServices;
        }
    }
}