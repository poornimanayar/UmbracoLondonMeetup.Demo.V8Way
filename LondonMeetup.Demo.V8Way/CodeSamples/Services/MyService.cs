using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web;
using Umbraco.Web.PublishedModels;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Services
{
    public class MyService :IMyService
    {
        private readonly IContentService _contentService;

        private readonly UmbracoHelper _umbraco;


        //injecting Content Service
        public MyService(IContentService contentService, UmbracoHelper umbraco)
        {
            this._contentService = contentService;
            this._umbraco = umbraco;
        }

        public List<string> GetSomeString()
        {
            return new List<string>(){"string 1", "string 2"};
        }

        /// <summary>
        /// Get the versions of a node by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<IContent> GetVersions(int id)
        {
            return this._contentService.GetVersions(id);
        }

        public void DeleteVersions(int id, DateTime deleteBeforeDate)
        {
            this._contentService.DeleteVersions(id,deleteBeforeDate);
        }

        public IEnumerable<Blogpost> GetBlogs()
        {
            return this._umbraco.ContentAtXPath("//home/blog/blogPost").OfType<Blogpost>();
        }
    }
}