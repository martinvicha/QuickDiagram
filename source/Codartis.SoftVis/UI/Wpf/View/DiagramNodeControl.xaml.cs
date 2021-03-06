﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Codartis.SoftVis.UI.Wpf.View
{
    /// <summary>
    /// Interaction logic for DiagramNodeControl.xaml
    /// </summary>
    public partial class DiagramNodeControl : UserControl
    {
        public static readonly DependencyProperty DiagramFillProperty =
            DiagramVisual.DiagramFillProperty.AddOwner(typeof(DiagramNodeControl));

        public static readonly DependencyProperty DiagramStrokeProperty =
            DiagramVisual.DiagramStrokeProperty.AddOwner(typeof(DiagramNodeControl));

        public static readonly DependencyProperty ChildrenAreaBorderThicknessProperty = DependencyProperty.Register(
            "ChildrenAreaBorderThickness",
            typeof(Thickness),
            typeof(DiagramNodeControl),
            new PropertyMetadata(default(Thickness)));

        public Thickness ChildrenAreaBorderThickness
        {
            get { return (Thickness)GetValue(ChildrenAreaBorderThicknessProperty); }
            set { SetValue(ChildrenAreaBorderThicknessProperty, value); }
        }

        public DiagramNodeControl()
        {
            InitializeComponent();
            Focusable = true;
        }

        public Brush DiagramFill
        {
            get { return (Brush)GetValue(DiagramFillProperty); }
            set { SetValue(DiagramFillProperty, value); }
        }

        public Brush DiagramStroke
        {
            get { return (Brush)GetValue(DiagramStrokeProperty); }
            set { SetValue(DiagramStrokeProperty, value); }
        }
    }
}
