﻿using EPiServer.Data;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Zanganeh.RobotsTxtHandler.ViewModel
{
    public class AdminViewModel
    {
        public IEnumerable<SelectListItem> Sites { get; internal set; }
        public string RobotText { get; set; }
        public string SelectedSite { get; set; }
        public Identity CurrentId { get; set; }

        public IEnumerable<AvailableRobotTxt> AvailableRobotTxts { get; set; }
    }

    public class AvailableRobotTxt
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
