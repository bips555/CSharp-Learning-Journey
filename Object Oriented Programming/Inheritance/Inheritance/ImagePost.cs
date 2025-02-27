﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    
    internal class ImagePost:Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {

        }
    
        public ImagePost(string Title,string sendByUsername,string imageURL,bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = Title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
            return  String.Format("{0} - {1} -{2} - by {3}", this.ID, this.Title,this.ImageURL, this.SendByUsername);
        }
    }
}
