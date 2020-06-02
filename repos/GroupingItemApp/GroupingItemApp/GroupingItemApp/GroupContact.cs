using System;
using System.Collections.Generic;
using System.Text;

namespace GroupingItemApp
{
    class GroupContact : List<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public GroupContact(string title, string shorttitle)
        {
            Title = title;
            ShortTitle = ShortTitle;
        }
    }
}
