﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FlexCharts.Controls.Contracts;
using FlexCharts.Helpers.DependencyHelpers;
using FlexCharts.MaterialDesign;
using FlexCharts.MaterialDesign.Descriptors;

namespace FlexCharts.Controls.Primatives
{
	public abstract class LinePrimative : FlexPrimative, ILineContract
	{
		public static readonly DependencyProperty LineStrokeProperty =
			DP.Attach<AbstractMaterialDescriptor>(typeof (LinePrimative), new FrameworkPropertyMetadata(MaterialPalette.Descriptors.P700Descriptor));

		public static readonly DependencyProperty LineStrokeThicknessProperty = 
			DP.Attach<double>(typeof(LinePrimative), new FrameworkPropertyMetadata(2.0));


		public static AbstractMaterialDescriptor GetLineStroke(DependencyObject i) => i.Get<AbstractMaterialDescriptor>(LineStrokeProperty);
		public static void SetLineStroke(DependencyObject i, AbstractMaterialDescriptor v) => i.Set(LineStrokeProperty, v);
		public AbstractMaterialDescriptor LineStroke
		{
			get { return (AbstractMaterialDescriptor) GetValue(LineStrokeProperty); }
			set { SetValue(LineStrokeProperty, value); }
		}

		public static double GetLineStrokeThickness(DependencyObject i) => i.Get<double>(LineStrokeThicknessProperty);
		public static void SetLineStrokeThickness(DependencyObject i, double v) => i.Set(LineStrokeThicknessProperty, v);
		public double LineStrokeThickness
		{
			get { return (double) GetValue(LineStrokeThicknessProperty); }
			set { SetValue(LineStrokeThicknessProperty, value); }
		}
	}
} 
