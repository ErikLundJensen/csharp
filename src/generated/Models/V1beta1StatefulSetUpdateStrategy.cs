// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// StatefulSetUpdateStrategy indicates the strategy that the StatefulSet
    /// controller will use to perform updates. It includes any additional
    /// parameters necessary to perform the update for the indicated strategy.
    /// </summary>
    public partial class V1beta1StatefulSetUpdateStrategy
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1StatefulSetUpdateStrategy
        /// class.
        /// </summary>
        public V1beta1StatefulSetUpdateStrategy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1StatefulSetUpdateStrategy
        /// class.
        /// </summary>
        /// <param name="rollingUpdate">RollingUpdate is used to communicate
        /// parameters when Type is
        /// RollingUpdateStatefulSetStrategyType.</param>
        /// <param name="type">Type indicates the type of the
        /// StatefulSetUpdateStrategy.</param>
        public V1beta1StatefulSetUpdateStrategy(V1beta1RollingUpdateStatefulSetStrategy rollingUpdate = default(V1beta1RollingUpdateStatefulSetStrategy), string type = default(string))
        {
            RollingUpdate = rollingUpdate;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets rollingUpdate is used to communicate parameters when
        /// Type is RollingUpdateStatefulSetStrategyType.
        /// </summary>
        [JsonProperty(PropertyName = "rollingUpdate")]
        public V1beta1RollingUpdateStatefulSetStrategy RollingUpdate { get; set; }

        /// <summary>
        /// Gets or sets type indicates the type of the
        /// StatefulSetUpdateStrategy.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}