using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using k8s;
using k8s.Models;

namespace simple
{
    internal class PodList
    {
        private static void Main(string[] args)
        {
            // Console.WriteLine("Running in cluster");
            // var config = KubernetesClientConfiguration.InClusterConfig();

            var config = KubernetesClientConfiguration.BuildConfigFromConfigFile();

            IKubernetes client = new Kubernetes(config);
            Console.WriteLine("Starting Request!");

            var typeMap = new Dictionary<String, Type>();
            typeMap.Add("Batch/v1/Job", typeof(V1Pod));

            var jobs = Yaml.LoadAllFromFileAsync("./config/job.tpl", typeMap);
            foreach (var job in jobs.Result)
            {
                var createdJob = client.CreateNamespacedJob((V1Job)job, args[1]);
                Console.WriteLine("Created object:");
                Console.WriteLine(createdJob.Metadata.Name);
            }

            Console.WriteLine("List jobs");
            var list = client.ListNamespacedJob(args[1]);
            foreach (var item in list.Items)
            {
                Console.WriteLine(item.Metadata.Name);
            }
        }
    }
}
