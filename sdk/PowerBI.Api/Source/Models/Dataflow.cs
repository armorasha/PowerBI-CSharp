// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The metadata of a dataflow
    /// </summary>
    public partial class Dataflow
    {
        /// <summary>
        /// Initializes a new instance of the Dataflow class.
        /// </summary>
        public Dataflow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dataflow class.
        /// </summary>
        /// <param name="objectId">The dataflow id</param>
        /// <param name="name">The dataflow name</param>
        /// <param name="description">The dataflow description</param>
        /// <param name="modelUrl">A URL to the dataflow definition file
        /// (model.json)</param>
        /// <param name="configuredBy">The dataflow owner</param>
        public Dataflow(System.Guid objectId, string name = default(string), string description = default(string), string modelUrl = default(string), string configuredBy = default(string))
        {
            ObjectId = objectId;
            Name = name;
            Description = description;
            ModelUrl = modelUrl;
            ConfiguredBy = configuredBy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dataflow id
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public System.Guid ObjectId { get; set; }

        /// <summary>
        /// Gets or sets the dataflow name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the dataflow description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a URL to the dataflow definition file (model.json)
        /// </summary>
        [JsonProperty(PropertyName = "modelUrl")]
        public string ModelUrl { get; set; }

        /// <summary>
        /// Gets or sets the dataflow owner
        /// </summary>
        [JsonProperty(PropertyName = "configuredBy")]
        public string ConfiguredBy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
