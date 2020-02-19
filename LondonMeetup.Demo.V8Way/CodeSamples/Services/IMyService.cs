using System;
using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web.PublishedModels;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Services
{
    public interface IMyService
    {
        List<string> GetSomeString();

        IEnumerable<IContent> GetVersions(int id);

        void DeleteVersions(int id, DateTime deleteBeforeDate);

        IEnumerable<Blogpost> GetBlogs();

    }
}
