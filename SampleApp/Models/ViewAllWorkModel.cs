﻿using System.Collections.Generic;
using SampleApp.ExampleData;

namespace SampleApp.Models
{
    public class ViewAllWorkModel
    {
        public IList<Project> Projects { get; set; }
        public Project SelectedProject { get; set; }
        public Task SelectedTask { get; set; }
        public IList<Task> TasksOfProject { get; set; }
        public IList<Work> WorkItemsOfTask { get; set; }
    }
}