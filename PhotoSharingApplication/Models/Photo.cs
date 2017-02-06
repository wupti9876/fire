using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoSharingApplication.Models
{
    public class Photo : TableEntity
    {
        [Required]
        [HiddenInput]
        public int PhotoID { get; set; }
        public string Title { get; set; }
        public byte[] PhotoFile { get; set; }
        [DisplayName("Picture")]
        public string ImageMimeType { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayName("Created Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [StringLength(250)]
        public string UserName {
            get
            { return this.UserName; }
            set
            {   PartitionKey = value;
                this.UserName = value; }
            } 
        public virtual ICollection<Comment> Comments { get; set; }
    }
}