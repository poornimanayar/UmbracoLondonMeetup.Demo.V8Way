using Examine;
using LondonMeetup.Demo.V8Way.CodeSamples.Examine;
using Umbraco.Core.Composing;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Components
{
    public class ProductIndexComponent : IComponent
    {
        private readonly IExamineManager _examineManager;
        private readonly ProductIndexCreator _productIndexCreator;

        public ProductIndexComponent(IExamineManager examineManager, ProductIndexCreator productIndexCreator)
        {
            _examineManager = examineManager;
            _productIndexCreator = productIndexCreator;
        }

        public void Initialize()
        {
            // add the indexes to the index
            foreach (var index in _productIndexCreator.Create())
            {
                _examineManager.AddIndex(index);
            }
        }

        public void Terminate() { }
    }
}