using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Notifikacije,
        Novosti,
        Lokacija,
        Rezervacije,
        Pretplate,
        Kupac,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
