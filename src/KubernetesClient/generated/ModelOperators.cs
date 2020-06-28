using k8s.Versioning;

namespace k8s.Models
{
    public partial class Admissionregistrationv1beta1ServiceReference
    {
        public static explicit operator Admissionregistrationv1beta1ServiceReference(Admissionregistrationv1ServiceReference s) => VersionConverter.Mapper.Map<Admissionregistrationv1beta1ServiceReference>(s);
    }
    public partial class Admissionregistrationv1ServiceReference
    {
        public static explicit operator Admissionregistrationv1ServiceReference(Admissionregistrationv1beta1ServiceReference s) => VersionConverter.Mapper.Map<Admissionregistrationv1ServiceReference>(s);
    }
    public partial class Admissionregistrationv1beta1WebhookClientConfig
    {
        public static explicit operator Admissionregistrationv1beta1WebhookClientConfig(Admissionregistrationv1WebhookClientConfig s) => VersionConverter.Mapper.Map<Admissionregistrationv1beta1WebhookClientConfig>(s);
    }
    public partial class Admissionregistrationv1WebhookClientConfig
    {
        public static explicit operator Admissionregistrationv1WebhookClientConfig(Admissionregistrationv1beta1WebhookClientConfig s) => VersionConverter.Mapper.Map<Admissionregistrationv1WebhookClientConfig>(s);
    }
    public partial class V1AggregationRule
    {
        public static explicit operator V1AggregationRule(V1alpha1AggregationRule s) => VersionConverter.Mapper.Map<V1AggregationRule>(s);
    }
    public partial class V1alpha1AggregationRule
    {
        public static explicit operator V1alpha1AggregationRule(V1AggregationRule s) => VersionConverter.Mapper.Map<V1alpha1AggregationRule>(s);
    }
    public partial class V1AggregationRule
    {
        public static explicit operator V1AggregationRule(V1beta1AggregationRule s) => VersionConverter.Mapper.Map<V1AggregationRule>(s);
    }
    public partial class V1beta1AggregationRule
    {
        public static explicit operator V1beta1AggregationRule(V1AggregationRule s) => VersionConverter.Mapper.Map<V1beta1AggregationRule>(s);
    }
    public partial class V1alpha1AggregationRule
    {
        public static explicit operator V1alpha1AggregationRule(V1beta1AggregationRule s) => VersionConverter.Mapper.Map<V1alpha1AggregationRule>(s);
    }
    public partial class V1beta1AggregationRule
    {
        public static explicit operator V1beta1AggregationRule(V1alpha1AggregationRule s) => VersionConverter.Mapper.Map<V1beta1AggregationRule>(s);
    }
    public partial class Apiextensionsv1beta1ServiceReference
    {
        public static explicit operator Apiextensionsv1beta1ServiceReference(Apiextensionsv1ServiceReference s) => VersionConverter.Mapper.Map<Apiextensionsv1beta1ServiceReference>(s);
    }
    public partial class Apiextensionsv1ServiceReference
    {
        public static explicit operator Apiextensionsv1ServiceReference(Apiextensionsv1beta1ServiceReference s) => VersionConverter.Mapper.Map<Apiextensionsv1ServiceReference>(s);
    }
    public partial class Apiextensionsv1beta1WebhookClientConfig
    {
        public static explicit operator Apiextensionsv1beta1WebhookClientConfig(Apiextensionsv1WebhookClientConfig s) => VersionConverter.Mapper.Map<Apiextensionsv1beta1WebhookClientConfig>(s);
    }
    public partial class Apiextensionsv1WebhookClientConfig
    {
        public static explicit operator Apiextensionsv1WebhookClientConfig(Apiextensionsv1beta1WebhookClientConfig s) => VersionConverter.Mapper.Map<Apiextensionsv1WebhookClientConfig>(s);
    }
    public partial class Apiregistrationv1beta1ServiceReference
    {
        public static explicit operator Apiregistrationv1beta1ServiceReference(Apiregistrationv1ServiceReference s) => VersionConverter.Mapper.Map<Apiregistrationv1beta1ServiceReference>(s);
    }
    public partial class Apiregistrationv1ServiceReference
    {
        public static explicit operator Apiregistrationv1ServiceReference(Apiregistrationv1beta1ServiceReference s) => VersionConverter.Mapper.Map<Apiregistrationv1ServiceReference>(s);
    }
    public partial class V1APIService
    {
        public static explicit operator V1APIService(V1beta1APIService s) => VersionConverter.Mapper.Map<V1APIService>(s);
    }
    public partial class V1beta1APIService
    {
        public static explicit operator V1beta1APIService(V1APIService s) => VersionConverter.Mapper.Map<V1beta1APIService>(s);
    }
    public partial class V1APIServiceCondition
    {
        public static explicit operator V1APIServiceCondition(V1beta1APIServiceCondition s) => VersionConverter.Mapper.Map<V1APIServiceCondition>(s);
    }
    public partial class V1beta1APIServiceCondition
    {
        public static explicit operator V1beta1APIServiceCondition(V1APIServiceCondition s) => VersionConverter.Mapper.Map<V1beta1APIServiceCondition>(s);
    }
    public partial class V1APIServiceList
    {
        public static explicit operator V1APIServiceList(V1beta1APIServiceList s) => VersionConverter.Mapper.Map<V1APIServiceList>(s);
    }
    public partial class V1beta1APIServiceList
    {
        public static explicit operator V1beta1APIServiceList(V1APIServiceList s) => VersionConverter.Mapper.Map<V1beta1APIServiceList>(s);
    }
    public partial class V1APIServiceSpec
    {
        public static explicit operator V1APIServiceSpec(V1beta1APIServiceSpec s) => VersionConverter.Mapper.Map<V1APIServiceSpec>(s);
    }
    public partial class V1beta1APIServiceSpec
    {
        public static explicit operator V1beta1APIServiceSpec(V1APIServiceSpec s) => VersionConverter.Mapper.Map<V1beta1APIServiceSpec>(s);
    }
    public partial class V1APIServiceStatus
    {
        public static explicit operator V1APIServiceStatus(V1beta1APIServiceStatus s) => VersionConverter.Mapper.Map<V1APIServiceStatus>(s);
    }
    public partial class V1beta1APIServiceStatus
    {
        public static explicit operator V1beta1APIServiceStatus(V1APIServiceStatus s) => VersionConverter.Mapper.Map<V1beta1APIServiceStatus>(s);
    }
    public partial class V1alpha1ClusterRole
    {
        public static explicit operator V1alpha1ClusterRole(V1beta1ClusterRole s) => VersionConverter.Mapper.Map<V1alpha1ClusterRole>(s);
    }
    public partial class V1beta1ClusterRole
    {
        public static explicit operator V1beta1ClusterRole(V1alpha1ClusterRole s) => VersionConverter.Mapper.Map<V1beta1ClusterRole>(s);
    }
    public partial class V1alpha1ClusterRole
    {
        public static explicit operator V1alpha1ClusterRole(V1ClusterRole s) => VersionConverter.Mapper.Map<V1alpha1ClusterRole>(s);
    }
    public partial class V1ClusterRole
    {
        public static explicit operator V1ClusterRole(V1alpha1ClusterRole s) => VersionConverter.Mapper.Map<V1ClusterRole>(s);
    }
    public partial class V1beta1ClusterRole
    {
        public static explicit operator V1beta1ClusterRole(V1ClusterRole s) => VersionConverter.Mapper.Map<V1beta1ClusterRole>(s);
    }
    public partial class V1ClusterRole
    {
        public static explicit operator V1ClusterRole(V1beta1ClusterRole s) => VersionConverter.Mapper.Map<V1ClusterRole>(s);
    }
    public partial class V1alpha1ClusterRoleBinding
    {
        public static explicit operator V1alpha1ClusterRoleBinding(V1beta1ClusterRoleBinding s) => VersionConverter.Mapper.Map<V1alpha1ClusterRoleBinding>(s);
    }
    public partial class V1beta1ClusterRoleBinding
    {
        public static explicit operator V1beta1ClusterRoleBinding(V1alpha1ClusterRoleBinding s) => VersionConverter.Mapper.Map<V1beta1ClusterRoleBinding>(s);
    }
    public partial class V1alpha1ClusterRoleBinding
    {
        public static explicit operator V1alpha1ClusterRoleBinding(V1ClusterRoleBinding s) => VersionConverter.Mapper.Map<V1alpha1ClusterRoleBinding>(s);
    }
    public partial class V1ClusterRoleBinding
    {
        public static explicit operator V1ClusterRoleBinding(V1alpha1ClusterRoleBinding s) => VersionConverter.Mapper.Map<V1ClusterRoleBinding>(s);
    }
    public partial class V1beta1ClusterRoleBinding
    {
        public static explicit operator V1beta1ClusterRoleBinding(V1ClusterRoleBinding s) => VersionConverter.Mapper.Map<V1beta1ClusterRoleBinding>(s);
    }
    public partial class V1ClusterRoleBinding
    {
        public static explicit operator V1ClusterRoleBinding(V1beta1ClusterRoleBinding s) => VersionConverter.Mapper.Map<V1ClusterRoleBinding>(s);
    }
    public partial class V1alpha1ClusterRoleBindingList
    {
        public static explicit operator V1alpha1ClusterRoleBindingList(V1beta1ClusterRoleBindingList s) => VersionConverter.Mapper.Map<V1alpha1ClusterRoleBindingList>(s);
    }
    public partial class V1beta1ClusterRoleBindingList
    {
        public static explicit operator V1beta1ClusterRoleBindingList(V1alpha1ClusterRoleBindingList s) => VersionConverter.Mapper.Map<V1beta1ClusterRoleBindingList>(s);
    }
    public partial class V1alpha1ClusterRoleBindingList
    {
        public static explicit operator V1alpha1ClusterRoleBindingList(V1ClusterRoleBindingList s) => VersionConverter.Mapper.Map<V1alpha1ClusterRoleBindingList>(s);
    }
    public partial class V1ClusterRoleBindingList
    {
        public static explicit operator V1ClusterRoleBindingList(V1alpha1ClusterRoleBindingList s) => VersionConverter.Mapper.Map<V1ClusterRoleBindingList>(s);
    }
    public partial class V1beta1ClusterRoleBindingList
    {
        public static explicit operator V1beta1ClusterRoleBindingList(V1ClusterRoleBindingList s) => VersionConverter.Mapper.Map<V1beta1ClusterRoleBindingList>(s);
    }
    public partial class V1ClusterRoleBindingList
    {
        public static explicit operator V1ClusterRoleBindingList(V1beta1ClusterRoleBindingList s) => VersionConverter.Mapper.Map<V1ClusterRoleBindingList>(s);
    }
    public partial class V1alpha1ClusterRoleList
    {
        public static explicit operator V1alpha1ClusterRoleList(V1beta1ClusterRoleList s) => VersionConverter.Mapper.Map<V1alpha1ClusterRoleList>(s);
    }
    public partial class V1beta1ClusterRoleList
    {
        public static explicit operator V1beta1ClusterRoleList(V1alpha1ClusterRoleList s) => VersionConverter.Mapper.Map<V1beta1ClusterRoleList>(s);
    }
    public partial class V1alpha1ClusterRoleList
    {
        public static explicit operator V1alpha1ClusterRoleList(V1ClusterRoleList s) => VersionConverter.Mapper.Map<V1alpha1ClusterRoleList>(s);
    }
    public partial class V1ClusterRoleList
    {
        public static explicit operator V1ClusterRoleList(V1alpha1ClusterRoleList s) => VersionConverter.Mapper.Map<V1ClusterRoleList>(s);
    }
    public partial class V1beta1ClusterRoleList
    {
        public static explicit operator V1beta1ClusterRoleList(V1ClusterRoleList s) => VersionConverter.Mapper.Map<V1beta1ClusterRoleList>(s);
    }
    public partial class V1ClusterRoleList
    {
        public static explicit operator V1ClusterRoleList(V1beta1ClusterRoleList s) => VersionConverter.Mapper.Map<V1ClusterRoleList>(s);
    }
    public partial class V1beta1CronJob
    {
        public static explicit operator V1beta1CronJob(V2alpha1CronJob s) => VersionConverter.Mapper.Map<V1beta1CronJob>(s);
    }
    public partial class V2alpha1CronJob
    {
        public static explicit operator V2alpha1CronJob(V1beta1CronJob s) => VersionConverter.Mapper.Map<V2alpha1CronJob>(s);
    }
    public partial class V1beta1CronJobList
    {
        public static explicit operator V1beta1CronJobList(V2alpha1CronJobList s) => VersionConverter.Mapper.Map<V1beta1CronJobList>(s);
    }
    public partial class V2alpha1CronJobList
    {
        public static explicit operator V2alpha1CronJobList(V1beta1CronJobList s) => VersionConverter.Mapper.Map<V2alpha1CronJobList>(s);
    }
    public partial class V1beta1CronJobSpec
    {
        public static explicit operator V1beta1CronJobSpec(V2alpha1CronJobSpec s) => VersionConverter.Mapper.Map<V1beta1CronJobSpec>(s);
    }
    public partial class V2alpha1CronJobSpec
    {
        public static explicit operator V2alpha1CronJobSpec(V1beta1CronJobSpec s) => VersionConverter.Mapper.Map<V2alpha1CronJobSpec>(s);
    }
    public partial class V1beta1CronJobStatus
    {
        public static explicit operator V1beta1CronJobStatus(V2alpha1CronJobStatus s) => VersionConverter.Mapper.Map<V1beta1CronJobStatus>(s);
    }
    public partial class V2alpha1CronJobStatus
    {
        public static explicit operator V2alpha1CronJobStatus(V1beta1CronJobStatus s) => VersionConverter.Mapper.Map<V2alpha1CronJobStatus>(s);
    }
    public partial class V1CrossVersionObjectReference
    {
        public static explicit operator V1CrossVersionObjectReference(V2beta1CrossVersionObjectReference s) => VersionConverter.Mapper.Map<V1CrossVersionObjectReference>(s);
    }
    public partial class V2beta1CrossVersionObjectReference
    {
        public static explicit operator V2beta1CrossVersionObjectReference(V1CrossVersionObjectReference s) => VersionConverter.Mapper.Map<V2beta1CrossVersionObjectReference>(s);
    }
    public partial class V1CrossVersionObjectReference
    {
        public static explicit operator V1CrossVersionObjectReference(V2beta2CrossVersionObjectReference s) => VersionConverter.Mapper.Map<V1CrossVersionObjectReference>(s);
    }
    public partial class V2beta2CrossVersionObjectReference
    {
        public static explicit operator V2beta2CrossVersionObjectReference(V1CrossVersionObjectReference s) => VersionConverter.Mapper.Map<V2beta2CrossVersionObjectReference>(s);
    }
    public partial class V2beta1CrossVersionObjectReference
    {
        public static explicit operator V2beta1CrossVersionObjectReference(V2beta2CrossVersionObjectReference s) => VersionConverter.Mapper.Map<V2beta1CrossVersionObjectReference>(s);
    }
    public partial class V2beta2CrossVersionObjectReference
    {
        public static explicit operator V2beta2CrossVersionObjectReference(V2beta1CrossVersionObjectReference s) => VersionConverter.Mapper.Map<V2beta2CrossVersionObjectReference>(s);
    }
    public partial class V1beta1CSIDriver
    {
        public static explicit operator V1beta1CSIDriver(V1CSIDriver s) => VersionConverter.Mapper.Map<V1beta1CSIDriver>(s);
    }
    public partial class V1CSIDriver
    {
        public static explicit operator V1CSIDriver(V1beta1CSIDriver s) => VersionConverter.Mapper.Map<V1CSIDriver>(s);
    }
    public partial class V1beta1CSIDriverList
    {
        public static explicit operator V1beta1CSIDriverList(V1CSIDriverList s) => VersionConverter.Mapper.Map<V1beta1CSIDriverList>(s);
    }
    public partial class V1CSIDriverList
    {
        public static explicit operator V1CSIDriverList(V1beta1CSIDriverList s) => VersionConverter.Mapper.Map<V1CSIDriverList>(s);
    }
    public partial class V1beta1CSIDriverSpec
    {
        public static explicit operator V1beta1CSIDriverSpec(V1CSIDriverSpec s) => VersionConverter.Mapper.Map<V1beta1CSIDriverSpec>(s);
    }
    public partial class V1CSIDriverSpec
    {
        public static explicit operator V1CSIDriverSpec(V1beta1CSIDriverSpec s) => VersionConverter.Mapper.Map<V1CSIDriverSpec>(s);
    }
    public partial class V1beta1CSINode
    {
        public static explicit operator V1beta1CSINode(V1CSINode s) => VersionConverter.Mapper.Map<V1beta1CSINode>(s);
    }
    public partial class V1CSINode
    {
        public static explicit operator V1CSINode(V1beta1CSINode s) => VersionConverter.Mapper.Map<V1CSINode>(s);
    }
    public partial class V1beta1CSINodeDriver
    {
        public static explicit operator V1beta1CSINodeDriver(V1CSINodeDriver s) => VersionConverter.Mapper.Map<V1beta1CSINodeDriver>(s);
    }
    public partial class V1CSINodeDriver
    {
        public static explicit operator V1CSINodeDriver(V1beta1CSINodeDriver s) => VersionConverter.Mapper.Map<V1CSINodeDriver>(s);
    }
    public partial class V1beta1CSINodeList
    {
        public static explicit operator V1beta1CSINodeList(V1CSINodeList s) => VersionConverter.Mapper.Map<V1beta1CSINodeList>(s);
    }
    public partial class V1CSINodeList
    {
        public static explicit operator V1CSINodeList(V1beta1CSINodeList s) => VersionConverter.Mapper.Map<V1CSINodeList>(s);
    }
    public partial class V1beta1CSINodeSpec
    {
        public static explicit operator V1beta1CSINodeSpec(V1CSINodeSpec s) => VersionConverter.Mapper.Map<V1beta1CSINodeSpec>(s);
    }
    public partial class V1CSINodeSpec
    {
        public static explicit operator V1CSINodeSpec(V1beta1CSINodeSpec s) => VersionConverter.Mapper.Map<V1CSINodeSpec>(s);
    }
    public partial class V1beta1CustomResourceColumnDefinition
    {
        public static explicit operator V1beta1CustomResourceColumnDefinition(V1CustomResourceColumnDefinition s) => VersionConverter.Mapper.Map<V1beta1CustomResourceColumnDefinition>(s);
    }
    public partial class V1CustomResourceColumnDefinition
    {
        public static explicit operator V1CustomResourceColumnDefinition(V1beta1CustomResourceColumnDefinition s) => VersionConverter.Mapper.Map<V1CustomResourceColumnDefinition>(s);
    }
    public partial class V1beta1CustomResourceConversion
    {
        public static explicit operator V1beta1CustomResourceConversion(V1CustomResourceConversion s) => VersionConverter.Mapper.Map<V1beta1CustomResourceConversion>(s);
    }
    public partial class V1CustomResourceConversion
    {
        public static explicit operator V1CustomResourceConversion(V1beta1CustomResourceConversion s) => VersionConverter.Mapper.Map<V1CustomResourceConversion>(s);
    }
    public partial class V1beta1CustomResourceDefinition
    {
        public static explicit operator V1beta1CustomResourceDefinition(V1CustomResourceDefinition s) => VersionConverter.Mapper.Map<V1beta1CustomResourceDefinition>(s);
    }
    public partial class V1CustomResourceDefinition
    {
        public static explicit operator V1CustomResourceDefinition(V1beta1CustomResourceDefinition s) => VersionConverter.Mapper.Map<V1CustomResourceDefinition>(s);
    }
    public partial class V1beta1CustomResourceDefinitionCondition
    {
        public static explicit operator V1beta1CustomResourceDefinitionCondition(V1CustomResourceDefinitionCondition s) => VersionConverter.Mapper.Map<V1beta1CustomResourceDefinitionCondition>(s);
    }
    public partial class V1CustomResourceDefinitionCondition
    {
        public static explicit operator V1CustomResourceDefinitionCondition(V1beta1CustomResourceDefinitionCondition s) => VersionConverter.Mapper.Map<V1CustomResourceDefinitionCondition>(s);
    }
    public partial class V1beta1CustomResourceDefinitionList
    {
        public static explicit operator V1beta1CustomResourceDefinitionList(V1CustomResourceDefinitionList s) => VersionConverter.Mapper.Map<V1beta1CustomResourceDefinitionList>(s);
    }
    public partial class V1CustomResourceDefinitionList
    {
        public static explicit operator V1CustomResourceDefinitionList(V1beta1CustomResourceDefinitionList s) => VersionConverter.Mapper.Map<V1CustomResourceDefinitionList>(s);
    }
    public partial class V1beta1CustomResourceDefinitionNames
    {
        public static explicit operator V1beta1CustomResourceDefinitionNames(V1CustomResourceDefinitionNames s) => VersionConverter.Mapper.Map<V1beta1CustomResourceDefinitionNames>(s);
    }
    public partial class V1CustomResourceDefinitionNames
    {
        public static explicit operator V1CustomResourceDefinitionNames(V1beta1CustomResourceDefinitionNames s) => VersionConverter.Mapper.Map<V1CustomResourceDefinitionNames>(s);
    }
    public partial class V1beta1CustomResourceDefinitionSpec
    {
        public static explicit operator V1beta1CustomResourceDefinitionSpec(V1CustomResourceDefinitionSpec s) => VersionConverter.Mapper.Map<V1beta1CustomResourceDefinitionSpec>(s);
    }
    public partial class V1CustomResourceDefinitionSpec
    {
        public static explicit operator V1CustomResourceDefinitionSpec(V1beta1CustomResourceDefinitionSpec s) => VersionConverter.Mapper.Map<V1CustomResourceDefinitionSpec>(s);
    }
    public partial class V1beta1CustomResourceDefinitionStatus
    {
        public static explicit operator V1beta1CustomResourceDefinitionStatus(V1CustomResourceDefinitionStatus s) => VersionConverter.Mapper.Map<V1beta1CustomResourceDefinitionStatus>(s);
    }
    public partial class V1CustomResourceDefinitionStatus
    {
        public static explicit operator V1CustomResourceDefinitionStatus(V1beta1CustomResourceDefinitionStatus s) => VersionConverter.Mapper.Map<V1CustomResourceDefinitionStatus>(s);
    }
    public partial class V1beta1CustomResourceDefinitionVersion
    {
        public static explicit operator V1beta1CustomResourceDefinitionVersion(V1CustomResourceDefinitionVersion s) => VersionConverter.Mapper.Map<V1beta1CustomResourceDefinitionVersion>(s);
    }
    public partial class V1CustomResourceDefinitionVersion
    {
        public static explicit operator V1CustomResourceDefinitionVersion(V1beta1CustomResourceDefinitionVersion s) => VersionConverter.Mapper.Map<V1CustomResourceDefinitionVersion>(s);
    }
    public partial class V1beta1CustomResourceSubresources
    {
        public static explicit operator V1beta1CustomResourceSubresources(V1CustomResourceSubresources s) => VersionConverter.Mapper.Map<V1beta1CustomResourceSubresources>(s);
    }
    public partial class V1CustomResourceSubresources
    {
        public static explicit operator V1CustomResourceSubresources(V1beta1CustomResourceSubresources s) => VersionConverter.Mapper.Map<V1CustomResourceSubresources>(s);
    }
    public partial class V1beta1CustomResourceSubresourceScale
    {
        public static explicit operator V1beta1CustomResourceSubresourceScale(V1CustomResourceSubresourceScale s) => VersionConverter.Mapper.Map<V1beta1CustomResourceSubresourceScale>(s);
    }
    public partial class V1CustomResourceSubresourceScale
    {
        public static explicit operator V1CustomResourceSubresourceScale(V1beta1CustomResourceSubresourceScale s) => VersionConverter.Mapper.Map<V1CustomResourceSubresourceScale>(s);
    }
    public partial class V1beta1CustomResourceValidation
    {
        public static explicit operator V1beta1CustomResourceValidation(V1CustomResourceValidation s) => VersionConverter.Mapper.Map<V1beta1CustomResourceValidation>(s);
    }
    public partial class V1CustomResourceValidation
    {
        public static explicit operator V1CustomResourceValidation(V1beta1CustomResourceValidation s) => VersionConverter.Mapper.Map<V1CustomResourceValidation>(s);
    }
    public partial class V1beta1EndpointPort
    {
        public static explicit operator V1beta1EndpointPort(V1EndpointPort s) => VersionConverter.Mapper.Map<V1beta1EndpointPort>(s);
    }
    public partial class V1EndpointPort
    {
        public static explicit operator V1EndpointPort(V1beta1EndpointPort s) => VersionConverter.Mapper.Map<V1EndpointPort>(s);
    }
    public partial class V1beta1Event
    {
        public static explicit operator V1beta1Event(V1Event s) => VersionConverter.Mapper.Map<V1beta1Event>(s);
    }
    public partial class V1Event
    {
        public static explicit operator V1Event(V1beta1Event s) => VersionConverter.Mapper.Map<V1Event>(s);
    }
    public partial class V1beta1EventList
    {
        public static explicit operator V1beta1EventList(V1EventList s) => VersionConverter.Mapper.Map<V1beta1EventList>(s);
    }
    public partial class V1EventList
    {
        public static explicit operator V1EventList(V1beta1EventList s) => VersionConverter.Mapper.Map<V1EventList>(s);
    }
    public partial class V1beta1EventSeries
    {
        public static explicit operator V1beta1EventSeries(V1EventSeries s) => VersionConverter.Mapper.Map<V1beta1EventSeries>(s);
    }
    public partial class V1EventSeries
    {
        public static explicit operator V1EventSeries(V1beta1EventSeries s) => VersionConverter.Mapper.Map<V1EventSeries>(s);
    }
    public partial class V1beta1ExternalDocumentation
    {
        public static explicit operator V1beta1ExternalDocumentation(V1ExternalDocumentation s) => VersionConverter.Mapper.Map<V1beta1ExternalDocumentation>(s);
    }
    public partial class V1ExternalDocumentation
    {
        public static explicit operator V1ExternalDocumentation(V1beta1ExternalDocumentation s) => VersionConverter.Mapper.Map<V1ExternalDocumentation>(s);
    }
    public partial class V2beta1ExternalMetricSource
    {
        public static explicit operator V2beta1ExternalMetricSource(V2beta2ExternalMetricSource s) => VersionConverter.Mapper.Map<V2beta1ExternalMetricSource>(s);
    }
    public partial class V2beta2ExternalMetricSource
    {
        public static explicit operator V2beta2ExternalMetricSource(V2beta1ExternalMetricSource s) => VersionConverter.Mapper.Map<V2beta2ExternalMetricSource>(s);
    }
    public partial class V2beta1ExternalMetricStatus
    {
        public static explicit operator V2beta1ExternalMetricStatus(V2beta2ExternalMetricStatus s) => VersionConverter.Mapper.Map<V2beta1ExternalMetricStatus>(s);
    }
    public partial class V2beta2ExternalMetricStatus
    {
        public static explicit operator V2beta2ExternalMetricStatus(V2beta1ExternalMetricStatus s) => VersionConverter.Mapper.Map<V2beta2ExternalMetricStatus>(s);
    }
    public partial class V1HorizontalPodAutoscaler
    {
        public static explicit operator V1HorizontalPodAutoscaler(V2beta1HorizontalPodAutoscaler s) => VersionConverter.Mapper.Map<V1HorizontalPodAutoscaler>(s);
    }
    public partial class V2beta1HorizontalPodAutoscaler
    {
        public static explicit operator V2beta1HorizontalPodAutoscaler(V1HorizontalPodAutoscaler s) => VersionConverter.Mapper.Map<V2beta1HorizontalPodAutoscaler>(s);
    }
    public partial class V1HorizontalPodAutoscaler
    {
        public static explicit operator V1HorizontalPodAutoscaler(V2beta2HorizontalPodAutoscaler s) => VersionConverter.Mapper.Map<V1HorizontalPodAutoscaler>(s);
    }
    public partial class V2beta2HorizontalPodAutoscaler
    {
        public static explicit operator V2beta2HorizontalPodAutoscaler(V1HorizontalPodAutoscaler s) => VersionConverter.Mapper.Map<V2beta2HorizontalPodAutoscaler>(s);
    }
    public partial class V2beta1HorizontalPodAutoscaler
    {
        public static explicit operator V2beta1HorizontalPodAutoscaler(V2beta2HorizontalPodAutoscaler s) => VersionConverter.Mapper.Map<V2beta1HorizontalPodAutoscaler>(s);
    }
    public partial class V2beta2HorizontalPodAutoscaler
    {
        public static explicit operator V2beta2HorizontalPodAutoscaler(V2beta1HorizontalPodAutoscaler s) => VersionConverter.Mapper.Map<V2beta2HorizontalPodAutoscaler>(s);
    }
    public partial class V2beta1HorizontalPodAutoscalerCondition
    {
        public static explicit operator V2beta1HorizontalPodAutoscalerCondition(V2beta2HorizontalPodAutoscalerCondition s) => VersionConverter.Mapper.Map<V2beta1HorizontalPodAutoscalerCondition>(s);
    }
    public partial class V2beta2HorizontalPodAutoscalerCondition
    {
        public static explicit operator V2beta2HorizontalPodAutoscalerCondition(V2beta1HorizontalPodAutoscalerCondition s) => VersionConverter.Mapper.Map<V2beta2HorizontalPodAutoscalerCondition>(s);
    }
    public partial class V1HorizontalPodAutoscalerList
    {
        public static explicit operator V1HorizontalPodAutoscalerList(V2beta1HorizontalPodAutoscalerList s) => VersionConverter.Mapper.Map<V1HorizontalPodAutoscalerList>(s);
    }
    public partial class V2beta1HorizontalPodAutoscalerList
    {
        public static explicit operator V2beta1HorizontalPodAutoscalerList(V1HorizontalPodAutoscalerList s) => VersionConverter.Mapper.Map<V2beta1HorizontalPodAutoscalerList>(s);
    }
    public partial class V1HorizontalPodAutoscalerList
    {
        public static explicit operator V1HorizontalPodAutoscalerList(V2beta2HorizontalPodAutoscalerList s) => VersionConverter.Mapper.Map<V1HorizontalPodAutoscalerList>(s);
    }
    public partial class V2beta2HorizontalPodAutoscalerList
    {
        public static explicit operator V2beta2HorizontalPodAutoscalerList(V1HorizontalPodAutoscalerList s) => VersionConverter.Mapper.Map<V2beta2HorizontalPodAutoscalerList>(s);
    }
    public partial class V2beta1HorizontalPodAutoscalerList
    {
        public static explicit operator V2beta1HorizontalPodAutoscalerList(V2beta2HorizontalPodAutoscalerList s) => VersionConverter.Mapper.Map<V2beta1HorizontalPodAutoscalerList>(s);
    }
    public partial class V2beta2HorizontalPodAutoscalerList
    {
        public static explicit operator V2beta2HorizontalPodAutoscalerList(V2beta1HorizontalPodAutoscalerList s) => VersionConverter.Mapper.Map<V2beta2HorizontalPodAutoscalerList>(s);
    }
    public partial class V1HorizontalPodAutoscalerSpec
    {
        public static explicit operator V1HorizontalPodAutoscalerSpec(V2beta1HorizontalPodAutoscalerSpec s) => VersionConverter.Mapper.Map<V1HorizontalPodAutoscalerSpec>(s);
    }
    public partial class V2beta1HorizontalPodAutoscalerSpec
    {
        public static explicit operator V2beta1HorizontalPodAutoscalerSpec(V1HorizontalPodAutoscalerSpec s) => VersionConverter.Mapper.Map<V2beta1HorizontalPodAutoscalerSpec>(s);
    }
    public partial class V1HorizontalPodAutoscalerSpec
    {
        public static explicit operator V1HorizontalPodAutoscalerSpec(V2beta2HorizontalPodAutoscalerSpec s) => VersionConverter.Mapper.Map<V1HorizontalPodAutoscalerSpec>(s);
    }
    public partial class V2beta2HorizontalPodAutoscalerSpec
    {
        public static explicit operator V2beta2HorizontalPodAutoscalerSpec(V1HorizontalPodAutoscalerSpec s) => VersionConverter.Mapper.Map<V2beta2HorizontalPodAutoscalerSpec>(s);
    }
    public partial class V2beta1HorizontalPodAutoscalerSpec
    {
        public static explicit operator V2beta1HorizontalPodAutoscalerSpec(V2beta2HorizontalPodAutoscalerSpec s) => VersionConverter.Mapper.Map<V2beta1HorizontalPodAutoscalerSpec>(s);
    }
    public partial class V2beta2HorizontalPodAutoscalerSpec
    {
        public static explicit operator V2beta2HorizontalPodAutoscalerSpec(V2beta1HorizontalPodAutoscalerSpec s) => VersionConverter.Mapper.Map<V2beta2HorizontalPodAutoscalerSpec>(s);
    }
    public partial class V1HorizontalPodAutoscalerStatus
    {
        public static explicit operator V1HorizontalPodAutoscalerStatus(V2beta1HorizontalPodAutoscalerStatus s) => VersionConverter.Mapper.Map<V1HorizontalPodAutoscalerStatus>(s);
    }
    public partial class V2beta1HorizontalPodAutoscalerStatus
    {
        public static explicit operator V2beta1HorizontalPodAutoscalerStatus(V1HorizontalPodAutoscalerStatus s) => VersionConverter.Mapper.Map<V2beta1HorizontalPodAutoscalerStatus>(s);
    }
    public partial class V1HorizontalPodAutoscalerStatus
    {
        public static explicit operator V1HorizontalPodAutoscalerStatus(V2beta2HorizontalPodAutoscalerStatus s) => VersionConverter.Mapper.Map<V1HorizontalPodAutoscalerStatus>(s);
    }
    public partial class V2beta2HorizontalPodAutoscalerStatus
    {
        public static explicit operator V2beta2HorizontalPodAutoscalerStatus(V1HorizontalPodAutoscalerStatus s) => VersionConverter.Mapper.Map<V2beta2HorizontalPodAutoscalerStatus>(s);
    }
    public partial class V2beta1HorizontalPodAutoscalerStatus
    {
        public static explicit operator V2beta1HorizontalPodAutoscalerStatus(V2beta2HorizontalPodAutoscalerStatus s) => VersionConverter.Mapper.Map<V2beta1HorizontalPodAutoscalerStatus>(s);
    }
    public partial class V2beta2HorizontalPodAutoscalerStatus
    {
        public static explicit operator V2beta2HorizontalPodAutoscalerStatus(V2beta1HorizontalPodAutoscalerStatus s) => VersionConverter.Mapper.Map<V2beta2HorizontalPodAutoscalerStatus>(s);
    }
    public partial class V1beta1JobTemplateSpec
    {
        public static explicit operator V1beta1JobTemplateSpec(V2alpha1JobTemplateSpec s) => VersionConverter.Mapper.Map<V1beta1JobTemplateSpec>(s);
    }
    public partial class V2alpha1JobTemplateSpec
    {
        public static explicit operator V2alpha1JobTemplateSpec(V1beta1JobTemplateSpec s) => VersionConverter.Mapper.Map<V2alpha1JobTemplateSpec>(s);
    }
    public partial class V1beta1JSONSchemaProps
    {
        public static explicit operator V1beta1JSONSchemaProps(V1JSONSchemaProps s) => VersionConverter.Mapper.Map<V1beta1JSONSchemaProps>(s);
    }
    public partial class V1JSONSchemaProps
    {
        public static explicit operator V1JSONSchemaProps(V1beta1JSONSchemaProps s) => VersionConverter.Mapper.Map<V1JSONSchemaProps>(s);
    }
    public partial class V1beta1Lease
    {
        public static explicit operator V1beta1Lease(V1Lease s) => VersionConverter.Mapper.Map<V1beta1Lease>(s);
    }
    public partial class V1Lease
    {
        public static explicit operator V1Lease(V1beta1Lease s) => VersionConverter.Mapper.Map<V1Lease>(s);
    }
    public partial class V1beta1LeaseList
    {
        public static explicit operator V1beta1LeaseList(V1LeaseList s) => VersionConverter.Mapper.Map<V1beta1LeaseList>(s);
    }
    public partial class V1LeaseList
    {
        public static explicit operator V1LeaseList(V1beta1LeaseList s) => VersionConverter.Mapper.Map<V1LeaseList>(s);
    }
    public partial class V1beta1LeaseSpec
    {
        public static explicit operator V1beta1LeaseSpec(V1LeaseSpec s) => VersionConverter.Mapper.Map<V1beta1LeaseSpec>(s);
    }
    public partial class V1LeaseSpec
    {
        public static explicit operator V1LeaseSpec(V1beta1LeaseSpec s) => VersionConverter.Mapper.Map<V1LeaseSpec>(s);
    }
    public partial class V1beta1LocalSubjectAccessReview
    {
        public static explicit operator V1beta1LocalSubjectAccessReview(V1LocalSubjectAccessReview s) => VersionConverter.Mapper.Map<V1beta1LocalSubjectAccessReview>(s);
    }
    public partial class V1LocalSubjectAccessReview
    {
        public static explicit operator V1LocalSubjectAccessReview(V1beta1LocalSubjectAccessReview s) => VersionConverter.Mapper.Map<V1LocalSubjectAccessReview>(s);
    }
    public partial class V2beta1MetricSpec
    {
        public static explicit operator V2beta1MetricSpec(V2beta2MetricSpec s) => VersionConverter.Mapper.Map<V2beta1MetricSpec>(s);
    }
    public partial class V2beta2MetricSpec
    {
        public static explicit operator V2beta2MetricSpec(V2beta1MetricSpec s) => VersionConverter.Mapper.Map<V2beta2MetricSpec>(s);
    }
    public partial class V2beta1MetricStatus
    {
        public static explicit operator V2beta1MetricStatus(V2beta2MetricStatus s) => VersionConverter.Mapper.Map<V2beta1MetricStatus>(s);
    }
    public partial class V2beta2MetricStatus
    {
        public static explicit operator V2beta2MetricStatus(V2beta1MetricStatus s) => VersionConverter.Mapper.Map<V2beta2MetricStatus>(s);
    }
    public partial class V1beta1MutatingWebhook
    {
        public static explicit operator V1beta1MutatingWebhook(V1MutatingWebhook s) => VersionConverter.Mapper.Map<V1beta1MutatingWebhook>(s);
    }
    public partial class V1MutatingWebhook
    {
        public static explicit operator V1MutatingWebhook(V1beta1MutatingWebhook s) => VersionConverter.Mapper.Map<V1MutatingWebhook>(s);
    }
    public partial class V1beta1MutatingWebhookConfiguration
    {
        public static explicit operator V1beta1MutatingWebhookConfiguration(V1MutatingWebhookConfiguration s) => VersionConverter.Mapper.Map<V1beta1MutatingWebhookConfiguration>(s);
    }
    public partial class V1MutatingWebhookConfiguration
    {
        public static explicit operator V1MutatingWebhookConfiguration(V1beta1MutatingWebhookConfiguration s) => VersionConverter.Mapper.Map<V1MutatingWebhookConfiguration>(s);
    }
    public partial class V1beta1MutatingWebhookConfigurationList
    {
        public static explicit operator V1beta1MutatingWebhookConfigurationList(V1MutatingWebhookConfigurationList s) => VersionConverter.Mapper.Map<V1beta1MutatingWebhookConfigurationList>(s);
    }
    public partial class V1MutatingWebhookConfigurationList
    {
        public static explicit operator V1MutatingWebhookConfigurationList(V1beta1MutatingWebhookConfigurationList s) => VersionConverter.Mapper.Map<V1MutatingWebhookConfigurationList>(s);
    }
    public partial class V1beta1NonResourceAttributes
    {
        public static explicit operator V1beta1NonResourceAttributes(V1NonResourceAttributes s) => VersionConverter.Mapper.Map<V1beta1NonResourceAttributes>(s);
    }
    public partial class V1NonResourceAttributes
    {
        public static explicit operator V1NonResourceAttributes(V1beta1NonResourceAttributes s) => VersionConverter.Mapper.Map<V1NonResourceAttributes>(s);
    }
    public partial class V1beta1NonResourceRule
    {
        public static explicit operator V1beta1NonResourceRule(V1NonResourceRule s) => VersionConverter.Mapper.Map<V1beta1NonResourceRule>(s);
    }
    public partial class V1NonResourceRule
    {
        public static explicit operator V1NonResourceRule(V1beta1NonResourceRule s) => VersionConverter.Mapper.Map<V1NonResourceRule>(s);
    }
    public partial class V2beta1ObjectMetricSource
    {
        public static explicit operator V2beta1ObjectMetricSource(V2beta2ObjectMetricSource s) => VersionConverter.Mapper.Map<V2beta1ObjectMetricSource>(s);
    }
    public partial class V2beta2ObjectMetricSource
    {
        public static explicit operator V2beta2ObjectMetricSource(V2beta1ObjectMetricSource s) => VersionConverter.Mapper.Map<V2beta2ObjectMetricSource>(s);
    }
    public partial class V2beta1ObjectMetricStatus
    {
        public static explicit operator V2beta1ObjectMetricStatus(V2beta2ObjectMetricStatus s) => VersionConverter.Mapper.Map<V2beta1ObjectMetricStatus>(s);
    }
    public partial class V2beta2ObjectMetricStatus
    {
        public static explicit operator V2beta2ObjectMetricStatus(V2beta1ObjectMetricStatus s) => VersionConverter.Mapper.Map<V2beta2ObjectMetricStatus>(s);
    }
    public partial class V1alpha1Overhead
    {
        public static explicit operator V1alpha1Overhead(V1beta1Overhead s) => VersionConverter.Mapper.Map<V1alpha1Overhead>(s);
    }
    public partial class V1beta1Overhead
    {
        public static explicit operator V1beta1Overhead(V1alpha1Overhead s) => VersionConverter.Mapper.Map<V1beta1Overhead>(s);
    }
    public partial class V2beta1PodsMetricSource
    {
        public static explicit operator V2beta1PodsMetricSource(V2beta2PodsMetricSource s) => VersionConverter.Mapper.Map<V2beta1PodsMetricSource>(s);
    }
    public partial class V2beta2PodsMetricSource
    {
        public static explicit operator V2beta2PodsMetricSource(V2beta1PodsMetricSource s) => VersionConverter.Mapper.Map<V2beta2PodsMetricSource>(s);
    }
    public partial class V2beta1PodsMetricStatus
    {
        public static explicit operator V2beta1PodsMetricStatus(V2beta2PodsMetricStatus s) => VersionConverter.Mapper.Map<V2beta1PodsMetricStatus>(s);
    }
    public partial class V2beta2PodsMetricStatus
    {
        public static explicit operator V2beta2PodsMetricStatus(V2beta1PodsMetricStatus s) => VersionConverter.Mapper.Map<V2beta2PodsMetricStatus>(s);
    }
    public partial class V1alpha1PolicyRule
    {
        public static explicit operator V1alpha1PolicyRule(V1beta1PolicyRule s) => VersionConverter.Mapper.Map<V1alpha1PolicyRule>(s);
    }
    public partial class V1beta1PolicyRule
    {
        public static explicit operator V1beta1PolicyRule(V1alpha1PolicyRule s) => VersionConverter.Mapper.Map<V1beta1PolicyRule>(s);
    }
    public partial class V1alpha1PolicyRule
    {
        public static explicit operator V1alpha1PolicyRule(V1PolicyRule s) => VersionConverter.Mapper.Map<V1alpha1PolicyRule>(s);
    }
    public partial class V1PolicyRule
    {
        public static explicit operator V1PolicyRule(V1alpha1PolicyRule s) => VersionConverter.Mapper.Map<V1PolicyRule>(s);
    }
    public partial class V1beta1PolicyRule
    {
        public static explicit operator V1beta1PolicyRule(V1PolicyRule s) => VersionConverter.Mapper.Map<V1beta1PolicyRule>(s);
    }
    public partial class V1PolicyRule
    {
        public static explicit operator V1PolicyRule(V1beta1PolicyRule s) => VersionConverter.Mapper.Map<V1PolicyRule>(s);
    }
    public partial class V1alpha1PriorityClass
    {
        public static explicit operator V1alpha1PriorityClass(V1beta1PriorityClass s) => VersionConverter.Mapper.Map<V1alpha1PriorityClass>(s);
    }
    public partial class V1beta1PriorityClass
    {
        public static explicit operator V1beta1PriorityClass(V1alpha1PriorityClass s) => VersionConverter.Mapper.Map<V1beta1PriorityClass>(s);
    }
    public partial class V1alpha1PriorityClass
    {
        public static explicit operator V1alpha1PriorityClass(V1PriorityClass s) => VersionConverter.Mapper.Map<V1alpha1PriorityClass>(s);
    }
    public partial class V1PriorityClass
    {
        public static explicit operator V1PriorityClass(V1alpha1PriorityClass s) => VersionConverter.Mapper.Map<V1PriorityClass>(s);
    }
    public partial class V1beta1PriorityClass
    {
        public static explicit operator V1beta1PriorityClass(V1PriorityClass s) => VersionConverter.Mapper.Map<V1beta1PriorityClass>(s);
    }
    public partial class V1PriorityClass
    {
        public static explicit operator V1PriorityClass(V1beta1PriorityClass s) => VersionConverter.Mapper.Map<V1PriorityClass>(s);
    }
    public partial class V1alpha1PriorityClassList
    {
        public static explicit operator V1alpha1PriorityClassList(V1beta1PriorityClassList s) => VersionConverter.Mapper.Map<V1alpha1PriorityClassList>(s);
    }
    public partial class V1beta1PriorityClassList
    {
        public static explicit operator V1beta1PriorityClassList(V1alpha1PriorityClassList s) => VersionConverter.Mapper.Map<V1beta1PriorityClassList>(s);
    }
    public partial class V1alpha1PriorityClassList
    {
        public static explicit operator V1alpha1PriorityClassList(V1PriorityClassList s) => VersionConverter.Mapper.Map<V1alpha1PriorityClassList>(s);
    }
    public partial class V1PriorityClassList
    {
        public static explicit operator V1PriorityClassList(V1alpha1PriorityClassList s) => VersionConverter.Mapper.Map<V1PriorityClassList>(s);
    }
    public partial class V1beta1PriorityClassList
    {
        public static explicit operator V1beta1PriorityClassList(V1PriorityClassList s) => VersionConverter.Mapper.Map<V1beta1PriorityClassList>(s);
    }
    public partial class V1PriorityClassList
    {
        public static explicit operator V1PriorityClassList(V1beta1PriorityClassList s) => VersionConverter.Mapper.Map<V1PriorityClassList>(s);
    }
    public partial class V1beta1ResourceAttributes
    {
        public static explicit operator V1beta1ResourceAttributes(V1ResourceAttributes s) => VersionConverter.Mapper.Map<V1beta1ResourceAttributes>(s);
    }
    public partial class V1ResourceAttributes
    {
        public static explicit operator V1ResourceAttributes(V1beta1ResourceAttributes s) => VersionConverter.Mapper.Map<V1ResourceAttributes>(s);
    }
    public partial class V2beta1ResourceMetricSource
    {
        public static explicit operator V2beta1ResourceMetricSource(V2beta2ResourceMetricSource s) => VersionConverter.Mapper.Map<V2beta1ResourceMetricSource>(s);
    }
    public partial class V2beta2ResourceMetricSource
    {
        public static explicit operator V2beta2ResourceMetricSource(V2beta1ResourceMetricSource s) => VersionConverter.Mapper.Map<V2beta2ResourceMetricSource>(s);
    }
    public partial class V2beta1ResourceMetricStatus
    {
        public static explicit operator V2beta1ResourceMetricStatus(V2beta2ResourceMetricStatus s) => VersionConverter.Mapper.Map<V2beta1ResourceMetricStatus>(s);
    }
    public partial class V2beta2ResourceMetricStatus
    {
        public static explicit operator V2beta2ResourceMetricStatus(V2beta1ResourceMetricStatus s) => VersionConverter.Mapper.Map<V2beta2ResourceMetricStatus>(s);
    }
    public partial class V1beta1ResourceRule
    {
        public static explicit operator V1beta1ResourceRule(V1ResourceRule s) => VersionConverter.Mapper.Map<V1beta1ResourceRule>(s);
    }
    public partial class V1ResourceRule
    {
        public static explicit operator V1ResourceRule(V1beta1ResourceRule s) => VersionConverter.Mapper.Map<V1ResourceRule>(s);
    }
    public partial class V1alpha1Role
    {
        public static explicit operator V1alpha1Role(V1beta1Role s) => VersionConverter.Mapper.Map<V1alpha1Role>(s);
    }
    public partial class V1beta1Role
    {
        public static explicit operator V1beta1Role(V1alpha1Role s) => VersionConverter.Mapper.Map<V1beta1Role>(s);
    }
    public partial class V1alpha1Role
    {
        public static explicit operator V1alpha1Role(V1Role s) => VersionConverter.Mapper.Map<V1alpha1Role>(s);
    }
    public partial class V1Role
    {
        public static explicit operator V1Role(V1alpha1Role s) => VersionConverter.Mapper.Map<V1Role>(s);
    }
    public partial class V1beta1Role
    {
        public static explicit operator V1beta1Role(V1Role s) => VersionConverter.Mapper.Map<V1beta1Role>(s);
    }
    public partial class V1Role
    {
        public static explicit operator V1Role(V1beta1Role s) => VersionConverter.Mapper.Map<V1Role>(s);
    }
    public partial class V1alpha1RoleBinding
    {
        public static explicit operator V1alpha1RoleBinding(V1beta1RoleBinding s) => VersionConverter.Mapper.Map<V1alpha1RoleBinding>(s);
    }
    public partial class V1beta1RoleBinding
    {
        public static explicit operator V1beta1RoleBinding(V1alpha1RoleBinding s) => VersionConverter.Mapper.Map<V1beta1RoleBinding>(s);
    }
    public partial class V1alpha1RoleBinding
    {
        public static explicit operator V1alpha1RoleBinding(V1RoleBinding s) => VersionConverter.Mapper.Map<V1alpha1RoleBinding>(s);
    }
    public partial class V1RoleBinding
    {
        public static explicit operator V1RoleBinding(V1alpha1RoleBinding s) => VersionConverter.Mapper.Map<V1RoleBinding>(s);
    }
    public partial class V1beta1RoleBinding
    {
        public static explicit operator V1beta1RoleBinding(V1RoleBinding s) => VersionConverter.Mapper.Map<V1beta1RoleBinding>(s);
    }
    public partial class V1RoleBinding
    {
        public static explicit operator V1RoleBinding(V1beta1RoleBinding s) => VersionConverter.Mapper.Map<V1RoleBinding>(s);
    }
    public partial class V1alpha1RoleBindingList
    {
        public static explicit operator V1alpha1RoleBindingList(V1beta1RoleBindingList s) => VersionConverter.Mapper.Map<V1alpha1RoleBindingList>(s);
    }
    public partial class V1beta1RoleBindingList
    {
        public static explicit operator V1beta1RoleBindingList(V1alpha1RoleBindingList s) => VersionConverter.Mapper.Map<V1beta1RoleBindingList>(s);
    }
    public partial class V1alpha1RoleBindingList
    {
        public static explicit operator V1alpha1RoleBindingList(V1RoleBindingList s) => VersionConverter.Mapper.Map<V1alpha1RoleBindingList>(s);
    }
    public partial class V1RoleBindingList
    {
        public static explicit operator V1RoleBindingList(V1alpha1RoleBindingList s) => VersionConverter.Mapper.Map<V1RoleBindingList>(s);
    }
    public partial class V1beta1RoleBindingList
    {
        public static explicit operator V1beta1RoleBindingList(V1RoleBindingList s) => VersionConverter.Mapper.Map<V1beta1RoleBindingList>(s);
    }
    public partial class V1RoleBindingList
    {
        public static explicit operator V1RoleBindingList(V1beta1RoleBindingList s) => VersionConverter.Mapper.Map<V1RoleBindingList>(s);
    }
    public partial class V1alpha1RoleList
    {
        public static explicit operator V1alpha1RoleList(V1beta1RoleList s) => VersionConverter.Mapper.Map<V1alpha1RoleList>(s);
    }
    public partial class V1beta1RoleList
    {
        public static explicit operator V1beta1RoleList(V1alpha1RoleList s) => VersionConverter.Mapper.Map<V1beta1RoleList>(s);
    }
    public partial class V1alpha1RoleList
    {
        public static explicit operator V1alpha1RoleList(V1RoleList s) => VersionConverter.Mapper.Map<V1alpha1RoleList>(s);
    }
    public partial class V1RoleList
    {
        public static explicit operator V1RoleList(V1alpha1RoleList s) => VersionConverter.Mapper.Map<V1RoleList>(s);
    }
    public partial class V1beta1RoleList
    {
        public static explicit operator V1beta1RoleList(V1RoleList s) => VersionConverter.Mapper.Map<V1beta1RoleList>(s);
    }
    public partial class V1RoleList
    {
        public static explicit operator V1RoleList(V1beta1RoleList s) => VersionConverter.Mapper.Map<V1RoleList>(s);
    }
    public partial class V1alpha1RoleRef
    {
        public static explicit operator V1alpha1RoleRef(V1beta1RoleRef s) => VersionConverter.Mapper.Map<V1alpha1RoleRef>(s);
    }
    public partial class V1beta1RoleRef
    {
        public static explicit operator V1beta1RoleRef(V1alpha1RoleRef s) => VersionConverter.Mapper.Map<V1beta1RoleRef>(s);
    }
    public partial class V1alpha1RoleRef
    {
        public static explicit operator V1alpha1RoleRef(V1RoleRef s) => VersionConverter.Mapper.Map<V1alpha1RoleRef>(s);
    }
    public partial class V1RoleRef
    {
        public static explicit operator V1RoleRef(V1alpha1RoleRef s) => VersionConverter.Mapper.Map<V1RoleRef>(s);
    }
    public partial class V1beta1RoleRef
    {
        public static explicit operator V1beta1RoleRef(V1RoleRef s) => VersionConverter.Mapper.Map<V1beta1RoleRef>(s);
    }
    public partial class V1RoleRef
    {
        public static explicit operator V1RoleRef(V1beta1RoleRef s) => VersionConverter.Mapper.Map<V1RoleRef>(s);
    }
    public partial class V1beta1RuleWithOperations
    {
        public static explicit operator V1beta1RuleWithOperations(V1RuleWithOperations s) => VersionConverter.Mapper.Map<V1beta1RuleWithOperations>(s);
    }
    public partial class V1RuleWithOperations
    {
        public static explicit operator V1RuleWithOperations(V1beta1RuleWithOperations s) => VersionConverter.Mapper.Map<V1RuleWithOperations>(s);
    }
    public partial class V1alpha1RuntimeClass
    {
        public static explicit operator V1alpha1RuntimeClass(V1beta1RuntimeClass s) => VersionConverter.Mapper.Map<V1alpha1RuntimeClass>(s);
    }
    public partial class V1beta1RuntimeClass
    {
        public static explicit operator V1beta1RuntimeClass(V1alpha1RuntimeClass s) => VersionConverter.Mapper.Map<V1beta1RuntimeClass>(s);
    }
    public partial class V1alpha1RuntimeClassList
    {
        public static explicit operator V1alpha1RuntimeClassList(V1beta1RuntimeClassList s) => VersionConverter.Mapper.Map<V1alpha1RuntimeClassList>(s);
    }
    public partial class V1beta1RuntimeClassList
    {
        public static explicit operator V1beta1RuntimeClassList(V1alpha1RuntimeClassList s) => VersionConverter.Mapper.Map<V1beta1RuntimeClassList>(s);
    }
    public partial class V1alpha1Scheduling
    {
        public static explicit operator V1alpha1Scheduling(V1beta1Scheduling s) => VersionConverter.Mapper.Map<V1alpha1Scheduling>(s);
    }
    public partial class V1beta1Scheduling
    {
        public static explicit operator V1beta1Scheduling(V1alpha1Scheduling s) => VersionConverter.Mapper.Map<V1beta1Scheduling>(s);
    }
    public partial class V1beta1SelfSubjectAccessReview
    {
        public static explicit operator V1beta1SelfSubjectAccessReview(V1SelfSubjectAccessReview s) => VersionConverter.Mapper.Map<V1beta1SelfSubjectAccessReview>(s);
    }
    public partial class V1SelfSubjectAccessReview
    {
        public static explicit operator V1SelfSubjectAccessReview(V1beta1SelfSubjectAccessReview s) => VersionConverter.Mapper.Map<V1SelfSubjectAccessReview>(s);
    }
    public partial class V1beta1SelfSubjectAccessReviewSpec
    {
        public static explicit operator V1beta1SelfSubjectAccessReviewSpec(V1SelfSubjectAccessReviewSpec s) => VersionConverter.Mapper.Map<V1beta1SelfSubjectAccessReviewSpec>(s);
    }
    public partial class V1SelfSubjectAccessReviewSpec
    {
        public static explicit operator V1SelfSubjectAccessReviewSpec(V1beta1SelfSubjectAccessReviewSpec s) => VersionConverter.Mapper.Map<V1SelfSubjectAccessReviewSpec>(s);
    }
    public partial class V1beta1SelfSubjectRulesReview
    {
        public static explicit operator V1beta1SelfSubjectRulesReview(V1SelfSubjectRulesReview s) => VersionConverter.Mapper.Map<V1beta1SelfSubjectRulesReview>(s);
    }
    public partial class V1SelfSubjectRulesReview
    {
        public static explicit operator V1SelfSubjectRulesReview(V1beta1SelfSubjectRulesReview s) => VersionConverter.Mapper.Map<V1SelfSubjectRulesReview>(s);
    }
    public partial class V1beta1SelfSubjectRulesReviewSpec
    {
        public static explicit operator V1beta1SelfSubjectRulesReviewSpec(V1SelfSubjectRulesReviewSpec s) => VersionConverter.Mapper.Map<V1beta1SelfSubjectRulesReviewSpec>(s);
    }
    public partial class V1SelfSubjectRulesReviewSpec
    {
        public static explicit operator V1SelfSubjectRulesReviewSpec(V1beta1SelfSubjectRulesReviewSpec s) => VersionConverter.Mapper.Map<V1SelfSubjectRulesReviewSpec>(s);
    }
    public partial class V1beta1StorageClass
    {
        public static explicit operator V1beta1StorageClass(V1StorageClass s) => VersionConverter.Mapper.Map<V1beta1StorageClass>(s);
    }
    public partial class V1StorageClass
    {
        public static explicit operator V1StorageClass(V1beta1StorageClass s) => VersionConverter.Mapper.Map<V1StorageClass>(s);
    }
    public partial class V1beta1StorageClassList
    {
        public static explicit operator V1beta1StorageClassList(V1StorageClassList s) => VersionConverter.Mapper.Map<V1beta1StorageClassList>(s);
    }
    public partial class V1StorageClassList
    {
        public static explicit operator V1StorageClassList(V1beta1StorageClassList s) => VersionConverter.Mapper.Map<V1StorageClassList>(s);
    }
    public partial class V1beta1Subject
    {
        public static explicit operator V1beta1Subject(V1Subject s) => VersionConverter.Mapper.Map<V1beta1Subject>(s);
    }
    public partial class V1Subject
    {
        public static explicit operator V1Subject(V1beta1Subject s) => VersionConverter.Mapper.Map<V1Subject>(s);
    }
    public partial class V1beta1SubjectAccessReview
    {
        public static explicit operator V1beta1SubjectAccessReview(V1SubjectAccessReview s) => VersionConverter.Mapper.Map<V1beta1SubjectAccessReview>(s);
    }
    public partial class V1SubjectAccessReview
    {
        public static explicit operator V1SubjectAccessReview(V1beta1SubjectAccessReview s) => VersionConverter.Mapper.Map<V1SubjectAccessReview>(s);
    }
    public partial class V1beta1SubjectAccessReviewSpec
    {
        public static explicit operator V1beta1SubjectAccessReviewSpec(V1SubjectAccessReviewSpec s) => VersionConverter.Mapper.Map<V1beta1SubjectAccessReviewSpec>(s);
    }
    public partial class V1SubjectAccessReviewSpec
    {
        public static explicit operator V1SubjectAccessReviewSpec(V1beta1SubjectAccessReviewSpec s) => VersionConverter.Mapper.Map<V1SubjectAccessReviewSpec>(s);
    }
    public partial class V1beta1SubjectAccessReviewStatus
    {
        public static explicit operator V1beta1SubjectAccessReviewStatus(V1SubjectAccessReviewStatus s) => VersionConverter.Mapper.Map<V1beta1SubjectAccessReviewStatus>(s);
    }
    public partial class V1SubjectAccessReviewStatus
    {
        public static explicit operator V1SubjectAccessReviewStatus(V1beta1SubjectAccessReviewStatus s) => VersionConverter.Mapper.Map<V1SubjectAccessReviewStatus>(s);
    }
    public partial class V1beta1SubjectRulesReviewStatus
    {
        public static explicit operator V1beta1SubjectRulesReviewStatus(V1SubjectRulesReviewStatus s) => VersionConverter.Mapper.Map<V1beta1SubjectRulesReviewStatus>(s);
    }
    public partial class V1SubjectRulesReviewStatus
    {
        public static explicit operator V1SubjectRulesReviewStatus(V1beta1SubjectRulesReviewStatus s) => VersionConverter.Mapper.Map<V1SubjectRulesReviewStatus>(s);
    }
    public partial class V1beta1TokenReview
    {
        public static explicit operator V1beta1TokenReview(V1TokenReview s) => VersionConverter.Mapper.Map<V1beta1TokenReview>(s);
    }
    public partial class V1TokenReview
    {
        public static explicit operator V1TokenReview(V1beta1TokenReview s) => VersionConverter.Mapper.Map<V1TokenReview>(s);
    }
    public partial class V1beta1TokenReviewSpec
    {
        public static explicit operator V1beta1TokenReviewSpec(V1TokenReviewSpec s) => VersionConverter.Mapper.Map<V1beta1TokenReviewSpec>(s);
    }
    public partial class V1TokenReviewSpec
    {
        public static explicit operator V1TokenReviewSpec(V1beta1TokenReviewSpec s) => VersionConverter.Mapper.Map<V1TokenReviewSpec>(s);
    }
    public partial class V1beta1TokenReviewStatus
    {
        public static explicit operator V1beta1TokenReviewStatus(V1TokenReviewStatus s) => VersionConverter.Mapper.Map<V1beta1TokenReviewStatus>(s);
    }
    public partial class V1TokenReviewStatus
    {
        public static explicit operator V1TokenReviewStatus(V1beta1TokenReviewStatus s) => VersionConverter.Mapper.Map<V1TokenReviewStatus>(s);
    }
    public partial class V1beta1UserInfo
    {
        public static explicit operator V1beta1UserInfo(V1UserInfo s) => VersionConverter.Mapper.Map<V1beta1UserInfo>(s);
    }
    public partial class V1UserInfo
    {
        public static explicit operator V1UserInfo(V1beta1UserInfo s) => VersionConverter.Mapper.Map<V1UserInfo>(s);
    }
    public partial class V1beta1ValidatingWebhook
    {
        public static explicit operator V1beta1ValidatingWebhook(V1ValidatingWebhook s) => VersionConverter.Mapper.Map<V1beta1ValidatingWebhook>(s);
    }
    public partial class V1ValidatingWebhook
    {
        public static explicit operator V1ValidatingWebhook(V1beta1ValidatingWebhook s) => VersionConverter.Mapper.Map<V1ValidatingWebhook>(s);
    }
    public partial class V1beta1ValidatingWebhookConfiguration
    {
        public static explicit operator V1beta1ValidatingWebhookConfiguration(V1ValidatingWebhookConfiguration s) => VersionConverter.Mapper.Map<V1beta1ValidatingWebhookConfiguration>(s);
    }
    public partial class V1ValidatingWebhookConfiguration
    {
        public static explicit operator V1ValidatingWebhookConfiguration(V1beta1ValidatingWebhookConfiguration s) => VersionConverter.Mapper.Map<V1ValidatingWebhookConfiguration>(s);
    }
    public partial class V1beta1ValidatingWebhookConfigurationList
    {
        public static explicit operator V1beta1ValidatingWebhookConfigurationList(V1ValidatingWebhookConfigurationList s) => VersionConverter.Mapper.Map<V1beta1ValidatingWebhookConfigurationList>(s);
    }
    public partial class V1ValidatingWebhookConfigurationList
    {
        public static explicit operator V1ValidatingWebhookConfigurationList(V1beta1ValidatingWebhookConfigurationList s) => VersionConverter.Mapper.Map<V1ValidatingWebhookConfigurationList>(s);
    }
    public partial class V1alpha1VolumeAttachment
    {
        public static explicit operator V1alpha1VolumeAttachment(V1beta1VolumeAttachment s) => VersionConverter.Mapper.Map<V1alpha1VolumeAttachment>(s);
    }
    public partial class V1beta1VolumeAttachment
    {
        public static explicit operator V1beta1VolumeAttachment(V1alpha1VolumeAttachment s) => VersionConverter.Mapper.Map<V1beta1VolumeAttachment>(s);
    }
    public partial class V1alpha1VolumeAttachment
    {
        public static explicit operator V1alpha1VolumeAttachment(V1VolumeAttachment s) => VersionConverter.Mapper.Map<V1alpha1VolumeAttachment>(s);
    }
    public partial class V1VolumeAttachment
    {
        public static explicit operator V1VolumeAttachment(V1alpha1VolumeAttachment s) => VersionConverter.Mapper.Map<V1VolumeAttachment>(s);
    }
    public partial class V1beta1VolumeAttachment
    {
        public static explicit operator V1beta1VolumeAttachment(V1VolumeAttachment s) => VersionConverter.Mapper.Map<V1beta1VolumeAttachment>(s);
    }
    public partial class V1VolumeAttachment
    {
        public static explicit operator V1VolumeAttachment(V1beta1VolumeAttachment s) => VersionConverter.Mapper.Map<V1VolumeAttachment>(s);
    }
    public partial class V1alpha1VolumeAttachmentList
    {
        public static explicit operator V1alpha1VolumeAttachmentList(V1beta1VolumeAttachmentList s) => VersionConverter.Mapper.Map<V1alpha1VolumeAttachmentList>(s);
    }
    public partial class V1beta1VolumeAttachmentList
    {
        public static explicit operator V1beta1VolumeAttachmentList(V1alpha1VolumeAttachmentList s) => VersionConverter.Mapper.Map<V1beta1VolumeAttachmentList>(s);
    }
    public partial class V1alpha1VolumeAttachmentList
    {
        public static explicit operator V1alpha1VolumeAttachmentList(V1VolumeAttachmentList s) => VersionConverter.Mapper.Map<V1alpha1VolumeAttachmentList>(s);
    }
    public partial class V1VolumeAttachmentList
    {
        public static explicit operator V1VolumeAttachmentList(V1alpha1VolumeAttachmentList s) => VersionConverter.Mapper.Map<V1VolumeAttachmentList>(s);
    }
    public partial class V1beta1VolumeAttachmentList
    {
        public static explicit operator V1beta1VolumeAttachmentList(V1VolumeAttachmentList s) => VersionConverter.Mapper.Map<V1beta1VolumeAttachmentList>(s);
    }
    public partial class V1VolumeAttachmentList
    {
        public static explicit operator V1VolumeAttachmentList(V1beta1VolumeAttachmentList s) => VersionConverter.Mapper.Map<V1VolumeAttachmentList>(s);
    }
    public partial class V1alpha1VolumeAttachmentSource
    {
        public static explicit operator V1alpha1VolumeAttachmentSource(V1beta1VolumeAttachmentSource s) => VersionConverter.Mapper.Map<V1alpha1VolumeAttachmentSource>(s);
    }
    public partial class V1beta1VolumeAttachmentSource
    {
        public static explicit operator V1beta1VolumeAttachmentSource(V1alpha1VolumeAttachmentSource s) => VersionConverter.Mapper.Map<V1beta1VolumeAttachmentSource>(s);
    }
    public partial class V1alpha1VolumeAttachmentSource
    {
        public static explicit operator V1alpha1VolumeAttachmentSource(V1VolumeAttachmentSource s) => VersionConverter.Mapper.Map<V1alpha1VolumeAttachmentSource>(s);
    }
    public partial class V1VolumeAttachmentSource
    {
        public static explicit operator V1VolumeAttachmentSource(V1alpha1VolumeAttachmentSource s) => VersionConverter.Mapper.Map<V1VolumeAttachmentSource>(s);
    }
    public partial class V1beta1VolumeAttachmentSource
    {
        public static explicit operator V1beta1VolumeAttachmentSource(V1VolumeAttachmentSource s) => VersionConverter.Mapper.Map<V1beta1VolumeAttachmentSource>(s);
    }
    public partial class V1VolumeAttachmentSource
    {
        public static explicit operator V1VolumeAttachmentSource(V1beta1VolumeAttachmentSource s) => VersionConverter.Mapper.Map<V1VolumeAttachmentSource>(s);
    }
    public partial class V1alpha1VolumeAttachmentSpec
    {
        public static explicit operator V1alpha1VolumeAttachmentSpec(V1beta1VolumeAttachmentSpec s) => VersionConverter.Mapper.Map<V1alpha1VolumeAttachmentSpec>(s);
    }
    public partial class V1beta1VolumeAttachmentSpec
    {
        public static explicit operator V1beta1VolumeAttachmentSpec(V1alpha1VolumeAttachmentSpec s) => VersionConverter.Mapper.Map<V1beta1VolumeAttachmentSpec>(s);
    }
    public partial class V1alpha1VolumeAttachmentSpec
    {
        public static explicit operator V1alpha1VolumeAttachmentSpec(V1VolumeAttachmentSpec s) => VersionConverter.Mapper.Map<V1alpha1VolumeAttachmentSpec>(s);
    }
    public partial class V1VolumeAttachmentSpec
    {
        public static explicit operator V1VolumeAttachmentSpec(V1alpha1VolumeAttachmentSpec s) => VersionConverter.Mapper.Map<V1VolumeAttachmentSpec>(s);
    }
    public partial class V1beta1VolumeAttachmentSpec
    {
        public static explicit operator V1beta1VolumeAttachmentSpec(V1VolumeAttachmentSpec s) => VersionConverter.Mapper.Map<V1beta1VolumeAttachmentSpec>(s);
    }
    public partial class V1VolumeAttachmentSpec
    {
        public static explicit operator V1VolumeAttachmentSpec(V1beta1VolumeAttachmentSpec s) => VersionConverter.Mapper.Map<V1VolumeAttachmentSpec>(s);
    }
    public partial class V1alpha1VolumeAttachmentStatus
    {
        public static explicit operator V1alpha1VolumeAttachmentStatus(V1beta1VolumeAttachmentStatus s) => VersionConverter.Mapper.Map<V1alpha1VolumeAttachmentStatus>(s);
    }
    public partial class V1beta1VolumeAttachmentStatus
    {
        public static explicit operator V1beta1VolumeAttachmentStatus(V1alpha1VolumeAttachmentStatus s) => VersionConverter.Mapper.Map<V1beta1VolumeAttachmentStatus>(s);
    }
    public partial class V1alpha1VolumeAttachmentStatus
    {
        public static explicit operator V1alpha1VolumeAttachmentStatus(V1VolumeAttachmentStatus s) => VersionConverter.Mapper.Map<V1alpha1VolumeAttachmentStatus>(s);
    }
    public partial class V1VolumeAttachmentStatus
    {
        public static explicit operator V1VolumeAttachmentStatus(V1alpha1VolumeAttachmentStatus s) => VersionConverter.Mapper.Map<V1VolumeAttachmentStatus>(s);
    }
    public partial class V1beta1VolumeAttachmentStatus
    {
        public static explicit operator V1beta1VolumeAttachmentStatus(V1VolumeAttachmentStatus s) => VersionConverter.Mapper.Map<V1beta1VolumeAttachmentStatus>(s);
    }
    public partial class V1VolumeAttachmentStatus
    {
        public static explicit operator V1VolumeAttachmentStatus(V1beta1VolumeAttachmentStatus s) => VersionConverter.Mapper.Map<V1VolumeAttachmentStatus>(s);
    }
    public partial class V1alpha1VolumeError
    {
        public static explicit operator V1alpha1VolumeError(V1beta1VolumeError s) => VersionConverter.Mapper.Map<V1alpha1VolumeError>(s);
    }
    public partial class V1beta1VolumeError
    {
        public static explicit operator V1beta1VolumeError(V1alpha1VolumeError s) => VersionConverter.Mapper.Map<V1beta1VolumeError>(s);
    }
    public partial class V1alpha1VolumeError
    {
        public static explicit operator V1alpha1VolumeError(V1VolumeError s) => VersionConverter.Mapper.Map<V1alpha1VolumeError>(s);
    }
    public partial class V1VolumeError
    {
        public static explicit operator V1VolumeError(V1alpha1VolumeError s) => VersionConverter.Mapper.Map<V1VolumeError>(s);
    }
    public partial class V1beta1VolumeError
    {
        public static explicit operator V1beta1VolumeError(V1VolumeError s) => VersionConverter.Mapper.Map<V1beta1VolumeError>(s);
    }
    public partial class V1VolumeError
    {
        public static explicit operator V1VolumeError(V1beta1VolumeError s) => VersionConverter.Mapper.Map<V1VolumeError>(s);
    }
    public partial class V1beta1VolumeNodeResources
    {
        public static explicit operator V1beta1VolumeNodeResources(V1VolumeNodeResources s) => VersionConverter.Mapper.Map<V1beta1VolumeNodeResources>(s);
    }
    public partial class V1VolumeNodeResources
    {
        public static explicit operator V1VolumeNodeResources(V1beta1VolumeNodeResources s) => VersionConverter.Mapper.Map<V1VolumeNodeResources>(s);
    }
}