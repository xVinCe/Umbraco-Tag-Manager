using Microsoft.AspNetCore.Mvc;
using Our.Umbraco.Community.TagManager.Repositories;
using Umbraco.Cms.Api.Management.Controllers;

namespace Our.Umbraco.Community.TagManager.Controllers
{
    public class TagListController : ManagementApiControllerBase
    {
        private readonly ITagListRepository _tagListRepository;

        public TagListController(ITagListRepository tagListRepository)
        {
            _tagListRepository = tagListRepository;
        }

        [HttpGet]
        public string[] GetTagsByGroup(string group, string culture)
        {
            return _tagListRepository.GetTagsByGroup(group, culture);
        }
    }
}