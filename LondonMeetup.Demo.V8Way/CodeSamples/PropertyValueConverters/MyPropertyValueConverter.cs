using System;
using LondonMeetup.Demo.V8Way.CodeSamples.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;

namespace LondonMeetup.Demo.V8Way.CodeSamples.PropertyValueConverters
{

    //No registration needed with Composer as Umbraco scans for types of IPropertyValueConverter during start up
    public class MyPropertyValueConverter : PropertyValueConverterBase
    {
        //specifies for which property editor this PVC is for, a boolean true needs to be returned for that.
        // My property editor is called My.PropertyEditor
        public override bool IsConverter(IPublishedPropertyType propertyType) => propertyType.EditorAlias.Equals("My.PropertyEditor");

        //This is where you specify what type you want the value returned as. 
        // In my case its a simple class with a property Name (string)
        public override Type GetPropertyValueType(IPublishedPropertyType propertyType) => typeof(ModifiedContent);

        // here is where I actually convert the value. I look for the value, do a null check and return the object
        public override object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview)
        {
            if (inter != null)
            {
                return new ModifiedContent {Name = inter.ToString()};
            }
            return null;
        }
    }
}