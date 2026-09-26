using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Panchang,
        LibraryDashboard,
        PJKS,
        Mahasabha,
        ContactUs
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string IconSource { get; set; }
        public Type TargetType { get; set; }
    }
}
