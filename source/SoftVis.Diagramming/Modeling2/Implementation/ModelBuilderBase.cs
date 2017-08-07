﻿using System;

namespace Codartis.SoftVis.Modeling2.Implementation
{
    /// <summary>
    /// Abstract base class for model builders.
    /// Responsible for adding, removing, updating nodes and relationships in a model.
    /// </summary>
    public abstract class ModelBuilderBase : IModelBuilder
    {
        private ImmutableModel _currentModel;

        public event Action<IModelNode, IModel> NodeAdded;
        //public event Action<IModelNode, IModel> NodeRemoved;
        public event Action<IModelRelationship, IModel> RelationshipAdded;
        //public event Action<IModelRelationship, IModel> RelationshipRemoved;
        //public event Action<IModelNode, IModel> NodeUpdated;
        public event Action<IModel> ModelCleared;

        protected ModelBuilderBase()
        {
            _currentModel = new ImmutableModel();
        }

        public IModel CurrentModel => _currentModel;

        public IModelBuilder ClearModel()
        {
            _currentModel = new ImmutableModel();
            ModelCleared?.Invoke(_currentModel);
            return this;
        }

        protected IModelBuilder AddNode(ImmutableModelNode node, ImmutableModelNode parentNode = null)
        {
            _currentModel = _currentModel.AddNode(node, parentNode);
            NodeAdded?.Invoke(node, _currentModel);
            return this;
        }

        protected IModelBuilder AddRelationship(ModelRelationship relationship)
        {
            _currentModel = _currentModel.AddRelationship(relationship);
            RelationshipAdded?.Invoke(relationship, _currentModel);
            return this;
        }
    }
}