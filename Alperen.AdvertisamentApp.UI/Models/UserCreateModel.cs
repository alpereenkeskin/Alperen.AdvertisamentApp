﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Alperen.AdvertisamentApp.UI.Models
{
    public class UserCreateModel
    {
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public int GenderId { get; set; }
        public SelectList Genders { get; set; }
    }
}
