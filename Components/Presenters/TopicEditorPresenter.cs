﻿//
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2011
// by DotNetNuke Corporation
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
//

namespace DotNetNuke.Modules.Forums.Components.Presenters
{
    using System;
    using Controllers;
    using Models;
    using Providers.Data.SqlDataProvider;
    using Views;
    using Web.Mvp;

    public class TopicEditorPresenter : ModulePresenter<ITopicEditorView, TopicEditorModel>
	{
		protected IForumsController Controller { get; private set; }

		public TopicEditorPresenter(ITopicEditorView view) : this(view, new ForumsController(new SqlDataProvider()))
		{
		}

		public TopicEditorPresenter(ITopicEditorView view, IForumsController controller) : base(view)
		{
			if (view == null)
			{
				throw new ArgumentException(@"View is nothing.", "view");
			}

			if (controller == null)
			{
				throw new ArgumentException(@"Controller is nothing.", "controller");
			}

			Controller = controller;
		    this.View.Load += ViewLoad;
            View.Submit += Submit;
		}

		private void ViewLoad(object sender, EventArgs eventArgs)
		{
			try
			{
				View.Model.CurrentUserId = ModuleContext.PortalSettings.UserId;
			}
			catch (Exception exc) {
				ProcessModuleLoadException(exc);
			}
		}
        public void Submit(object sender, EventArgs e) {
            //beerRepository.AddBeer(View.Model);
            //beerRepository.SubmitChanges();
            Messages.Publish(View.Model);
        }
	}
}