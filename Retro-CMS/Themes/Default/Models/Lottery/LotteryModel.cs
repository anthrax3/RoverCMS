using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Default.Models.Lottery
{
    public class LotteryModel
    {
        public int SelectedCodeOne { get; set; }
        public int SelectedCodeTwo { get; set; }
        public int SelectedCodeThree { get; set; }
        public int SelectedCodeFour { get; set; }

        public IEnumerable<SelectListItem> GetCodes()
        {
            return new Collection<SelectListItem>
            {
                new SelectListItem {Selected = false, Text = "1", Value = "1"},
                new SelectListItem {Selected = false, Text = "1", Value = "2"},
                new SelectListItem {Selected = false, Text = "1", Value = "3"},
                new SelectListItem {Selected = false, Text = "1", Value = "4"},
                new SelectListItem {Selected = false, Text = "1", Value = "5"},
                new SelectListItem {Selected = false, Text = "1", Value = "6"},
                new SelectListItem {Selected = false, Text = "1", Value = "7"},
                new SelectListItem {Selected = false, Text = "1", Value = "8"},
                new SelectListItem {Selected = false, Text = "1", Value = "9"},
                new SelectListItem {Selected = false, Text = "1", Value = "10"}
            };
        }
    }
}
