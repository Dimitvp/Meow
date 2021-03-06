﻿namespace Meow.Web.Areas.Volunteer.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Area(WebConstants.VolunteerArea)]
    [Authorize(Roles = WebConstants.VolunteerRole)]
    public class BaseVolunteerController : Controller
    {
    }
}