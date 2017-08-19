using comicbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comicbook.Data
{
    public class comicbookRepository
    {
        public Models.comicbook getcomicbook()
        {
            return null;
        }
        public Models.comicbook getAllcomicbook()
        {
            return Allcomicbook;
        }
        private static Models.comicbook[] _comicBooks = new Models.comicbook[]
        {
            new Models.comicbook()
            {
                Id = 0,
                Title = "The Amazing Spider-Man",
                IssueNumber = 700,
                Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
                }
            },
            new Models.comicbook()
            {
                Id = 1,
                Title = "The Amazing Spider-Man",
                IssueNumber = 657,
                Description = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                    new Artist() { Name = "Marcos Martin", Role = "Inks" },
                    new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                    new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                }

            },
            new Models.comicbook()
            {
                Id = 2,
                Title = "Bone",
                IssueNumber = 50,
                Description = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                }
            }
        };
        private Models.comicbook Allcomicbook;

        public Models.comicbook getcomicbook(int id)
        {
            Models.comicbook comicbookReturned = null;

            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicbookReturned = comicBook;
                    break;
                }
            }
            return (comicbookReturned);
        }
    }
}