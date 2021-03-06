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

using System;

namespace DotNetNuke.Modules.Forums.Components.Entities
{

	/// <summary>
	/// This is our Info class that represents columns in our data store that are associated with the Forums_Poll table. 
	/// </summary>
	public class PollInfo
	{

		#region Public Properties

		/// <summary>
		/// Our PK field.
		/// </summary>
		public int PollId { get; set; }

		public int TopicId { get; set; }

		public int UserId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>1000 characters</remarks>
		public string Question { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>10 characters</remarks>
		public string PollType { get; set; }

		public DateTime CreatedOnDate { get; set; }

		public DateTime LastModifiedOnDate { get; set; }

		/// <summary>
		/// A count used for paging.
		/// </summary>
		/// <remarks>Not stored in a table.</remarks>
		public int TotalRecords { get; set; }

		#endregion

	}
}