﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LiveChat.Core.Entities;

namespace LiveChat.Core
{
	public class VisitorInitViewModel
	{
		public bool ChatOnline { get; set; }
		public List<Department> Departments { get; set; }
		public ChatRequest NewChatRequest { get; set; }

		public VisitorInitViewModel()
		{
			NewChatRequest = new ChatRequest();
			NewChatRequest.Created = DateTime.Now;
			NewChatRequest.FromVisitor = true;
			NewChatRequest.Id = Guid.NewGuid();
			NewChatRequest.Modified = DateTime.Now;
			NewChatRequest.Requested = DateTime.Now;
		}

		public VisitorInitViewModel(bool chatOnline, List<Department> departments)
		{
			this.ChatOnline = chatOnline;
			this.Departments = departments;
		}
	}
}
