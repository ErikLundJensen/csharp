apiVersion: batch/v1
kind: Job
metadata:
  name: transfer-12345
  labels:
    jobtype: transfer
    managedBy: metadata
    # Override jobId 
    jobId: "12345"
spec:
  ttlSecondsAfterFinished: 600
  template:
    spec:
      containers:
      - name: transfer
        image: jareakstest.azurecr.io/transfer:0.0.1
        command: [ "dotnet", "DHI.WaterData.Transfer.Run.dll", "startfileUri" ]
      restartPolicy: Never
  backoffLimit: 2
  