using System;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong>",
                Artists = new Artist[]
                {
                    new Artist() { Id = 1, Name = "Dan Slott", Role = "Script" },
                    new Artist() { Id = 2, Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Id = 3, Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Id = 4, Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Id = 5, Name = "Chris Eliopoulos", Role = "Letters" }
                }
            };

            return View( comicBook );
        }
    }
}
