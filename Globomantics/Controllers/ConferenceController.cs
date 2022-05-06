﻿using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;
using Shared;
using System.Threading.Tasks;

namespace Globomantics.Controllers
{
    public class ConferenceController: Controller
    {
        private readonly IConferenceService conferenceService;

        public ConferenceController(IConferenceService conferenceService)
        {
            this.conferenceService = conferenceService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Conferences";
            return View(await conferenceService.GetAll());
        }

        public IActionResult Add()
        {
            ViewBag.Title = "Add Conference";
            return View(new ConferenceModel());
        }
    }
}