using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Mvc;

namespace Default.Models.Register
{
    public class StepOneModel
    {
        public string Gender { get; set; }
        public int DayBirthday { get; set; }
        public int MonthBirthday { get; set; }
        public int YearBirthday { get; set; }

        public DateTime GetBirthday()
        {
            // Default birthday
            DateTime dtBirthday;

            // Day-Month-Year , UK - EU Format. Stupid americans.. not personal though
            string strBirthday = string.Format("{0}/{1}/{2}", DayBirthday, MonthBirthday, YearBirthday);

            // Get datetime
            DateTime.TryParse(strBirthday, out dtBirthday);

            return dtBirthday;
        }

        public IEnumerable<SelectListItem> Months
        {
            get
            {
                return new Collection<SelectListItem>
                {
                    new SelectListItem {Selected = false, Text = "Januari", Value = "1"},
                    new SelectListItem {Selected = false, Text = "Februari", Value = "2"},
                    new SelectListItem {Selected = false, Text = "March", Value = "3"},
                    new SelectListItem {Selected = false, Text = "April", Value = "4"},
                    new SelectListItem {Selected = false, Text = "May", Value = "5"},
                    new SelectListItem {Selected = false, Text = "June", Value = "6"},
                    new SelectListItem {Selected = false, Text = "Juli", Value = "7"},
                    new SelectListItem {Selected = false, Text = "August", Value = "8"},
                    new SelectListItem {Selected = false, Text = "September", Value = "9"},
                    new SelectListItem {Selected = false, Text = "Oktober", Value = "10"},
                    new SelectListItem {Selected = false, Text = "November", Value = "11"},
                    new SelectListItem {Selected = false, Text = "December", Value = "12"},
                };
            }
        }

        public IEnumerable<SelectListItem> Days
        {
            get
            {
                return new Collection<SelectListItem>
                {
                    new SelectListItem {Selected = false, Text = "1", Value = "1"},
                    new SelectListItem {Selected = false, Text = "2", Value = "2"},
                    new SelectListItem {Selected = false, Text = "3", Value = "3"},
                    new SelectListItem {Selected = false, Text = "4", Value = "4"},
                    new SelectListItem {Selected = false, Text = "5", Value = "5"},
                    new SelectListItem {Selected = false, Text = "6", Value = "6"},
                    new SelectListItem {Selected = false, Text = "7", Value = "7"},
                    new SelectListItem {Selected = false, Text = "8", Value = "8"},
                    new SelectListItem {Selected = false, Text = "9", Value = "9"},
                    new SelectListItem {Selected = false, Text = "10", Value = "10"},
                    new SelectListItem {Selected = false, Text = "11", Value = "11"},
                    new SelectListItem {Selected = false, Text = "12", Value = "12"},
                    new SelectListItem {Selected = false, Text = "13", Value = "13"},
                    new SelectListItem {Selected = false, Text = "14", Value = "14"},
                    new SelectListItem {Selected = false, Text = "15", Value = "5"},
                    new SelectListItem {Selected = false, Text = "16", Value = "16"},
                    new SelectListItem {Selected = false, Text = "17", Value = "17"},
                    new SelectListItem {Selected = false, Text = "18", Value = "18"},
                    new SelectListItem {Selected = false, Text = "19", Value = "19"},
                    new SelectListItem {Selected = false, Text = "20", Value = "20"},
                    new SelectListItem {Selected = false, Text = "21", Value = "21"},
                    new SelectListItem {Selected = false, Text = "22", Value = "22"},
                    new SelectListItem {Selected = false, Text = "23", Value = "23"},
                    new SelectListItem {Selected = false, Text = "24", Value = "24"},
                    new SelectListItem {Selected = false, Text = "25", Value = "25"},
                    new SelectListItem {Selected = false, Text = "26", Value = "26"},
                    new SelectListItem {Selected = false, Text = "27", Value = "27"},
                    new SelectListItem {Selected = false, Text = "28", Value = "28"},
                    new SelectListItem {Selected = false, Text = "29", Value = "29"},
                    new SelectListItem {Selected = false, Text = "30", Value = "30"},
                    new SelectListItem {Selected = false, Text = "31", Value = "31"},
                };
            }
        }

        public IEnumerable<SelectListItem> Years
        {
            get
            {
                return new Collection<SelectListItem>
                {
                    new SelectListItem {Selected = false, Text = "2014", Value = "2014"},
                    new SelectListItem {Selected = false, Text = "2013", Value = "2013"},
                    new SelectListItem {Selected = false, Text = "2012", Value = "2012"},
                    new SelectListItem {Selected = false, Text = "2011", Value = "2011"},
                    new SelectListItem {Selected = false, Text = "2010", Value = "2010"},
                    new SelectListItem {Selected = false, Text = "2009", Value = "2009"},
                    new SelectListItem {Selected = false, Text = "2008", Value = "2008"},
                    new SelectListItem {Selected = false, Text = "2007", Value = "2007"},
                    new SelectListItem {Selected = false, Text = "2006", Value = "2006"},
                    new SelectListItem {Selected = false, Text = "2005", Value = "2005"},
                    new SelectListItem {Selected = false, Text = "2004", Value = "2004"},
                    new SelectListItem {Selected = false, Text = "2003", Value = "2003"},
                    new SelectListItem {Selected = false, Text = "2002", Value = "2002"},
                    new SelectListItem {Selected = false, Text = "2001", Value = "2001"},
                    new SelectListItem {Selected = false, Text = "2000", Value = "2000"},
                    new SelectListItem {Selected = false, Text = "1999", Value = "1999"},
                    new SelectListItem {Selected = false, Text = "1998", Value = "1998"},
                    new SelectListItem {Selected = false, Text = "1997", Value = "1997"},
                    new SelectListItem {Selected = false, Text = "1996", Value = "1996"},
                    new SelectListItem {Selected = false, Text = "1995", Value = "1995"},
                    new SelectListItem {Selected = false, Text = "1994", Value = "1994"},
                    new SelectListItem {Selected = false, Text = "1993", Value = "1993"},
                    new SelectListItem {Selected = false, Text = "1992", Value = "1992"},
                    new SelectListItem {Selected = false, Text = "1991", Value = "1991"},
                    new SelectListItem {Selected = false, Text = "1990", Value = "1990"},
                    new SelectListItem {Selected = false, Text = "1989", Value = "1989"},
                    new SelectListItem {Selected = false, Text = "1988", Value = "1988"},
                    new SelectListItem {Selected = false, Text = "1987", Value = "1987"},
                    new SelectListItem {Selected = false, Text = "1986", Value = "1986"},
                    new SelectListItem {Selected = false, Text = "1985", Value = "1985"},
                    new SelectListItem {Selected = false, Text = "1984", Value = "1984"},
                    new SelectListItem {Selected = false, Text = "1983", Value = "1983"},
                    new SelectListItem {Selected = false, Text = "1982", Value = "1982"},
                    new SelectListItem {Selected = false, Text = "1981", Value = "1981"},
                    new SelectListItem {Selected = false, Text = "1980", Value = "1980"}
                };
            }
        }
    }
}
