﻿using System;
using Xamarin.Forms;

namespace Industrious.ToDo.Forms
{
	public partial class MainTwoColumnPage : ContentPage
	{
		public MainTwoColumnPage()
		{
			InitializeComponent();
		}


		public View LeftContent
		{
			get { return (SplitView.LeftContent); }
			set { SplitView.LeftContent = value; }
		}


		public View RightContent
		{
			get { return (SplitView.RightContent); }
			set { SplitView.RightContent = value; }
		}
	}
}